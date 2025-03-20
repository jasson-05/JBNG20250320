using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JBNG20250320.AppWebMVC.Models;

public partial class Brand
{
    public int BrandId { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [Display(Name = "Nobre")]
    public string BrandName { get; set; } = null!;

    [Required(ErrorMessage = "El pais es obligatorio.")]
    [Display(Name = "Pais")]
    public string? Country { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
