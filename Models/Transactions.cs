using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Budget.Models
{    
    public class Transactions
    {
        public List<Transaction> List { get; set; }

        public Transactions() => List = new List<Transaction>();

        public Transactions Import(string csv)
        {
            List = new List<Transaction>();
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            foreach(string values in (csv.Split(new char[] {'\n'})).Skip(1))
            {
                string[] v = values.Split(',');
                List.Add(new Transaction(bool.Parse(v[0]), v[1], v[2], float.Parse(v[3]), float.Parse(v[4]), bool.Parse(v[5])));             
            }

            Thread.CurrentThread.CurrentCulture = currentCulture;
            return this;
        }

        public string Export()
        {
            string csv = "IsIncome,Category,Title,LastMonth,ThisMonth,IsDone";
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            foreach (var t in this.List)
            {
                csv += "\n" + t.IsIncome + "," + t.Category + "," + t.Title + "," + t.Previous + "," + t.Current + "," + t.IsDone;
            }
            
            Thread.CurrentThread.CurrentCulture = currentCulture;
            return csv;
        }
        
        public double[] Balance()
        {
            return new double[] {
                Total()[0] - Categories()[0].Where(c => c.Key == "Previous").Sum(c => c.Sum(t => t.Previous)),
                Total()[1] - Categories()[0].Where(c => c.Key == "Previous").Sum(c => c.Sum(t => t.Current))
            };
        }

        public double[] Total()
        {
            return new double[] {
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