using System.Data;
using System.Xml;

namespace BIndingCsv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader theReader;
            var dt = new DataTable();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String filePath = openFileDialog1.FileName;
                theReader = File.OpenText(filePath);

                foreach (var headerLine in File.ReadLines(filePath).Take(1))
                {

                    foreach (var headerItem in headerLine.Split(","))
                    {
                        dt.Columns.Add(headerItem.Trim());
                    }
                }

                foreach (var line in File.ReadLines(filePath).Skip(1))
                {
                    dt.Rows.Add(line.Split(','));
                }
                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            int columns = row.Cells.Count;
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
            textBox6.Text = row.Cells[5].Value.ToString();
            textBox7.Text = row.Cells[6].Value.ToString();
            textBox8.Text = row.Cells[7].Value.ToString();
            textBox9.Text = row.Cells[8].Value.ToString();
            textBox10.Text = row.Cells[9].Value.ToString();
            textBox11.Text = row.Cells[10].Value.ToString();
            textBox12.Text = row.Cells[11].Value.ToString();
            textBox13.Text = row.Cells[12].Value.ToString();


        }
    }
}