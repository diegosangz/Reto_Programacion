using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Reto_Programacion.Models
{
    //Creacion Base de Datos para Clientes
    public class Cliente
    {
        [Key]
        [Display(Name = "Numero de Cliente: ")]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Nombre: ")]
        [StringLength(50, ErrorMessage = "Nombre no puede ser mayor a 50 caracteres. ")]
        public string NombreCliente { get; set; }

        [Display(Name = "Concesionario: ")]
        [StringLength(50)]
        public string Cncsn { get; set; }

        [Display(Name = "Ciudad: ")]
        [StringLength(50)]
        public string Cdad { get; set; }

        [Display(Name = "Telefono Celular: ")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{4})[-.●]?([0-9]{4})$", ErrorMessage = "El Numero de Telefono no es valido")]
        public string Tlfno { get; set; }

        [Display(Name = "Status: ")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}