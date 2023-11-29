namespace BackgroundService
{
    public class UserService
    {
        public List<User> GetUser()
        {
            return new List<User>()
            {
                new User()
                {
                    Name = "Obinna",
                    Email = "uwaomai@gmail.com",
                    PhoneNumber = "09054647554",
                }
            };
        }
    }
}