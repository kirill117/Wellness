using Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebHost.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public JsonResult GetRecall(string name, string phone, string email, string comment, string subcomment, string textbody)
        {
            var result = false;
            var user = ConfigurationManager.AppSettings["MailUserTarget"];
            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(name) && (!string.IsNullOrEmpty(phone) || !string.IsNullOrEmpty(email)))
            {
                var body = new StringBuilder();
                body.AppendLine("Форма обратной связи RussiaWellness.ru");
                body.AppendLine("");
                body.AppendLine("Имя клиента: " + name.Trim());
                body.AppendLine("Тел.: " + phone.Trim());
                if (!string.IsNullOrEmpty(email))
                {
                    body.AppendLine("Email: " + email.Trim());
                }
                if (!string.IsNullOrEmpty(subcomment))
                {
                    body.AppendLine("");
                    body.AppendLine(subcomment.Trim());
                }
                if (!string.IsNullOrEmpty(textbody))
                {
                    body.AppendLine("");
                    body.AppendLine(textbody.Trim());
                    body.AppendLine("");
                }
                if (!string.IsNullOrEmpty(comment))
                {
                    body.AppendLine("Комментарий:");
                    body.AppendLine(comment.Trim());
                }

                result = EmailHelper.SendMail(user, body.ToString(), "Сообщение с сайта RussiaWellness.ru");
            }
            return Json(result);
        }
    }
}