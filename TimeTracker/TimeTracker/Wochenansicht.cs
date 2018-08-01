using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker
{
    public partial class Wochenansicht : Form
    {
        public Wochenansicht()
        {
            InitializeComponent();
        }

        public void Zeiten_setzen()
        {
            lblMontag.Text = "";
            lblDienstag.Text = "";
            lblMittwoch.Text = "";
            lblDonnerstag.Text = "";
            lblFreitag.Text = "";
            lblSamstag.Text = "";
            lblSonntag.Text = "";

        }
    }
}
