using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//new namespaces to allow use of databases
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
//Allows for the use of settings
using PhumlaKamnandi.Properties;

namespace PhumlaKamnandi.Data
{
    class Database
    {
        #region Variables
        private string strConnection = Settings.Default.HotelDBConnectionString;
        protected SqlConnection cnHotel;
        protected DataSet dsHotel;
        protected SqlDataAdapter daHotel;
        #endregion

        #region Constructor
        public Database()
        {
            try
            {
                //Open a connection & create a new dataset object
                cnHotel = new SqlConnection(strConnection);
                dsHotel = new DataSet();
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return;
            }
        }

        #endregion

        #region Update the DataSet
        public void FillDataSet(string aSQLstring, string aTable)
        {
            //fills dataset fresh from the db for a specific table and with a specific Query
            try
            {
                daHotel = new SqlDataAdapter(aSQLstring, cnHotel);
                cnHotel.Open();
                daHotel.Fill(dsHotel, aTable);
                cnHotel.Close();
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
            }
        }

        #endregion

        #region Update the data source 
        protected bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success;
            try
            {
                //open the connection
                cnHotel.Open();
                //***update the database table via the data adapter
                daHotel.Update(dsHotel, table);
                //---close the connection
                cnHotel.Close();
                //refresh the dataset
                FillDataSet(sqlLocal, table);
                success = true;
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                success = false;
            }
            finally
            {
            }
            return success;
        }
        #endregion
    }
}
