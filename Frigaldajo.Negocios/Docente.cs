using System;
using System.Collections.Generic;
using System.Text;

namespace Frigaldajo.Negocios
{
    public class Docente
    {
        #region Campos
        private string _rut;
        private string _nombre;
        private long _telefono;
        private int _edad;
        private Evento _idEvento;
        #endregion

        #region Propiedades
        public string Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public long Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }
        public Evento IdEvento
        {
            get { return _idEvento; }
            set { _idEvento = value; }
        }
        #endregion

        #region Constructor e Inicializador
        public Docente()
        {
            Init();
        }

        private void Init()
        {
            Rut = string.Empty;
            Nombre = string.Empty;
            Telefono = 0;
            Edad = 0;
        }
        #endregion

        #region Metodos

        #endregion
    }
}
