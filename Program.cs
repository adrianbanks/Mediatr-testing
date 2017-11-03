using System;
using System.Dynamic;
using System.IO;
using System.Threading.Tasks;
using MediatR;

namespace Mediatr_test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var mediator = new Mediator(DISetup.CreateInstance, DISetup.CreateAllInstances);
            Run(Console.Out, mediator);
        }

        private static void Run(TextWriter writer, Mediator mediator)
        {
            var conference = new Conference { Id = Guid.NewGuid(),  Name = "DDD East Anglia 2018", Date = new DateTime(2018, 09, 25) };
            writer.WriteLine($"Creating new conference: {conference.Name}");
            mediator.Send(conference).Wait();
            writer.WriteLine("Conference created");
        }
    }
}