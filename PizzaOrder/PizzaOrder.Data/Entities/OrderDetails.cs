using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaOrder.Data.Entities;
public class OrderDetails
{
    #region Fields
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [StringLength(40)]
    [Column(TypeName = "nvarchar(40)")]
    public string AddressLine1 { get; set; }
    [Required]
    [StringLength(40)]
    [Column(TypeName = "nvarchar(40)")]
    public string AddressLine2 { get; set; }
    [Required]
    [StringLength(10)]
    [Column(TypeName = "nvarchar(10)")]
    public string MobileNo { get; set; }
    [Column(TypeName = "decimal(18,4)")]
    public decimal Amount { get; set; }
    [Required]
    public DateOnly Date { get; set; }
    [Required]
    [Column(TypeName = "int")]
    public Enum.OrderStatus OrderStatus { get; set; }
    #endregion

    #region Ctor
    internal OrderDetails(
        string addressLine1,
        string addressLine2,
        string mobileNo,
        decimal amount,
        Enum.OrderStatus orderStatus = Enum.OrderStatus.Created)
    {
        AddressLine1 = addressLine1 ?? throw new ArgumentNullException(nameof(addressLine1));
        AddressLine2 = addressLine2 ?? throw new ArgumentNullException(nameof(addressLine2));
        MobileNo = mobileNo ?? throw new ArgumentNullException(nameof(mobileNo));
        Amount = amount;
        Date = DateTime.Now.ToDateOnly();
        OrderStatus = orderStatus;
    }
    #endregion
}
