using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmail.Models
{
    public class EmailModel
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime SentAt { get; set; }
        public string Attachements {  get; set; }
        public string EmailID { get; set; }
         public DateTime createdon { get; set; }

    }
}
