using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class form_Login : Form
    {
        dbClass dbc = new dbClass();
        
        public form_Login()
        {
            InitializeComponent();
        }

        private bool btn_prijava_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
            string ole = "SELECT * FROM korisnici WHERE KorisnickoIme='" + txt_korIme + "'and Lozinka='" + txt_lozinka + "'";
            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            OleDbCommand cmd = new OleDbCommand(ole, conn);
            conn.Open();
            OleDbDataReader _reader = cmd.ExecuteReader();
            while (_reader.Read())
            {
                //form_Main.menustrup1.enabled
            }
            return isSuccess;            
        }
    }
}
