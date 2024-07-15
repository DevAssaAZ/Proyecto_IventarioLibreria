using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Ventas_cn.Facturacion
{
    public abstract class Facturacion_N
    {
        // Campos protegidos
        protected int id;
        protected string numFactura;
        protected string cedula;
        protected string cliente;
        protected string libro;
        protected int cantidad;
        protected decimal precioCantidad;
        protected string detalles;
        protected decimal descuento;
        protected decimal precioTotal;
        protected string metodoDePago;
        protected string estado;

        // Constructores
        public Facturacion_N(int id, string numFactura, string cedula, string cliente, string libro, int cantidad, decimal precioCantidad, string detalles, decimal descuento, decimal precioTotal, string metodoDePago, string estado)
        {
            this.Id = id;
            this.NumFactura = numFactura;
            this.Cedula = cedula;
            this.Cliente = cliente;
            this.Libro = libro;
            this.Cantidad = cantidad;
            this.PrecioCantidad = precioCantidad;
            this.Detalles = detalles;
            this.Descuento = descuento;
            this.PrecioTotal = precioTotal;
            this.MetodoDePago = metodoDePago;
            this.Estado = estado;
        }

        public Facturacion_N(string numFactura, string cedula, string cliente, string libro, int cantidad, decimal precioCantidad, string detalles, decimal descuento, decimal precioTotal, string metodoDePago, string estado)
        {
            this.NumFactura = numFactura;
            this.Cedula = cedula;
            this.Cliente = cliente;
            this.Libro = libro;
            this.Cantidad = cantidad;
            this.PrecioCantidad = precioCantidad;
            this.Detalles = detalles;
            this.Descuento = descuento;
            this.PrecioTotal = precioTotal;
            this.MetodoDePago = metodoDePago;
            this.Estado = estado;
        }

        public Facturacion_N(int id)
        {
            this.Id = id;
        }

        public Facturacion_N()
        {
            // Constructor vacío
        }

        // Propiedades con getters y setters
        public int Id { get => id; set => id = value; }
        public string NumFactura { get => numFactura; set => numFactura = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Libro { get => libro; set => libro = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal PrecioCantidad { get => precioCantidad; set => precioCantidad = value; }
        public string Detalles { get => detalles; set => detalles = value; }
        public decimal Descuento { get => descuento; set => descuento = value; }
        public decimal PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public string MetodoDePago { get => metodoDePago; set => metodoDePago = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
