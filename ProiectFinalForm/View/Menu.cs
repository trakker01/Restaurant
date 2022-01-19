using System;
using ProiectFinalForm.View;
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
    public partial class Menu : Form
    {
        public Menu(String user)
        {
            InitializeComponent();
            txtU.Text = user;
        }


        private void btnComanda_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPreturiMeniu_Click(object sender, EventArgs e)
        {
            var p = new View.PreturiMeniuri();
            //p.FormClosed += (s, args) => this.Close();
            p.Show();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            var m = new View.DatelePersonale(txtU.Text);
           //m.FormClosed += (s, args) => this.Close();
            m.Show();
        }
    }
}
