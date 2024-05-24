using DesingerPattnersHomeWork3.Abstract;

namespace DesingerPattnersHomeWork3.Contanies;

public class FacebookDecorator : BaseDecorator
{
    private BaseDecorator baseDecorator;

    public FacebookDecorator(BaseDecorator? baseDecorator)
    {
        this.baseDecorator = baseDecorator!;
    }

    public override void Send(string Message) { Console.WriteLine($"Facebook Decorator -> {Message}"); }
}
