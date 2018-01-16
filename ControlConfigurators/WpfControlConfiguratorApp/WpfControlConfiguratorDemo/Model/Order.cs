namespace WpfControlConfiguratorDemo.Model {
    using System;
    using System.Collections.Generic;

    public class Order {

        public String AccountingCode { get; set; }

        public Customer Customer { get; set; }

        public DateTime DateOrdered { get; set; }

        public Boolean HasBeenApproved { get; set; }

        public IList<OrderDetail> OrderDetails { get; set; }

        public IList<OrderDetail> OrderDetailsTwo { get; set; }

        public Int32 OrderId { get; set; }

        public Int32 OrderStatus { get; set; }

        public String ShipState { get; set; }

        public Double SubTotal { get; set; }

        public String TemplateData { get; set; }

        public Double Total { get; set; }

        public Order() {
            this.OrderDetails = new List<OrderDetail>();
            this.OrderDetailsTwo = new List<OrderDetail>();
        }

    }
}
