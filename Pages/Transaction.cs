namespace Budget.Pages
{
    public class Transaction
    {
        public bool IsIncome { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public float LastMonth { get; set; }
        public float ThisMonth { get; set; }
        public bool IsDone { get; set; }
    }
}