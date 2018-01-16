namespace WpfControlConfiguratorDemo.Model {
    using System;

    public class Customer : ObservableObject {

        Address _address;
        Int32 _favoriteSport;
        String _firstName;
        Int32 _id;
        String _lastName;
        Status _status;

        public Address Address {
            get { return _address; }
            set {
                _address = value;
                RaisePropertyChanged();
            }
        }

        public Int32 FavoriteSport {
            get { return _favoriteSport; }
            set {
                _favoriteSport = value;
                RaisePropertyChanged();
            }
        }

        public String FirstName {
            get { return _firstName; }
            set {
                _firstName = value;
                RaisePropertyChanged();
            }
        }

        public Int32 Id {
            get { return _id; }
            set {
                _id = value;
                RaisePropertyChanged();
            }
        }

        public String LastName {
            get { return _lastName; }
            set {
                _lastName = value;
                RaisePropertyChanged();
            }
        }

        public Status Status {
            get { return _status; }
            set {
                _status = value;
                RaisePropertyChanged();
            }
        }

        public Customer() {
        }

    }
}
