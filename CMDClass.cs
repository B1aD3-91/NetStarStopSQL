using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAPP
{
    class CMDClass
    {
        ///<summary>
        ///Метод запускает процесс CMD и отключает процессы SQL.
        ///</summary>
        internal static void offMethod()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                //CreateNoWindow = true,
                //UseShellExecute = false,
                Verb = "runas",
                Arguments = @"/c net stop MSSQL$SQLEXPRESS /y 
                              && 
                                net stop MSSQLFDLauncher$SQLEXPRESS
                              &&
                                net stop SQLTELEMETRY$SQLEXPRESS
                              &&
                                net stop SQLWriter
                              &&
                                net stop MSSQLLaunchpad$SQLEXPRESS"
            });
        }
        /// <summary>
        /// Метод запускает процесс CMD и включает процессы SQL.
        /// </summary>
        internal static void onMethod()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                CreateNoWindow = true,
                //UseShellExecute = false,
                Verb = "runas",
                Arguments = @"/c net start MSSQL$SQLEXPRESS
                              &&
                                net start MSSQLFDLauncher$SQLEXPRESS
                              &&
                                net start SQLTELEMETRY$SQLEXPRESS
                              &&
                                net start SQLWriter
                              &&
                                net start MSSQLLaunchpad$SQLEXPRESS"
            });
        }
    }
}
