using System;
using System.Globalization;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var data = new DateTime();
            var now = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(now);

            var date2 = new DateTime(2021, 12, 20, 23, 45, 20);
            Console.WriteLine(date2);

            Console.WriteLine(date2.Year);
            Console.WriteLine(date2.Month);
            Console.WriteLine(date2.Day);
            Console.WriteLine(date2.Hour);
            Console.WriteLine(date2.Minute);
            Console.WriteLine(date2.Second);

            Console.WriteLine(date2.DayOfWeek);
            Console.WriteLine(date2.DayOfYear);

            //Formatando Datas
            var data3 = DateTime.Now;
            var formatada = string.Format("{0:yyyy/MM/dd hh:mm:ss zzz}", data3);
            var formatada2 = string.Format("{0:d}", data3);
            var formatada3 = string.Format("{0:s}", data3); // muito utilizado no json
            Console.WriteLine(formatada);
            Console.WriteLine(formatada2);

            //Adicionando Valores as Datas
            var data4 = DateTime.Now;
            Console.WriteLine(data4);
            Console.WriteLine(data4.AddDays(12));
            Console.WriteLine(data4.AddMonths(1));
            Console.WriteLine(data4.AddYears(1));
            Console.WriteLine(data4.AddHours(4));

            //Comparando Datas
            var data5 = DateTime.Now;
            if (data5.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É iGUAL");
            }

            //Culture Info
            Console.Clear();
            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now.ToString("D", atual));

            //Timezone
            Console.Clear();
            var utcDate = DateTime.UtcNow;
            Console.WriteLine(utcDate);
            Console.WriteLine(utcDate.ToLocalTime()); // converte uma data UTC (imagina por exemplo do banco de dados) para a hora do servidor.

            //
            foreach (var timezone in TimeZoneInfo.GetSystemTimeZones())
            {
                Console.WriteLine(timezone.Id);
            }

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("New Zealand Standard Time");
            Console.WriteLine(timezoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
            Console.WriteLine(horaAustralia);

            //TimeSpan
            Console.Clear();
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var nanoSegundos = new TimeSpan(1);
            Console.WriteLine(nanoSegundos);

            var horaMinutoSegundo = new TimeSpan(6, 14, 15);
            Console.WriteLine(horaMinutoSegundo);

            var diaHoraMinutoSegundo = new TimeSpan(2, 6, 14, 15);
            Console.WriteLine(diaHoraMinutoSegundo);

            var diaHoraMinutoSegundoMilisegundo = new TimeSpan(2, 6, 14, 15, 44);
            Console.WriteLine(diaHoraMinutoSegundoMilisegundo);
        }
    }
}
