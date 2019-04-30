using System;
using System.Collections.Generic;
using System.Text;

namespace Frigaldajo.Negocios
{
    public class Externo
    {
        #region Campos
        private string _rut;
        private string _nombre;
        private long _telefono;
        private string _correo;
        private int _edad; 
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
        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        } 
        #endregion

        #region Constructor e Inicializador
        public Externo()
        {
            Init();
        }

        private void Init()
        {
            Rut = string.Empty;
            Nombre = string.Empty;
            Telefono = 0;
            Correo = string.Empty;
            Edad = 0;
        } 
        #endregion

        #region Metodos

        #endregion
    }
}
