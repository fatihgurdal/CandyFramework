using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.ConfigurationEditor.Entites
{
    public class Product
    {
        public string ProductName { get; set; }
        public string InstanceName { get; set; }
        public string ConnectionString { get; set; }
        public override string ToString()
        {
            return $"{this.ProductName} -> {this.InstanceName}";
        }
        public Product():this(string.Empty)
        { }
        public Product(string productName) : this(productName, string.Empty)
        { }
        public Product(string productName, string instanceName) : this(productName, instanceName, string.Empty)
        { }
        public Product(string productName, string instanceName, string connectionString)
        {
            this.ProductName = productName;
            this.InstanceName = instanceName;
            this.ConnectionString = connectionString;
        }
    }
}
