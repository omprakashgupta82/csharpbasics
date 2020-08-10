using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using  System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ds= MessageBox.Show("abc","Info",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button1);
            label1.Text = ds.ToString();

            int a = 10;

            switch (a)
            {
                case 1:
                    break;
            }
        }
    }

    public interface ITest

    {

        void SomeMethod();

    }

    public class FixedBase : ITest

    {

        void ITest.SomeMethod()

        {

            // ...

        }



        protected void SomeMethod()

        {

            // ...

        }

        void aa(string aa)
        {
        }
    }



}
