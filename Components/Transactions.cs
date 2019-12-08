using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Budget.Components
{    
    public class Transactions
    {
        public List<Transaction> List { get; set; }

        public Transactions() => List = new List<Transaction>();

        public Transactions(ISyncLocalStorageService service, string key)
        {
            Transactions exist = service.GetItem<Transactions>(key);
            List = exist is null ? new Transactions().List : exist.List;
        }

        public void Save(ISyncLocalStorageService service, string key)
        {
            List.RemoveAll(t => t.Category == "");
            service.SetItem(key, this);
        }

        public Transactions Import(string csv)
        {
            List = new List<Transaction>();
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            foreach(string values in (csv.Split(new char[] {'\n'})).Skip(1))
            {
                string[] v = values.Split(',');
                List.Add(new Transaction(bool.Parse(v[0]), v[1], v[2], float.Parse(v[3]), float.Parse(v[4]), bool.Parse(v[5])));             
            }

            return this;
        }

        public string Export()
        {
            string csv = "IsIncome,Category,Title,LastMonth,ThisMonth,IsDone";
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            foreach (var t in this.List)
            {
                csv += "\n" + t.IsIncome + "," + t.Category + "," + t.Title + "," + t.Previous + "," + t.Current + "," + t.IsDone;
            }
            
            return csv;
        }
        
        public double[] Balance()
        {
            return new double[] {
                Math.Round(Total()[0] - Categories()[0].Where(c => c.Key == "Previous").Sum(c => c.Sum(t => t.Previous)), 2),
                Math.Round(Total()[1] - Categories()[0].Where(c => c.Key == "Previous").Sum(c => c.Sum(t => t.Current)), 2)
            };
        }

        public float[] Total()
        {
            return new float[] {
                Categories()[0].Sum(c => c.Sum(t => t.Previous)) - Categories()[1].Sum(c => c.Sum(t => t.Previous)),
                Categories()[0].Sum(c => c.Sum(t => t.Current)) - Categories()[1].Sum(c => c.Sum(t => t.Current))
                };
        }

        public IEnumerable<IGrouping<string, Transaction>>[] Categories()
        {
            return new IEnumerable<IGrouping<string, Transaction>>[]
                {
                    List.Where(t => t.IsIncome).OrderBy(t => t.Category).ThenBy(t => t.Title).GroupBy(t => t.Category),
                    List.Where(t => !t.IsIncome).OrderBy(t => t.Category).ThenBy(t => t.Title).GroupBy(t => t.Category)
                };
        }
    }
}