using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Journal
{
    public static class JournalTester
    {
        public static void Test()
        {
            try
            {
                DateTime christmas = new DateTime(2025, 12, 25);
                DateTime boxingDay = christmas.AddDays(1.0);
                Entry first = new Entry(christmas, "Merry Christmas!");
                Entry second = new Entry(boxingDay, "Premier league");
                Journal captainsLog = new Journal();
                captainsLog.Save(first);
                String password = "password";
                PrivateJournal doctorsLog = new PrivateJournal();
                doctorsLog.Authenticate(password);
                doctorsLog.Save(first);
                doctorsLog.Save(second);
                doctorsLog.Find(christmas).ToList().ForEach(s => Console.WriteLine(s));
            }
            catch (AccessViolationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
