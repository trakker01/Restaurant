using System;
using ProiectFinalForm.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectFinalForm.View
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void btnFinalizare_Click(object sender, EventArgs e)
        {
            using (UtilizatorDbContext context = new UtilizatorDbContext())
            {
                 if (this.txtNume.Text ==  "" || this.txtPrenume.Text ==  "" || this.txtUser.Text ==  "" || this.txtParola.Text ==  "")
                {
                    MessageBox.Show("Unele detalii au fost lasate goale completatile");
                }
                else
                {
                    Utilizator u = new Utilizator();
                    u.Nume = this.txtNume.Text;
                    u.Prenume = this.txtPrenume.Text;
                    u.Username = this.txtUser.Text;
                    u.Parola = this.txtParola.Text;
                    if (this.txtReParola.Text == this.txtParola.Text)
                    {
                        context.Utilizatori.Add(u);
                        context.SaveChanges();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ati reintrodus parola gresit");
                    }
                }
            }

        }

    }
}
