using OOP1;

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnıtInStock = 3;

Product product2 = new Product {Id = 2, CategoryId = 5, UnıtInStock = 5, 
    ProductName = "Kalem", UnitPrice = 35};

//PascalCase //camelCase
//case sensitive = Küçük büyük harf duyarlı 
ProductManager productManager = new ProductManager();
productManager.Add(product1);

productManager.Topla2(3, 6);

int toplamsonuc = productManager.Topla(3, 6);
Console.WriteLine(toplamsonuc*2);