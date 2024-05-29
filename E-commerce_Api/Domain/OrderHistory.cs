using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class OrderHistory
    {
        public string? OrderId { get; set; }
        public string? UserId { get; set; }
        public string? ProductId { get; set; }   
        public DateTime OrderDate { get; set; }
        public User? UserModel { get; set; }
        public ICollection<Product>? Products { get; set; }

    }
}
