using System;
using System.Collections.Generic;
using System.Text;

namespace ABM_Facultad_CapaDatos
{
    public class Salario
    {
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuentos;
        private DateTime _fechaPago;

        public Salario(double bruto, DateTime fechaPago)
        {
            long fechaDecimal = fechaPago.Ticks;
            TimeSpan fecha = new TimeSpan(fechaDecimal);
            this._bruto = bruto;
            this._descuentos = bruto * 0.17;
            this._codigoTransferencia = fecha.Days.ToString();
            this._fechaPago = fechaPago;
        }

        public double Descuentos
        {
            get
            {
                return this._descuentos;
            }
            set
            {
                this._descuentos = value;
            }
        }

        public string CodigoTransferencia
        {
            get
            {
                return this._codigoTransferencia;
            }
            set
            {
                this._codigoTransferencia = value;
            }
        }

        public double Bruto
        {
            get
            {
                return this._bruto;
            }
            set
            {
                this._bruto = value;
            }
        }

        public DateTime FechaPago
        {
            get
            {
                return this._fechaPago;
            }
            set
            {
                this._fechaPago = value;
            }
        }

        public double GetSalarioNeto()
        {
            return this._bruto - this._descuentos;
        }
    }
}
