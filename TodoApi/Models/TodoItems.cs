using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    
        public class TodoItem
        {
            public long Id { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public string Category { get; set; }
            public string Year_of_publication { get; set; }
            public string Number_of_pages { get; set; }
        }
    
}
