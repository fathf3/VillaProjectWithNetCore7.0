using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Dto.Dtos.Question
{
    public class ResultQuestionDto
    {
        public ObjectId Id { get; set; }   
        public string Title { get; set; }
        public string Answer { get; set; }
    }
}
