using LP2016Lib.Interfaces;

namespace LP2016Lib.Classes
{
    /// <summary>
    /// Miscellanious articles that can be rented within the livery.
    /// </summary>
    public class Article : IRentable, ISaveable
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }

        /// <summary>
        /// Constructs an article.
        /// </summary>
        /// <param name="id">The id of the article in the database.</param>
        /// <param name="name">The name of the article.</param>
        /// <param name="price">The price of the article.</param>
        public Article(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - €{Price}";
        }
    }
}
