namespace WpfControlConfiguratorDemo.View {
    using System;
    using System.Collections.Generic;
    using WpfControlConfiguratorDemo.Model;
    using WpfControlConfiguratorDemo.Services;

    public class CategoryChartViewModel {

        public CustomDataModel CustomDataModel { get; set; }

        public IList<DataItem> ListOfDataItems { get; set; }

        public IList<IDictionary<String, Object>> ListOfDictionaryDataItems { get; set; }

        public IList<HierarchicalDataItem> ListOfHierarchicalDataItems { get; set; }

        public CategoryChartViewModel() {
            var dataService = new DataService();
            this.CustomDataModel = dataService.CustomDataModel;
            this.ListOfDataItems = dataService.DataItems;
            this.ListOfDictionaryDataItems = dataService.DictionaryItems;
            this.ListOfHierarchicalDataItems = dataService.HierarchicalDataItems;
        }

    }
}
