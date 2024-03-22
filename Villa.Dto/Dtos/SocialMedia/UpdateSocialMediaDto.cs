﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Dto.Dtos.SocialMedia
{
    public class UpdateSocialMediaDto
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string IconLink { get; set; }
    }
}
