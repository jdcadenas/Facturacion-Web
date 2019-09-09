//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaFacturacionWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;


    public partial class articulo
    {

        [Display(Name = "Id")]
        public int IdArticulo { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Nombre ")]
        public string NombreArticulo { get; set; }


        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Stock Minimo")]
        public double StockMinArticulo { get; set; }

        [Display(Name = "Stock Maximo")]
        [Required(ErrorMessage = "Campo requerido")]
        public string StockMaxArticulo { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Codigo")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Precio Venta")]
        public double PrecioPromedioArticulo { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Cantidad")]
        public decimal CantidadArticulo { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Fecha Vencimiento")]
        [DataType(DataType.Date)]

        public System.DateTime FechaVencimiento { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Precio Compra")]
        public string DescripcionArticulo { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Unidad de Medida")]
        public string UnidadMedidaArticulo { get; set; }
    }
}