using Yeni.Models;
namespace Yeni.Data;

public static class ProductDataControl{

    static List<Product> _products;
    
    static ProductDataControl(){
        _products=new List<Product>{
            new Product{ProductId=1,Name="Samsung S5",Price=3.400,Description="küçük boyutlu ",ImgUrl="samsung1.png",CategoriId=1},
            new Product{ProductId=2,Name="Samsung A24",Price=2000,Description="yaxsi veziyyetde ",ImgUrl="samsung2.png",CategoriId=1},
            new Product{ProductId=3,Name="Samsung Galaxy",Price=3200,Description="Profesyonel kullanıcılar için ",ImgUrl="samsung3.png",CategoriId=1},
            new Product{ProductId=4,Name="Samsung S20",Price=3900,Description="ELa veziyyetde ",ImgUrl="samsung4.png",CategoriId=1},
            new Product{ProductId=5,Name="HP Spectre",Price=5.400,Description="İnce ve hafif tasarım ",ImgUrl="samsung5.png",CategoriId=2},
            new Product{ProductId=6,Name="HP Envy",Price=7000,Description="Şık tasarıma sahip ",ImgUrl="samsung6.png",CategoriId=2},
            new Product{ProductId=7,Name="HP Pavilion",Price=3000,Description="Geniş bir kullanıcı ",ImgUrl="samsung7.png",CategoriId=2},
            new Product{ProductId=8,Name="HP Omen",Price=1900,Description="İş kullanıcılarına ",ImgUrl="samsung8.png",CategoriId=2}
        };
    }
    public static List<Product> AllProducts { get{return _products;} }

    public static void ProductElaveEt(Product prod){
        _products.Add(prod);
    }

    public static Product getProductId(int PrId) {
        return AllProducts.Where(i=> i.ProductId==PrId).FirstOrDefault();
    }
    
}