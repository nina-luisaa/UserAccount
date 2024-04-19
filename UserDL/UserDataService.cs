using UserModel;


namespace UserDL
{


    public class UserDataService
    {
        List<User> dummyUsers = new List<User>();
        public UserDataService()
        {
            CreateDummyData();
        }
        private void CreateDummyData()
        {

            User user1 = new User()
            {
                username = "Nina",
                password = "Simple",
            };

            User user2 = new User()
            {
                username = "Luisa",
                password = "ILY",

            };
            User user3 = new User()
            {
                username = "Lysa",
                password = "IMY",

            };
            dummyUsers.Add(user1);
            dummyUsers.Add(user2);
            dummyUsers.Add(user3);
        }
        public User GetUser(string username)
        {
            User foundUser = new User();
            foreach (var user in dummyUsers)
            {
                if (user.username == username)
                {
                    foundUser = user;
                }
            }

            return foundUser;
        }

        public User GetPassword(string password)
        {
            User foundPassword = new User();
            foreach (var user in dummyUsers)
            {
                if (user.password == password)
                {
                    foundPassword = user;
                }
            }

            return foundPassword;

        }
    }
}