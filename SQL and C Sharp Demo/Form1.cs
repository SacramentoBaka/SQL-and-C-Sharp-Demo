using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_and_C_Sharp_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbStudentTwoDataSet.tbStudentTwo' table. You can move, or remove it, as needed.
            this.tbStudentTwoTableAdapter.Fill(this.dbStudentTwoDataSet.tbStudentTwo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbStudentTwoBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbStudentTwoBindingSource.EndEdit();
            tbStudentTwoTableAdapter.Update(dbStudentTwoDataSet.tbStudentTwo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbStudentTwoBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbStudentTwoBindingSource.MoveFirst(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbStudentTwoBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbStudentTwoBindingSource.MovePrevious();  
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbStudentTwoBindingSource.MoveNext();
        }
    }
}
