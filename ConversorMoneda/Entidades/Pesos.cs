using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoneda
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        #region Constructores
        private Pesos()
        {
            Pesos.SetCotizacion(cotizRespectoDolar);
        }
        public Pesos(double cantidad) :
            this()
        {
            this.cantidad = cantidad;
        }
        public Pesos(double cantidad, double cotizacion) :
            this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos
        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public static void SetCotizacion(double num)
        {
            Pesos.cotizRespectoDolar = num;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region EXPLICITOS

        public static explicit operator Dolar(Pesos p)
        {
            double cantidad = p.GetCantidad() * Pesos.GetCotizacion();

            return new Dolar(cantidad);
        }

        public static explicit operator DolarBlue(Pesos p)
        {
            double cantidadEnDolares = p.GetCantidad() * Pesos.GetCotizacion();
            double cantidadEnDolarBlues = cantidadEnDolares / DolarBlue.GetCotizacion();

            return new DolarBlue(cantidadEnDolarBlues);
        }

        public static explicit operator DolarCCL(Pesos p)
        {
            double cantidadEnDolares = p.GetCantidad() * Pesos.GetCotizacion();
            double cantidadEnDolarBlues = cantidadEnDolares / DolarCCL.GetCotizacion();

            return new DolarCCL(cantidadEnDolarBlues);
        }
        public static explicit operator DolarAhorro(Pesos p)
        {
            double cantidadEnDolares = p.GetCantidad() * Pesos.GetCotizacion();
            double cantidadEnDolarBlues = cantidadEnDolares / DolarAhorro.GetCotizacion();

            return new DolarAhorro(cantidadEnDolarBlues);
        }
        public static explicit operator DolarTurista(Pesos p)
        {
            double cantidadEnDolares = p.GetCantidad() * Pesos.GetCotizacion();
            double cantidadEnDolarBlues = cantidadEnDolares / DolarTurista.GetCotizacion();

            return new DolarTurista(cantidadEnDolarBlues);
        }

        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }
        #endregion

        #region Operadores de comparacion

        public static bool operator ==(Pesos p, Dolar d)
        {
            if (((Pesos)d).GetCantidad() == p.GetCantidad())
                return true;
            return false;
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Pesos p, DolarBlue e)
        {
            if (((Pesos)e).GetCantidad() == p.GetCantidad())
                return true;
            return false;
        }

        public static bool operator !=(Pesos p, DolarBlue e)
        {
            return !(p == e);
        }

        public static bool operator ==(Pesos p, DolarCCL e)
        {
            if (((Pesos)e).GetCantidad() == p.GetCantidad())
                return true;
            return false;
        }

        public static bool operator !=(Pesos p, DolarCCL e)
        {
            return !(p == e);
        }
        public static bool operator ==(Pesos p, DolarAhorro e)
        {
            if (((Pesos)e).GetCantidad() == p.GetCantidad())
                return true;
            return false;
        }

        public static bool operator !=(Pesos p, DolarAhorro e)
        {
            return !(p == e);
        }
        public static bool operator ==(Pesos p, DolarTurista e)
        {
            if (((Pesos)e).GetCantidad() == p.GetCantidad())
                return true;
            return false;
        }

        public static bool operator !=(Pesos p, DolarTurista e)
        {
            return !(p == e);
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            if (p1.cantidad == p2.cantidad)
                return true;

            return false;
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }
        #endregion

        #region Operadores de sumas y restas

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return p.GetCantidad() + ((Pesos)d).GetCantidad();
        }

        public static Pesos operator +(Pesos p, DolarBlue e)
        {
            return p.GetCantidad() + ((Pesos)e).GetCantidad();
        }

        public static Pesos operator +(Pesos p, DolarCCL e)
        {
            return p.GetCantidad() + ((Pesos)e).GetCantidad();
        }
        public static Pesos operator +(Pesos p, DolarAhorro e)
        {
            return p.GetCantidad() + ((Pesos)e).GetCantidad();
        }
        public static Pesos operator +(Pesos p, DolarTurista e)
        {
            return p.GetCantidad() + ((Pesos)e).GetCantidad();
        }
        public static Pesos operator -(Pesos p, Dolar d)
        {
            return p.GetCantidad() - ((Pesos)d).GetCantidad();
        }
        public static Pesos operator -(Pesos p, DolarBlue e)
        {
            return p.GetCantidad() - ((Pesos)e).GetCantidad();
        }
        public static Pesos operator -(Pesos p, DolarCCL e)
        {
            return p.GetCantidad() - ((Pesos)e).GetCantidad();
        }
        public static Pesos operator -(Pesos p, DolarAhorro e)
        {
            return p.GetCantidad() - ((Pesos)e).GetCantidad();
        }
        public static Pesos operator -(Pesos p, DolarTurista e)
        {
            return p.GetCantidad() - ((Pesos)e).GetCantidad();
        }


        #endregion

    }
}
