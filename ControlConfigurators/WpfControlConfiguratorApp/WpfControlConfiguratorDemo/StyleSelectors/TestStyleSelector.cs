namespace WpfControlConfiguratorDemo.StyleSelectors {
    using System;
    using System.Windows;
    using System.Windows.Controls;

    public class TestStyleSelector : StyleSelector {

        public TestStyleSelector() {
        }

        public override Style SelectStyle(Object item, DependencyObject container) {
            return base.SelectStyle(item, container);
        }

    }
}
