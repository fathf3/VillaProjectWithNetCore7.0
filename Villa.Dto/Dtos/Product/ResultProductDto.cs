﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Dto.Dtos.Product
{
    public class ResultProductDto
    {
        public ObjectId Id { get; set; }

        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public int BedRoomCount { get; set; }
        public int BathRoomCount { get; set; }
        public int Area { get; set; }
        public int Floor { get; set; }
        public int ParkingCount { get; set; }
    }
}
