using System.ComponentModel.DataAnnotations.Schema;

namespace Practica4.Models
{
    public class Fail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }
        
        [Column("Nombre")]
        public string Nombre {get;set;}

        [Column("Foto")]
        public string Foto {get;set;}

        [Column("Usuario")]
        public string NombreUsuario {get;set;}

        [Column("mensajes")]
        public string Mensajes{get;set;}

        [Column("Fecha")]
        public string Fecha{get;set;}
    }
}