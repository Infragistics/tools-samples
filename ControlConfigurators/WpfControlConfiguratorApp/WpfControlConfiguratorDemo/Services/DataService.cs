namespace WpfControlConfiguratorDemo.Services {
    using System;
    using System.Collections.Generic;
    using WpfControlConfiguratorDemo.Model;

    public class DataService {

        readonly DataGridSampleData _dataGridSampleData = new DataGridSampleData();

        readonly String[] names = {
            "John",
            "Kim",
            "Sandy",
            "Mark",
            "Josh",
            "Jim",
            "Sam",
            "Mary",
            "Harry",
            "Sue",
            "Chris",
            "Joe",
            "Carl"
        };

        public IList<IList<DataItem>> CollectionDataItems => CreateCollectionDataItems();

        public CustomDataModel CustomDataModel => CreateCustomDataModel();

        public IList<DataItem> DataItems => CreateDataItems();

        public IList<IDictionary<String, Object>> DictionaryItems => CreateDictionaryItems();

        public IList<HierarchicalDataItem> HierarchicalDataItems => CreateHierarchicalDataItems();

        public IList<Order> Orders => CreateOrders();

        public IList<PieChartItem> PieChartItems => CreatePieChartItems();

        public DataService() {
        }

        IList<IList<DataItem>> CreateCollectionDataItems() {
            var list = new List<IList<DataItem>>();
            list.Add(CreateDataItems());
            list.Add(CreateDataItems(25, 75));
            list.Add(CreateDataItems(15, 100));
            return list;
        }

        CustomDataModel CreateCustomDataModel() {
            var customDataModel = new CustomDataModel();
            foreach (var dataItem in CreateDataItems()) {
                customDataModel.Add(dataItem);
            }
            return customDataModel;
        }

        IList<DataItem> CreateDataItems(Int32 min = 0, Int32 max = 50, Boolean reverse = false) {
            var list = new List<DataItem>();
            var r = new Random();
            var dateValue = DateTime.Today.AddDays(-20);
            for (var i = 0; i < 13; i++) {
                var name = names[i];
                if (reverse) {
                    name = Reverse(name);
                }
                list.Add(new DataItem(name, r.Next(min, max), r.Next(min + 75, max + 100), dateValue));
                dateValue = dateValue.AddDays(1);
            }
            return list;
        }

        IList<IDictionary<String, Object>> CreateDictionaryItems() {
            var list = new List<IDictionary<String, Object>>();
            var sortKey = 0;
            var r = new Random();
            for (var i = 0; i < 10; i++) {
                var dict = new Dictionary<String, Object>();
                dict.Add("SortKey", sortKey);
                sortKey += 1;
                for (var j = 0; j < 5; j++) {
                    dict.Add(names[j], r.Next(0, 1000));
                }
                list.Add(dict);
            }

            return list;
        }

        IList<HierarchicalDataItem> CreateHierarchicalDataItems() {
            var list = new List<HierarchicalDataItem>();
            var r = new Random();
            for (var i = 0; i <= 3; i++) {
                var children = new List<DataItem>();
                var dateValue = DateTime.Today.AddDays(-20);
                for (var j = 0; j <= 3; j++) {
                    children.Add(new DataItem(names[i], r.Next(-100, 0), r.Next(-50, 50), dateValue));
                    dateValue = dateValue.AddDays(1);
                }

                list.Add(new HierarchicalDataItem(names[i], r.Next(0, 50), r.Next(75, 150), children));
            }
            return list;
        }

        IList<Order> CreateOrders() {
            return _dataGridSampleData.Orders;
        }

        IList<PieChartItem> CreatePieChartItems() {
            var list = new List<PieChartItem>();
            var r = new Random();
            for (int i = 0; i < 5; i++) {
                list.Add(new PieChartItem(r.Next(0, 75), $"Day {i}", $"Long Day {i}"));
            }
            return list;
        }

        String Reverse(String s) {
            var charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new String(charArray);
        }

    }
}
