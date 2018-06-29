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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bGenerate_Click(object sender, EventArgs e)
        {
            Function f = new Function(get_rbFunctionX(), get_ValueA(), get_ValueB(), this);
            this.Visible = false;
            f.Show();

        }

         public string get_rbFunctionX ()
        {
            if (rbFunction1.Checked==true)
            {
                return rbFunction1.Text;
            }

            if (rbFunction2.Checked == true)
            {
                return rbFunction2.Text;
            }
            return null;
        }

        public string get_ValueA()
        {
            return tbValueA.Text;
        }

        public string get_ValueB()
        {
            return tbValueB.Text;
        }
    }
}
