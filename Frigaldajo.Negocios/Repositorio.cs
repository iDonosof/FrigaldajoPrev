using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Frigaldajo.Negocios
{
    public class Repositorio
    {
        #region Campos
        private List<Alumnos> _alumnos = new List<Alumnos>();
        private List<Evento> _evento = new List<Evento>();
        private List<Docente> _docente = new List<Docente>();
        private List<Externo> _externos = new List<Externo>();
        private List<Alumnos> _alumnosExterno;
        #endregion

        #region Propiedades
        internal List<Alumnos> AlumnosExterno
        {
            get
            {
                if (_alumnosExterno == null)
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
                    _alumnosExterno.Add(new Alumnos()
                    {
                        Nombre = "Daniela",
                        Apellido = "Sepulveda",
                        Correo = "da.sepulvedag@alumnos.duoc.cl",
                        Edad = 22,
                        IdEvento = 1,
                        Jornada = "Diurna",
                        Rut = "19409356-k",
                        Telefono = 987654321
                    });
                }
                return _alumnosExterno;
            }
            set { _alumnosExterno = value; }
        }


        internal List<Externo> Externos
        {
            get { return _externos; }
            set { _externos = value; }
        }


        internal List<Docente> Docentes
        {
            get { return _docente; }
            set { _docente = value; }
        }


        internal List<Evento> Eventos
        {
            get { return _evento; }
            set { _evento = value; }
        }

        internal List<Alumnos> Alumnos
        {
            get { return _alumnos; }
            set { _alumnos = value; }
        }
        #endregion

        #region Alumnos
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
                if (alum != null && !Alumnos.Exists(a => alum.Rut == a.Rut))
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

        public bool UpdateAlumno(Alumnos alumno)
        {
            try
            {
                foreach (Alumnos a in Alumnos)
                {
                    if (a.Rut == alumno.Rut)
                    {
                        a.Nombre = alumno.Nombre;
                        a.Jornada = alumno.Jornada;
                        a.Telefono = alumno.Telefono;
                        a.Edad = alumno.Edad;
                        a.Correo = alumno.Correo;
                        a.Apellido = alumno.Apellido;
                        return true;
                    }
                }
                throw new Exception();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public Alumnos ReadAlumno(string rut)
        {
            try
            {
                foreach (Alumnos a in Alumnos)
                {
                    if (a.Rut == rut)
                    {
                        return a;
                    }
                }
                throw new Exception();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteAlumno(string rut)
        {
            try
            {
                foreach (Alumnos a in Alumnos)
                {
                    if (a.Rut == rut)
                    {
                        Alumnos.Remove(a);
                        return true;
                    }
                }
                throw new Exception();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        #endregion

        #region Docente
        public bool InsertDocente(Docente docente)
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

        public bool UpdateDocente(Docente docente)
        {
            try
            {
                foreach (Docente d in Docentes)
                {
                    if (d.Rut == docente.Rut)
                    {
                        d.Edad = docente.Edad;
                        d.Nombre = docente.Nombre;
                        d.Telefono = docente.Telefono;
                        return true;
                    }
                }
                throw new Exception();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public Docente ReadDocente(string rut)
        {
            try
            {
                foreach (Docente d in Docentes)
                {
                    if (d.Rut == rut)
                    {
                        return d;
                    }
                }
                throw new Exception();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteDocente(string rut)
        {
            try
            {
                foreach (Docente d in Docentes)
                {
                    if (d.Rut == rut)
                    {
                        Docentes.Remove(d);
                        return true;
                    }
                }
                throw new Exception();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        #endregion

        #region Externo
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

        public bool UpdateExterno(Externo externo)
        {
            try
            {
                foreach (Externo e in Externos)
                {
                    if (e.Rut == externo.Rut)
                    {
                        e.Correo = externo.Correo;
                        e.Edad = externo.Edad;
                        e.Nombre = externo.Nombre;
                        e.Telefono = externo.Telefono;
                        return true;
                    }
                }
                throw new Exception();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public Externo ReadExterno(string rut)
        {
            try
            {
                foreach (Externo e in Externos)
                {
                    if (e.Rut == rut)
                    {
                        return e;
                    }
                }
                throw new Exception();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteExterno(string rut)
        {
            try
            {
                foreach (Externo e in Externos)
                {
                    if (e.Rut == rut)
                    {
                        Externos.Remove(e);
                        return true;
                    }
                }
                throw new Exception();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        #endregion

        #region Evento
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

        public bool UpdateEvento(Evento evento)
        {
            try
            {
                foreach (Evento e in Eventos)
                {
                    if (e.IdEvento == evento.IdEvento)
                    {
                        e.NombreEvento = evento.NombreEvento;
                        e.Encargado = evento.Encargado;
                        e.EscuelaArea = evento.EscuelaArea;
                        e.FechaInicio = evento.FechaInicio;
                        e.FechaTermino = evento.FechaTermino;
                        e.HoraInicio = evento.HoraInicio;
                        e.HoraTermino = evento.HoraTermino;
                        return true;
                    }
                }
                throw new Exception();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public Evento ReadEvento(int idEvento)
        {
            try
            {
                foreach (Evento e in Eventos)
                {
                    if (e.IdEvento == idEvento)
                    {
                        return e;
                    }
                }
                throw new Exception();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteEvento(int idEvento)
        {
            try
            {
                foreach (Evento e in Eventos)
                {
                    if (e.IdEvento == idEvento)
                    {
                        Eventos.Remove(e);
                    }
                }
                throw new Exception();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<Evento> GetListaEventos()
        {
            try
            {
                return Eventos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
