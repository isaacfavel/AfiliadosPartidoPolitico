using OfficeOpenXml;
using System;
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

namespace AfiliadosPartidoPolitico
{
    public partial class FrmAfiliados : Form
    {
        //declarar encabezados de columna
        List<string> columnas;
        DataTable dt;

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
            pictureBox1.Visible= false;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //if para ver si confirma la seleccion del archivo
            if (oFDAbrir.ShowDialog() == DialogResult.OK)
            {
                string archivo = oFDAbrir.FileName;
                txtArchivo.Text = archivo;
                pictureBox1.Visible = true;
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

                //se crea una tbla para ponerle la informacion
                

                foreach (var col in columnas)
                {
                    //Se agregan columnas al data table
                    dt.Columns.Add(col);
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


                

                

                this.Invoke((MethodInvoker)delegate
                {
                    dgvDatos.Columns.Clear();
                    dgvDatos.DataSource = dt;
                    dgvDatos.Columns[0].Width =45;
                    dgvDatos.Columns[3].Width = 200;
                    pictureBox1.Visible =false;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var celda = dt.Rows[i][2];

                        if (celda != null)
                        {
                            string mun = celda.ToString();

                            // Evita agregar duplicados
                            if (!cbxMunicipio.Items.Contains(mun))
                            {
                                cbxMunicipio.Items.Add(mun);
                            }
                        }
                    }
                });

                
            }
        }

        
    }
}
