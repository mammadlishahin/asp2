using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Yeni.Data;
using Yeni.Models;
using Yeni.ViewModel;
public class ProductController:Controller{
    public IActionResult Index(){
        return View();
    }
    public IActionResult List(int? id,string? id2){
        ProductViewModel PVM =new ProductViewModel();
        PVM.Products=ProductDataControl.AllProducts;

        if(id!=null){
        PVM.Products=ProductDataControl.AllProducts.Where(i=>i.CategoriId==id).ToList();

        }
        if(id2!=null){
            PVM.Products=ProductDataControl.AllProducts.Where(k=>k.Name.ToLower()==id2.ToString().ToLower()).ToList();
        }
        
        return View(PVM);
    }
    public IActionResult Details(int id){
        var P=ProductDataControl.getProductId(id);
        return View(P);
    }
    [HttpGet]
    public IActionResult Create(){
        return View();
    }
    [HttpPost]
    public IActionResult Create(Product p){
        if(p.Name!=null){
        ProductDataControl.ProductElaveEt(p);
        Console.WriteLine(p.CategoriId);
         }
        return RedirectToAction("list");
    }
}