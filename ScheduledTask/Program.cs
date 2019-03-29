using System;
using ClassLibrary1;

namespace ScheduledTask
{
    class Program
    {
        static void Main(string[] args)
        {
            new SomeBusinessLogic(new StaticImmutableUserContext()).DoSomething();
        }
    }
}
