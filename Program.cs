namespace BackgroundService;

class Program
{
    static void Main(string[] args)
    {
        UserService userService = new ();
        while(true)
        {
            foreach(User user in userService.GetUser())
            {
                SmsService smsService = new (); 
                smsService.SendSms(user);
            }
            Thread.Sleep(500);
        }
    }
}
