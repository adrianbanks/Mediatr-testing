using System;
using MediatR;

namespace Mediatr_test
{
    public class Conference : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
}