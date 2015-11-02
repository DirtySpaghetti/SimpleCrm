using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrm.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }        

        public DateTime DateCreated { get; set; }
    }
}
