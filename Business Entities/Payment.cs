using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business_Entities
{
    class Payment
    {
        #region Data Members
        private string guestID;
        private decimal amountPaid;
        private decimal amountOwed;
        private decimal fullPayment;
        private MethodOfPayemnt methodOfPayment;

        public enum MethodOfPayemnt
        {
            card = 0,
            deposit = 1,
            debtor = 2
        }
        #endregion

        #region Property Methods
        public String GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }
        public decimal AmountPaid
        {
            get { return amountPaid; }
            set { amountPaid = value; }
        }

        public decimal AmountOwed
        {
            get { return amountOwed; }
            set { amountOwed = value; }
        }

        public decimal FullPayment
        {
            get { return fullPayment; }
            set { fullPayment = value; }
        }
        #endregion

        #region Constructor
        public Payment()
        {
            guestID = "001";
            amountPaid = 0;
            amountOwed = 0;

        }

        public Payment(String gstID, decimal amntPaid)
        {
            guestID = gstID;
            amountPaid = amntPaid;
            amountOwed = 0;

        }

        #endregion

        #region Utility Methods

        #endregion
    }
}
