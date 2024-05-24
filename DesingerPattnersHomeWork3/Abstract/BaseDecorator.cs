namespace DesingerPattnersHomeWork3.Abstract;
using DesingerPattnersHomeWork3.Notifier;

public abstract class BaseDecorator
{
    private Notifier? wrappee;

    public abstract void Send(string Message);
}
