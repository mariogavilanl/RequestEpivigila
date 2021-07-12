using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DiegoRequest
{
    class ConsultaHTTP
    {
        private string _ga;
        private string _gid;
        private string laravel_session;
        private string XSRF_TOKEN;
        public ConsultaHTTP() {
            this._ga = System.Configuration.ConfigurationSettings.AppSettings["_ga"].ToString();
            this._gid = System.Configuration.ConfigurationSettings.AppSettings["_gid"].ToString();
            this.laravel_session = System.Configuration.ConfigurationSettings.AppSettings["laravel_session"].ToString();
            this.XSRF_TOKEN = System.Configuration.ConfigurationSettings.AppSettings["XSRF-TOKEN"].ToString();
        }
        public Object ConsultaRuts( string rut ) {

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://epivigila.minsal.cl/index.php/administracion/consulta-eno/RUN/243980453?draw=1&columns%5B0%5D%5Bdata%5D=n_folio&columns%5B0%5D%5Bname%5D=&columns%5B0%5D%5Bsearchable%5D=true&columns%5B0%5D%5Borderable%5D=false&columns%5B0%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B0%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B1%5D%5Bdata%5D=enfermedad&columns%5B1%5D%5Bname%5D=&columns%5B1%5D%5Bsearchable%5D=true&columns%5B1%5D%5Borderable%5D=false&columns%5B1%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B1%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B2%5D%5Bdata%5D=fecha_notificacion&columns%5B2%5D%5Bname%5D=&columns%5B2%5D%5Bsearchable%5D=true&columns%5B2%5D%5Borderable%5D=false&columns%5B2%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B2%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B3%5D%5Bdata%5D=nombre_paciente&columns%5B3%5D%5Bname%5D=&columns%5B3%5D%5Bsearchable%5D=true&columns%5B3%5D%5Borderable%5D=false&columns%5B3%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B3%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B4%5D%5Bdata%5D=sospecha&columns%5B4%5D%5Bname%5D=&columns%5B4%5D%5Bsearchable%5D=true&columns%5B4%5D%5Borderable%5D=false&columns%5B4%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B4%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B5%5D%5Bdata%5D=validada&columns%5B5%5D%5Bname%5D=&columns%5B5%5D%5Bsearchable%5D=true&columns%5B5%5D%5Borderable%5D=false&columns%5B5%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B5%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B6%5D%5Bdata%5D=notificador_nombre_completo&columns%5B6%5D%5Bname%5D=&columns%5B6%5D%5Bsearchable%5D=true&columns%5B6%5D%5Borderable%5D=false&columns%5B6%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B6%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B7%5D%5Bdata%5D=fecha_modificacion&columns%5B7%5D%5Bname%5D=&columns%5B7%5D%5Bsearchable%5D=true&columns%5B7%5D%5Borderable%5D=false&columns%5B7%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B7%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B8%5D%5Bdata%5D=nombre_institucion&columns%5B8%5D%5Bname%5D=&columns%5B8%5D%5Bsearchable%5D=true&columns%5B8%5D%5Borderable%5D=false&columns%5B8%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B8%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B9%5D%5Bdata%5D=opciones&columns%5B9%5D%5Bname%5D=&columns%5B9%5D%5Bsearchable%5D=false&columns%5B9%5D%5Borderable%5D=false&columns%5B9%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B9%5D%5Bsearch%5D%5Bregex%5D=false&order%5B0%5D%5Bcolumn%5D=0&order%5B0%5D%5Bdir%5D=asc&start=0&length=10&search%5Bvalue%5D=&search%5Bregex%5D=false&_=1625935458911");
            httpWebRequest.CookieContainer = new CookieContainer();
            WebHeaderCollection h = new WebHeaderCollection();
            h.Add("authority", "epivigila.minsal.cl");
            h.Add("method", "GET");
            h.Add("path", "/index.php/administracion/consulta-eno/RUN/"+rut+"?draw=1&columns%5B0%5D%5Bdata%5D=n_folio&columns%5B0%5D%5Bname%5D=&columns%5B0%5D%5Bsearchable%5D=true&columns%5B0%5D%5Borderable%5D=false&columns%5B0%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B0%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B1%5D%5Bdata%5D=enfermedad&columns%5B1%5D%5Bname%5D=&columns%5B1%5D%5Bsearchable%5D=true&columns%5B1%5D%5Borderable%5D=false&columns%5B1%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B1%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B2%5D%5Bdata%5D=fecha_notificacion&columns%5B2%5D%5Bname%5D=&columns%5B2%5D%5Bsearchable%5D=true&columns%5B2%5D%5Borderable%5D=false&columns%5B2%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B2%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B3%5D%5Bdata%5D=nombre_paciente&columns%5B3%5D%5Bname%5D=&columns%5B3%5D%5Bsearchable%5D=true&columns%5B3%5D%5Borderable%5D=false&columns%5B3%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B3%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B4%5D%5Bdata%5D=sospecha&columns%5B4%5D%5Bname%5D=&columns%5B4%5D%5Bsearchable%5D=true&columns%5B4%5D%5Borderable%5D=false&columns%5B4%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B4%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B5%5D%5Bdata%5D=validada&columns%5B5%5D%5Bname%5D=&columns%5B5%5D%5Bsearchable%5D=true&columns%5B5%5D%5Borderable%5D=false&columns%5B5%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B5%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B6%5D%5Bdata%5D=notificador_nombre_completo&columns%5B6%5D%5Bname%5D=&columns%5B6%5D%5Bsearchable%5D=true&columns%5B6%5D%5Borderable%5D=false&columns%5B6%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B6%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B7%5D%5Bdata%5D=fecha_modificacion&columns%5B7%5D%5Bname%5D=&columns%5B7%5D%5Bsearchable%5D=true&columns%5B7%5D%5Borderable%5D=false&columns%5B7%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B7%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B8%5D%5Bdata%5D=nombre_institucion&columns%5B8%5D%5Bname%5D=&columns%5B8%5D%5Bsearchable%5D=true&columns%5B8%5D%5Borderable%5D=false&columns%5B8%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B8%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B9%5D%5Bdata%5D=opciones&columns%5B9%5D%5Bname%5D=&columns%5B9%5D%5Bsearchable%5D=false&columns%5B9%5D%5Borderable%5D=false&columns%5B9%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B9%5D%5Bsearch%5D%5Bregex%5D=false&order%5B0%5D%5Bcolumn%5D=0&order%5B0%5D%5Bdir%5D=asc&start=0&length=10&search%5Bvalue%5D=&search%5Bregex%5D=false&_=1625935458913");

            h.Add("scheme", "https");
            //h.Add("accept" ,"application/json");

            h.Add("accept-encoding", "gzip, deflate, br");
            h.Add("accept-language", "es-419,es;q=0.9,es-ES;q=0.8,en;q=0.7,en-GB;q=0.6,en-US;q=0.5");
            //h.Add("cookie","_ga=GA1.2.1727160678.1625933084; _gid=GA1.2.1347252700.1625933084; _ga=GA1.3.1727160678.1625933084; _gid=GA1.3.1347252700.1625933084; XSRF-TOKEN=eyJpdiI6ImZqZnFaMWFHMXJxU3lSNGp6enZLV0E9PSIsInZhbHVlIjoiSmlhZ2w0MlR3RTE3TWw5c1lkNVczWlBPXC84RDNSNFFYMVwvYWdveVBGR0w5c3A0Q0YxQTkzSHJpZ3ExWndNaGliIiwibWFjIjoiODQzYjg5OTIyMjMxMzY3OTA4MGMxYjNlNmQ3MGUwZjkwMjM4NmM2NzJjMjk3ZWRkZDUyMDYyZTkwOGFmNTg1NiJ9; laravel_session=eyJpdiI6Im9UNmRTOUJkZ2VLNGF4ZERcLzdwRlZnPT0iLCJ2YWx1ZSI6IlwvdWxLeWg5cGxXb1wvb3o3REJ2d09IenZENU5ZK2E0R0NBMkNwczYzeDRWWitvMGtrN1N1dHFcL2VZcjhHK2ZUd24iLCJtYWMiOiJiZTBmMWM2YzVmZmU0MzBiNTFhNDQyZTZlMDA5YWIzMmQzYjBmZWQxZTkyMTZkODg4YmZjMTk1ODI4YTBhYWMxIn0%3D; _gat_gtag_UA_161703128_1=1");
            //h.Add("referer", "https://epivigila.minsal.cl/index.php/administracion/listar-boletin");
            h.Add("sec-ch-ua", "Not; A Brand\";v=\"99\", \"Microsoft Edge\";v=\"91\", \"Chromium\";v=\"91\"");
            h.Add("sec-ch-ua-mobile", "?0");
            h.Add("sec-fetch-dest", "empty");
            h.Add("sec-fetch-mode", "cors");
            h.Add("sec-fetch-site", "same-origin");
            h.Add("sec-fetch-mode", "cors");
            //h.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36 Edg/91.0.864.67");
            h.Add("x-csrf-token", "7zM9DBaVV6IaH9YCsXWQkHjabFjqq5ZoctS2btQH");
            h.Add("x-requested-with", "XMLHttpRequest");

            httpWebRequest.Headers = h;

            //httpWebRequest.Headers.Add("Cookie", "_ga=GA1.2.1727160678.1625933084; _gid=GA1.2.1347252700.1625933084; _ga=GA1.3.1727160678.1625933084; _gid=GA1.3.1347252700.1625933084; XSRF-TOKEN=eyJpdiI6ImZqZnFaMWFHMXJxU3lSNGp6enZLV0E9PSIsInZhbHVlIjoiSmlhZ2w0MlR3RTE3TWw5c1lkNVczWlBPXC84RDNSNFFYMVwvYWdveVBGR0w5c3A0Q0YxQTkzSHJpZ3ExWndNaGliIiwibWFjIjoiODQzYjg5OTIyMjMxMzY3OTA4MGMxYjNlNmQ3MGUwZjkwMjM4NmM2NzJjMjk3ZWRkZDUyMDYyZTkwOGFmNTg1NiJ9; laravel_session=eyJpdiI6Im9UNmRTOUJkZ2VLNGF4ZERcLzdwRlZnPT0iLCJ2YWx1ZSI6IlwvdWxLeWg5cGxXb1wvb3o3REJ2d09IenZENU5ZK2E0R0NBMkNwczYzeDRWWitvMGtrN1N1dHFcL2VZcjhHK2ZUd24iLCJtYWMiOiJiZTBmMWM2YzVmZmU0MzBiNTFhNDQyZTZlMDA5YWIzMmQzYjBmZWQxZTkyMTZkODg4YmZjMTk1ODI4YTBhYWMxIn0%3D");
            httpWebRequest.Accept = "application/json, text/javascript, */*; q=0.01";
            httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36 Edg/91.0.864.67";
            httpWebRequest.Referer = "https://epivigila.minsal.cl/index.php/administracion/listar-boletin";
            httpWebRequest.CookieContainer = new CookieContainer();
            System.Net.Cookie c1 = new Cookie("_ga", this._ga);
            c1.Domain = ".epivigila.minsal.cl";
            System.Net.Cookie c2 = new Cookie("_gid", this._gid);
            c2.Domain = ".epivigila.minsal.cl";
            System.Net.Cookie c3 = new Cookie("_ga", this._ga);
            c3.Domain = ".minsal.cl";
            System.Net.Cookie c4 = new Cookie("_gid", this._gid);
            c4.Domain = ".minsal.cl";
            System.Net.Cookie c5 = new Cookie("laravel_session", this.laravel_session);
            c5.Domain = "epivigila.minsal.cl";
            System.Net.Cookie c6 = new Cookie("XSRF-TOKEN", this.XSRF_TOKEN);
            c6.Domain = "epivigila.minsal.cl";

            httpWebRequest.CookieContainer.Add(c1);
            httpWebRequest.CookieContainer.Add(c2);
            httpWebRequest.CookieContainer.Add(c3);
            httpWebRequest.CookieContainer.Add(c4);
            httpWebRequest.CookieContainer.Add(c5);
            httpWebRequest.CookieContainer.Add(c6);

            WebResponse response = httpWebRequest.GetResponse();
            System.IO.StreamReader reader = new System.IO.StreamReader(response.GetResponseStream());
            string result = reader.ReadToEnd();


            return Newtonsoft.Json.JsonConvert.DeserializeObject(result);

        }

        public Object ConsultaFicha(string nroficha)
        {

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://epivigila.minsal.cl/index.php/administracion/consulta-eno/RUN/243980453?draw=1&columns%5B0%5D%5Bdata%5D=n_folio&columns%5B0%5D%5Bname%5D=&columns%5B0%5D%5Bsearchable%5D=true&columns%5B0%5D%5Borderable%5D=false&columns%5B0%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B0%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B1%5D%5Bdata%5D=enfermedad&columns%5B1%5D%5Bname%5D=&columns%5B1%5D%5Bsearchable%5D=true&columns%5B1%5D%5Borderable%5D=false&columns%5B1%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B1%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B2%5D%5Bdata%5D=fecha_notificacion&columns%5B2%5D%5Bname%5D=&columns%5B2%5D%5Bsearchable%5D=true&columns%5B2%5D%5Borderable%5D=false&columns%5B2%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B2%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B3%5D%5Bdata%5D=nombre_paciente&columns%5B3%5D%5Bname%5D=&columns%5B3%5D%5Bsearchable%5D=true&columns%5B3%5D%5Borderable%5D=false&columns%5B3%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B3%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B4%5D%5Bdata%5D=sospecha&columns%5B4%5D%5Bname%5D=&columns%5B4%5D%5Bsearchable%5D=true&columns%5B4%5D%5Borderable%5D=false&columns%5B4%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B4%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B5%5D%5Bdata%5D=validada&columns%5B5%5D%5Bname%5D=&columns%5B5%5D%5Bsearchable%5D=true&columns%5B5%5D%5Borderable%5D=false&columns%5B5%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B5%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B6%5D%5Bdata%5D=notificador_nombre_completo&columns%5B6%5D%5Bname%5D=&columns%5B6%5D%5Bsearchable%5D=true&columns%5B6%5D%5Borderable%5D=false&columns%5B6%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B6%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B7%5D%5Bdata%5D=fecha_modificacion&columns%5B7%5D%5Bname%5D=&columns%5B7%5D%5Bsearchable%5D=true&columns%5B7%5D%5Borderable%5D=false&columns%5B7%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B7%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B8%5D%5Bdata%5D=nombre_institucion&columns%5B8%5D%5Bname%5D=&columns%5B8%5D%5Bsearchable%5D=true&columns%5B8%5D%5Borderable%5D=false&columns%5B8%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B8%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B9%5D%5Bdata%5D=opciones&columns%5B9%5D%5Bname%5D=&columns%5B9%5D%5Bsearchable%5D=false&columns%5B9%5D%5Borderable%5D=false&columns%5B9%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B9%5D%5Bsearch%5D%5Bregex%5D=false&order%5B0%5D%5Bcolumn%5D=0&order%5B0%5D%5Bdir%5D=asc&start=0&length=10&search%5Bvalue%5D=&search%5Bregex%5D=false&_=1625935458911");
            httpWebRequest.CookieContainer = new CookieContainer();
            WebHeaderCollection h = new WebHeaderCollection();
            h.Add("authority", "epivigila.minsal.cl");
            h.Add("method", "POST");
            h.Add("path", "/index.php/administracion/consulta-eno/RUN/" + nroficha + "?draw=1&columns%5B0%5D%5Bdata%5D=n_folio&columns%5B0%5D%5Bname%5D=&columns%5B0%5D%5Bsearchable%5D=true&columns%5B0%5D%5Borderable%5D=false&columns%5B0%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B0%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B1%5D%5Bdata%5D=enfermedad&columns%5B1%5D%5Bname%5D=&columns%5B1%5D%5Bsearchable%5D=true&columns%5B1%5D%5Borderable%5D=false&columns%5B1%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B1%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B2%5D%5Bdata%5D=fecha_notificacion&columns%5B2%5D%5Bname%5D=&columns%5B2%5D%5Bsearchable%5D=true&columns%5B2%5D%5Borderable%5D=false&columns%5B2%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B2%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B3%5D%5Bdata%5D=nombre_paciente&columns%5B3%5D%5Bname%5D=&columns%5B3%5D%5Bsearchable%5D=true&columns%5B3%5D%5Borderable%5D=false&columns%5B3%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B3%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B4%5D%5Bdata%5D=sospecha&columns%5B4%5D%5Bname%5D=&columns%5B4%5D%5Bsearchable%5D=true&columns%5B4%5D%5Borderable%5D=false&columns%5B4%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B4%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B5%5D%5Bdata%5D=validada&columns%5B5%5D%5Bname%5D=&columns%5B5%5D%5Bsearchable%5D=true&columns%5B5%5D%5Borderable%5D=false&columns%5B5%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B5%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B6%5D%5Bdata%5D=notificador_nombre_completo&columns%5B6%5D%5Bname%5D=&columns%5B6%5D%5Bsearchable%5D=true&columns%5B6%5D%5Borderable%5D=false&columns%5B6%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B6%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B7%5D%5Bdata%5D=fecha_modificacion&columns%5B7%5D%5Bname%5D=&columns%5B7%5D%5Bsearchable%5D=true&columns%5B7%5D%5Borderable%5D=false&columns%5B7%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B7%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B8%5D%5Bdata%5D=nombre_institucion&columns%5B8%5D%5Bname%5D=&columns%5B8%5D%5Bsearchable%5D=true&columns%5B8%5D%5Borderable%5D=false&columns%5B8%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B8%5D%5Bsearch%5D%5Bregex%5D=false&columns%5B9%5D%5Bdata%5D=opciones&columns%5B9%5D%5Bname%5D=&columns%5B9%5D%5Bsearchable%5D=false&columns%5B9%5D%5Borderable%5D=false&columns%5B9%5D%5Bsearch%5D%5Bvalue%5D=&columns%5B9%5D%5Bsearch%5D%5Bregex%5D=false&order%5B0%5D%5Bcolumn%5D=0&order%5B0%5D%5Bdir%5D=asc&start=0&length=10&search%5Bvalue%5D=&search%5Bregex%5D=false&_=1625935458913");

            h.Add("scheme", "https");
            //h.Add("accept" ,"application/json");

            h.Add("accept-encoding", "gzip, deflate, br");
            h.Add("accept-language", "es-419,es;q=0.9,es-ES;q=0.8,en;q=0.7,en-GB;q=0.6,en-US;q=0.5");
            //h.Add("cookie","_ga=GA1.2.1727160678.1625933084; _gid=GA1.2.1347252700.1625933084; _ga=GA1.3.1727160678.1625933084; _gid=GA1.3.1347252700.1625933084; XSRF-TOKEN=eyJpdiI6ImZqZnFaMWFHMXJxU3lSNGp6enZLV0E9PSIsInZhbHVlIjoiSmlhZ2w0MlR3RTE3TWw5c1lkNVczWlBPXC84RDNSNFFYMVwvYWdveVBGR0w5c3A0Q0YxQTkzSHJpZ3ExWndNaGliIiwibWFjIjoiODQzYjg5OTIyMjMxMzY3OTA4MGMxYjNlNmQ3MGUwZjkwMjM4NmM2NzJjMjk3ZWRkZDUyMDYyZTkwOGFmNTg1NiJ9; laravel_session=eyJpdiI6Im9UNmRTOUJkZ2VLNGF4ZERcLzdwRlZnPT0iLCJ2YWx1ZSI6IlwvdWxLeWg5cGxXb1wvb3o3REJ2d09IenZENU5ZK2E0R0NBMkNwczYzeDRWWitvMGtrN1N1dHFcL2VZcjhHK2ZUd24iLCJtYWMiOiJiZTBmMWM2YzVmZmU0MzBiNTFhNDQyZTZlMDA5YWIzMmQzYjBmZWQxZTkyMTZkODg4YmZjMTk1ODI4YTBhYWMxIn0%3D; _gat_gtag_UA_161703128_1=1");
            //h.Add("referer", "https://epivigila.minsal.cl/index.php/administracion/listar-boletin");
            h.Add("sec-ch-ua", "Not; A Brand\";v=\"99\", \"Microsoft Edge\";v=\"91\", \"Chromium\";v=\"91\"");
            h.Add("sec-ch-ua-mobile", "?0");
            h.Add("sec-fetch-dest", "empty");
            h.Add("sec-fetch-mode", "cors");
            h.Add("sec-fetch-site", "same-origin");
            h.Add("sec-fetch-mode", "cors");
            //h.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36 Edg/91.0.864.67");
            h.Add("x-csrf-token", "7zM9DBaVV6IaH9YCsXWQkHjabFjqq5ZoctS2btQH");
            h.Add("x-requested-with", "XMLHttpRequest");

            httpWebRequest.Headers = h;

            //httpWebRequest.Headers.Add("Cookie", "_ga=GA1.2.1727160678.1625933084; _gid=GA1.2.1347252700.1625933084; _ga=GA1.3.1727160678.1625933084; _gid=GA1.3.1347252700.1625933084; XSRF-TOKEN=eyJpdiI6ImZqZnFaMWFHMXJxU3lSNGp6enZLV0E9PSIsInZhbHVlIjoiSmlhZ2w0MlR3RTE3TWw5c1lkNVczWlBPXC84RDNSNFFYMVwvYWdveVBGR0w5c3A0Q0YxQTkzSHJpZ3ExWndNaGliIiwibWFjIjoiODQzYjg5OTIyMjMxMzY3OTA4MGMxYjNlNmQ3MGUwZjkwMjM4NmM2NzJjMjk3ZWRkZDUyMDYyZTkwOGFmNTg1NiJ9; laravel_session=eyJpdiI6Im9UNmRTOUJkZ2VLNGF4ZERcLzdwRlZnPT0iLCJ2YWx1ZSI6IlwvdWxLeWg5cGxXb1wvb3o3REJ2d09IenZENU5ZK2E0R0NBMkNwczYzeDRWWitvMGtrN1N1dHFcL2VZcjhHK2ZUd24iLCJtYWMiOiJiZTBmMWM2YzVmZmU0MzBiNTFhNDQyZTZlMDA5YWIzMmQzYjBmZWQxZTkyMTZkODg4YmZjMTk1ODI4YTBhYWMxIn0%3D");
            httpWebRequest.Accept = "application/json, text/javascript, */*; q=0.01";
            httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36 Edg/91.0.864.67";
            httpWebRequest.Referer = "https://epivigila.minsal.cl/index.php/administracion/listar-boletin";
            httpWebRequest.CookieContainer = new CookieContainer();
            System.Net.Cookie c1 = new Cookie("_ga", this._ga);
            c1.Domain = ".epivigila.minsal.cl";
            System.Net.Cookie c2 = new Cookie("_gid", this._gid);
            c2.Domain = ".epivigila.minsal.cl";
            System.Net.Cookie c3 = new Cookie("_ga", this._ga);
            c3.Domain = ".minsal.cl";
            System.Net.Cookie c4 = new Cookie("_gid", this._gid);
            c4.Domain = ".minsal.cl";
            System.Net.Cookie c5 = new Cookie("laravel_session", this.laravel_session);
            c5.Domain = "epivigila.minsal.cl";
            System.Net.Cookie c6 = new Cookie("XSRF-TOKEN", this.XSRF_TOKEN);
            c6.Domain = "epivigila.minsal.cl";

            httpWebRequest.CookieContainer.Add(c1);
            httpWebRequest.CookieContainer.Add(c2);
            httpWebRequest.CookieContainer.Add(c3);
            httpWebRequest.CookieContainer.Add(c4);
            httpWebRequest.CookieContainer.Add(c5);
            httpWebRequest.CookieContainer.Add(c6);
           
            WebResponse response = httpWebRequest.GetResponse();
            System.IO.StreamReader reader = new System.IO.StreamReader(response.GetResponseStream());
            string result = reader.ReadToEnd();

            return Newtonsoft.Json.JsonConvert.DeserializeObject(result);

        }
    }
}
