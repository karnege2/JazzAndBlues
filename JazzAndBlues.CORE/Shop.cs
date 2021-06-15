namespace JazzAndBlues.CORE
{
    public record Shop
    {
        public int Id  { get; init; }
        public string StoreName { get; init; }
        public Address Address { get; init; }

        public Cuisine Cuisine { get; set; }
    }

    public record Games(string Name, int Id, string Genre);
}
