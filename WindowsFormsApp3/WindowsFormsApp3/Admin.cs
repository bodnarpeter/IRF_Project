using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Admin : Form
    {
        Database1Entities1 context;
        public Admin()
        {
            InitializeComponent();
            this.context = new Database1Entities1();
            context.Orders.Load();
            context.OrderTitles.Load();
            context.PizzaLists.Load();
            context.Pizzerias.Load();
            orderBindingSource.DataSource = context.Orders.Local;
            orderTitleBindingSource.DataSource = context.OrderTitles.Local;
            pizzaListBindingSource.DataSource = context.PizzaLists.Local;
            pizzeriaBindingSource.DataSource = context.Pizzerias.Local;

        }

        private void KezdolapBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var start = new KezdolapForm();
            start.Show();
        }

        private void KilepesBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
