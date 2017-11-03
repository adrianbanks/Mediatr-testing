using System;
using System.Collections.Generic;
using MediatR;

namespace Mediatr_test
{
    public class DISetup
    {
        public static object CreateInstance(Type type)
        {
            if (type == typeof(IRequestHandler<Conference>))
            {
                return new NewConferenceHandler();
            }
            
            return null;
        }

        public static IEnumerable<object> CreateAllInstances(Type type)
        {     
            yield break;
        }
    }
}