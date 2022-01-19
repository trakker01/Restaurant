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

namespace ProiectFinalForm.View
{
    public partial class PreturiMeniuri : Form
    {
        public PreturiMeniuri()
        {
            InitializeComponent();
            LoadDataP();
        }

        private void LoadDataP()
        {
            using(MeniuriDbContext mdb = new MeniuriDbContext())
            {
                var res = from m in mdb.Meniu
                          select new
                          {
                              m.Id,
                              m.NumeMeniu,
                              m.Continut,
                              m.Pret
                          };
                dataGridView1.DataSource = res.ToList();
            }
        }


    }
}
