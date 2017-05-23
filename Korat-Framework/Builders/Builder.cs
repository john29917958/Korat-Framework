using System;
using System.Collections.Generic;

namespace Korat_Framework.Builders
{
    public abstract class Builder<T> where T : Builder<T>
    {
        protected abstract List<string> VersionNumbers { get; }
        protected string VersionNumber;
        protected Behaviors.Behaviors Behaviors;
        protected T Host;

        protected Builder(string versionNumber)
        {
            if (string.IsNullOrWhiteSpace(versionNumber))
            {
                throw new ArgumentNullException("Given version number should not be null.");
            }

            Host = null;
            VersionNumber = versionNumber;
        }

        public Builder<T> On(T builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException("Given builder should not be null.");
            }
            
            Host = builder;

            return builder;
        }

        protected string GetHostHirarchy()
        {
            string hirarchy = VersionNumber;
            T host = Host;

            while (host != null)
            {
                hirarchy += " " + Host.VersionNumber;
                host = Host.Host;
            }

            return hirarchy;
        }

        protected abstract void Make();
    }
}
