using System;
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
        internal static IEnumerable<ServiceController> GetSQLServices(string s) // Get SQL Services
        {
            ServiceController[] Services = ServiceController.GetServices();
            return Services.Where(x => x.ServiceName.Contains(s));
        }
        ///<summary>
        ///Метод получает коллекцию служб и отключает их.
        ///</summary>
        internal string StopServicesMethod(IEnumerable<ServiceController> CollectionServices) //Get Services and stops them
        {
            string ErrorMessage = null;
            foreach (var item in CollectionServices)
            {
                if (item.CanStop && item.Status == ServiceControllerStatus.Running)
                {
                    try
                    {
                        item.Stop();
                    }
                    catch(Exception ex)
                    {
                        ErrorMessage = ex.Message;
                    }
                }
            }
            return ErrorMessage;
        }
        /// <summary>
        /// Метод получает коллекцию служб и включает их
        /// </summary>
        internal string StartServicesMethod(IEnumerable<ServiceController> CollectionServices) //Get Services and starts them
        {
            string ErrorMessage = null;
            foreach (var item in CollectionServices)
            {
                if (item.StartType != ServiceStartMode.Disabled && item.Status != ServiceControllerStatus.Running)
                {
                    try
                    {
                        item.Start();
                    }
                    catch(Exception ex)
                    {
                        ErrorMessage = ex.Message;
                    }
                }
            }
            return ErrorMessage;
        }
    }
}
