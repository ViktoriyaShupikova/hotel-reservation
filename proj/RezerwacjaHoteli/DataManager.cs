using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezerwacjaHoteli
{
  /// <summary>
  /// Klasa statycza zawierająca wszystkie metody dostępu do danych
  /// </summary>
  public static class DataManager
  {
    private const string CONN_STR = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Viktoriya.Shupikova\\Desktop\\Wsiz\\projekt\\vika_proj\\proj\\RezerwacjaHoteli\\HotelDatabase.mdf;Integrated Security=True;Connect Timeout=30";

    /// <summary>
    /// Metoda wyszukująca pokoje według kryteriów
    /// </summary>
    /// <param name="iloscMiejsc">Dla ilu osób poszukiwany jest pokój</param>
    /// <param name="odData">Data od której pokój jest dostępny</param>
    /// <param name="doData">Data do której pokój jest dostępny</param>
    /// <param name="typ">Typ pokoju</param>
    /// <param name="tryb">True - poszukiwanie pokoju na kilka dni, false - na jeden dzień</param>
    /// <returns>DataTable zawierający wynik wyszukiwania</returns>
    public static DataTable FindRooms(int iloscMiejsc, string odData, string doData, string typ, bool tryb)
    {
      SqlConnection connectionSearch = new SqlConnection(CONN_STR);
      connectionSearch.Open();
      DataTable dt = new DataTable();
      SqlCommand commandSql;

      if (tryb == true)
      {
        commandSql = new SqlCommand(@"select Pokoje.Typ, Pokoje.Ilosc_miejsc, Pokoje.Cena, Pokoje.Id_pokoju
                                              from Pokoje Left Outer Join Rezerwacja
                                              on Id_pokoju = id_pokoju_
                                              where Ilosc_miejsc=" + iloscMiejsc + "and  (Rezerwacja.Od is null and Rezerwacja.Do is null)" +
                                     " or ('" + odData + "' < Rezerwacja.Od and '" + odData + "'> Rezerwacja.Do)" +
                                      "and (Pokoje.Wolne='Tak' and  Typ='" + typ + "')", connectionSearch);
      }

      else
      {
        commandSql = new SqlCommand(@"select Pokoje.Typ, Pokoje.Ilosc_miejsc, Pokoje.Cena, Pokoje.Id_pokoju
                                              from Pokoje Left Outer Join Rezerwacja
                                              on Id_pokoju = id_pokoju_
                                                where  Ilosc_miejsc=" + iloscMiejsc + "and ((Rezerwacja.Od is null and Rezerwacja.Do is null)" +
                                       " or ('" + odData + "'<Rezerwacja.Od and '" + odData + "' > Rezerwacja.Do and '" + doData + "'" +
                                       "< Rezerwacja.Od and'" + doData + "'> Rezerwacja.Do))" +
                                       "and (Pokoje.Wolne='Tak' and Typ='" + typ + "')", connectionSearch);
      }

      SqlDataReader dr = commandSql.ExecuteReader();
      dt.Load(dr);
      connectionSearch.Close();

      return dt;
    }

    /// <summary>
    /// Metoda służąca do rezerwacji pokoju
    /// </summary>
    /// <param name="imie">Imię klienta</param>
    /// <param name="nazwisko">Nazwisko klienta</param>
    /// <param name="nrPaszportu">Nr paszportu klienta</param>
    /// <param name="nrTel">Nr telefonu klienta</param>
    /// <param name="odData">Data początku rezerwacji</param>
    /// <param name="doData">Data końca rezerwacji</param>
    /// <param name="id">Id pokoju</param>
    /// <returns>True - rezerwacja dokonana pomyślnie, False - błąd rezerwacji</returns>
    public static bool Book(string imie, string nazwisko, string nrPaszportu, string nrTel, string odData, string doData, string id)
    {
      try
      {
        SqlConnection connectionReserved = new SqlConnection(CONN_STR);
        connectionReserved.Open();

        var query = $@"INSERT INTO Rezerwacja (Imie, Nazwisko, Numer_paszportu, Numer_telefonu, Od, Do, id_pokoju_)
                        VALUES ('{imie}', '{nazwisko}', '{nrPaszportu}', '{nrTel}', '{odData}', '{odData}', {id});";
        SqlCommand cmd =
            new SqlCommand(query, connectionReserved);

        SqlDataReader dr = cmd.ExecuteReader();
        connectionReserved.Close();
        connectionReserved.Open();
        SqlCommand cdc = new SqlCommand(@"Update Pokoje set Wolne = 'Nie' where id_pokoju = " + id,
            connectionReserved);

        SqlDataReader dr2 = cdc.ExecuteReader();
        connectionReserved.Close();

        return true;
      }
      catch (Exception)
      {
        return false;
      }
    }

    /// <summary>
    /// Metoda usuwająca wszystkie rezeracji według parametrów użytkownika
    /// </summary>
    /// <param name="name">Imię użytkownika</param>
    /// <param name="surname">Nazwisko użytkownika</param>
    /// <param name="nrPaszportu">Nr paszportu użytkownika</param>
    public static void RemoveAllReservations(string name, string surname, string nrPaszportu)
    {
      SqlConnection connectionReserved = new SqlConnection(CONN_STR);
      connectionReserved.Open();

      var query = $@"delete from Rezerwacja where Imie = '{name}'";
      SqlCommand cmd =
          new SqlCommand(query, connectionReserved);

      SqlDataReader dr = cmd.ExecuteReader();
      connectionReserved.Close();
      connectionReserved.Open();
      SqlCommand cdc = new SqlCommand(@"Update Pokoje set Wolne = 'Tak'",
          connectionReserved);

      SqlDataReader dr2 = cdc.ExecuteReader();
      connectionReserved.Close();
    }
  }
}
