using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalrPractice.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string displayName { get; set; }
        public string age { get; set; }
        public string description { get; set; }
        public DateTime dateTime { get; set; }
    }
}