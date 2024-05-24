using DesingerPattnersHomeWork3.Abstract;

namespace DesingerPattnersHomeWork3.Contanies;

public class SmsDecorator : BaseDecorator
{
    private BaseDecorator baseDecorator;

    public SmsDecorator(BaseDecorator? baseDecorator)
    {
        this.baseDecorator = baseDecorator!;
    }



    public override void Send(string? Message) { Console.WriteLine($"Sms Decorator -> {Message}"); }
}
