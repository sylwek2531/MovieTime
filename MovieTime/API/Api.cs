using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MovieTime.API
{
    class Api
    {
        private string Key { get; set; }
       public Api()
        {
            Key = GetKey();
        }
        protected HttpResponseMessage GET(string URL)
        {
            using (HttpClient client = new HttpClient())
            {
                var result = client.GetAsync(URL);
                result.Wait();

                return result.Result;
            }
        }
        protected string GetURI(string path)
        {
            return "http://api.themoviedb.org/3/"+ path + "?api_key="+ Key;
        }
        public string GetKey()
        {
            return "21a972e49437efa15ad8c8b404b8e5ef";
        }
    }
}
