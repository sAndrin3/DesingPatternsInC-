using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class MotorCycle : IBuilder
    {
        private string brandName;
        private Product product;
        public MotorCycle(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }
        public void StartUpOperations()
        {
            product.Add(string.Format("Motorcycle model name: {0}", this.brandName));
        }
        public void BuildBody()
        {
            product.Add("This is a body of a Motorcycle");
        }
        public void InsertWheels()
        {
            product.Add("2 wheels are added");
        }
        public void AddHeadlights()
        {
            product.Add("1 Headlight was added");
        }
        public void EndOperations()
        {

        }
        public Product GetVehicle()
        {
            return product;
        }
    }
}