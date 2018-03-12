using System;
using System.Windows.Forms;
using System.Drawing;

namespace Aufgabe1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTschuess_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRot_Click(object sender, EventArgs e)
        {
            lblGutenTag.ForeColor = Color.Red;   // ForeColor = Foreground Color = Farbe des Vordergrunds
        }

        private void btnGross_Click(object sender, EventArgs e)
        {
            lblGutenTag.Font = new Font(lblGutenTag.Font.Name,20);
            // Font-Objekte können nicht verändert werden - daher muss ein neues Objekt kreiert werden: 
            // Bestehenden Font verwenden und auf Grösse 20em setzen
        }

        private void btnZurueck_Click(object sender, EventArgs e)
        {
            lblGutenTag.ForeColor = Color.Empty;   // Empty = keine Angabe = Standardfarbe
            lblGutenTag.Font = new Font(lblGutenTag.Font.Name, 8);
        }
    }
}
