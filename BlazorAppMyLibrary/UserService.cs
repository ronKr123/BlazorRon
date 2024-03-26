using Model;

namespace BlazorAppMyLibrary
{
    public class UserService
    {

        public Users CurrentUser { get; set; }
        
        public void SetCurrentUser(Users user)
        {
            CurrentUser = user;
        }

    }
}
