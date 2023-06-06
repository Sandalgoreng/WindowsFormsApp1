using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string connection = "server=localhost;uid=root;pwd=;database=biocare";
        MySqlConnection SqlConnection;
        MySqlCommand SqlCommand;
        MySqlDataAdapter SqlDataAdapter;
        string sql2;
        DataTable pp = new DataTable();
        DataTable oo = new DataTable();
        DataTable ii = new DataTable();
        DataTable uu = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection = new MySqlConnection(connection);
            SqlConnection.Open();
            sql2 = "SELECT nama_pasien,id_pasien from pasien p;";
            SqlCommand = new MySqlCommand(sql2, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(pp);
            namapasien.DataSource = pp;
            namapasien.DisplayMember = "nama_pasien";
            namapasien.ValueMember = "id_pasien";
            ////////////////////////////////////////////////////////
            SqlConnection = new MySqlConnection(connection);
            SqlConnection.Open();
            sql2 = "SELECT nama_dokter from dokter;";
            SqlCommand = new MySqlCommand(sql2, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(oo);
            namadokter.DataSource = oo;
            namadokter.DisplayMember = "nama_dokter";
            namadokter.ValueMember = "nama_dokter";
            ///////////////////////////////////////////////////////
            //idpas
            ///////////////////////////////////////////////////////
            string test = namapasien.SelectedValue.ToString();
            uu = new DataTable();
            SqlConnection = new MySqlConnection(connection);
            SqlConnection.Open();
            sql2 = $"select nama_obat as `nama obat`, hargaPerBiji as `harga obat perbiji`, nama_jenis as `jenis kamar`, harga_perMalam as `harga kamar permalam`, (hargaPerBiji + harga_perMalam) as `akumulasi harga`\r\nfrom obat o, jenis_kamar j\r\nwhere o.id_pasien = '{test}';";
            SqlCommand = new MySqlCommand(sql2, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(uu);
            dataharga.DataSource = uu;
            
        }
    }
}
