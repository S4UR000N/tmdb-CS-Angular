namespace Common.Application.Http
{
    public class HttpServiceProvider : IHttpServiceProvider
    {
        public readonly IHttpClientFactory _clientFactory;
        private readonly Dictionary<string, HttpClient> _httpClients = new Dictionary<string, HttpClient>();
        public HttpServiceProvider(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public HttpClient GetHttpNamedClient(string name)
        {
            if (this._httpClients.ContainsKey(name))
            {
                return this._httpClients[name];
            }
            var client = this._clientFactory.CreateClient(name);
            this._httpClients.Add(name, client);
            return this._httpClients[name];
        }
    }
}
