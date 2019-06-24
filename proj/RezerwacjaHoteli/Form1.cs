using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezerwacjaHoteli
{
	/// <summary>
  /// Klasa zawierająca wszystkie metody do zarządzaniem logiką formy Wyszukiwarka
  /// </summary>
    public partial class Wyszukiwarka : Form
    {
        public Wyszukiwarka()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Prezentacja pól do wyszukiwania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Wyszukiwarka_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Kilka_radioButton.Checked = true;

            Z_dateTimePicker.CustomFormat = "yyyy-MM-dd";
            Z_dateTimePicker.Format = DateTimePickerFormat.Custom;
            Do_dateTimePicker.CustomFormat = "yyyy-MM-dd";
            Do_dateTimePicker.Format = DateTimePickerFormat.Custom;

        }

        private void Jeden_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Do_dateTimePicker.Hide();
            label2.Hide();
        }

        private void Kilka_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Do_dateTimePicker.Show();
            label2.Show();
        }

        /// <summary>
        /// Obsługa komunikatów walidacyjnych, uruchomienia procesu wyszukiwania według podanych parametrów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void szukaj_but_Click(object sender, EventArgs e)
        {
            if (Typ_cmb.Text == "")
            {
                MessageBox.Show("Proszę wpisać typ!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Miejsca_cmb.Text == "")
                {
                    MessageBox.Show("Proszę wpisać ilość miejsc.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    Wynik_wyszukiwania n = new Wynik_wyszukiwania();
                    n.DoData = Do_dateTimePicker.Text;
                    n.OdData = Z_dateTimePicker.Text;
                    n.Typ = Typ_cmb.Text;
                    n.IloscMiejsc = Convert.ToInt32(Miejsca_cmb.Text);
                    n.TrybPoszukiwania = Jeden_radioButton.Checked;
                    n.Show();
                }
            }
        }
    }
}
