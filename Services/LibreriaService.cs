using System;
using System.Collections.Generic;
using System.Linq;
using libreria.Models;

namespace libreria.Services
{
    public class LibroService
    {
        private List<Libro> _libros;

        public LibroService()
        {
            _libros = new List<Libro>();
        }

        public IEnumerable<Libro> GetAllLibros()
        {
            return _libros ?? Enumerable.Empty<Libro>();
        }

        public Libro GetLibroById(Guid libroId)
        {
            return _libros.SingleOrDefault(l => l.LibroId == libroId);
        }

        public void CreateLibro(Libro libro)
        {
            libro.LibroId = Guid.NewGuid();
            _libros.Add(libro);
        }

        public void UpdateLibro(Guid libroId, Libro libro)
        {
            var existingLibro = _libros.SingleOrDefault(l => l.LibroId == libroId);

            if (existingLibro != null)
            {
                existingLibro.nombre = libro.nombre;
                existingLibro.Edicion = libro.Edicion;
                existingLibro.Paginas = libro.Paginas;
                existingLibro.AutorId = libro.AutorId;
                existingLibro.Genero = libro.Genero;
            }
        }

        public void DeleteLibro(Guid libroId)
        {
            var libro = _libros.SingleOrDefault(l => l.LibroId == libroId);

            if (libro != null)
            {
                _libros.Remove(libro);
            }
        }
    }
}