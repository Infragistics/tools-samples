namespace WpfControlConfiguratorDemo.Model {
    using System;
    using System.Collections.Generic;

    public class OrderDetail {

        public IList<Feature> Features { get; set; }

        public String Name { get; set; }

        public Int32 OrderDetailId { get; set; }

        public Int32 OrderId { get; set; }

        public Double Price { get; set; }

        public OrderDetail() {
            this.Features = new List<Feature>();
        }

    }
}
