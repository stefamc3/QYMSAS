<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace QYMSAS
{
    class exportExcel
    {
        Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

        public void exportaraexcel(DataGridView tabla)
        {
            int filastotales = tabla.Rows.Count;


            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns) // Columnas
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows) // Filas
            {
                IndeceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
                //progress.Value = (IndeceFila * 100) / filastotales;
            }
            excel.Visible = true;
            Worksheet worksheet = (Worksheet)excel.ActiveSheet;
            worksheet.Activate();
            MessageBox.Show("Exportación Exitosa", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //progress.Value = 0; 
        }

        public void descargarmemoria()
        {
            excel.Visible = true;
            Worksheet worksheet = (Worksheet)excel.ActiveSheet;
            worksheet.Activate();
            MessageBox.Show("Exportación Exitosa", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void exportarEspaexcel(DataGridView tabla, ProgressBar progress, int inicial, int final)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            int filastotales = final;


            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns) // Columnas
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndeceFila = inicial;
            int indice = 0;
            foreach (DataGridViewRow row in tabla.Rows) // Filas
            {
               
                IndeceFila++;
                IndiceColumna = 0;
                if (IndeceFila == final+2)
                {
                    break;
                }
                else
                {
                    foreach (DataGridViewColumn col in tabla.Columns)
                    {
                        IndiceColumna++;
                        excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                    }
                }                
                Console.WriteLine(IndeceFila);
                indice++;
                progress.Value = (indice * 100) / filastotales;
            }
            excel.Visible = true;
            Worksheet worksheet = (Worksheet)excel.ActiveSheet;
            worksheet.Activate();
            MessageBox.Show("Exportación Exitosa", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //progress.Value = 0;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace QYMSAS
{
    class exportExcel
    {
        Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

        public void exportaraexcel(DataGridView tabla)
        {
            int filastotales = tabla.Rows.Count;


            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns) // Columnas
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows) // Filas
            {
                IndeceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
                //progress.Value = (IndeceFila * 100) / filastotales;
            }
            excel.Visible = true;
            Worksheet worksheet = (Worksheet)excel.ActiveSheet;
            worksheet.Activate();
            MessageBox.Show("Exportación Exitosa", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //progress.Value = 0; 
        }

        public void descargarmemoria()
        {
            excel.Visible = true;
            Worksheet worksheet = (Worksheet)excel.ActiveSheet;
            worksheet.Activate();
            MessageBox.Show("Exportación Exitosa", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void exportarEspaexcel(DataGridView tabla, ProgressBar progress, int inicial, int final)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            int filastotales = final;


            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns) // Columnas
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndeceFila = inicial;
            int indice = 0;
            foreach (DataGridViewRow row in tabla.Rows) // Filas
            {
               
                IndeceFila++;
                IndiceColumna = 0;
                if (IndeceFila == final+2)
                {
                    break;
                }
                else
                {
                    foreach (DataGridViewColumn col in tabla.Columns)
                    {
                        IndiceColumna++;
                        excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                    }
                }                
                Console.WriteLine(IndeceFila);
                indice++;
                progress.Value = (indice * 100) / filastotales;
            }
            excel.Visible = true;
            Worksheet worksheet = (Worksheet)excel.ActiveSheet;
            worksheet.Activate();
            MessageBox.Show("Exportación Exitosa", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //progress.Value = 0;
        }
    }
}
>>>>>>> c914ecc4e70bd20047b5792bb7b198ea09b47722
