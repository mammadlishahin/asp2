using Yeni.Models;
namespace Yeni.Data;

public static class CategoriDataControl{
    private static List<Categori> _categori=null;

    static CategoriDataControl(){
        _categori=new List<Categori>{
            new Categori {CategoriId=1,Name="Telefon",Description="Telefon Kategorisi"},
            new Categori {CategoriId=2,Name="Bilgisayar",Description="Bilgisayar Kategorisi"},
            new Categori {CategoriId=3,Name="Elektronik",Description="Elektronik Kategorisi"}
        };
    }
    public static void AddCategori(Categori Cat){
        _categori.Add(Cat);
    }
    public static List<Categori> AllCategori{get {return _categori;}}

    public static Categori GetCategori(int Cid){
        return AllCategori.Where(i=>i.CategoriId==Cid).FirstOrDefault();
    }
} 