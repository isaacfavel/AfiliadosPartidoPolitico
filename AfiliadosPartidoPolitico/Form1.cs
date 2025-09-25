using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace AfiliadosPartidoPolitico
{
    public partial class FrmAfiliados : Form
    {
        //declarar encabezados de columna
        List<string> columnas;
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

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //if para ver si confirma la seleccion del archivo
            if (oFDAbrir.ShowDialog() == DialogResult.OK)
            {
                string archivo = oFDAbrir.FileName;
                txtEstado.Text ="Coahuila";
                cargarDatos(archivo);
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
                DataTable dt = new DataTable();

                foreach (var col in columnas)
                {
                    //Se agregan columnas al data table
                    dt.Columns.Add(col);
                }
                 //obtengo el numero de filas
                int filas = worksheet.Dimension.End.Row+2;
                int co=dt.Columns.Count;
                txtEstado.Text = co.ToString();
                for (int i = 2; i < filas; i++) {
                    //creamos un data row para copiar el contenido de la celda 
                    DataRow row = dt.NewRow();
                    for (int j =1; i < dt.Columns.Count+1; j++)
                    {
                        row[j-1 ] = worksheet.Cells[i, j].Text;
                    }
                    dt.Rows.Add(row);
                }


                //Mostrar datos en el dgvDatos

                //Le agregamos las filas que tiene el dataTable
                dgvDatos.Rows.Add(dt.Rows.Count);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        //recorre fila por fila para copiar los valores
                        dgvDatos.Rows[i].Cells[j].Value = dt.Rows[i][j].ToString();
                    }
                }
            }
        }
    }
}
