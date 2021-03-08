using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoneda
{
    public class DolarCCL
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        #region Constructor

        private DolarCCL()
        {
            DolarCCL.SetCotizacion(cotizRespectoDolar);
        }

        public DolarCCL(double cantidad) :
            this()
        {
            this.cantidad = cantidad;
        }
        public DolarCCL(double cantidad, double cotizacion) :
            this(cantidad)
        {
            DolarCCL.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos
        public static double GetCotizacion()
        {
            return DolarCCL.cotizRespectoDolar;
        }

        public static void SetCotizacion(double num)
        {
            DolarCCL.cotizRespectoDolar = num;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region EXPLICITOS

        public static explicit operator Dolar(DolarCCL p)
        {
            double cantidad = p.GetCantidad() * DolarCCL.GetCotizacion();

            return new Dolar(cantidad);
        }

        public static explicit operator DolarBlue(DolarCCL p)
        {
            double cantidadEnDolares = p.GetCantidad() * DolarCCL.GetCotizacion();
            double cantidadEnDolarBlues = cantidadEnDolares / DolarBlue.GetCotizacion();

            return new DolarBlue(cantidadEnDolarBlues);
        }
        public static explicit operator DolarAhorro(DolarCCL p)
        {
            double cantidadEnDolares = p.GetCantidad() * DolarCCL.GetCotizacion();
            double cantidadEnDolarBlues = cantidadEnDolares / DolarAhorro.GetCotizacion();

            return new DolarAhorro(cantidadEnDolarBlues);
        }
        public static explicit operator DolarTurista(DolarCCL p)
        {
            double cantidadEnDolares = p.GetCantidad() * DolarCCL.GetCotizacion();
            double cantidadEnDolarBlues = cantidadEnDolares / DolarTurista.GetCotizacion();

            return new DolarTurista(cantidadEnDolarBlues);
        }
        public static explicit operator Pesos(DolarCCL p)
        {
            double cantidadEnDolares = p.GetCantidad() * DolarCCL.GetCotizacion();
            double cantidadEnDolarBlues = cantidadEnDolares / Pesos.GetCotizacion();

            return new Pesos(cantidadEnDolarBlues);
        }

        public static implicit operator DolarCCL(double d)
        {
            return new DolarCCL(d);
        }
        #endregion


        #region Operadores de comparacion

        public static bool operator ==(DolarCCL p, Dolar d)
        {
            if (((DolarCCL)d).GetCantidad() == p.GetCantidad())
                return true;
            return false;
        }
        public static bool operator !=(DolarCCL p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(DolarCCL p, DolarBlue e)
        {
            if (((DolarCCL)e).GetCantidad() == p.GetCantidad())
                return true;
            return false;
        }

        public static bool operator !=(DolarCCL p, DolarBlue e)
        {
            return !(p == e);
        }

        public static bool operator ==(DolarCCL p, DolarAhorro e)
        {
            if (((DolarCCL)e).GetCantidad() == p.GetCantidad())
                return true;
            return false;
        }
        public static bool operator !=(DolarCCL p, DolarAhorro e)
        {
            return !(p == e);
        }

        public static bool operator ==(DolarCCL p, DolarTurista e)
        {
            if (((DolarCCL)e).GetCantidad() == p.GetCantidad())
                return true;
            return false;
        }
        public static bool operator !=(DolarCCL p, DolarTurista e)
        {
            return !(p == e);
        }

        public static bool operator ==(DolarCCL p, Pesos e)
        {
            if (((DolarCCL)e).GetCantidad() == p.GetCantidad())
                return true;
            return false;
        }
        public static bool operator !=(DolarCCL p, Pesos e)
        {
            return !(p == e);
        }

        public static bool operator ==(DolarCCL p1, DolarCCL p2)
        {
            if (p1.cantidad == p2.cantidad)
                return true;

            return false;
        }
        public static bool operator !=(DolarCCL p1, DolarCCL p2)
        {
            return !(p1 == p2);
        }
        #endregion

        #region Operadores de sumas y restas

        public static DolarCCL operator +(DolarCCL p, Dolar d)
        {
            return p.GetCantidad() + ((DolarCCL)d).GetCantidad();
        }

        public static DolarCCL operator +(DolarCCL p, DolarBlue e)
        {
            return p.GetCantidad() + ((DolarCCL)e).GetCantidad();
        }
        public static DolarCCL operator +(DolarCCL p, DolarAhorro e)
        {
            return p.GetCantidad() + ((DolarCCL)e).GetCantidad();
        }
        public static DolarCCL operator +(DolarCCL p, DolarTurista e)
        {
            return p.GetCantidad() + ((DolarCCL)e).GetCantidad();
        }
        public static DolarCCL operator +(DolarCCL p, Pesos e)
        {
            return p.GetCantidad() + ((DolarCCL)e).GetCantidad();
        }

        public static DolarCCL operator -(DolarCCL p, Dolar d)
        {
            return p.GetCantidad() - ((DolarCCL)d).GetCantidad();
        }
        public static DolarCCL operator -(DolarCCL p, DolarBlue e)
        {
            return p.GetCantidad() - ((DolarCCL)e).GetCantidad();
        }
        public static DolarCCL operator -(DolarCCL p, DolarAhorro e)
        {
            return p.GetCantidad() - ((DolarCCL)e).GetCantidad();
        }
        public static DolarCCL operator -(DolarCCL p, DolarTurista e)
        {
            return p.GetCantidad() - ((DolarCCL)e).GetCantidad();
        }
        public static DolarCCL operator -(DolarCCL p, Pesos e)
        {
            return p.GetCantidad() - ((DolarCCL)e).GetCantidad();
        }


        #endregion
    }
}
