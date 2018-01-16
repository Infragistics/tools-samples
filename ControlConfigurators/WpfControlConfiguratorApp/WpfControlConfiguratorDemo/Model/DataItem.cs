namespace WpfControlConfiguratorDemo.Model {
    using System;

    public class DataItem : ItemBase {

        public Double FinalValue { get; }

        public Double InitialValue { get; }

        public String Name { get; }

        public DateTime PostDate { get; }

        public DataItem(String name, Double initialValue, Double finalValue, DateTime postDate) {
            this.Name = name;
            this.InitialValue = initialValue;
            this.FinalValue = finalValue;
            this.PostDate = postDate;
        }

    }
}
