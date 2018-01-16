namespace WpfControlConfiguratorDemo.Model {
    using System;

    public class Address : ObservableObject {

        String _city;
        String _state;
        String _street;
        String _zip;

        public String City {
            get { return _city; }
            set {
                _city = value;
                RaisePropertyChanged();
            }
        }

        public String State {
            get { return _state; }
            set {
                _state = value;
                RaisePropertyChanged();
            }
        }

        public String Street {
            get { return _street; }
            set {
                _street = value;
                RaisePropertyChanged();
            }
        }

        public String Zip {
            get { return _zip; }
            set {
                _zip = value;
                RaisePropertyChanged();
            }
        }

        public Address() {
        }

    }
}
