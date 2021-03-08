using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoneda
{
    public class DolarTurista 
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        #region Constructor

        private DolarTurista()
        {
            DolarTurista.SetCotizacion(cotizRespectoDolar);
        }

        public DolarTurista(double cantidad) :
            this()
        {
            this.cantidad = cantidad;
        }
        public DolarTurista(double cantidad, double cotizacion) :
            this(cantidad)
        {
            DolarTurista.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos
        public static double GetCotizacion()
        {
            return DolarTurista.cotizRespectoDolar;
        }

        public static void SetCotizacion(double num)
        {
            DolarTurista.cotizRespectoDolar = num;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion


        #region EXPLICITOS

        public static explicit operator Dolar(DolarTurista p)
        {
            double cantidad = p.GetCantidad() * DolarTurista.GetCotizacion();

            return new Dolar(cantidad);
        }

        public static explicit operator DolarBlue(DolarTurista p)
        {
            double cantidadEnDolares = p.GetCantidad() * DolarTurista.GetCotizacion();
            double cantidadEnDolarBlues = cantidadEnDolares / DolarBlue.GetCotizacion();

            return new DolarBlue(cantidadEnDolarBlues);
        }
        public static explicit operator DolarCCL(DolarTurista p)
        {
            double cantidadEnDolares = p.GetCantidad() * DolarTurista.GetCotizacion();
            double cantidadEnDolarBlues = cantidadEnDolares / DolarCCL.GetCotizacion();

            return new DolarCCL(cantidadEnDolarBlues);
        }
        public static explicit operator DolarAhorro(DolarTurista p)
        {
            double cantidadEnDolares = p.GetCantidad() * DolarTurista.GetCotizacion();
            double cantidadEnDolarBlues = cantidadEnDolares / DolarAhorro.GetCotizacion();

            return new DolarAhorro(cantidadEnDolarBlues);
        }
        public static explicit operator Pesos(DolarTurista p)
        {
            double cantidadEnDolares = p.GetCantidad() * DolarTurista.GetCotizacion();
            double cantidadEnDolarBlues = cantidadEnDolares / Pesos.GetCotizacion();

            return new Pesos(cantidadEnDolarBlues);
        }

        public static implicit operator DolarTurista(double d)
        {
            return new DolarTurista(d);
        }
        #endregion


        #region Operadores de comparacion

        public static bool operator ==(DolarTurista p, Dolar d)
        {
            if (((DolarTurista)d).GetCantidad() == p.GetCantidad())
                return true;
            return false;
        }
        public static bool operator !=(DolarTurista p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(DolarTurista p, DolarBlue e)
        {
            if (((DolarTurista)e).GetCantidad() == p.GetCantidad())
                return true;
            return false;
        }
        public static bool operator !=(DolarTurista p, DolarBlue e)
        {
            return !(p == e);
        }
        public static bool operator ==(DolarTurista p, DolarCCL e)
        {
            if (((DolarTurista)e).GetCantidad() == p.GetCantidad())
                return true;
            return false;
        }
        public static bool operator !=(DolarTurista p, DolarCCL e)
        {
            return !(p == e);
        }
        public static bool operator ==(DolarTurista p, DolarAhorro e)
        {
            if (((DolarTurista)e).GetCantidad() == p.GetCantidad())
                return true;
            return false;
        }
        public static bool operator !=(DolarTurista p, DolarAhorro e)
        {
            return !(p == e);
        }
        public static bool operator ==(DolarTurista p, Pesos e)
        {
            if (((DolarTurista)e).GetCantidad() == p.GetCantidad())
                return true;
            return false;
        }
        public static bool operator !=(DolarTurista p, Pesos e)
        {
            return !(p == e);
        }


        public static bool operator ==(DolarTurista p1, DolarTurista p2)
        {
            if (p1.cantidad == p2.cantidad)
                return true;

            return false;
        }
        public static bool operator !=(DolarTurista p1, DolarTurista p2)
        {
            return !(p1 == p2);
        }
        #endregion

        #region Operadores de sumas y restas

        public static DolarTurista operator +(DolarTurista p, Dolar d)
        {
            return p.GetCantidad() + ((DolarTurista)d).GetCantidad();
        }

        public static DolarTurista operator +(DolarTurista p, DolarBlue e)
        {
            return p.GetCantidad() + ((DolarTurista)e).GetCantidad();
        }
        public static DolarTurista operator +(DolarTurista p, DolarCCL e)
        {
            return p.GetCantidad() + ((DolarTurista)e).GetCantidad();
        }
        public static DolarTurista operator +(DolarTurista p, DolarAhorro e)
        {
            return p.GetCantidad() + ((DolarTurista)e).GetCantidad();
        }
        public static DolarTurista operator +(DolarTurista p, Pesos e)
        {
            return p.GetCantidad() + ((DolarTurista)e).GetCantidad();
        }

        public static DolarTurista operator -(DolarTurista p, Dolar d)
        {
            return p.GetCantidad() - ((DolarTurista)d).GetCantidad();
        }
        public static DolarTurista operator -(DolarTurista p, DolarBlue e)
        {
            return p.GetCantidad() - ((DolarTurista)e).GetCantidad();
        }
        public static DolarTurista operator -(DolarTurista p, DolarCCL e)
        {
            return p.GetCantidad() - ((DolarTurista)e).GetCantidad();
        }
        public static DolarTurista operator -(DolarTurista p, DolarAhorro e)
        {
            return p.GetCantidad() - ((DolarTurista)e).GetCantidad();
        }
        public static DolarTurista operator -(DolarTurista p, Pesos e)
        {
            return p.GetCantidad() - ((DolarTurista)e).GetCantidad();
        }


        #endregion
    }
}
