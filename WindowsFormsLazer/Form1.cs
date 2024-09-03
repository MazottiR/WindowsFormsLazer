using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLazer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text);

            textBox1.Clear();
            textBox2.Clear();

            MessageBox.Show("Aluno incluído com sucesso", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            label5.Text = dataGridView1.RowCount.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 0;

            label5.Text = dataGridView1.RowCount.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                MessageBox.Show("Aluno removido com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                label5.Text = dataGridView1.RowCount.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                dataGridView1.CurrentRow.Cells["nome"].Value = textBox3.Text;

                MessageBox.Show("Aluno alterado com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.RowCount > 0)
            {
                textBox3.Text = dataGridView1.CurrentRow.Cells["nome"].Value.ToString();
            }
        }
    }
}
