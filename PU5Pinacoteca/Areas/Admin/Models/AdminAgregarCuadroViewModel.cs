﻿namespace PU5Pinacoteca.Areas.Admin.Models
{
    public class AdminAgregarCuadroViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public IEnumerable<AdminPintorModel>? Pintores { get; set; }
        public int AñoPintado { get; set; }
        public string Tecnica { get; set; } = null!;
        public string Dimensiones { get; set; } = null!;
        public IEnumerable<AdminColeccionModel>? Colecciones { get; set; }
        public string Descripcion { get; set; } = null!;
        public IFormFile? Archivo { get; set; }
        public int IdPintor { get; set; }
        public int IdColeccion { get; set; }
    }
    public class AdminPintorModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

    }
    public class AdminColeccionModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
    }
}
