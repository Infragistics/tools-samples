namespace WpfControlConfiguratorDemo.View {
    using System.Collections.Generic;
    using WpfControlConfiguratorDemo.Model;
    using WpfControlConfiguratorDemo.Services;

    public class PieChartViewModel {

        public IList<PieChartItem> PieChartItems { get; }

        public PieChartViewModel() {
            var dataService = new DataService();
            this.PieChartItems = dataService.PieChartItems;
        }

    }
}
