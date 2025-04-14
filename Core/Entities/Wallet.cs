
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enums;

namespace Domain.Entities;

public class Wallet
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required]
    public required decimal Balance { get; set; }

    [Required]
    [EnumDataType(typeof(CurrencyType))]
    public required CurrencyType Currency { get; set; }

    [Required]
    public required string Address { get; set; }

    [Required]
    [ForeignKey("User")]
    public required User User { get; set; }

    [Required]
    public required Guid UserId { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Required]
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
