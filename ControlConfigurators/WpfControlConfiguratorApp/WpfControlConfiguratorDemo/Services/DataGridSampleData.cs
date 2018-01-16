namespace WpfControlConfiguratorDemo.Services {
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using WpfControlConfiguratorDemo.Model;
    using WpfControlConfiguratorDemo.SampleData;

    public class DataGridSampleData : ObservableObject {

        readonly DataGenerator _dataGenerator = new DataGenerator();

        public IList<Customer> Customers { get; private set; }

        public IList<Order> Orders => CreateOrders();

        public IEnumerable<ComboBoxDataItem> OrderStatusComboBoxDataItems => CreateOrderStatusComboBoxDataItems();

        public IEnumerable<ComboBoxDataItem> SportsComboBoxDataItems => CreateSportsComboBoxDataItems();

        public IEnumerable<String> States => LoadStates();

        public IEnumerable<String> CustomerStatuses => Enum.GetNames(typeof(Status)).ToList().OrderBy(x => x);

        public DataGridSampleData() {
            LoadCustomers();
        }

        IList<Order> CreateOrders() {
            var list = new List<Order>();
            var order = new Order();
            order.Customer = this.Customers[0];
            order.DateOrdered = DateTime.Now;
            order.OrderId = 101;
            order.HasBeenApproved = true;
            order.ShipState = "IN";
            order.OrderStatus = 1;
            order.AccountingCode = "GL1596";
            order.Total = 1245.78;
            order.SubTotal = 1199.01;
            order.TemplateData = "template data value";

            var orderDetail = new OrderDetail();
            orderDetail.Name = "McNuggets";
            orderDetail.OrderDetailId = 1;
            orderDetail.OrderId = order.OrderId;
            orderDetail.Price = .99d;
            orderDetail.Features.Add(new Feature {Id = 10, Name = "Item One"});
            orderDetail.Features.Add(new Feature {Id = 11, Name = "Item Two"});
            order.OrderDetails.Add(orderDetail);

            orderDetail = new OrderDetail();
            orderDetail.Name = "McNuggets Two";
            orderDetail.OrderDetailId = 2;
            orderDetail.OrderId = order.OrderId;
            orderDetail.Price = .99d;
            orderDetail.Features.Add(new Feature {Id = 12, Name = "Item One"});
            orderDetail.Features.Add(new Feature {Id = 13, Name = "Item Two"});
            order.OrderDetailsTwo.Add(orderDetail);

            orderDetail = new OrderDetail();
            orderDetail.Name = "Double Cheese Burger";
            orderDetail.OrderDetailId = 3;
            orderDetail.OrderId = order.OrderId;
            orderDetail.Price = 1.99d;
            orderDetail.Features.Add(new Feature {Id = 14, Name = "Item One"});
            orderDetail.Features.Add(new Feature {Id = 15, Name = "Item Two"});
            order.OrderDetails.Add(orderDetail);

            orderDetail = new OrderDetail();
            orderDetail.Name = "Double Cheese Burger Two";
            orderDetail.OrderDetailId = 4;
            orderDetail.OrderId = order.OrderId;
            orderDetail.Price = 1.99d;
            orderDetail.Features.Add(new Feature {Id = 16, Name = "Item One"});
            orderDetail.Features.Add(new Feature {Id = 17, Name = "Item Two"});
            order.OrderDetailsTwo.Add(orderDetail);

            orderDetail = new OrderDetail();
            orderDetail.Name = "Medium Fries";
            orderDetail.OrderDetailId = 5;
            orderDetail.OrderId = order.OrderId;
            orderDetail.Price = 1.79d;
            orderDetail.Features.Add(new Feature {Id = 18, Name = "Item One"});
            orderDetail.Features.Add(new Feature {Id = 19, Name = "Item Two"});
            order.OrderDetails.Add(orderDetail);

            orderDetail = new OrderDetail();
            orderDetail.Name = "Medium Fries Two";
            orderDetail.OrderDetailId = 6;
            orderDetail.OrderId = order.OrderId;
            orderDetail.Price = 1.79d;
            orderDetail.Features.Add(new Feature {Id = 20, Name = "Item One"});
            orderDetail.Features.Add(new Feature {Id = 21, Name = "Item Two"});
            order.OrderDetailsTwo.Add(orderDetail);

            list.Add(order);
            return list;
        }

        IEnumerable<ComboBoxDataItem> CreateOrderStatusComboBoxDataItems() {
            var list = new List<ComboBoxDataItem>();
            list.Add(new ComboBoxDataItem(0, "( Select )"));
            list.Add(new ComboBoxDataItem(1, "Ordered"));
            list.Add(new ComboBoxDataItem(2, "Verified"));
            list.Add(new ComboBoxDataItem(3, "Fulfilled"));
            list.Add(new ComboBoxDataItem(4, "Cancelled"));
            return list;
        }

        IList<ComboBoxDataItem> CreateSportsComboBoxDataItems() {
            var list = new List<ComboBoxDataItem>();
            list.Add(new ComboBoxDataItem(0, "( Select )"));
            list.Add(new ComboBoxDataItem(1, "Harley Drags"));
            list.Add(new ComboBoxDataItem(2, "Motorcycle Racing"));
            list.Add(new ComboBoxDataItem(3, "Soccer"));
            list.Add(new ComboBoxDataItem(4, "Baseball"));
            return list;
        }

        void LoadCustomers() {
            var list = new List<Customer>();
            var address = new Address {
                City = "Greenfield",
                State = "IN",
                Street = "427 Fallon Drive",
                Zip = "46140"
            };
            var customer = new Customer();
            customer.Address = address;
            customer.FavoriteSport = 1;
            customer.FirstName = "Karl";
            customer.Id = 100;
            customer.LastName = "Shifflett";
            customer.Status = Status.Active;
            list.Add(customer);
            this.Customers = new ObservableCollection<Customer>(list);
        }

        IEnumerable<String> LoadStates() {
            return _dataGenerator.States;
        }

    }
}
