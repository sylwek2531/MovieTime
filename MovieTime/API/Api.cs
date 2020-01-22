using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MovieTime.API
{
    /// <summary>
    /// Konfiguracja Api dla naszej aplikacji
    /// </summary>

    class Api
    {
        private string Key { get; set; }
       public Api()
        {
            Key = GetKey();
        }

        /// <summary>
        /// Tworzenie połączenia HTTP
        /// </summary>
        /// <param name="URL">URL na jaki wykonujemy zapytanie</param>
        /// <returns>Zwraca nam wynik</returns>  
        /// 
        protected HttpResponseMessage GET(string URL)
        {
            using (HttpClient client = new HttpClient())
            {
                var result = client.GetAsync(URL);
                result.Wait();

                return result.Result;
            }
        }
        /// <summary>
        ///Umieszczenie parametru w adresie URI strony
        /// </summary>
        /// <param name="path">Sciezka endpointu</param>
        protected string GetURI(string path)
        {
            return "http://api.themoviedb.org/3/"+ path + "?api_key="+ Key;
        }
        /// <summary>
        /// Klucz autoryzacji
        /// </summary>
        /// <returns><c>"21a972e49437efa15ad8c8b404b8e5ef"</c></returns>
        public string GetKey()
        {
            return "21a972e49437efa15ad8c8b404b8e5ef";
        }
    }
}
