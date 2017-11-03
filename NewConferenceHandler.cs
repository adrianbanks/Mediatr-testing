using System;
using MediatR;

namespace Mediatr_test
{
    internal class NewConferenceHandler : IRequestHandler<Conference>
    {
        public void Handle(Conference conference)
        {
            Console.WriteLine($"Saved conference {conference.Name} ({conference.Id}) to database");
        }
    }
}