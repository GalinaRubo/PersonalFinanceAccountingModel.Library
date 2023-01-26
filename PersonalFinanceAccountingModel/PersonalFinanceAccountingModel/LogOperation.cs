namespace PersonalFinanceAccountingModel.Library
{
    /// <summary>
    /// класс Запись операции
    /// </summary>
    public class LogOperation
    {
        /// <summary>
        /// идентификатор записи
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// идентификатор кошелька
        /// </summary>
        public int IdWallet { get; set; }

        /// <summary>
        /// время проведения транзакции
        /// </summary>
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// идентификатор операции
        /// </summary>
        public string? IdOperation { get; set; }

        /// <summary>
        /// сумма транзакции
        /// </summary>
        public double Sum { get; set; }
    }
}
