using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;

namespace WindowsFormsAPP
{
    class ServicesClass
    {
        /// <summary>
        /// Возвращает коллекцию SQL служб.
        /// </summary>
        /// <returns>(Collection)ServiceController</returns>
        internal static IEnumerable<ServiceController> GetSQLServices() // Get SQL Services
        {
            ServiceController[] Services = ServiceController.GetServices();
            return Services.Where(x => x.ServiceName.Contains("SQL"));
        }
        ///<summary>
        ///Метод получает коллекцию служб и отключает их.
        ///</summary>
        internal void StopServicesMethod(IEnumerable<ServiceController> CollectionServices) //Get Services and stops them
        {
            foreach (var item in GetSQLServices())
            {
                if (item.CanStop && item.Status == ServiceControllerStatus.Running)
                {
                    try
                    {
                        item.Stop();
                    }
                    catch
                    {

                    }
                }
            }
        }
        /// <summary>
        /// Метод получает коллекцию служб и включает их
        /// </summary>
        internal void StartServicesMethod(IEnumerable<ServiceController> CollectionServices) //Get Services and starts them
        {
            foreach (var item in GetSQLServices())
            {
                if (item.StartType != ServiceStartMode.Disabled && item.Status != ServiceControllerStatus.Running)
                {
                    try
                    {
                        item.Start();
                    }
                    catch
                    {

                    }

                }
            }
        }
    }
}
