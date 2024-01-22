using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Log4NetExample
{
    class Program
    {
        private static ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            logger.Info("Hello log4net!");
            logger.Error("Error", new Exception("發生錯誤"));

            log4net.NDC.Push("MyContext");
            logger.Info("This is a log message with NDC context.");
            log4net.NDC.Pop();

            var list = new List<Thread>();

            for (int i = 0; i < 10; i++)
            {
                var th = new Thread(() =>
                {
                    Get();
                });
                th.Start();
                list.Add(th);
            }
            list.ForEach(a => a.Join());
        }

        static string Get()
        {
            using (log4net.NDC.Push(Guid.NewGuid().ToString()))
            {
                logger.Debug("Start of service test");
                //System.Threading.Thread.Sleep(5000); // simulate work
                Random r = new Random();
                int seconds = r.Next(0, 1000);
                logger.Debug(string.Format("Sleep {0} milliseconds", seconds));
                Thread.Sleep(seconds);
                logger.Debug("End of service test");
                return "HypervResource controller running, use POST to send JSON encoded RPCs";
            }
        }
    }
}
