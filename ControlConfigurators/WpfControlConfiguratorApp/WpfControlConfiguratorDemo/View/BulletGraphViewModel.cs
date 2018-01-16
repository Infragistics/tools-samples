namespace WpfControlConfiguratorDemo.View {
    using System;

    public class BulletGraphViewModel {

        public Double Value { get; set; }

        public Double TargetValue { get; set; }

        public BulletGraphViewModel() {
            this.Value = 65;
            this.TargetValue = 90;
        }

    }
}
