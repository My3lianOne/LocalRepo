using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHW2
{
    class Order
    {
        private int orderId;
        private string Name;
    }

    class OrderRepository : Order
    {
        public virtual Order Load(int orderId) { return null;  }
        public virtual void Save(Order order) { }
        public virtual void Update(Order order) { }
        public virtual void Delete(Order order) { }
    }

    class OrderRepositoryAPI : OrderRepository
    {
        public override Order Load(int orderId) { return null; }
        public override void Save(Order order) { }
        public override void Update(Order order) { }
        public override void Delete(Order order) { }
    }

}
