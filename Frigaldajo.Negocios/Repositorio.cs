using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Frigaldajo.Negocios
{
    public class Repositorio
    {
        private List<Alumnos> _alumnos;
        private List<Evento> _evento;
        private List<Docente> _docente;
        private List<Externo> _externos;
        private List<Alumnos> _alumnosExterno;

        internal List<Alumnos> AlumnosExterno
        {
            get
            { 
                if(_alumnosExterno == null)
                {
                    _alumnosExterno = new List<Alumnos>();
                    _alumnosExterno.Add(new Alumnos()
                    {
                        Nombre = "Ignacio",
                        Apellido = "Donoso",
                        Correo = "naxonicolas1997@gmail.com",
                        Edad = 20,
                        IdEvento = 1,
                        Jornada = "Diurna",
                        Rut = "19845227-0",
                        Telefono = 123456789
                    });
                }
                return _alumnosExterno;
            }
            set { _alumnosExterno = value; }
        }


        internal List<Externo> Externos
        {
            get { return _externos == null? new List<Externo>() : _externos; }
            set { _externos = value; }
        }


        internal List<Docente> Docentes
        {
            get { return _docente == null? new List<Docente>() : _docente; }
            set { _docente = value; }
        }


        internal List<Evento> Eventos
        {
            get { return _evento == null? new List<Evento>() : _evento; }
            set { _evento = value; }
        }

        internal List<Alumnos>  Alumnos
        {
            get { return _alumnos == null? new List<Alumnos>() : _alumnos; }
            set { _alumnos = value; }
        }

        public bool InsertAlumno(string rut)
        {
            try
            {
                Alumnos alum = (from al in AlumnosExterno
                                where al.Rut == rut
                                select new Alumnos
                                {
                                    Nombre = al.Nombre,
                                    Apellido = al.Apellido,
                                    Correo = al.Correo,
                                    Edad = al.Edad,
                                    IdEvento = 1,
                                    Jornada = al.Jornada,
                                    Rut = al.Rut,
                                    Telefono = al.Telefono
                                }).First();
                if(alum != null)
                    Alumnos.Add(alum);
                else
                    throw new Exception();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool InsertDocente (Docente docente)
        {
            try
            {
                Docentes.Add(docente);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool InsertExterno(Externo externo)
        {
            try
            {
                Externos.Add(externo);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool InsertEvento(Evento evento)
        {
            try
            {
                Eventos.Add(evento);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<Alumnos> GetAlumnos()
        {
            try
            {
                return Alumnos;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
