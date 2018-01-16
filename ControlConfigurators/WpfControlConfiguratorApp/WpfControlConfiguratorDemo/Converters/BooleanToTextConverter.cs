namespace WpfControlConfiguratorDemo.Converters {
    using System;
    using System.Globalization;
    using System.Windows.Data;

    [ValueConversion(typeof(Boolean), typeof(String))]
    public class BooleanToTextConverter : IValueConverter {

        public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture) {
            if (value is Boolean b) {
                if (b) {
                    return "Yes";
                }
            }

            return "No";
        }

        public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) {
            if (value is String s) {
                if (String.Compare(s, "yes", true, culture) == 0) {
                    return true;
                }
            }

            return false;
        }

    }
}
