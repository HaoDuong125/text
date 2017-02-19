using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace demo
{
    public partial class Form1 : Form
    {
        string connectionString;
        DataSet ds;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "Data Source=DESKTOP-6QDKNM9\\ SQLEXPRESS;Initial Catalog=QLTTNN;User ID=sa;Password=123";
            ds = new DataSet();
            string query = "Select * from tb_NhanVien";
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                da = new SqlDataAdapter(query, conn);
                da.Fill(ds, "tb_NhanVien");
                dataGridView1.DataSource = ds.Tables["tb_NhanVien"];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
