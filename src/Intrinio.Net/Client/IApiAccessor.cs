namespace Intrinio.Net.Client
{
    /// <summary>
    /// Represents configuration aspects required to interact with the API endpoints.
    /// </summary>
    public interface IApiAccessor
    {
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        Configuration Configuration {get; set;}
        
        IIntrinioDependencies Dependencies { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        // string GetBasePath();
        
        
        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        ExceptionFactory ExceptionFactory { get; set; }
    }

    internal class ApiAccessor : IApiAccessor
    {
        public Configuration Configuration {get; set;}
        public ExceptionFactory ExceptionFactory { get; set; }
        public IIntrinioDependencies Dependencies { get; set; }

        public ApiAccessor(Configuration configuration, ExceptionFactory exFactory, IIntrinioDependencies dep)
        {
            Configuration = configuration;
            ExceptionFactory = exFactory;
            Dependencies = dep;
        }
    }
}
