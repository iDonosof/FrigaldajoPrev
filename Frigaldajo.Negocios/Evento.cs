using System;
using System.Collections.Generic;
using System.Text;

namespace Frigaldajo.Negocios
{
    public class Evento
    {
        #region Campos
        private int _idEvento;
        private string _nombreEvento;
        private string __encargado;
        private string _escuelaArea;
        private DateTime _fechaInicio;
        private DateTime _fechaTermino;
        private DateTime _horaInicio;
        private DateTime _horaTermino;
        #endregion

        #region Propiedades
        public DateTime HoraTermino
        {
            get { return _horaTermino; }
            set { _horaTermino = value; }
        }

        public int IdEvento
        {
            get { return _idEvento; }
            set { _idEvento = value; }
        }

        public string NombreEvento
        {
            get { return _nombreEvento; }
            set { _nombreEvento = value; }
        }

        public string Encargado
        {
            get { return __encargado; }
            set { __encargado = value; }
        }

        public string EscuelaArea
        {
            get { return _escuelaArea; }
            set { _escuelaArea = value; }
        }

        public DateTime FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }

        public DateTime FechaTermino
        {
            get { return _fechaTermino; }
            set { _fechaTermino = value; }
        }

        public DateTime HoraInicio
        {
            get { return _horaInicio; }
            set { _horaInicio = value; }
        }
        #endregion

        #region Constructor e Inicializador
        public Evento()
        {
            Init();
        }

        private void Init()
        {
            IdEvento = 0;
            NombreEvento = string.Empty;
            Encargado = string.Empty;
            EscuelaArea = string.Empty;
            FechaInicio = DateTime.Now;
            FechaTermino = DateTime.Now;
            HoraInicio = DateTime.Now;
            HoraTermino = DateTime.Now;
        }
        #endregion

        #region Metodos

        #endregion
    }
}
