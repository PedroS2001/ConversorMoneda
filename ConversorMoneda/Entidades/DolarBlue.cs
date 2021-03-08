using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoneda
{
    public class DolarBlue
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        #region Constructor

        private DolarBlue()
        {
            DolarBlue.SetCotizacion(cotizRespectoDolar);
        }

        public DolarBlue(double cantidad) :
            this()
        {
            this.cantidad = cantidad;
        }
        public DolarBlue(double cantidad, double cotizacion) :
            this(cantidad)
        {
            DolarBlue.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos
        public static double GetCotizacion()
        {
            return DolarBlue.cotizRespectoDolar;
        }

        public static void SetCotizacion(double num)
        {
            DolarBlue.cotizRespectoDolar = num;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region Operadores explicitos
        public static explicit operator Dolar(DolarBlue e)
        {
            double cant = e.GetCantidad() * DolarBlue.GetCotizacion();
            return new Dolar(cant);
        }

        public static explicit operator Pesos(DolarBlue e)
        {
            Dolar d = (Dolar)e;

            return (Pesos)d;
        }
        public static explicit operator DolarCCL(DolarBlue e)
        {
            Dolar d = (Dolar)e;

            return (DolarCCL)d;
        }
        public static explicit operator DolarAhorro(DolarBlue e)
        {
            Dolar d = (Dolar)e;

            return (DolarAhorro)d;
        }
        public static explicit operator DolarTurista(DolarBlue e)
        {
            Dolar d = (Dolar)e;

            return (DolarTurista)d;
        }

        public static implicit operator DolarBlue(double d)
        {
            return new DolarBlue(d);
        }

        #endregion

        #region Operadores de comparacion

        public static bool operator ==(DolarBlue e, Dolar d)
        {
            if ((Dolar)e == d)
                return true;
            return false;
        }

        public static bool operator ==(DolarBlue e, Pesos p)
        {
            if ((Pesos)e == p)
                return true;
            return false;
        }
        public static bool operator ==(DolarBlue e, DolarCCL p)
        {
            if ((DolarCCL)e == p)
                return true;
            return false;
        }
        public static bool operator ==(DolarBlue e, DolarAhorro p)
        {
            if ((DolarAhorro)e == p)
                return true;
            return false;
        }
        public static bool operator ==(DolarBlue e, DolarTurista p)
        {
            if ((DolarTurista)e == p)
                return true;
            return false;
        }
        public static bool operator ==(DolarBlue e1, DolarBlue e2)
        {
            if (e1.GetCantidad() == e2.GetCantidad())
                return true;
            return false;
        }


        public static bool operator !=(DolarBlue e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator !=(DolarBlue e, Pesos p)
        {
            return !(e == p);
        }
        public static bool operator !=(DolarBlue e, DolarCCL d)
        {
            return !(e == d);
        }
        public static bool operator !=(DolarBlue e, DolarAhorro d)
        {
            return !(e == d);
        }
        public static bool operator !=(DolarBlue e, DolarTurista d)
        {
            return !(e == d);
        }

        public static bool operator !=(DolarBlue e1, DolarBlue e2)
        {
            return !(e1 == e2);
        }


        #endregion

        #region Operadores de Suma Y resta

        public static DolarBlue operator -(DolarBlue e, Dolar d)
        {
            return e.GetCantidad() - ((DolarBlue)d).GetCantidad();
        }

        public static DolarBlue operator -(DolarBlue e, Pesos p)
        {
            return e.GetCantidad() - ((DolarBlue)p).GetCantidad();
        }
        public static DolarBlue operator -(DolarBlue e, DolarCCL p)
        {
            return e.GetCantidad() - ((DolarBlue)p).GetCantidad();
        }
        public static DolarBlue operator -(DolarBlue e, DolarAhorro p)
        {
            return e.GetCantidad() - ((DolarBlue)p).GetCantidad();
        }
        public static DolarBlue operator -(DolarBlue e, DolarTurista p)
        {
            return e.GetCantidad() - ((DolarBlue)p).GetCantidad();
        }

        public static DolarBlue operator +(DolarBlue e, Dolar d)
        {
            return e.GetCantidad() + ((DolarBlue)d).GetCantidad();
        }
        public static DolarBlue operator +(DolarBlue e, Pesos p)
        {
            return e.GetCantidad() + ((DolarBlue)p).GetCantidad();
        }
        public static DolarBlue operator +(DolarBlue e, DolarCCL p)
        {
            return e.GetCantidad() + ((DolarBlue)p).GetCantidad();
        }
        public static DolarBlue operator +(DolarBlue e, DolarAhorro p)
        {
            return e.GetCantidad() + ((DolarBlue)p).GetCantidad();
        }
        public static DolarBlue operator +(DolarBlue e, DolarTurista p)
        {
            return e.GetCantidad() + ((DolarBlue)p).GetCantidad();
        }

        #endregion

    }
}
