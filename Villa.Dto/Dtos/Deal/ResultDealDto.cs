﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Dto.Dtos.Deal
{
    public class ResultDealDto
    {
        public ObjectId Id { get; set; }
        public string HouseType { get; set; }
        public string Title { get; set; }
        public string Square { get; set; }
        public string Floor { get; set; }
        public int RoomCount { get; set; }
        public bool HasParkingArea { get; set; }
        public string PaymentType { get; set; }

    }
}
