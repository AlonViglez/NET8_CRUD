//ARCHIVO DE CONTEXTO
using CrudNet8MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudNet8MVC.Datos
{
    public class ApplicationDbContext: DbContext
    {
        //Crear constructor (metodo especial carga la clase sin ser invocado )
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        //Agregar los modelos aqui
        public DbSet<Contacto> Contacto { get; set; }
    }
}
