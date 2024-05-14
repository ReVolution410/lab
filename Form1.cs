using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 10;
            dataGridView1.Width = 255;
            dataGridView1.Height = 245;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Columns[i].Width = 20;
                    dataGridView1.Rows[i].Height = 20;
                    
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dataGridView1.Rows.Count ; i++)
            {

                for (int j = 0; j < dataGridView1.Columns.Count / 2; j++)
                {

                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                }

            }
        } 

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                for (int j = dataGridView1.Rows.Count / 2; j < dataGridView1.Columns.Count; j++)
                {

                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }

            }
        } 

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }

            }
        } 

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (i == j)
                    {
                        dataGridView1.Rows[i].Cells[i].Style.BackColor = Color.Red;

                    }
                    
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (i < j)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Blue;

                    }

                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (j < i)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Blue;

                    }

                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if ((i + j) < (dataGridView1.RowCount - 1)) 
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Green;
                    }

                }

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    dataGridView1.Rows[i].Cells[9 - i].Style.BackColor = Color.Yellow;

                }

            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count / 2; i++)
            {

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Pink;
                }

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.Rows.Count / 2; i < dataGridView1.Rows.Count; i++)
            {

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if ((i + j) > (dataGridView1.RowCount - 1)) 
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                    }
                }
            }
        }
    }
}

