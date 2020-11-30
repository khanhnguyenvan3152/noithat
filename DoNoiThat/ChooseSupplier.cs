using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoNoiThat
{
    public delegate void DataSentHandler(string id, string name);
    public partial class ChooseSupplier : Form
    {
        private string id;
        private string name;
        public event DataSentHandler DataSent;
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public ChooseSupplier()
        {
            InitializeComponent();
        }

        private void ChooseSupplier_Load(object sender, EventArgs e)
        {
            DataTable temp = Functions.GetDataTable("SELECT * FROM NhaCungCap");
            dataGridView1.DataSource = temp;
            temp.Dispose();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow !=null)
            {
                Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.DataSent(Id, Name);
                this.Close();
            }
            else
            {
                MessageBox.Show("Chọn nhà cung cấp");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
