using System;
using System.Collections.Generic;
using System.Text;

namespace Frigaldajo.Negocios
{
    public class Encuestas
    {
        private int _idEncuesta;
        private int _totalAsistentes;
        private int _totalExternos;
        private int _totalDocentes;
        private int _edadPromedio;
        private int _totalDiurnos;
        private int _totalVespertinos;

        public int TotalVespertinos
        {
            get { return _totalVespertinos; }
            set { _totalVespertinos = value; }
        }


        public int TotalDiurnos
        {
            get { return _totalDiurnos; }
            set { _totalDiurnos = value; }
        }


        public int EdadPromedio
        {
            get { return _edadPromedio; }
            set { _edadPromedio = value; }
        }


        public int TotalDocentes
        {
            get { return _totalDocentes; }
            set { _totalDocentes = value; }
        }


        public int TotalExternos
        {
            get { return _totalExternos; }
            set { _totalExternos = value; }
        }


        public int TotalAsistentes
        {
            get { return _totalAsistentes; }
            set { _totalAsistentes = value; }
        }


        public int IdEncuesta
        {
            get { return _idEncuesta; }
            set { _idEncuesta = value; }
        }

    }
}
