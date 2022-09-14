using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.Http
{
    public interface IHttpServiceProvider
    {
        public HttpClient GetHttpNamedClient(string name);
    }
}
