using OfficeOpenXml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AfiliadosPartidoPolitico
{
    public partial class FrmAfiliados : Form
    {
        //declarar encabezados de columna
        List<string> columnas;
        //en esta tabla guardamos todo el total de registros del archivo
        DataTable dt;
        //en esta tabla guardamos solo los que son de cada municipio
        DataTable dat;

        public FrmAfiliados()
        {
            InitializeComponent();
            columnas = new List<string>();
            columnas.Add("ID");
            columnas.Add("ENTIDAD");
            columnas.Add("MUNICIPIO");
            columnas.Add("NOMBRE");
            columnas.Add("FECHA_AFILIACION");
            columnas.Add("ESTATUS");
            dt = new DataTable();
            pbxCargando.Visible= false;
            checkBoxFecha.Enabled=false;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //if para ver si confirma la seleccion del archivo
            if (oFDAbrir.ShowDialog() == DialogResult.OK)
            {
                //Se recibe el archivo aqui
                string archivo = oFDAbrir.FileName;
                string nombreArchivo = Path.GetFileName(archivo);
                txtArchivo.Text = nombreArchivo;
                pbxCargando.Visible = true;
                //Se crea el hilo y se empieza a ejeccuatr el metodo dentro del hilo
                Thread p1 = new Thread(() => cargarDatos(archivo));
                p1.Start();

            } 
        }
        private void cargarDatos(string archivo)
        {
            //licencia de paquete
            ExcelPackage.License.SetNonCommercialPersonal("Isaac Romero Favela");
            //se crea un paquete donde se abrira el archivo excel
            using (var paquete = new ExcelPackage(new System.IO.FileInfo(archivo)))
            {
                //se obtiene la primera hoja del archivo
                ExcelWorksheet worksheet = paquete.Workbook.Worksheets[0];

                foreach (var col in columnas)
                {
                    //validar si ya estan las columnas
                    if (!dt.Columns.Contains(col))
                    {
                        dt.Columns.Add(col);
                    }
                }
                //obtengo el numero de filas
                int filas = worksheet.Dimension.End.Row;
                for (int i =2; i < filas; i++) {
                    //creamos un data row para copiar el contenido de la celda 
                    DataRow row = dt.NewRow();
                    for (int j =1; j < dt.Columns.Count+1; j++)
                    {  
                        row[j-1 ] = worksheet.Cells[i, j].Text;
                    }
                    dt.Rows.Add(row);
                }


                

                
                //Se crea una invocacion para poder tener acceso a al hilo principal y poder asignar cosas en el visual
                this.Invoke((MethodInvoker)delegate
                {
                    dgvDatos.Columns.Clear();
                    dgvDatos.DataSource = dt;
                    pbxCargando.Visible =false;
                    cbxMunicipio.Items.Add("Todos");
                    cbxMunicipio.Items.Add("Sin municipio");
                    txtEstado.Text = dt.Rows[0][1].ToString();
                    numeroAfiliados();
                    //Se agregan los municipios
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string mun = dt.Rows[i][2].ToString();
                        if (mun !="")
                        {
                            // verificamos que no se repitan
                            if (!cbxMunicipio.Items.Contains(mun) && mun!="")
                            {
                                cbxMunicipio.Items.Add(mun);
                            }
                        }
                    }
                    cbxMunicipio.SelectedIndex = 0;
                });

                
            }
        }

        private void numeroAfiliados() {
            lblAfiliados.Text = "Numero de Afiliados: " + dgvDatos.Rows.Count.ToString();
        }

        private void checkBoxFecha_CheckedChanged(object sender, EventArgs e)
        {
            //Checamos si esta seleccionado
            if (checkBoxFecha.Checked)
            {
                DateTime fechaInicio = dtpInicio.Value;
                DateTime fechaTermina = dtpTermina.Value;
                
                if (cbxMunicipio.SelectedItem.ToString()!="Todos")
                {
                    DataTable data=dat.Clone();
                    foreach (DataRow fila in dat.Rows)
                    {

                        DateTime fecha = Convert.ToDateTime(fila["FECHA_AFILIACION"]);

                        // checar la fecha para ver si esta dentro del rango
                        if (fecha >= fechaInicio && fecha <= fechaTermina)
                        {
                            data.ImportRow(fila);
                        }
                    }

                    dgvDatos.DataSource = data;
                }
                else
                {
                    DataTable tablaFecha = dt.Clone();

                    foreach (DataRow fila in dt.Rows)
                    {

                        DateTime fecha = Convert.ToDateTime(fila["FECHA_AFILIACION"]);

                        // checar la fecha para ver si esta dentro del rango
                        if (fecha >= fechaInicio && fecha <= fechaTermina)
                        {
                            tablaFecha.ImportRow(fila);
                        }
                    }

                    dgvDatos.DataSource = tablaFecha;
                }
                cbxMunicipio.Enabled = false;
            }
            else 
            {
                dgvDatos.DataSource = dt;
                if (cbxMunicipio.Items.Count > 0)
                {
                    cbxMunicipio.SelectedIndex = 0;
                    cbxMunicipio.Enabled=true;
                }

            }

            numeroAfiliados();
        }
        
        private void cbxMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Habilitamos el check
            checkBoxFecha.Enabled = true;
            string municipio = cbxMunicipio.SelectedItem.ToString();
            
            // Clonamos la estructura del DataTable original
            dat = dt.Clone();
            //si es verdadero asignamos todos los registros
            if (municipio == "Todos")
            {
                dgvDatos.DataSource = dt;
            }
            else
            {
                foreach (DataRow fila in dt.Rows)
                {
                    string mun;
                    //comprobamos si el municipio esta vacio
                    if (fila["MUNICIPIO"] == DBNull.Value)
                    {
                        mun = "";
                    }
                    else
                    {
                        mun = fila["MUNICIPIO"].ToString();
                    }

                    //Si la celda municipio esta vacia y el combox esta seleccionado sin municipio entra
                    if (municipio == "Sin municipio" && string.IsNullOrWhiteSpace(mun))
                    {
                        dat.ImportRow(fila);
                    }
                    else if (mun == municipio)
                    {
                        dat.ImportRow(fila);
                    }
                }

                //Agregamos la tabla al dgv
                dgvDatos.DataSource = dat;

            }
            numeroAfiliados();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            //limpiamos todo
            dgvDatos.DataSource = null;
            dt.Clear();
            dat.Clear();
            numeroAfiliados();
            cbxMunicipio.Items.Clear();
            txtArchivo.Clear();
            txtEstado.Clear();
            checkBoxFecha.Checked = false;
            cbxMunicipio.Text = "";
            cbxMunicipio.Enabled=true;
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
