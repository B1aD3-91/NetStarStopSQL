using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;


namespace WindowsFormsAPP
{
    class ServicesClass
    { 
        internal static string errorMessage = null;
        //internal static ServiceController ServiceMNG = new ServiceController();
        ///<summary>
        ///Метод отключает службы SQL.
        ///</summary>
        internal static void offMethod()
        {
            ServiceController[] Services = ServiceController.GetServices();
            var list = Services.Where(x => x.ServiceName.Contains("SQL"));

            foreach (var item in list)
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
        /// Метод включает процессы SQL.
        /// </summary>
        internal static void onMethod()
        {
            ServiceController[] Services = ServiceController.GetServices();
            var list = Services.Where(x => x.ServiceName.Contains("SQL"));

            foreach (var item in list)
            {
                if (item.StartType != ServiceStartMode.Disabled && item.Status != ServiceControllerStatus.Running)
                {
                    item.Start();
                }
            }
        }
    }
}
