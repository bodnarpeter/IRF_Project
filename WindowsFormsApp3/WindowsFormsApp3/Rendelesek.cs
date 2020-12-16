using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;

namespace WindowsFormsApp3
{
    public partial class RendelesekForm : Form
    {
        Database1Entities1 context;
      
        public RendelesekForm()
        {
            InitializeComponent();
            this.context = new Database1Entities1();
            context.OrderTitles.Load();
            context.Orders.Load();
            RendelesiTetelekListbox.DataSource = context.OrderTitles.ToList();
            RendelesiTetelekListbox.DisplayMember = "pizzaName";
            Rendeleseklistbox.DataSource = context.Orders.ToList();
            Rendeleseklistbox.DisplayMember = "orderdate";
            orderSKlistbox.DataSource = context.Orders.ToList();
            orderSKlistbox.DisplayMember = "orderSK";
            orderFKlist.DataSource = context.OrderTitles.ToList();
            orderFKlist.DisplayMember = "orderFK";
        }
        private void Rendeleselemlistazas()
        {
            context.OrderTitles.Load();
            RendelesiTetelekListbox.DataSource = context.OrderTitles.ToList();
            RendelesiTetelekListbox.DisplayMember = "pizzaName";
        }
        private void Rendeleseklistazas()
        {
            context.Orders.Load();
            Rendeleseklistbox.DataSource = context.Orders.ToList();
            Rendeleseklistbox.DisplayMember = "orderdate";
        }
        private void OrderFKlistazas()
        {
            context.OrderTitles.Load();
            orderFKlist.DataSource = context.OrderTitles.ToList();
            orderFKlist.DisplayMember = "orderFK";
        }
        private void OrderSKlistazas()
        {
            context.Orders.Load();
            orderSKlistbox.DataSource = context.Orders.ToList();
            orderSKlistbox.DisplayMember = "titleSK";
        }
        private void Kezdolap_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new KezdolapForm();
            f1.Show();
        }
        private void Rendelesek_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f4 = new PizzeriasForm();
            f4.Show();

        }
        private void Kilepbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Teteltorlesebtn_Click(object sender, EventArgs e)
        {
            if (RendelesiTetelekListbox.SelectedItem==null)
            {
                MessageBox.Show("Nincs kiválasztva rendelési tétel vagy még nincsenek rendelési tételek a listában!");
            }
            else
            {
                try
                {
                    dynamic aktualis;
                    aktualis = RendelesiTetelekListbox.SelectedItem;
                    int piID = aktualis.titleSK;
                    var torlendo = from x in context.OrderTitles
                                   where x.titleSK == piID
                                   select x;
                    context.OrderTitles.Remove(torlendo.FirstOrDefault());
                    context.SaveChanges();
                    Rendeleselemlistazas();
                    OrderFKlistazas();
                    MessageBox.Show("Sikeresen törölted a rendelést a listáról!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            

        }
        private void RendelesTorlesBtn_Click(object sender, EventArgs e)
        {
            if (Rendeleseklistbox.SelectedItem == null)
            {
                MessageBox.Show("Nincs kiválasztva rendelés vagy még nincsenek rendelések a listában!");
            }
            else
            {
                try
                {
                    dynamic aktualis;
                    aktualis = Rendeleseklistbox.SelectedItem;
                    int piID = aktualis.orderSK;
                    var torlendo = from x in context.Orders
                                   where x.orderSK == piID
                                   select x;
                    context.Orders.Remove(torlendo.FirstOrDefault());
                    context.SaveChanges();
                    Rendeleseklistazas();
                    Rendeleselemlistazas();
                    OrderFKlistazas();
                    OrderSKlistazas();
                    MessageBox.Show("Sikeresen törölted a rendelést a listáról!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void RendelesTorlesbtn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(RendelesTorlesbtn, "Rendelés törlése. Figyelem, ezzel a rendeléshez tartozó összes elem törlődik!");
        }

        private void Teteltorlesebtn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(RendelesTorlesbtn,"A kiválasztott rendelési tétel törlése.");
        }
    }
}

