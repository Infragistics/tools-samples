namespace WpfControlConfiguratorDemo.Model {
    using System;

    public class PieChartItem {

        public Double Value { get; }

        public String Text { get; }

        public String LegendText { get; }
        
        public PieChartItem(Double value, String text, String legendText = "") {
            if (String.IsNullOrWhiteSpace(text)) {
                throw new ArgumentException("Value cannot be null or white space.", nameof(text));
            }
            this.Value = value;
            this.Text = text;
            this.LegendText = legendText;
        }

    }
}
