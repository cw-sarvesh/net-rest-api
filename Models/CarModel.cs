namespace net_rest_api.Models.CarModel
{
    public record CarModel
    {

        // init is like private set means cant change after one time defining
        public Guid id { get; init; }
        public string? Name { get; set; }
        public string? ModelName { get; set; }

        public DateTime CreatedAt { get; init; }
    }
}