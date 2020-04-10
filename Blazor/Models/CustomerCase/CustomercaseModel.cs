using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Models.CustomerCase
{
    public class CustomercaseModel
    {
        public int Id { get; set; }
        public int customerId { get; set; }
        public int userId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public string Status { get; set; }
    }
}
