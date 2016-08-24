using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ProjetoDeSoftware.Classe
{
    class Extrator
    {
        /// <summary>
        /// Nível Territorial - Código.
        /// </summary>
        public string NC { get; set; }

        /// <summary>
        /// Nível Territorial - Nome.
        /// </summary>
        public string NN { get; set; }

        /// <summary>
        /// Dimensão 1 - Código.
        /// </summary>
        public string D1C { get; set; }

        /// <summary>
        /// Dimensão 1 - Nome.
        /// </summary>
        public string D1N { get; set; }

        /// <summary>
        /// Dimensão 2 - Código.
        /// </summary>
        public string D2C { get; set; }

        /// <summary>
        /// Dimensão 2 - Nome.
        /// </summary>
        public string D2N { get; set; }

        /// <summary>
        /// Dimensão 3 - Código.
        /// </summary>
        public string D3C { get; set; }

        /// <summary>
        /// Dimensão 3 - Nome.
        /// </summary>
        public string D3N { get; set; }

        /// <summary>
        /// Dimensão 4 - Código.
        /// </summary>
        public string D4C { get; set; }

        /// <summary>
        /// Dimensão 4 - Nome.
        /// </summary>
        public string D4N { get; set; }

        /// <summary>
        /// Dimensão 5 - Código.
        /// </summary>
        public string D5C { get; set; }

        /// <summary>
        /// Dimensão 5 - Nome.
        /// </summary>
        public string D5N { get; set; }

        /// <summary>
        /// Dimensão 6 - Código.
        /// </summary>
        public string D6C { get; set; }

        /// <summary>
        /// Dimensão 6 - Nome.
        /// </summary>
        public string D6N { get; set; }

        /// <summary>
        /// Dimensão 7 - Código.
        /// </summary>
        public string D7C { get; set; }

        /// <summary>
        /// Dimensão 7 - Nome.
        /// </summary>
        public string D7N { get; set; }

        /// <summary>
        /// Dimensão 8 - Código.
        /// </summary>
        public string D8C { get; set; }

        /// <summary>
        /// Dimensão 8 - Nome.
        /// </summary>
        public string D8N { get; set; }

        /// <summary>
        /// Dimensão 9 - Código.
        /// </summary>
        public string D9C { get; set; }

        /// <summary>
        /// Dimensão 9 - Nome.
        /// </summary>
        public string D9N { get; set; }

        /// <summary>
        /// Unidade de medida - Código.
        /// </summary>
        public string MC { get; set; }

        /// <summary>
        /// Unidade de medida - Nome.
        /// </summary>
        public string MN { get; set; }

        /// <summary>
        /// Valor.
        /// </summary>
        public string V { get; set; }

        public List<Extrator> extrairDados() {

            List<Extrator> dados = new List<Extrator>();

            HttpClient client = new HttpClient();
            string baseApiAddress = "http://www.sidra.ibge.gov.br";
            client.BaseAddress = new Uri(baseApiAddress);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //HttpResponseMessage response = client.GetAsync("/api/values/t/686/n1/all/v/all/p/last/c318/all/f/u").Result;
            ///t/3168//n102/2408102019/v/all/p/last/c63/all/f/u
            //"/t/3213/n102/2408102017/v/all/p/last/c287/all/f/u
            //Console.WriteLine(valor.D1C + " - " + valor.D1N + " - " + valor.D2N + " - " + valor.D3N + " - " + valor.D4N + " - " + valor.MN + " - " + valor.V);
            HttpResponseMessage response = client.GetAsync("/api/values/t/3213/n102/2408102017/v/all/p/last/c287/all/f/u").Result;
            if (response.IsSuccessStatusCode)
            {
                IEnumerable<Extrator> valores = response.Content.ReadAsAsync<IEnumerable<Extrator>>().Result;
                foreach (Extrator valor in valores)
                {
                    dados.Add(valor);
                }
            }
            else
            {

            }

            return dados;
        }
    }
}
