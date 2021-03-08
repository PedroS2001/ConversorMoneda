using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoneda
{
    public class DolarAhorro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        #region Constructor

        private DolarAhorro()
        {
            DolarAhorro.SetCotizacion(cotizRespectoDolar);
        }

        public DolarAhorro(double cantidad) :
            this()
        {
            this.cantidad = cantidad;
        }
        public DolarAhorro(double cantidad, double cotizacion) :
            this(cantidad)
        {
            DolarAhorro.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos
        public static double GetCotizacion()
        {
            return DolarAhorro.cotizRespectoDolar;
        }

        public static void SetCotizacion(double num)
        {
            DolarAhorro.cotizRespectoDolar = num;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region EXPLICITOS

        public static explicit operator Dolar(DolarAhorro p)
        {
            double cantidad = p.GetCantidad() * DolarAhorro.GetCotizacion();

            return new Dolar(cantidad);
        }

        public static explicit operator DolarBlue(DolarAhorro p)
        {
            double cantidadEnDolares = p.GetCantidad() * DolarAhorro.GetCotizacion();
            double cantidadEnDolarBlues = cantidadEnDolares / DolarBlue.GetCotizacion();

            return new DolarBlue(cantidadEnDolarBlues);
        }
        public static explicit operator DolarCCL(DolarAhorro p)
        {
            double cantidadEnDolares = p.GetCantidad() * DolarAhorro.GetCotizacion();
            double cantidadEnDolarBlues = cantidadEnDolares / DolarCCL.GetCotizacion();

            return new DolarCCL(cantidadEnDolarBlues);
        }
        public static explicit operator DolarTurista(DolarAhorro p)
        {
            double cantidadEnDolares = p.GetCantidad() * DolarAhorro.GetCotizacion();
            double cantidadEnDolarBlues = cantidadEnDolares / DolarTurista.GetCotizacion();

            return new DolarTurista(cantidadEnDolarBlues);
        }
        public static explicit operator Pesos(DolarAhorro p)
        {
            double cantidadEnDolares = p.GetCantidad() * DolarAhorro.GetCotizacion();
            double cantidadEnDolarBlues = cantidadEnDolares / Pesos.GetCotizacion();

            return new Pesos(cantidadEnDolarBlues);
        }

        public static implicit operator DolarAhorro(double d)
        {
            return new DolarAhorro(d);
        }
        #endregion


        #region Operadores de comparacion

        public static bool operator ==(DolarAhorro p, Dolar d)
        {
            if (((DolarAhorro)d).GetCantidad() == p.GetCantidad())
                return true;
            return false;
        }
        public static bool operator !=(DolarAhorro p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(DolarAhorro p, DolarBlue e)
        {
            if (((DolarAhorro)e).GetCantidad() == p.GetCantidad())
                return true;
            return false;
        }
        public static bool operator !=(DolarAhorro p, DolarBlue e)
        {
            return !(p == e);
        }
        public static bool operator ==(DolarAhorro p, DolarCCL e)
        {
            if (((DolarAhorro)e).GetCantidad() == p.GetCantidad())
                return true;
            return false;
        }
        public static bool operator !=(DolarAhorro p, DolarCCL e)
        {
            return !(p == e);
        }

        public static bool operator ==(DolarAhorro p, DolarTurista e)
        {
            if (((DolarAhorro)e).GetCantidad() == p.GetCantidad())
                return true;
            return false;
        }
        public static bool operator !=(DolarAhorro p, DolarTurista e)
        {
            return !(p == e);
        }

        public static bool operator ==(DolarAhorro p, Pesos e)
        {
            if (((DolarAhorro)e).GetCantidad() == p.GetCantidad())
                return true;
            return false;
        }
        public static bool operator !=(DolarAhorro p, Pesos e)
        {
            return !(p == e);
        }



        public static bool operator ==(DolarAhorro p1, DolarAhorro p2)
        {
            if (p1.cantidad == p2.cantidad)
                return true;

            return false;
        }
        public static bool operator !=(DolarAhorro p1, DolarAhorro p2)
        {
            return !(p1 == p2);
        }
        #endregion

        #region Operadores de sumas y restas

        public static DolarAhorro operator +(DolarAhorro p, Dolar d)
        {
            return p.GetCantidad() + ((DolarAhorro)d).GetCantidad();
        }

        public static DolarAhorro operator +(DolarAhorro p, DolarBlue e)
        {
            return p.GetCantidad() + ((DolarAhorro)e).GetCantidad();
        }
        public static DolarAhorro operator +(DolarAhorro p, DolarCCL e)
        {
            return p.GetCantidad() + ((DolarAhorro)e).GetCantidad();
        }
        public static DolarAhorro operator +(DolarAhorro p, DolarTurista e)
        {
            return p.GetCantidad() + ((DolarAhorro)e).GetCantidad();
        }
        public static DolarAhorro operator +(DolarAhorro p, Pesos e)
        {
            return p.GetCantidad() + ((DolarAhorro)e).GetCantidad();
        }

        public static DolarAhorro operator -(DolarAhorro p, Dolar d)
        {
            return p.GetCantidad() - ((DolarAhorro)d).GetCantidad();
        }
        public static DolarAhorro operator -(DolarAhorro p, DolarBlue e)
        {
            return p.GetCantidad() - ((DolarAhorro)e).GetCantidad();
        }
        public static DolarAhorro operator -(DolarAhorro p, DolarCCL e)
        {
            return p.GetCantidad() - ((DolarAhorro)e).GetCantidad();
        }
        public static DolarAhorro operator -(DolarAhorro p, DolarTurista e)
        {
            return p.GetCantidad() - ((DolarAhorro)e).GetCantidad();
        }
        public static DolarAhorro operator -(DolarAhorro p, Pesos e)
        {
            return p.GetCantidad() - ((DolarAhorro)e).GetCantidad();
        }


        #endregion


    }
}
