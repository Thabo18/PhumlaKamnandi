using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business_Entities
{
    class Room
    {
        #region Data Members
        private int roomNo;
        private decimal rate;
        private decimal fridgeBill;
        private decimal tvBill;
        private decimal phoneBill;
        private decimal barBill;
        private decimal fullBill;
        #endregion

        #region Constructor
        public Room(int room, decimal frBill, decimal tvB, decimal phoneB, decimal barB)

        {
            roomNo = room;
            fridgeBill = frBill;
            tvBill = tvB;
            phoneBill = phoneB;
            barBill = barB;
        }

        public Room()
        {
            roomNo = 1;
            fridgeBill = 0;
            tvBill = 0;
            phoneBill = 0;
            barBill = 0;
        }
        #endregion

        #region Property Methods
        public int RoomNo
        {
            get { return roomNo; }
            set { roomNo = value; }
        }

        public decimal FridgeBill
        {
            get { return fridgeBill; }
            set { fridgeBill = value; }
        }

        public decimal TVBill
        {
            get { return tvBill; }
            set { tvBill = value; }
        }

        public decimal PhoneBill
        {
            get { return phoneBill; }
            set { phoneBill = value; }
        }

        public decimal BarBill
        {
            get { return barBill; }
            set { barBill = value; }
        }

        public decimal Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public decimal FullBill
        {
            get { return fullBill; }
            set { fullBill = value; }
        }
        #endregion

        #region Utility Methods

        #endregion
    }
}
