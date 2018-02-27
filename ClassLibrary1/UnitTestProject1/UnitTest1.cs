using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace UnitTestProject1
{

    [TestClass()]
    public class programTests
    {

        [TestMethod()]
        public void ProductTest()
        {
            List<product> P = new List<product>();
            P.Add(new product() { Name = "lettuce", Price = 10.5, Qauntity = 50, Type = "Leafy green" });
            P.Add(new product() { Name = "cabbage", Price = 20, Qauntity = 100, Type = "Cruciferous" });
            P.Add(new product() { Name = "pumpkin", Price = 30, Qauntity = 30, Type = "Marrow" });
            P.Add(new product() { Name = "cauliflower", Price = 10, Qauntity = 25, Type = "Cruciferous" });
            P.Add(new product() { Name = "zucchini", Price = 20.5, Qauntity = 50, Type = "Marrow" });
            P.Add(new product() { Name = "yam", Price = 30, Qauntity = 50, Type = "Root" });
            P.Add(new product() { Name = "spinach", Price = 10, Qauntity = 100, Type = "Leafy green" });
            P.Add(new product() { Name = "broccoli", Price = 20.2, Qauntity = 75, Type = "Cruciferous" });
            P.Add(new product() { Name = "Garlic", Price = 30, Qauntity = 20, Type = "Leafy green" });
            P.Add(new product() { Name = "silverbeet", Price = 10, Qauntity = 50, Type = "Marrow" });

            int expected = 10;
            ProductRepository pr = new ProductRepository(P);
            int actual = pr.Totalnumberofproduct();

            Assert.AreEqual(expected, actual);
            P.Add(new product() { Name = "Muli", Price = 10, Qauntity = 50, Type = "Root" });
            int a = P.Count();
            Assert.AreEqual(11, a);
        }
 [TestMethod()]
        public void ProductTest1()
        {
            List<product> P = new List<product>();
            P.Add(new product() { Name = "lettuce", Price = 10.5, Qauntity = 50, Type = "Leafy green" });
            P.Add(new product() { Name = "cabbage", Price = 20, Qauntity = 100, Type = "Cruciferous" });
            P.Add(new product() { Name = "pumpkin", Price = 30, Qauntity = 30, Type = "Marrow" });
            P.Add(new product() { Name = "cauliflower", Price = 10, Qauntity = 25, Type = "Cruciferous" });
            P.Add(new product() { Name = "zucchini", Price = 20.5, Qauntity = 50, Type = "Marrow" });
            P.Add(new product() { Name = "yam", Price = 30, Qauntity = 50, Type = "Root" });
            P.Add(new product() { Name = "spinach", Price = 10, Qauntity = 100, Type = "Leafy green" });
            P.Add(new product() { Name = "broccoli", Price = 20.2, Qauntity = 75, Type = "Cruciferous" });
            P.Add(new product() { Name = "Garlic", Price = 30, Qauntity = 20, Type = "Leafy green" });
            P.Add(new product() { Name = "silverbeet", Price = 10, Qauntity = 50, Type = "Marrow" });
            ProductRepository pr = new ProductRepository(P);
            var dele1 = pr.DeleteByName1("zucchini");
            var dele2 = pr.DeleteByName1("broccoli");
            Assert.AreEqual(8, pr.Totalnumberofproduct());
        }
        
        [TestMethod()]
        public void ProductTest2()
        {
            List<product> P = new List<product>();
            P.Add(new product() { Name = "lettuce", Price = 10.5, Qauntity = 50, Type = "Leafy green" });
            P.Add(new product() { Name = "cabbage", Price = 20, Qauntity = 100, Type = "Cruciferous" });
            P.Add(new product() { Name = "pumpkin", Price = 30, Qauntity = 30, Type = "Marrow" });
            P.Add(new product() { Name = "cauliflower", Price = 10, Qauntity = 25, Type = "Cruciferous" });
            P.Add(new product() { Name = "zucchini", Price = 20.5, Qauntity = 50, Type = "Marrow" });
            P.Add(new product() { Name = "yam", Price = 30, Qauntity = 50, Type = "Root" });
            P.Add(new product() { Name = "spinach", Price = 10, Qauntity = 100, Type = "Leafy green" });
            P.Add(new product() { Name = "broccoli", Price = 20.2, Qauntity = 75, Type = "Cruciferous" });
            P.Add(new product() { Name = "Garlic", Price = 30, Qauntity = 20, Type = "Leafy green" });
            P.Add(new product() { Name = "silverbeet", Price = 10, Qauntity = 50, Type = "Marrow" });
            
            ProductRepository pr = new ProductRepository(P);
            P.Add(new product() { Name = "Potato", Price = 10, Qauntity = 50, Type = "Root" });
            int a = P.Count();
            Assert.AreEqual(11, a);

        }
        [TestMethod()]
        public void ProductTest3()
        {
            List<product> P = new List<product>();
            P.Add(new product() { Name = "lettuce", Price = 10.5, Qauntity = 50, Type = "Leafy green" });
            P.Add(new product() { Name = "cabbage", Price = 20, Qauntity = 100, Type = "Cruciferous" });
            P.Add(new product() { Name = "pumpkin", Price = 30, Qauntity = 30, Type = "Marrow" });
            P.Add(new product() { Name = "cauliflower", Price = 10, Qauntity = 25, Type = "Cruciferous" });
            P.Add(new product() { Name = "zucchini", Price = 20.5, Qauntity = 50, Type = "Marrow" });
            P.Add(new product() { Name = "yam", Price = 30, Qauntity = 50, Type = "Root" });
            P.Add(new product() { Name = "spinach", Price = 10, Qauntity = 100, Type = "Leafy green" });
            P.Add(new product() { Name = "broccoli", Price = 20.2, Qauntity = 75, Type = "Cruciferous" });
            P.Add(new product() { Name = "Garlic", Price = 30, Qauntity = 20, Type = "Leafy green" });
            P.Add(new product() { Name = "silverbeet", Price = 10, Qauntity = 50, Type = "Marrow" });

            ProductRepository pr = new ProductRepository(P);
            var find = pr.ProductsByType("Cruciferous");
            Assert.AreEqual(3, find.Count);
            
            pr = new ProductRepository(P);
            var find2 = pr.ProductsByType("Marrow");
            foreach (var product in find2)
            {
                if (product.Type.Equals("Marrow"))
                    Assert.IsTrue(true);
                else
                    Assert.IsFalse(false);
            }
        }
        [TestMethod()]
        public void ProductTest4()
        {
            List<product> P = new List<product>();
            P.Add(new product() { Name = "lettuce", Price = 10.5, Qauntity = 50, Type = "Leafy green" });
            P.Add(new product() { Name = "cabbage", Price = 20, Qauntity = 100, Type = "Cruciferous" });
            P.Add(new product() { Name = "pumpkin", Price = 30, Qauntity = 30, Type = "Marrow" });
            P.Add(new product() { Name = "cauliflower", Price = 10, Qauntity = 25, Type = "Cruciferous" });
            P.Add(new product() { Name = "zucchini", Price = 20.5, Qauntity = 50, Type = "Marrow" });
            P.Add(new product() { Name = "yam", Price = 30, Qauntity = 50, Type = "Root" });
            P.Add(new product() { Name = "spinach", Price = 10, Qauntity = 100, Type = "Leafy green" });
            P.Add(new product() { Name = "broccoli", Price = 20.2, Qauntity = 75, Type = "Cruciferous" });
            P.Add(new product() { Name = "Garlic", Price = 30, Qauntity = 20, Type = "Leafy green" });
            P.Add(new product() { Name = "silverbeet", Price = 10, Qauntity = 50, Type = "Marrow" });

            ProductRepository pr = new ProductRepository(P);
            Assert.AreEqual(9, pr.DeleteByName("pumpkin").Count);
            var del = pr.DeleteByName("cabbage");
            var result = del.FindAll(x => x.Name.Equals("cabbage", StringComparison.OrdinalIgnoreCase));
            Assert.AreEqual(0, result.Count);
        }

    
    [TestMethod]
        public void ProductTest5()
        {   
            List<product> P = new List<product>();
            P.Add(new product() { Name = "lettuce", Price = 10.5, Qauntity = 50, Type = "Leafy green" });
            P.Add(new product() { Name = "cabbage", Price = 20, Qauntity = 100, Type = "Cruciferous" });
            P.Add(new product() { Name = "pumpkin", Price = 30, Qauntity = 30, Type = "Marrow" });
            P.Add(new product() { Name = "cauliflower", Price = 10, Qauntity = 25, Type = "Cruciferous" });
            P.Add(new product() { Name = "zucchini", Price = 20.5, Qauntity = 50, Type = "Marrow" });
            P.Add(new product() { Name = "yam", Price = 30, Qauntity = 50, Type = "Root" });
            P.Add(new product() { Name = "spinach", Price = 10, Qauntity = 100, Type = "Leafy green" });
            P.Add(new product() { Name = "broccoli", Price = 20.2, Qauntity = 75, Type = "Cruciferous" });
            P.Add(new product() { Name = "Garlic", Price = 30, Qauntity = 20, Type = "Leafy green" });
            P.Add(new product() { Name = "silverbeet", Price = 10, Qauntity = 50, Type = "Marrow" });
            
            ProductRepository pr = new ProductRepository(P);
            double total = ( pr.BoughtProduct(P, "zucchini", 1.0))
                     + (pr.BoughtProduct(P, "spinach", 1.0))
                     + (pr.BoughtProduct(P, "cabbage", 1.0));

            double expected = 50.5;
            Assert.AreEqual(expected, total);

        }
    }
}

