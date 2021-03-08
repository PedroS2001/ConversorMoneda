using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoneda
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        #region Constructores
        private Dolar()
        {
            Dolar.SetCotizacion(cotizRespectoDolar);
        }

        public Dolar(double cantidad) :
            this()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) :
            this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public static void SetCotizacion(double num)
        {
            Dolar.cotizRespectoDolar = num;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        #endregion

        #region Operadores explicitos
        public static explicit operator DolarBlue(Dolar d)
        {
            return new DolarBlue(d.GetCantidad() / DolarBlue.GetCotizacion());
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.GetCantidad() / Pesos.GetCotizacion());
        }

        public static explicit operator DolarCCL(Dolar d)
        {
            return new DolarCCL(d.GetCantidad() / DolarCCL.GetCotizacion());
        }

        public static explicit operator DolarAhorro(Dolar d)
        {
            return new DolarAhorro(d.GetCantidad() / DolarAhorro.GetCotizacion());
        }

        public static explicit operator DolarTurista(Dolar d)
        {
            return new DolarTurista(d.GetCantidad() / DolarTurista.GetCotizacion());
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        #endregion

        #region Operadores de comparacion

        public static bool operator ==(Dolar d, DolarBlue e)
        {
            if ((DolarBlue)d == e)
                return true;
            return false;
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            if ((Pesos)d == p)
                return true;
            return false;
        }

        public static bool operator ==(Dolar d, DolarCCL p)
        {
            if ((DolarCCL)d == p)
                return true;
            return false;
        }

        public static bool operator ==(Dolar d, DolarAhorro p)
        {
            if ((DolarAhorro)d == p)
                return true;
            return false;
        }

        public static bool operator ==(Dolar d, DolarTurista p)
        {
            if ((DolarTurista)d == p)
                return true;
            return false;
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            if (d1.GetCantidad() == d2.GetCantidad())
                return true;
            return false;
        }


        public static bool operator !=(Dolar d, DolarBlue e)
        {
            return !(d == e);
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
        public static bool operator !=(Dolar d, DolarCCL p)
        {
            return !(d == p);
        }

        public static bool operator !=(Dolar d, DolarAhorro p)
        {
            return !(d == p);
        }
        public static bool operator !=(Dolar d, DolarTurista p)
        {
            return !(d == p);
        }


        #endregion

        #region OPERADORES DE SUMA Y RESTA

        public static Dolar operator -(Dolar d, DolarBlue e)
        {
            return d.GetCantidad() - ((Dolar)e).GetCantidad();
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            return d.GetCantidad() - ((Dolar)p).GetCantidad();
        }
        public static Dolar operator -(Dolar d, DolarCCL p)
        {
            return d.GetCantidad() - ((Dolar)p).GetCantidad();
        }
        public static Dolar operator -(Dolar d, DolarAhorro p)
        {
            return d.GetCantidad() - ((Dolar)p).GetCantidad();
        }
        public static Dolar operator -(Dolar d, DolarTurista p)
        {
            return d.GetCantidad() - ((Dolar)p).GetCantidad();
        }

        public static Dolar operator +(Dolar d, DolarBlue e)
        {
            return d.GetCantidad() + ((Dolar)e).GetCantidad();
        }
        public static Dolar operator +(Dolar d, Pesos p)
        {
            return d.GetCantidad() + ((Dolar)p).GetCantidad();
        }
        public static Dolar operator +(Dolar d, DolarCCL e)
        {
            return d.GetCantidad() + ((Dolar)e).GetCantidad();
        }
        public static Dolar operator +(Dolar d, DolarAhorro e)
        {
            return d.GetCantidad() + ((Dolar)e).GetCantidad();
        }
        public static Dolar operator +(Dolar d, DolarTurista e)
        {
            return d.GetCantidad() + ((Dolar)e).GetCantidad();
        }

        #endregion

    }
}
