using System;
using System.Collections.Generic;
using System.Text;

namespace Frigaldajo.Negocios
{
    public class Alumnos
    {
        #region Campos
        private string _rut;
        private string _nombre;
        private string _apellido;
        private long _telefono;
        private string _correo;
        private int _edad;
        private string _jornada;
        private int _idEvento;
        #endregion
        //
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
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
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
        public string Jornada
        {
            get { return _jornada; }
            set { _jornada = value; }
        }
        public int IdEvento
        {
            get { return _idEvento; }
            set { _idEvento = value; }
        }
        #endregion
        //
        #region Contructor E Inicializador
        public Alumnos()
        {
            Init();
        }

        private void Init()
        {
            Rut = string.Empty;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Telefono = 0;
            Correo = string.Empty;
            Edad = 0;
            Jornada = string.Empty;
        }
        #endregion
        //
        #region Metodos

        #endregion
    }
}
