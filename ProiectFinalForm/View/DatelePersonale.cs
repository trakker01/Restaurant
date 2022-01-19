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
    public partial class DatelePersonale : Form
    {

        public DatelePersonale(String U)
        {
            InitializeComponent();
            using (UtilizatorDbContext udb = new UtilizatorDbContext())
            {
                txtUtilizator.Text = U;
                
                int i = int.Parse(this.txtUtilizator.Text);
                var res = udb.Utilizatori.Single(p => p.Id == i);
                {
                    this.NameD.Text = res.Nume.ToString();
                    this.PrenumeD.Text = res.Prenume.ToString();
                    this.UserD.Text = res.Username.ToString();
                }
            }
        }

    }
}
