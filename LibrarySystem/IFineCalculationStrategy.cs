namespace LibrarySystem
{
    internal interface IFineCalculationStrategy
    {
        decimal CalculateFine(int overdueDays);
    }
}