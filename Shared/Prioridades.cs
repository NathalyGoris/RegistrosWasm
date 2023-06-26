using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Prioridades
    {
        [Key]
        public int PrioridadId { get; set; }

        [Required (ErrorMessage = "El codigo de la prioridad es obligatorio")]
        public string? Codigo { get; set; }

        [Required(ErrorMessage = "Es obligatorio tener una descripcion")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Es obligatorio tener dias compromiso")]
        public int DiasCompromiso { get; set; }
    }