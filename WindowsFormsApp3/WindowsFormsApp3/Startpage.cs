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
    public partial class KezdolapForm : Form
    {
        public KezdolapForm()
        {
            InitializeComponent();
        }

        private void Rendeles_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f2 = new PizzeriasForm();
            f2.Show();
        }

        private void Rendeleseim_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f3 = new RendelesekForm();
            f3.Show();
        }

        private void Kilepbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RendeleseimBtn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(RendeleseimBtn, "Eddigi rendeléseim megtekintése");
        }

        private void PizzarendeleseBtn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(PizzarendeleseBtn, "Ha pizzát szeretnél rendelni, kattints ide");
        }

        private void AdminBtn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(TablaHistoryBtn, "Táblák historyai");
        }

        private void TablaHistoryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminform = new Admin();
            adminform.Show();
        }

        private void KilepBtn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(KilepBtn, "Kilépés a programból");
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var modify = new Modify();
            modify.Show();
        }

        private void ModifyBtn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(ModifyBtn, "Pizzéria és Pizza táblák módosítása");
        }

        
    }
}
