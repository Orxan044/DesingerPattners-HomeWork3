using DesingerPattnersHomeWork3.Abstract;

namespace DesingerPattnersHomeWork3.Contanies;

internal class SmsDecorator(Notifier? notifier = null) : BaseDecorator(notifier)
{
    public override void Send(string message)
    {
        notifier?.Send(message);
        Console.WriteLine($"Sms: {message}");
    }
}