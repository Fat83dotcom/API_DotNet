namespace ApiRocket.Comunications.Requests
{
    public class RequestRegisterUserJson : User
    {

        public bool InvalidRegister()
        {
            if (
                    string.IsNullOrEmpty(Name)
                    || string.IsNullOrEmpty(Email)
                    || string.IsNullOrEmpty(Password)
                )
            {
                return true;
            }
            return false;   
        }
    }
}
