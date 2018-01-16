namespace WpfControlConfiguratorDemo.Model {
    using System;
    using Infragistics.Controls.Charts.DataAdapters;

    public abstract class ItemBase {

        [DataSeriesMemberIntent(DataSeriesIntent.DontPlot)]
        public Int32 Id { get; set; }

        protected ItemBase() {
            
        }

    }
}
