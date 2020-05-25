using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProblemaProdutorConsumidor
{
    public partial class Programas : Form
    {
        Thread nt;
        public Programas()
        {
            InitializeComponent();
        }


      

        private void BTEx07_Click(object sender, EventArgs e)
        {
            nt = new Thread(SemaforoMutexSincroniza);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void SemaforoMutexSincroniza()
        {
            Application.Run(new SemaforoMutexSinc());
        }
    }
}
