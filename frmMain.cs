﻿using buBilet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace suBilet
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=Data Source=BurakAlkan\SQLEXPRESS;Initial Catalog=buBilet;Integrated Security=True;Trust Server Certificate=True;Initial Catalog=buBilet;Integrated Security=True");

        // identifying user's id num whose logged in 
        internal string Id { get; set; }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dateTimePicker.MinDate = DateTime.Now;

            try
            {
                // for available and already taken tickets

            }
            catch 
            {
                MessageBox.Show("Somethings went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                connection.Close();
            }

        }

    }
}
