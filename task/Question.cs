using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Question
    {
        public int Id { get; set; }
        public string question { get; set; }
        public string[] answers { get; set; }
        public string CorrectAnswer { get; set; }
    }
}

