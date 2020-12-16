using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Modify : Form
    {
        Database1Entities1 context;
        

        public Modify()
        {
            InitializeComponent();
            this.context = new Database1Entities1();
            context.Pizzerias.Load();
            context.PizzaLists.Load();
            PizzeriaCombo.DataSource = context.Pizzerias.ToList();
            PizzeriaCombo.DisplayMember = "pizzeriaName";
            PizzaCombo.DataSource = context.PizzaLists.ToList();
            PizzaCombo.DisplayMember = "pizzaName";
            PizzeriakujPizzahozCombo.DataSource = context.Pizzerias.ToList();
            PizzeriakujPizzahozCombo.DisplayMember = "pizzeriaName";
            FeltetekCombo.DataSource = context.PizzaLists.ToList();
            FeltetekCombo.DisplayMember = "description";
            TorolniPizzalistbox.DataSource = context.PizzaLists.ToList();
            TorolniPizzalistbox.DisplayMember = "pizzaName";
        }
        private void PizzeriaListazas()
        {
            PizzeriaCombo.DataSource = context.Pizzerias.ToList();
            PizzeriaCombo.DisplayMember = "pizzeriaName";
        }
        private void PizzeriaUjpizzahoz()
        {
            PizzeriakujPizzahozCombo.DataSource = context.Pizzerias.ToList();
            PizzeriakujPizzahozCombo.DisplayMember = "pizzeriaName";
        }
        private void PizzaListazas()
        {
            PizzaCombo.DataSource = context.PizzaLists.ToList();
            PizzaCombo.DisplayMember = "pizzaName";
        }
        private void FeltetekListazas()
        {
            FeltetekCombo.DataSource = context.PizzaLists.ToList();
            FeltetekCombo.DisplayMember = "description";
        }
        private void TorolniPizzaListazas()
        {
            TorolniPizzalistbox.DataSource = context.PizzaLists.ToList();
            TorolniPizzalistbox.DisplayMember = "pizzaName";
        }
        private void PizzeriaFelvetelBtn_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrWhiteSpace(pizzeriaTxt.Text)))
            {
                Pizzeria ujpizzeria = new Pizzeria();
                ujpizzeria.pizzeriaName = pizzeriaTxt.Text;
                context.Pizzerias.Add(ujpizzeria);
                context.SaveChanges();
                PizzeriaListazas();
                PizzeriaUjpizzahoz();
                MessageBox.Show("Sikeresen hozzadtad a Pizzériát a listához!");
            }
        }
        private void PizzeriaTorlesBtn_Click(object sender, EventArgs e)
        {

            PizzeriaCombo.ValueMember = "pizzeriaID";
            try
            {
                dynamic aktualis;
                aktualis = PizzeriaCombo.SelectedItem;
                int piID = aktualis.pizzeriaID;
                var torlendo = from x in context.Pizzerias
                               where x.pizzeriaID == piID
                               select x;
            context.Pizzerias.Remove(torlendo.FirstOrDefault());
                context.SaveChanges();
                PizzeriaListazas();
                PizzaListazas();
                TorolniPizzaListazas();
                PizzeriaUjpizzahoz();
                MessageBox.Show("Sikeresen törölted a pizzériát a listáról!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        private void UjPizzaFelveszBtn_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrWhiteSpace(UjPizzanevtxt.Text)) && (PizzaCombo.SelectedItem == null) || (String.IsNullOrWhiteSpace(UjFeltettxt.Text))
                && (FeltetekCombo.SelectedItem == null) || (String.IsNullOrWhiteSpace(UjArtxt.Text)) || (PizzeriakujPizzahozCombo.SelectedItem==null))
            {
                MessageBox.Show("Kérlek válaszd vagy töltsd ki minden szükséges adatot!");
            }
            else
            {
                if ((!String.IsNullOrWhiteSpace(UjPizzanevtxt.Text)) && (!String.IsNullOrWhiteSpace(UjFeltettxt.Text)) //minden új
                      && (!String.IsNullOrWhiteSpace(UjArtxt.Text)))
                {
                    Pizzeria pizzeria = (Pizzeria)PizzeriakujPizzahozCombo.SelectedItem;
                    PizzaList ujpizza = new PizzaList();
                    ujpizza.pizzaName = UjPizzanevtxt.Text;
                    ujpizza.pizzeriaFK = pizzeria.pizzeriaID;
                    ujpizza.description = UjFeltettxt.Text;
                    ujpizza.price = int.Parse(UjArtxt.Text);

                    context.PizzaLists.Add(ujpizza);
                    context.SaveChanges();
                    PizzaListazas();
                    TorolniPizzaListazas();
                    MessageBox.Show("Sikeresen hozzáadtad a Pizzát a listához!");
                }
                else
                {
                    if ((String.IsNullOrWhiteSpace(UjPizzanevtxt.Text)) && (!String.IsNullOrWhiteSpace(UjFeltettxt.Text)) //meglevo pizza+uj feltet+nemures ár
                     && (!String.IsNullOrWhiteSpace(UjArtxt.Text)))
                    {

                        Pizzeria pizzeria = (Pizzeria)PizzeriakujPizzahozCombo.SelectedItem;
                        PizzaList pizza = (PizzaList)PizzaCombo.SelectedItem;
                        PizzaList ujpizza = new PizzaList();
                        ujpizza.pizzaName = pizza.pizzaName;
                        ujpizza.pizzeriaFK = pizzeria.pizzeriaID;
                        ujpizza.description = UjFeltettxt.Text;
                        ujpizza.price = int.Parse(UjArtxt.Text);

                        context.PizzaLists.Add(ujpizza);
                        context.SaveChanges();
                        PizzaListazas();
                        TorolniPizzaListazas();
                        MessageBox.Show("Sikeresen hozzáadtad a Pizzát a listához!");
                    }
                    else
                    {
                        if ((!String.IsNullOrWhiteSpace(UjPizzanevtxt.Text)) && (String.IsNullOrWhiteSpace(UjFeltettxt.Text)) //új pizzanev+meglevo feltet+ nemures ár
                              && (!String.IsNullOrWhiteSpace(UjArtxt.Text)))
                        {
                            Pizzeria pizzeria = (Pizzeria)PizzeriakujPizzahozCombo.SelectedItem;
                            PizzaList desc = (PizzaList)FeltetekCombo.SelectedItem;
                            PizzaList ujpizza = new PizzaList();
                            ujpizza.pizzaName = UjPizzanevtxt.Text;
                            ujpizza.pizzeriaFK = pizzeria.pizzeriaID;
                            ujpizza.description = desc.description;
                            ujpizza.price = int.Parse(UjArtxt.Text);
                            context.PizzaLists.Add(ujpizza);
                            context.SaveChanges();
                            PizzaListazas();
                            TorolniPizzaListazas();
                            MessageBox.Show("Sikeresen hozzáadtad a Pizzát a listához!");
                        }
                        else
                        {
                            if ((String.IsNullOrWhiteSpace(UjPizzanevtxt.Text)) && (String.IsNullOrWhiteSpace(UjFeltettxt.Text)) //meglevo pizzanev+meglevo feltet+ nemures ár
                              && (!String.IsNullOrWhiteSpace(UjArtxt.Text)))
                            {
                                Pizzeria pizzeria = (Pizzeria)PizzeriakujPizzahozCombo.SelectedItem;
                                PizzaList pizza = (PizzaList)PizzaCombo.SelectedItem;
                                PizzaList desc = (PizzaList)FeltetekCombo.SelectedItem;
                                PizzaList ujpizza = new PizzaList();
                                ujpizza.pizzaName = pizza.pizzaName;
                                ujpizza.pizzeriaFK = pizzeria.pizzeriaID;
                                ujpizza.description = desc.description;
                                ujpizza.price = int.Parse(UjArtxt.Text);
                                context.PizzaLists.Add(ujpizza);
                                context.SaveChanges();
                                PizzaListazas();
                                TorolniPizzaListazas();
                                MessageBox.Show("Sikeresen hozzáadtad a Pizzát a listához!");
                            }
                        }
                    }
                }
            }
        }
       
        private void PizzaTorlesBtn_Click(object sender, EventArgs e)
        {
            var torlendo = (PizzaList)TorolniPizzalistbox.SelectedItem;
            context.PizzaLists.Remove(torlendo);
            context.SaveChanges();
            TorolniPizzaListazas();
            PizzaListazas();
            MessageBox.Show("Sikeresen törölted a pizzériát a listáról!");
        }
        private void PizzeriaTorlesBtn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(PizzeriaTorlesBtn, "A kijelölt pizzéria törlése");
        }

        private void PizzaTorlesBtn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(PizzaTorlesBtn, "A kijelölt pizza törlése");
        }

        private void StartPageBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var kezdolap = new KezdolapForm();
            kezdolap.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PizzeriaFelvetelBtn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(PizzeriaFelvetelBtn, "Új Pizzéria felvétele");
        }

        private void UjPizzaFelveszBtn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(UjPizzaFelveszBtn, "Új Pizza felvétele");
        }

        private void UjrendelesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var rendeles = new PizzeriasForm();
            rendeles.Show();
        }

        private void UjPizzanevtxt_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[A-Za-zÁÉÍÓÖŐÚÜŰáéíóöőúüű\\s]{1,20}$");
            if (!regex.IsMatch(UjPizzanevtxt.Text))
            {
                MessageBox.Show("Helytelen Pizzanév formátum! Helyes formátum: A-Z-ig, kis és nagybetűk, max 20 karakter!");
            }
        }

        private void UjArtxt_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[1-4][0-9]{3}|5000$");
            if (!regex.IsMatch(UjArtxt.Text))
                MessageBox.Show("Helytelen Ár formátum! Helyes formátum: [1000-5000] 4 számjegyű szám!");
        }

        private void UjFeltettxt_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[A-Za-zÁÉÍÓÖŐÚÜŰáéíóöőúüű,\\s]{1,200}$");
            if (!regex.IsMatch(UjFeltettxt.Text))
            {
                MessageBox.Show("Helytelen Pizzanév formátum! Helyes formátum: A-Z-ig, kis és nagybetűk, max 20 karakter!");
            }
        }
    }
}
