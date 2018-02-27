using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ProductRepository
    {
        List<product> P = new List<product>();
        public ProductRepository(List<product> P)
        {
            this.P = P;
            
        }
        public int Totalnumberofproduct()
        {
            return P.Count;
        }
        public List<product> DeleteByName1(string name)
        {
            this.P.Remove(P.Find(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase)));
            return this.P;
        }
        public List<product> addnewproduct(product add)
        {
            P.Add(add);
            return P;
        }
        public List<product> ProductsByType(string type)
        {
            return this.P.FindAll(x => x.Type.Equals(type, StringComparison.OrdinalIgnoreCase));
        }
        public List<product> DeleteByName(string name)
        {
            this.P.Remove(P.Find(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase)));
            return this.P;
        }

        public double BoughtProduct(List<product> pl, string Name, double Quantity)
        {   double x=0;
            foreach (var product in pl)
            {
                if (product.Name.Equals(Name))
                {
                    x = product.Price * Quantity;
                }
            }
            return x;
        }
    }
}
