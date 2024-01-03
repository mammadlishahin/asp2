
namespace Yeni.Models;

public class Product{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public string ImgUrl { get; set; }
    public int CategoriId { get; set; }
}