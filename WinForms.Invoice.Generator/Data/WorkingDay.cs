namespace WinForms.Invoice.Generator.Data
{
   public class WorkingDay
    {
        public WorkingDay(DateTime date, bool isWorkingDay)
        {
            Date = date;
            IsWorkingDay = isWorkingDay;
        }
        public DateTime Date { get; set; }
        public bool IsWorkingDay { get; set; }
        public bool IsHoliday { get; set; }
    }
}
