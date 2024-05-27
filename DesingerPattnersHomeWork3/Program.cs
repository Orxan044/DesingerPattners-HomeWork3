
using DesingerPattnersHomeWork3.Abstract;
using DesingerPattnersHomeWork3.Contanies;

Notifier notifier = new SmsDecorator();
notifier = new FacebookDecorator(notifier);
notifier = new SlackDecorator(notifier);

notifier.Send("Step It Academy");
