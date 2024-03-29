﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiLibreriaa;
using System.Data;

namespace Factura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static String Codigo = "";



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String CMD = String.Format("Select * FROM Usuarios WHERE account = '{0}' AND password = '{1}'", txtNomAcc.Text.Trim(), txtPass.Text.Trim());

                DataSet ds = Utilidades.Ejecutar(CMD);

                Codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();

                if( cuenta == txtNomAcc.Text.Trim() && contra == txtPass.Text.Trim())
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_admin"]) == true)
                    {
                        VentanaAdmin VenAd = new VentanaAdmin();
                        this.Hide();
                        VenAd.Show();
                    }
                    else
                    {
                        VentanaUser VenUS = new VentanaUser();
                        this.Hide();
                        VenUS.Show();
                    }
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Datos incorrectos, intente de nuevo ");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
