namespace InventoryMVC.Models;

public class OrderModel{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }

    //ForeignKey
    public int CustomerId { get; set; }
    public int EmployeeId { get; set; }
    public int ProductId { get; set; }
}