using System;
using System.Collections.Generic;
//namespaces that allwos for use of collections 
using System.Collections.ObjectModel;
//namespaces that allows for use of SQL
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//namespace used to access the entity classes 
using PhumlaKamnandi.Business_Entities;

namespace PhumlaKamnandi.Data
{
    class HotelDB: Database 
    {
        #region Data members
        private string table1 = "Guest";
        private string sqlLocal1 = "SELECT * FROM Guest";
        private string table2 = "Reservation";
        private string sqlLocal2 = "SELECT * FROM Reservation";
        private string table3 = "Room";
        private string sqlLocal3 = "SELECT * FROM Room";
        private string table4 = "Dependant";
        private string sqlLocal4 = "SELECT * FROM Dependant";
       
        //collection to store single guests details 
        private Collection<Guest> guests;

        //collection to store each reservation details ??

        //collection for dependant ??

        //collection for room??
        #endregion

        #region Property Method: Collection
        public Collection<Guest> AllGuests
        {
            get
            {
                return guests;
            }
        }
        #endregion

        #region Constructor
        public HotelDB() : base()
        {
            guests = new Collection<Guest>();
            FillDataSet(sqlLocal1, table1);
           // Add2Collection(table1);
            FillDataSet(sqlLocal2, table2);
           // Add2Collection(table2);
            FillDataSet(sqlLocal3, table3);
           // Add2Collection(table3);
            FillDataSet(sqlLocal4, table4);
          //  Add2Collection(table4);
        }
        #endregion

        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dsHotel;
        }
    /*    private void Add2GuestCollection(string table)
          {
              //Declare references to a row object and guest collection 
              DataRow myRow = null;
              Guest guest;

              //READ from the table  
              foreach (DataRow myRow_loopVariable in dsHotel.Tables[table].Rows)
              {
                  myRow = myRow_loopVariable;
                  if (!(myRow.RowState == DataRowState.Deleted))
                  {
                      //Instantiate a new Guest object
                      guest = new Guest();

                      //Obtain each guest attribute from the specific field in the row in the guest table

                      guest.ID = Convert.ToString(myRow["GuestID"]).TrimEnd();
                      guest.Name = Convert.ToString(myRow["GuestName"].TrimEnd();
                      guest.Surname = Convert.ToString(myRow["GuestSurname"].TrimEnd();
                      guest.Address = Convert.ToString(myRow["Address"].TrimEnd();
                      guest.Phone = Convert.ToString(myRow["Phone"].TrimEnd();
                      guest.BookingDate = Convert.ToString(myRow["BookingDate"].TrimEnd();
                      guest.ConfirmedStatus = Convert.ToString(myRow["ConfirmedStatus"].TrimEnd();
                      guest.NoOfDependants= Convert.ToString(myRow["NoOfDependants"].TrimEnd();
                      //Do the same for all other attributes
        
                      guests.Add(guest);
                  }
              }
          }
          private void FillRow(DataRow aRow, Guest guest)
          {
         
              aRow["GuestID"] = guest.GuestID;  //NOTE square brackets to indicate index of collections of fields in row.
              aRow["GuestName"] = guest.GuestName;
              aRow["GuestSurname"] = guest.GuestSurname;
              aRow["Address"] = guest.Address;
              aRow["Phone"] = guest.Phone;
              aRow["BookingDate"] = guest.BookingDate;
              aRow["ConfirmedStatus"] = guest.ConfirmedStatus;
              aRow["NoOfDependants"] = guest.NoOfDependants;
             
          }  */

        #endregion

    }
}
