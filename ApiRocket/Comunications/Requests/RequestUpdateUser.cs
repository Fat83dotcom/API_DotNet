namespace ApiRocket.Comunications.Requests
{
    public class RequestUpdateUser : User
    {
        private string? _name;
        public new string? Name
        {
            get => _name;
            set => _name = value?.ToUpper();
        }
    }
}
