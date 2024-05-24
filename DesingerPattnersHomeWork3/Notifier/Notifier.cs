using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesingerPattnersHomeWork3.Abstract;

namespace DesingerPattnersHomeWork3.Notifier;

public class Notifier : BaseDecorator
{
    public override void Send(string Message) { Console.WriteLine($"Message->  {Message}"); }
}
