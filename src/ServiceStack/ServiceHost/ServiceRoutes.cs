using System;
using System.Collections.Generic;

namespace ServiceStack.ServiceHost
{
    public class ServiceRoutes : IServiceRoutes
    {
        public readonly List<RestPath> RestPaths = new List<RestPath>();

        public IServiceRoutes Add<TRequest>(string restPath)
        {
            RestPaths.Add(new RestPath(typeof(TRequest), restPath));
            return this;
        }

        public IServiceRoutes Add<TRequest>(string restPath, string verbs)
        {
            RestPaths.Add(new RestPath(typeof(TRequest), restPath, verbs, null, null, false));
            return this;
        }

        public IServiceRoutes Add<TRequest>(string restPath, string verbs, string defaultContentType)
        {
            RestPaths.Add(new RestPath(typeof(TRequest), restPath, verbs, defaultContentType, null, false));
            return this;
        }

        public IServiceRoutes Add<TRequest>(string restPath, string verbs, string defaultContentType, bool isOneWay)
        {
            RestPaths.Add(new RestPath(typeof(TRequest), restPath, verbs, defaultContentType, null, isOneWay));
            return this;
        }

        public IServiceRoutes Add(Type requestType, string restPath, string verbs, string defaultContentType)
        {
            RestPaths.Add(new RestPath(requestType, restPath, verbs, defaultContentType, null, false));
            return this;
        }
	}
}