using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JBNG20250320.AppWebMVC.Models;

public partial class Warehouse
{
    public int WarehouseId { get; set; }

    [Required(ErrorMessage = "El Nombre es obligatorio.")]
    [Display(Name = "Bodega")]
    public string WarehouseName { get; set; } = null!;

    [Display(Name = "Nota")]
    [Required(ErrorMessage = "La nota es obligatorio.")]
    public string? Notes { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
