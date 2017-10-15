using System.IO;
using System.Web.Mvc;

namespace FilterAndLog.Models
{
    public class LogFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var controllerAdi = filterContext.ActionDescriptor.ControllerDescriptor
                .ControllerName;
            var actionAdi = filterContext.ActionDescriptor.ActionName;
            var ipAddress = filterContext.HttpContext.Request.UserHostAddress;
            var tarih = filterContext.HttpContext.Timestamp;

            var message = string.Format("Controller : {0}, Action: {1} , IP {2} , Date : {3} ", controllerAdi, actionAdi, ipAddress, tarih);
            Log(message);
            base.OnActionExecuted(filterContext);   
        }

        private void Log(string message)
        {
            var sw = new StreamWriter("Loglar.txt",true);

            sw.WriteLine(message);
            sw.Close();
        }
    }
}