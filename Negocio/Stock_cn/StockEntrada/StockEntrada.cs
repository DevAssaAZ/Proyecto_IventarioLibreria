using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Stock_cn.StockEntrada
{
    public abstract class StockEntrada
    {
        protected int id;
        protected int idLibro;
        protected int cantidad;
        protected DateTime fecha;
        protected string proveedor;
        protected string comentarios;

        public StockEntrada(int id, int idLibro, int cantidad, DateTime fecha, string proveedor, string comentarios)
        {
            this.Id = id;
            this.IdLibro = idLibro;
            this.Cantidad = cantidad;
            this.Fecha = fecha;
            this.Proveedor = proveedor;
            this.Comentarios = comentarios;
        }

        public StockEntrada( int idLibro, int cantidad, DateTime fecha, string proveedor, string comentarios)
        {
            this.IdLibro = idLibro;
            this.Cantidad = cantidad;
            this.Fecha = fecha;
            this.Proveedor = proveedor;
            this.Comentarios = comentarios;
        }


        public StockEntrada(int idLibro)
        {
            this.IdLibro = idLibro;

        }



        public StockEntrada()
        {

        }


        public int Id { get => id; set => id = value; }
        public int IdLibro { get => idLibro; set => idLibro = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
    }
}
