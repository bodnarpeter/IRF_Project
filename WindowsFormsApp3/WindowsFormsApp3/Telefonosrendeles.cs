using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Telefonosrendeles : Form
    {
        public Telefonosrendeles()
        {
            InitializeComponent();
        }

        private void rendelesekbetoltbtn_Click(object sender, EventArgs e)
        {

        }
        public class TRendelesek
        {
            public string CustomerName { get; set; } 
            public int PizzeriaId{ get; set; }
            public string PizzaName { get; set; }
            public int Quantity { get; set; }
            public string Address { get; set; }
           
        }
    }
}
