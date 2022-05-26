﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl.DTO
{
    public class Train_View
    {
        public int TrainID { get; set; }
        public string TrainName { get; set; }
        public string NumberOfCarriages { get; set; }
        public string DriverUN { get; set; }
        public int ScheduleID { get; set; }
        public decimal BasicPrice { get; set; }
        public string State { get; set; }
    }
} 
