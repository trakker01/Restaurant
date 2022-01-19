using ProiectFinalForm.Models;
using ProiectFinalForm.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Menu = ProiectFinalForm.View.Menu;

namespace ProiectFinalForm
{
    public partial class Form1 : Form
    {
       // DatelePersonale DP = new View.DatelePersonale();

        public Form1()
        {
            InitializeComponent();
            LoadDataU();
        }
        private void LoadDataU()
        {
            using (UtilizatorDbContext udb = new UtilizatorDbContext())
            {
                var res = from u in udb.Utilizatori
                          select new
                          {
                              u.Id,
                              u.Nume,
                              u.Prenume,
                              u.Username,
                              u.Parola

                          };
                dataGridView1.DataSource = res.ToList();
            }
        }

        public string getU
        {
            get { return txtNume.Text; }
            set { txtNume.Text = value; }
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            using (UtilizatorDbContext UDB = new UtilizatorDbContext())
            {
                // this.Close();
                try {
                var res = UDB.Utilizatori.Single(p => p.Username == this.txtNume.Text && p.Parola == this.txtPassword.Text);
                if (res != null)
                {
                    getU = this.txtNume.Text;
                    this.Hide();
                    var m = new View.Menu(res.Id.ToString());
                    m.FormClosed += (s, args) => this.Close();
                    m.Show();
                }
                else MessageBox.Show("Ati introdus gresit User name-ul sau parola");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Datele date nu apar in baza de date."+ "Va rugam sa verificati din nou datele trimise");
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            CreateUser CR = new CreateUser();
            if (CR.ShowDialog() == DialogResult.OK)
                LoadDataU();
        }

        private void btnEliminare_Click(object sender, EventArgs e)
        {
            using (UtilizatorDbContext udb = new UtilizatorDbContext())
            {
                var res = udb.Utilizatori.SingleOrDefault(p => p.Username == this.txtNume.Text && p.Parola == this.txtPassword.Text);
                if (res != null)
                {
                    udb.Utilizatori.Remove(res);
                    udb.SaveChanges();
                }
                else MessageBox.Show("Ati introdus gresit User name-ul sau parola");
            }
        }

       
    }
}
