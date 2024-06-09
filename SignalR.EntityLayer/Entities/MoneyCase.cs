using SignalR.Core.Concretes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SignalR.EntityLayer.Entities
{
    public class MoneyCase : Entity<int>
    {
        public decimal TotalAmount { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
    }
}
