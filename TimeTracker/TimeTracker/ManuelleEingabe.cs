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
    public partial class ManuelleEingabe : Form
    {
        TextFileOperations ops = new TextFileOperations();
        public ManuelleEingabe()
        {
            InitializeComponent();
        }

        private void btnAddManual_Click(object sender, EventArgs e)
        {
            //Code zum Zeit hinzufügen
            String time = null; //datetimepicker 2- datetimer picker 1
            ops.InsertTime(time);
            this.Close();
        }
    }
}
