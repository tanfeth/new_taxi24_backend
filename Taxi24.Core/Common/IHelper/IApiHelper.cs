using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Common.IHelper
{
    public interface IApiHelper
    {
        Dictionary<string, string> Headers { get; }
        Task<TResponse> GetAsync<TResponse>(string url);
        Task<TResponse> PostAsync<TBody, TResponse>(string url, TBody entity);
    }
}
