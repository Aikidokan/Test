using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;
using UAF_web.Classes;
using UAF_web.Models;

namespace UAF_web.Controllers
{
	public class ContactController:BaseController
	{
		[HttpPost]
		public ActionResult CreateComment(ContactModel model)
		{
			//model not valid, do not save, but return current Umbraco page
			if (!ModelState.IsValid)
			{
				//Perhaps you might want to add a custom message to the ViewBag
				//which will be available on the View when it renders (since we're not 
				//redirecting)          
				return CurrentUmbracoPage();
			}
			var contactRecipientEmail =UAFHelpers.GetAppSetting<string>("ContactRecipientEmail");
			EmailGateway.SendMail(model.Email,
					   contactRecipientEmail, Umbraco.GetDictionaryValue("contactformsubject"),
					   string.Format(Umbraco.GetDictionaryValue("contactformbody"), model.Name, model.Email,model.Comment), true);
			TempData.Add("CustomMessage",Umbraco.GetDictionaryValue("contactformsubject"));

		//redirect to current page to clear the form
			return RedirectToCurrentUmbracoPage();
		}
	}
}
