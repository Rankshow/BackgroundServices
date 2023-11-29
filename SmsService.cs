namespace BackgroundService
{
    public class SmsService
    {
        public void SendSms(User user)
        {
            Console.WriteLine($"Hi {user.Name}, We have sent your Monthly allowance to your email {user.Email} having the following phone number {user.PhoneNumber}");
        }
    }
}