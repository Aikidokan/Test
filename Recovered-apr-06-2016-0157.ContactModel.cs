using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAF_web.Classes;

namespace UAF_web.Models
{
	public class ContactModel
	{
		[UmbracoDisplay("fullname"), UmbracoRequired("fullnamereq")]
		
		public string Name { get; set; }

		[UmbracoDisplay("email"), UmbracoRequired("reqemail")]
		public string Email { get; set; }

		[UmbracoDisplay("messagetext")]
        public string Comment { get; set; }
	}
}
