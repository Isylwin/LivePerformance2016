namespace LP2016Lib.Interfaces
{
    /// <summary>
    /// Interface used to gather all classes that are rentable.
    /// </summary>
    public interface IRentable
    {
        /// <summary>
        /// The id of the item in the database.
        /// </summary>
        int Id { get; }       
        /// <summary>
        /// The name of the item.
        /// </summary>
        string Name { get; }
        /// <summary>
        /// The price of the item.
        /// </summary>
        decimal Price { get; }
    }
}
