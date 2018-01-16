namespace WpfControlConfiguratorDemo {
    using System;
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Controls;

    public partial class Shell : Window {

        public Shell() {
            InitializeComponent();
        }

        void Shell_OnLoaded(Object sender, RoutedEventArgs e) {
            var list = new List<ViewItem>();
            list.Add(new ViewItem("WpfControlConfiguratorDemo.View.BulletGraphView", "Bullet Graph"));
            list.Add(new ViewItem("WpfControlConfiguratorDemo.View.CategoryChartView", "Category Chart"));
            list.Add(new ViewItem("WpfControlConfiguratorDemo.View.DataGridNestedLayoutView", "Data Grid Nested Layout"));
            list.Add(new ViewItem("WpfControlConfiguratorDemo.View.DataGridManualLayoutView", "Data Grid Manual Layout"));
            list.Add(new ViewItem("WpfControlConfiguratorDemo.View.DataGridLayoutGroupView", "Data Grid Layout Group"));
            list.Add(new ViewItem("WpfControlConfiguratorDemo.View.LinearGaugeView", "Linear Gauge"));
            list.Add(new ViewItem("WpfControlConfiguratorDemo.View.PieChartView", "Pie Chart"));
            list.Add(new ViewItem("WpfControlConfiguratorDemo.View.RadialGaugeView", "Radial Gauge"));
            viewsList.ItemsSource = list;
            viewsList.SelectedIndex = 0;
        }

        void ViewsList_OnSelectionChanged(object sender, SelectionChangedEventArgs e) {
            targetRegion.Content = null;
            if (viewsList.SelectedItem != null) {
                targetRegion.Content = Activator.CreateInstance("WpfControlConfiguratorDemo", viewsList.SelectedValue.ToString()).Unwrap();
            }
        }

    }

    internal class ViewItem {

        public String FullTypeName { get; }

        public String TextName { get; }

        public ViewItem(String fullTypeName, String textName) {
            this.FullTypeName = fullTypeName;
            this.TextName = textName;
        }

    }
}
