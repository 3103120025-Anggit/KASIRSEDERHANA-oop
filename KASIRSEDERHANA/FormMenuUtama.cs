using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace KASIRSEDERHANA
{
    public partial class FormMenuUtama : Form
    {

        public FormMenuUtama()
        {
            InitializeComponent();
           
        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

         }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=db_kasir";
            string query = "INSERT INTO tbl_barang(kode_barang,nama_barang,harga_jual,harga_beli,jumlah_barang,satuan)VALUES('" + this.boxkodebarang.Text + "','" + this.boxnamabarang.Text + "','" + this.boxhargajual.Text + "','" + this.boxhargabeli.Text + "','" + this.boxjumlahbarang.Text + "','" + this.boxsatuan.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Data berhasil ditambahkan");
            conn.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=db_kasir";
            string query = "UPDATE tbl_barang SET nama_barang='" + this.boxnamabarang.Text + "',harga_jual='" + this.boxhargajual.Text + "',harga_beli='" + this.boxhargabeli.Text + "',jumlah_barang='" + this.boxjumlahbarang.Text + "',satuan='" + this.boxsatuan.Text + "' WHERE kode_barang='" + this.boxkodebarang.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil diubah");
            conn.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=db_kasir";
            string query = "DELETE FROM tbl_barang WHERE kode_barang='" + this.boxkodebarang.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Data berhasil dihapus");
            conn.Close();
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=db_kasir";
            string query = "SELECT * FROM tbl_barang";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}

