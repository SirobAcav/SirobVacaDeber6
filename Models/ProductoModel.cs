using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SirobVacaDeber6.Models
{
    public class ProductoModel
    {
        [Key]
        public int ProductoId { get; set; }


        [Required(ErrorMessage = "El campo Producto del Producto es requerido")]
        [MaxLength(40, ErrorMessage = "El máximo de caracteres es 40")]
        [MinLength(4, ErrorMessage = "El mínimo de caracteres es 4")]
        public string Producto { get; set; } = null!;


        [Required, MaxLength(50)]
        public string Paquete { get; set; } = null!;


        [DataType(DataType.Date)]
        public DateTime FechaIngreso { get; set; }


        [DataType(DataType.Date)]
        public DateTime FechaCaducidad { get; set; }


        [Required, MaxLength(100)]
        public string Proveedor { get; set; } = null!;


        [Range(0, uint.MaxValue, ErrorMessage = "El stock no puede ser negativo")]
        public uint Stock { get; set; }


        [Precision(10, 2)] // DECIMAL(10,2)
        [Range(0.0, double.MaxValue, ErrorMessage = "El precio no puede ser negativo")]
        public decimal Precio { get; set; }


        public DateTime Create_At { get; set; }
        public DateTime Update_Up { get; set; }
    }
}
