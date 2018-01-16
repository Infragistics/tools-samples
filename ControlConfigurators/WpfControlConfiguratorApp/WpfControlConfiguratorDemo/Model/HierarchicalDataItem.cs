namespace WpfControlConfiguratorDemo.Model {
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class HierarchicalDataItem : ItemBase, IEnumerable<DataItem> {

        public IList<DataItem> Children { get; }
        public Double FinalValue { get; }
        public Double InitialValue { get; }
        public String Name { get; }

        public HierarchicalDataItem(String name, Double initialValue, Double finalValue, IList<DataItem> children) {
            this.Name = name;
            this.InitialValue = initialValue;
            this.FinalValue = finalValue;
            this.Children = children;
        }

        public IEnumerator<DataItem> GetEnumerator() {
            return this.Children.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return this.Children.GetEnumerator();
        }

    }
}
