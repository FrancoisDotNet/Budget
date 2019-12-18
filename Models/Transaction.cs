namespace Budget.Models
{
    public class Transaction
    {
        public bool IsIncome { get; set; } // Income or Expense
        public string Category { get; set; }
        public string Title { get; set; }
        public float Previous { get; set; } // Previous month amount
        public float Current { get; set; } // Current month amount
        public bool IsDone { get; set; }

        public Transaction()
        {
            IsIncome = false;
            Category = "";
            Title = "";
            Previous = 0;
            Current = 0;
            IsDone = false;
        }

        public Transaction(bool isIncome, string category, string title, float previous, float current, bool isDone)
        {
            IsIncome = isIncome;
            Category = category;
            Title = title;
            Previous = previous;
            Current = current;
            IsDone = isDone;
        } 
    }
}