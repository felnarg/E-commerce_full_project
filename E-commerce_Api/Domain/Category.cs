using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Category
    {
        public string? CategoryId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string? ImageUrl { get; set; } 
        public ICollection<Product>? Products { get; set; }
    }
}
