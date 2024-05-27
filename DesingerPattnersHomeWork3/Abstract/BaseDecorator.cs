namespace DesingerPattnersHomeWork3.Abstract;
internal abstract class BaseDecorator : Notifier
{
    protected Notifier? notifier;

    protected BaseDecorator(Notifier? notifier = null)
    {
        this.notifier = notifier;
    }
}