using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ApiRocket.Comunications.Requests
{
    public class RequestGetUser : User
    {
        public new Guid Id { get; set; } = Guid.NewGuid();
        private string? _name;
        public new string? Name
        {
            get => _name;
            set => _name = value?.ToUpper(System.Globalization.CultureInfo.CurrentCulture);
        }
    }
    public class BadRequestResponse(object? value) : ObjectResult(value)
    {
        public string? Title { get; set; }
        public string? Detail { get; set; }
        public new int StatusCode { get; } = 400;
    }
}
