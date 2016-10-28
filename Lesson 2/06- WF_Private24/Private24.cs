using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06__WF_Private24
{
    public class ExchangeRate
    {
        public string baseCurrency { get; set; }
        public string currency { get; set; }
        public decimal saleRateNB { get; set; }
        public decimal purchaseRateNB { get; set; }
        public decimal saleRate { get; set; }
        public decimal purchaseRate { get; set; }
    }
    public class UserServices
    {
        public DateTime date { get; set; }
        public string bank { get; set; }
        public int baseCurrency { get; set; }
        public string baseCurrencyLit { get; set; }

        public List<ExchangeRate> exchangeRate { get; set; }
    }
    class Data
    {
        public UserServices Response { get; set; }
    }
    class Private24
    {
        public Thread Thrd;
        ListBox listbox;
        DateTime dStart;
        public Private24(ListBox lb,DateTime dt)
        {
            listbox = lb;
            dStart = dt;
            Thrd = new Thread(Run);
            Thrd.IsBackground = true;
            Thrd.CurrentCulture = CultureInfo.CreateSpecificCulture("uk-UA");
            Thrd.Start();//Начать Поток
        }
        void Run() {
            while (dStart<=DateTime.Now) {
                string strUrl = @"https://api.privatebank.ua/p24api/exhange_rates?json&date=" + dStart.ToShortDateString();

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strUrl);
                string answer = string.Empty;
                using (WebResponse response = request.GetResponse()) {
                    using (StreamReader rd = new StreamReader(response.GetResponseStream())) {
                        answer = rd.ReadToEnd();
                    }
                }
                var servicedata = JsonConvert.DeserializeObject<UserServices>(answer, new IsoDateTimeConverter { DateTimeFormat = "dd.MM.yyyy" });
                foreach (var item in servicedata.exchangeRate) {
                    if (item.currency=="USD") {
                        listbox.Items.Add(string.Format("Date - {0}, purchase - {1}", dStart.ToShortDateString(), item.purchaseRate));
                    }
                }
                Thread.Sleep(500);
               dStart = dStart.AddDays(1);
            }
        }
    }
}


strUrl	"https://api.privatebank.ua/p24api/exhangeretes?json&date=01.09.2016"	string
