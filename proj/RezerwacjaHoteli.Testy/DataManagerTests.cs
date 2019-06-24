using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RezerwacjaHoteli.Testy
{
  [TestClass]
  public class DataManagerTests
  {
    [TestMethod]
    public void FindRoomsReturnDataTable()
    {
      var response = DataManager.FindRooms(1, "2019-06-19", "2019-06-19", "3 gwiazdy", true);

      Assert.IsInstanceOfType(response, typeof(DataTable));
    }

    [TestMethod]
    public void BookTheSameRoomInSameTimeFails()
    {
      var responseforFirstBooking = DataManager.Book("Name", "Surname", "Test", "00000", "2019-06-19", "2019-06-19", "1");
      var responseforSecondBooking = DataManager.Book("Name", "Surname", "Test", "00000", "2019-06-19", "2019-06-19", "1");
      DataManager.RemoveAllReservations("Name", string.Empty, string.Empty);
      Assert.IsTrue(responseforFirstBooking);
      Assert.IsFalse(!responseforSecondBooking);
    }

    [TestMethod]
    public void BookReturnsBool()
    {
      var response = DataManager.Book("Name", "Surname", "Test", "00000", "2019-06-19", "2019-06-19", "1");
      DataManager.RemoveAllReservations("Name", string.Empty, string.Empty);
      Assert.IsInstanceOfType(response, typeof(bool));
    }

    [TestMethod]
    public void BookReturnFalseWhenDataWrong()
    { 
      var response = DataManager.Book("Name", "Surname", "Test", "fff", "2019-06-19", "2019-06-19", "1");
      DataManager.RemoveAllReservations("Name", string.Empty, string.Empty);
      Assert.IsFalse(response);
    }

    [TestMethod]
    public void BookReturnTrueWhenDataCorrect()
    {
      var response = DataManager.Book("Name", "Surname", "Test", "00000", "2019-06-19", "2019-06-19", "1");
      DataManager.RemoveAllReservations("Name", string.Empty, string.Empty);
      Assert.IsTrue(response);
    }
  }
}
