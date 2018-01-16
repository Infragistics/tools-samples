namespace WpfControlConfiguratorDemo.Model {
    using System;

    public class ComboBoxDataItem {

        public Int32 Key { get; }

        public String Text { get; }

        public ComboBoxDataItem(Int32 key, String text) {
            this.Key = key;
            this.Text = text;
        }

    }
}
