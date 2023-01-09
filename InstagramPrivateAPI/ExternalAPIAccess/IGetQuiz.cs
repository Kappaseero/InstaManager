using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstaManagerLibrary.Models;
using InstaManagerLibrary.Helpers;

namespace InstaManagerLibrary.ExternalAPIAccess
{
    internal interface IGetQuiz
    {
        public string Uri { get; }
        public Task<string> GetDataAsync(HttpClient httpClient);
    }
}
