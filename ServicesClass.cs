using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;
//todo добавить ожидание завершение методов

namespace WindowsFormsAPP
{
    class ServicesClass
    {
        /// <summary>
        /// Возвращает коллекцию SQL служб.
        /// </summary>
        /// <returns></returns>
        internal static IEnumerable<ServiceController> GetSQLServices()
        {
            ServiceController[] Services = ServiceController.GetServices();
            return Services.Where(x => x.ServiceName.Contains("SQL"));
        }
        ///<summary>
        ///Метод получает коллекцию служб и отключает их.
        ///</summary>
        internal void StopServicesMethod(IEnumerable<ServiceController> CollectionServices)
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
        internal void StartServicesMethod(IEnumerable<ServiceController> CollectionServices)
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
