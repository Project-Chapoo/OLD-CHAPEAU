﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModels
{
    public class Bill
    {
        public int EmployeeID { get; set; }
        public int ReservationID { get; set; }
        public int TableID { get; set; }
        public string Commentary { get; set; }
        public DateTime DateAndTime { get; set; }
        public List<BillItem> billItems { get; set; }

        public Bill(int tableID, List<BillItem> billItems)
        {
            TableID = tableID;
            DateAndTime = DateTime.Now;
            this.billItems = billItems;
        }
    }
    
    
}
