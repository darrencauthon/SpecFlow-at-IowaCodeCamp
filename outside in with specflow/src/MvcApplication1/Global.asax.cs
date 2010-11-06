using System.Web;
using MvcTurbine.ComponentModel;
using MvcTurbine.Unity;
using MvcTurbine.Web;

namespace MvcApplication1
{
    public class MvcApplication : TurbineApplication
    {
        public MvcApplication()
        {
            ServiceLocatorManager.SetLocatorProvider(() => new UnityServiceLocator());
        }
    }
}