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
    public partial class PizzeriasForm : Form
    {
         Database1Entities1 context;   
        private DataTable shoppingList;
        private List<Pizzeria> pizzeriaList;

        public PizzeriasForm()
        {
            this.context = new Database1Entities1();
            this.shoppingList = new DataTable();

            InitializeComponent();
            context.Pizzerias.Load();
            context.PizzaLists.Load();
            context.Orders.Load();
            context.OrderTitles.Load();
            listBoxPizzerias.DisplayMember = nameof(Pizzeria.pizzeriaName);
            pizzeriaList = context.Pizzerias.AsQueryable().ToList();
            listBoxPizzerias.DataSource = pizzeriaList;
        }             

        private void TextPizzeriaszures_TextChanged(object sender, EventArgs e)
        {
            var p = pizzeriaList.Where(x => x.pizzeriaName.Contains(pizzeriaszures.Text));
            listBoxPizzerias.DataSource = p.ToList();
            listBoxPizzerias.DisplayMember = nameof(Pizzeria.pizzeriaName);
        }     
        
        private void Kezdolap_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new KezdolapForm();
            f1.Show();
        }

        private void ListBoxPizzerias_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pizzak = from x in context.PizzaLists
                         where x.pizzeriaFK == ((Pizzeria)listBoxPizzerias.SelectedItem).pizzeriaID
                         select new
                         {
                             x.pizzaID,
                             x.pizzaName,
                             x.price,
                             x.Pizzeria.pizzeriaName,
                             x.description,
                         };

            bindingSource1.DataSource = pizzak.ToList();

        } //kiválaszott pizzéria pizzáinak betöltése a pizzák datagridviewba

        private void KosarbaRak_Click(object sender, EventArgs e)//kosarba rak
        {
            int sum = 0;

            if (!shoppingList.Columns.Contains("Pizza") && !shoppingList.Columns.Contains("Ár(Ft)"))
            {
                shoppingList.Columns.Add("PizzaID");
                shoppingList.Columns.Add("Pizza");
                shoppingList.Columns.Add("Ár(Ft)");               
            }

            foreach (DataGridViewRow drv in pizzakdgw.Rows)
            {
                bool chkboxselect = Convert.ToBoolean(drv.Cells["select"].Value);
                if (chkboxselect)
                {
                    shoppingList.Rows.Add(drv.Cells[1].Value, drv.Cells[2].Value, drv.Cells[4].Value);
                }
                kosártartalmadgv.DataSource = shoppingList;
            }
            this.kosártartalmadgv.Columns["PizzaID"].Visible = false;
       
            for (int i = 0; i < kosártartalmadgv.Rows.Count; i++)
            {
                sum += Convert.ToInt32(kosártartalmadgv.Rows[i].Cells[3].Value);
            }
            összesit.Text = "Összesen: "+ sum.ToString()+" Ft";
        }
        
        private void KosarbolTorol_Click(object sender, EventArgs e)//kijelölt elem törlése a kosárból
        {
            int sum = 0; 
            foreach  (DataGridViewRow drv in kosártartalmadgv.Rows )
            {
                bool chkboxselect = Convert.ToBoolean(drv.Cells["selected"].Value);
                if (chkboxselect)
                {
                    shoppingList.Rows.Remove(((DataRowView)drv.DataBoundItem).Row);
                }
            }
            for (int i = 0; i < kosártartalmadgv.Rows.Count; i++)
            {
                sum += Convert.ToInt32(kosártartalmadgv.Rows[i].Cells[3].Value);
            }
            összesit.Text = "Összesen: " + sum.ToString() + " Ft";
        }

        private void Kilepesrendelesnelkulbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void Rendelesfelvet_Click(object sender, EventArgs e)
        {
            var order = new Order();
            order.orderdate = DateTime.Now;
            
            order.price = order.price = kosártartalmadgv.Rows.Cast<DataGridViewRow>()
                .Where(x => Convert.ToBoolean((x as DataGridViewRow).Cells["selected"].Value))
                .Sum(x => int.Parse((x as DataGridViewRow).Cells[3].Value.ToString()));


            bool s = false;
            foreach (DataGridViewRow chc in kosártartalmadgv.Rows)
            {
                var check = Convert.ToBoolean(chc.Cells["selected"].Value);
                if (check)
                {
                    s = true;
                }
            }

            if (s)
            {
                foreach (DataGridViewRow drv in kosártartalmadgv.Rows)
                {
                    var chkboxselect = Convert.ToBoolean(drv.Cells["selected"].Value);
                    if (chkboxselect)
                    {

                        var orderTitle = new OrderTitle();
                        order.price = int.Parse(drv.Cells[3].Value.ToString());
                        orderTitle.pizzaName = drv.Cells[2].Value.ToString();
                        orderTitle.Order = order;
                        orderTitle.orderFK = order.orderSK;
                        orderTitle.pizzaFK = int.Parse(drv.Cells[1].Value.ToString());
                        orderTitle.price = int.Parse(drv.Cells[3].Value.ToString());
                        order.OrderTitles.Add(orderTitle);
                        context.OrderTitles.Attach(orderTitle);
                        context.OrderTitles.Add(orderTitle);
                    }
                }
              MessageBox.Show("Sikeres rendelés!");
                context.Orders.Attach(order);
                context.Orders.Add(order);
                await context.SaveChangesAsync();
            }
           
            else
            {
                MessageBox.Show("A rendeléshez válassz ki pizzát/pizzákat!");
            }
          }

        private void rendeleseimbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f4 = new RendelesekForm();
            f4.Show();
        }

        private void KosarbateszBtn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(KosarbateszBtn, "A kijelölt pizzák kosárba helyezése");
        }

        
    }
}