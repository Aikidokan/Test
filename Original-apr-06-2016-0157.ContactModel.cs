using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAF_web.Models
{
	public class ContactModel
	{
		[Required(ErrorMessage = "Namn är obligatoriskt")]
		[Display(Name = "Namn")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Epost är obligatoriskt")]
		[EmailAddress(ErrorMessage = "Ej giltig epostaddress")]
		[Display(Name = "E-post")]
		public string Email { get; set; }

		[Display(Name = "Fritext")]
		public string Comment { get; set; }
	}
}
