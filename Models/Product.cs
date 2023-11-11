using System.ComponentModel.DataAnnotations;

namespace BlazorStore.Models;

public class Product
{
    [Key] public int Id { get; set; }

    [Required(ErrorMessage = "Informe o título")]
    [MaxLength(40, ErrorMessage = "O título deve conter menos que 40 caracteres")]
    [MinLength(3, ErrorMessage = "O título deve conter mais que 3 caracteres")]
    public string Title { get; set; } = string.Empty;

    [DataType(DataType.Currency)] public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}