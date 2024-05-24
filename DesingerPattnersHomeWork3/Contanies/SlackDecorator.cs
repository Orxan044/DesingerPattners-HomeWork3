using DesingerPattnersHomeWork3.Abstract;

namespace DesingerPattnersHomeWork3.Contanies;

public class SlackDecorator : BaseDecorator
{
    private BaseDecorator baseDecorator;
    public SlackDecorator(BaseDecorator? baseDecorator) 
    {
        this.baseDecorator = baseDecorator!;
    }

    public override void Send(string Message) { Console.WriteLine($"Slack Decorator -> {Message}"); }
}
