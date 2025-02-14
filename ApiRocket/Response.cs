namespace ApiRocket
{
    public class Response
    {
        public Response(string? name, int? age) 
        {
            Name = name;
            Age = age;
        }
        private string? _name;
        public string? Name
        {
            get => _name;
            set => _name = value?.ToUpper(System.Globalization.CultureInfo.CurrentCulture);
        }
        public int? Age { get; set; }

    }
}
