using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QYMSAS
{
    public partial class estadisticas : Form
    {
        int iduss;
        public estadisticas(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void estadisticas_Load(object sender, EventArgs e)
        {
            string[] series = { "Enero", "Febrero", "Marzo", "Abril" , "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre","Noviembre", "Diciembre" };
            int[] monto = new int[12]; ;
            chart1.Titles.Add("VENTAS DE RECEBO MENSUAL");
            monto[0] = basededatos.sumaporplaca("2019/01/01","2019/01/31");
            monto[1] = basededatos.sumaporplaca("2019/02/01", "2019/02/28");
            monto[2] = basededatos.sumaporplaca("2019/03/01", "2019/03/31");
            monto[3] = basededatos.sumaporplaca("2019/04/01", "2019/04/30");
            monto[4] = basededatos.sumaporplaca("2019/05/01", "2019/05/31");
            monto[5] = basededatos.sumaporplaca("2019/06/01", "2019/06/30");
            monto[6] = basededatos.sumaporplaca("2019/07/01", "2019/07/31");
            monto[7] = basededatos.sumaporplaca("2019/08/01", "2019/08/31");
            monto[8] = basededatos.sumaporplaca("2019/09/01", "2019/09/30");
            monto[9] = basededatos.sumaporplaca("2019/10/01", "2019/10/31");
            monto[10] = basededatos.sumaporplaca("2019/11/01", "2019/11/30");
            monto[11] = basededatos.sumaporplaca("2019/12/01", "2019/12/31");


            chart1.Palette = ChartColorPalette.Pastel;

            for (int i = 0; i < series.Length; i++)
            {
                Series serie = chart1.Series.Add(series[i]);

                serie.Label = monto[i].ToString();
                serie.Points.Add(monto[i]);
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Selección men = new Selección(iduss);
            men.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
