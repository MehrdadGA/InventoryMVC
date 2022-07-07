namespace InventoryMVC.Models;

public class ProductModel{
    public int Id { get; set; }
    public string? ProductName { get; set; }
    public int ProductCount { get; set; }
    public double ProductPrice { get; set; }
}