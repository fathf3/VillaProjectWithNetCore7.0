using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Dto.Dtos.Contact
{
    public class ResultContactDto
    {
        public ObjectId Id { get; set; }
        public string MapUrl { get; set; }
        public string Phone { get; set; }
        public string? Address { get; set; }
        public string Email { get; set; }
    }
}
