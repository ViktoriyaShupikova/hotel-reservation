using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezerwacjaHoteli
{
    /// <summary>
    /// Klasa zawierająca wszystkie metody do zarządzaniem logiką formy Wynik_wyszukiwania
    /// </summary>
  public partial class Wynik_wyszukiwania : Form
  {
    public string DoData { get; set; }
    public string OdData { get; set; }
    public int IloscMiejsc { get; set; }
    public string Typ { get; set; }
    public bool TrybPoszukiwania { get; set; }

    public Wynik_wyszukiwania()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Nawiązuję połączenie z bazą danych pod czas włączenie okna "Wynik poszukiwania" zgodnie a wysłanymi kryterium
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Wynik_wyszukiwania_Load(object sender, EventArgs e)
    {
      this.MaximizeBox = false;   
      this.FormBorderStyle = FormBorderStyle.FixedSingle;

      var dt = DataManager.FindRooms(IloscMiejsc, OdData, DoData, Typ, TrybPoszukiwania);


      if (dt.Rows.Count == 0)
      {
        MessageBox.Show("Nie ma takich pokoje!");
        Close();
      }
      else
      {
        int wysokosc = 221;
        TableLayoutPanel TabLay = new TableLayoutPanel();
        Controls.Add(TabLay);
        TabLay.ColumnCount = 1;
        TabLay.RowCount = dt.Rows.Count;
        TabLay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        TabLay.Location = new System.Drawing.Point(0, 0);
        TabLay.Name = "Tab1";
        PokojUC[] obiekty = new PokojUC[100];


        for (int i = 0; i < dt.Rows.Count; i++)
        {
          TabLay.Size = new System.Drawing.Size(591, wysokosc);
          wysokosc += wysokosc;
          obiekty[i] = new PokojUC();

          obiekty[i].TypProp = dt.Rows[i][0].ToString();
          obiekty[i].CenaProp = float.Parse(dt.Rows[i][2].ToString());
          obiekty[i].IloscMiejscProp = Convert.ToInt32(dt.Rows[i][1]);
          obiekty[i].ID = dt.Rows[i][3].ToString();
          Controls.Add(obiekty[i]);
          TabLay.Controls.Add(obiekty[i], 1, i);
        }

      }
    }

  }


}


