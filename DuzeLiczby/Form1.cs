using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuzeLiczby
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            Operation operation;

            operation = new Operation((int)numericUpDown1.Value);
            operation.GenerateRandomValues();

            if (Dodawanie.Checked)
            {
                var list = operation.Addition();
                foreach (var elem in list) { listBox1.Items.Add(elem); }
            }
            else if (Odejmowanie.Checked)
            {
                var list = operation.Subtraction();
                foreach (var elem in list) { listBox1.Items.Add(elem); }
            }
            else if (Mnozenie.Checked)
            {
                var list = operation.Multiplication();
                foreach (var elem in list) { listBox1.Items.Add(elem); }
            }
            else
            {
                var list = operation.Division();
                foreach (var elem in list) { listBox1.Items.Add(elem); }
            }

                

            if (operation.Logger.ErrorFlag)
            {
                foreach (var msg in operation.Logger.Messages)
                {
                    listBox2.Items.Add(msg);
                }
            }


        }
    }
}
