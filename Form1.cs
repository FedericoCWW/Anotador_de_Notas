using System.Data;
using System.Windows.Forms;
using System.Text;


namespace NotetakingApp
{
    public partial class Form1 : Form
    {
        DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("titulo", typeof(string));
            table.Columns.Add("mensajes", typeof(string));

            dataGridView1.DataSource = table;
            dataGridView1.Columns["mensajes"].Width = 100;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            txt_title.Clear();
            txt_msg.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txt_title.Text, txt_msg.Text);
            txt_title.Clear();
            txt_msg.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index > -1)
            {
                txt_title.Text = table.Rows[index].ItemArray[0].ToString();
                txt_msg.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            table.Rows.RemoveAt(index);
        }
    }
}
