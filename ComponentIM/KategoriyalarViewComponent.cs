
using Microsoft.AspNetCore.Mvc;
using Yeni.Data;
namespace Yeni.ComponentIM;

public class KategoriyalarViewComponent:ViewComponent{

    public IViewComponentResult Invoke(){
        ViewBag.RouteId=RouteData.Values["id"];
        var categories = CategoriDataControl.AllCategori;
       
        return View(categories);
    }

}
