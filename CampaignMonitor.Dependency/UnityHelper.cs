using CampaignMonitor.Business;
using CampaignMonitor.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignMonitor.Dependency
{
    static public class UnityHelper
    {
        private static IUnityContainer _container;

        public static IUnityContainer Container
        {
            get
            {
                if (_container == null)
                {
                    _container = new UnityContainer();

                    ConfigureContainer(_container);
                }
                return _container;
            }
        }

        private static void ConfigureContainer(IUnityContainer container)
        {
            container.RegisterType<IDotNetManager, DotNetManager>();
            
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}
