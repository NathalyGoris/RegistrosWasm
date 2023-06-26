using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

	public class Tickets
	{
		[Key]
		public int TicketId { get; set; }

		[Required (ErrorMessage = "El campo fecha es obligatorio")]
		public DateOnly Fecha { get; set;}

		[Required (ErrorMessage = "El campo ClienteId obligatorio")]
		public int ClienteId { get; set; }

		[Required (ErrorMessage = "El sistemaId es obligatorio")]
		public int SistemaId { get; set; }
		
		[Required (ErrorMessage = "Este campo es obligatorio.")]
		public string? SolicitadoPor { get; set; }

		[Required (ErrorMessage = "Este campo es obligatorio.")]
		public string?  Asunto { get; set; }

		[Required (ErrorMessage = "Este campo es obligatorio.")]	
		public string?  Descripcion { get; set; }
	}