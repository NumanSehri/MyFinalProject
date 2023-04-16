using Core.Entities;
using Newtonsoft.Json;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        [JsonIgnore]
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short  UnitsInStock{ get; set; }
        public decimal UnitPrice { get; set; }

    }
}
