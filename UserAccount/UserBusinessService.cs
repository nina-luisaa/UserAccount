using UserDL;

namespace UserBL
{

    public class UserBusinessService
    {

        public bool VerifyingUser(string username, string password)
        {
            UserDataService dataService = new UserDataService();
            var result1 = dataService.GetUser(username);
            var result2 = dataService.GetPassword(password);
            return result1 != null ? true : false;

        }
    }
}