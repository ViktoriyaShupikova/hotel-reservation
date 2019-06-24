using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezerwacjaHoteli
{
	/// <summary>
    /// Klasa reprezentująca Pokoj UserControl 
    /// </summary>
  public partial class PokojUC : UserControl
  {
    public string TypProp { get; set; }
    public float CenaProp { get; set; }
    public int IloscMiejscProp { get; set; }
    public string ID { get; set; }

    public PokojUC()
    {
      InitializeComponent();
    }

    /// <summary>
    ///  Prezentacja pół na formatce
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PokojUC_Load(object sender, EventArgs e)
    {
      ODdateTimePicker.CustomFormat = "yyyy-MM-dd";
      ODdateTimePicker.Format = DateTimePickerFormat.Custom;
      DOdateTimePicker.CustomFormat = "yyyy-MM-dd";
      DOdateTimePicker.Format = DateTimePickerFormat.Custom;
      panel1.Hide();

      typ_label.Text = TypProp;
      Cena_label.Text = CenaProp.ToString();
      Ilosc_miejsc_label.Text = IloscMiejscProp.ToString();
    }

    /// <summary>
    /// Rezerwacja 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Zarezerwuj_but_Click(object sender, EventArgs e)
    {
      panel1.Show();
    }


    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Obsługa komunikatów walidacyjnych
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void zarezerwuj2_Click(object sender, EventArgs e)
    {
      if (Imie_txtb.Text == "" || Nazwisko_txtb.Text == "" || Nrpaszp_txtb.Text == "" ||
          Nrtelefonu_txtb.Text == "")
      {
        MessageBox.Show("Prosze wpisać danę osobowe!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      else
      {
        if (DOdateTimePicker.Text == "" || ODdateTimePicker.Text == "")
        {
          MessageBox.Show("Prosze wpisac datę.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
        {
          var odpowiedz = DataManager.Book(Imie_txtb.Text, Nazwisko_txtb.Text, Nrpaszp_txtb.Text, Nrtelefonu_txtb.Text, ODdateTimePicker.Text, DOdateTimePicker.Text, ID);
          
          if(odpowiedz)
            MessageBox.Show("Rezerwacja dokonana", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
    }
  }
}
