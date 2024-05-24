
using DesingerPattnersHomeWork3.Abstract;
using DesingerPattnersHomeWork3.Contanies;
using DesingerPattnersHomeWork3.Notifier;

BaseDecorator baseDecorator = new Notifier();

baseDecorator.Send("Step");
baseDecorator = new SmsDecorator(baseDecorator);
baseDecorator.Send("Step Yeni");
