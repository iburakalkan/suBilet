using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suBilet
{
    public partial class frmAdminMain : Form
    {
        public frmAdminMain()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=Data Source=BurakAlkan\SQLEXPRESS;Initial Catalog=buBilet;Integrated Security=True;Trust Server Certificate=True;Initial Catalog=buBilet;Integrated Security=True");
        // identifying user's id num whose logged in
        internal string Id { get; set; }
        private void createBusTrip_Click(object sender, EventArgs e)
        {
            frmCreateBusTrip cbt = new frmCreateBusTrip();
            cbt.Show();
        }
    }
}
