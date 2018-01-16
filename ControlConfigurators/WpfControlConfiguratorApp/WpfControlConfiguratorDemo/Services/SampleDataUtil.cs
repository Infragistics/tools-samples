namespace WpfControlConfiguratorDemo.Services {
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;

    public class SampleDataUtil {

        static readonly String connectionString = "server=(local); Initial Catalog=Northwind; Persist Security Info=False; Integrated Security=SSPI";

        public static DataSet GetCustomers() {
            var customerDataSet = new DataSet("Northwind");
            using (var conn = new SqlConnection(connectionString)) {
                var customerSelectCommand = new SqlCommand("SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers", conn);
                var customerAdapter = new SqlDataAdapter(customerSelectCommand);
                try {
                    customerAdapter.Fill(customerDataSet, "Customers");
                } catch (Exception e) {
                    Debug.WriteLine(e.Message);
                }
            }
            return customerDataSet;
        }

        public static DataSet GetCustomersOrders() {
            var customerOrderDataSet = GetCustomers();
            using (var conn = new SqlConnection(connectionString)) {
                var orderSelectCommand = new SqlCommand("SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry FROM Orders", conn);
                var orderAdapter = new SqlDataAdapter(orderSelectCommand);
                try {
                    orderAdapter.Fill(customerOrderDataSet, "Orders");
                    customerOrderDataSet.Relations.Add("Customer_Orders", customerOrderDataSet.Tables["Customers"].Columns["CustomerID"], customerOrderDataSet.Tables["Orders"].Columns["CustomerID"]);
                } catch (Exception e) {
                    Debug.WriteLine(e.Message);
                }
            }
            return customerOrderDataSet;
        }

        public static DataSet GetTop10ProductsInStock(String serverAddress) {
            var top10ProductsDataSet = new DataSet("Northwind");
            using (var conn = new SqlConnection(connectionString)) {
                var productSelectCommand = new SqlCommand("SELECT TOP 10 UnitsInStock, ProductID FROM Products ORDER BY UnitsInStock DESC", conn);
                var productAdapter = new SqlDataAdapter(productSelectCommand);
                try {
                    productAdapter.Fill(top10ProductsDataSet, "Products");
                } catch (Exception e) {
                    Debug.WriteLine(e.Message);
                }
            }
            return top10ProductsDataSet;
        }

    }
}
