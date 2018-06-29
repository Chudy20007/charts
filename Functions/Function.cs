using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Functions
{
    public partial class Function : Form
    {
        private Form1 f1;
        public Function(string function,string valueA, string valueB,Form1 MainForm)
        {
            
            InitializeComponent();
            this.label1.Text = function;
            this.label2.Text = "Value a: " + valueA;
            this.label3.Text = "Value b: " + valueB;
            f1 = MainForm;
            chart1.Visible = false;
          


        }

        public void pbFunctionPlace_Paint(object sender, PaintEventArgs e)
        {
            
            int []ArrY = new int[10];
            int[]ArrX = { 20, 40, 60, 80, 100, 120, 140, 160, 180, 200 };
            int a = int.Parse(f1.get_ValueA());
            int b = int.Parse(f1.get_ValueB());
         /*   
            Pen penCurrent = new Pen(Color.Blue);
            Point[] pt = new Point[10];

            for (int i=0; i<9; i++)
            {
                ArrY[i] = a * ArrX[i] - b;
                pt[i]=new Point(ArrX[i],ArrY[i]);
                Console.WriteLine(pt);
                
            }

           
                e.Graphics.DrawCurve(penCurrent, pt);

          */


        }

   

        private void chart1_Paint(object sender, PaintEventArgs e)
        {
            double[] ArrY = new double[10];
            double[] ArrX = { -15, -10, -5, 0,-5,10, 15, 16, 18, 20 };
            double a = double.Parse(f1.get_ValueA());
            double b;
            if (f1.get_ValueB() == "")
            {
                b = 0;
            }
            else b = double.Parse(f1.get_ValueB());
            Point[] pt = new Point[10];

            if (label1.Text == f1.rbFunction2.Text)
            {

                for (int i = 0; i < 10; i++)
                {
                    ArrY[i] = a * ArrX[i] - b;

                    this.chart1.Series["Series1"].Points.AddXY(ArrX[i], ArrY[i]);
                }

            }

            if (label1.Text == f1.rbFunction1.Text)
            {

                for (int i = 0; i < 10; i++)
                {
                    ArrY[i] = a *ArrX[i]*ArrX[i];

                    this.chart1.Series["Series1"].Points.AddXY(ArrX[i], ArrY[i]);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b=0;
            double a=0;
            chart1.Visible = true;
            double[] ArrY = new double[10];
            double[] ArrX = { -20,-15,-10,-5,0,5,10,15,20,25};
            if (f1.get_ValueA().Length == 0)
            {
                MessageBox.Show("Input variable!");
                return;
            }
            if (f1.get_ValueB() == "")
            {
                b = 0;
            }
            try
            {
                a = double.Parse(f1.get_ValueA());
                b = double.Parse(f1.get_ValueB());
            }
            catch
            {
                MessageBox.Show("Check values!","Warning!");
                return;
            }
            Point[] pt = new Point[10];

            if (label1.Text == f1.rbFunction2.Text)
            {

                for (int i = 0; i < 10; i++)
                {
                    ArrY[i] = a * ArrX[i] - b;

                    this.chart1.Series["Function"].Points.AddXY(ArrX[i], ArrY[i]);
                }

            }

            if (label1.Text == f1.rbFunction1.Text)
            {

                for (int i = 0; i < 10; i++)
                {
                    ArrY[i] = a * (ArrX[i] * ArrX[i]);

                    this.chart1.Series["Function"].Points.AddXY(ArrX[i], ArrY[i]);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            this.Visible = false;
            f1.Show();
        }
    }
}
