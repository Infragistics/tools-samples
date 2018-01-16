namespace WpfControlConfiguratorDemo.View {
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using WpfControlConfiguratorDemo.Model;
    using WpfControlConfiguratorDemo.Services;

    public class DataGridManualLayoutViewModel {

        public IEnumerable<String> CustomerStatuses { get; }

        public ObservableCollection<Order> Orders { get; }

        public IEnumerable<ComboBoxDataItem> OrderStatusComboBoxDataItems { get; }

        public IEnumerable<ComboBoxDataItem> SportsComboBoxDataItems { get; }

        public IEnumerable<String> States { get; }

        public DataGridManualLayoutViewModel() {
            var dataGridSampleData = new DataGridSampleData();
            this.Orders = new ObservableCollection<Order>(dataGridSampleData.Orders);
            this.OrderStatusComboBoxDataItems = dataGridSampleData.OrderStatusComboBoxDataItems;
            this.States = dataGridSampleData.States;
            this.CustomerStatuses = dataGridSampleData.CustomerStatuses;
            this.SportsComboBoxDataItems = dataGridSampleData.SportsComboBoxDataItems;
        }

    }
}
