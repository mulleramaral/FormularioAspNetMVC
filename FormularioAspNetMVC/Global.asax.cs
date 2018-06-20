using FormularioAspNetMVC.Binders;
using System.Web.Mvc;
using System.Web.Routing;

namespace FormularioAspNetMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ModelBinders.Binders.Add(typeof(decimal), new DecimalModelBinder());
        }
    }
}
