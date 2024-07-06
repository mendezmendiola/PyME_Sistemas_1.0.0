using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Periodo
{
    public class ClsPeriodo
    {
        #region Atributos privados
        private int _IDPeriodo;
        private string _Periodo;
        private DateTime _FechaInicioPeriodo;
        private DateTime _FechaFinalPeriodo;
        private bool _EstadoPeriodo;
        private DateTime _FechaInicioContabilidad;
        private DateTime _FechaInicioVencimiento;
        private DateTime _FechaFinalContabilidad;
        private DateTime _FechaFinalVencimiento;
        private DateTime _FechaCreacion;
        #endregion

        //Atributos de manejo de Base de Datos.
        private string _mensajeError, _valorScalar;
        private DataTable _dtResultados;


        #region Atributos Publicos
        public int IDPeriodo { get => _IDPeriodo; set => _IDPeriodo = value; }
        public string Periodo { get => _Periodo; set => _Periodo = value; }
        public DateTime FechaInicioPeriodo { get => _FechaInicioPeriodo; set => _FechaInicioPeriodo = value; }
        public DateTime FechaFinalPeriodo { get => _FechaFinalPeriodo; set => _FechaFinalPeriodo = value; }
        public bool EstadoPeriodo { get => _EstadoPeriodo; set => _EstadoPeriodo = value; }
        public DateTime FechaInicioContabilidad { get => _FechaInicioContabilidad; set => _FechaInicioContabilidad = value; }
        public DateTime FechaInicioVencimiento { get => _FechaInicioVencimiento; set => _FechaInicioVencimiento = value; }
        public DateTime FechaFinalContabilidad { get => _FechaFinalContabilidad; set => _FechaFinalContabilidad = value; }
        public DateTime FechaFinalVencimiento { get => _FechaFinalVencimiento; set => _FechaFinalVencimiento = value; }
        public DateTime FechaCreacion { get => _FechaCreacion; set => _FechaCreacion = value; }
        public string MensajeError { get => _mensajeError; set => _mensajeError = value; }
        public string ValorScalar { get => _valorScalar; set => _valorScalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion
    }
}
