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
    //CLASSE COM A FUNÇÃO DE REALIZAR A EXTRAÇÃO DOS DADOS DA API
    class Extrator
    {
        //IMPLEMENTAÇÃO DO PADRÃO SINGLETON
        private static Extrator instance;

        private Extrator() { }

        public static Extrator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Extrator();
                }
                return instance;
            }
        }

        //VARIAVEL DE RETORNO DA CONSULTA NA API
        public string V { get; set; }

        public static Bairro extrairBairro(string codigo)
        {
            Bairro bairro = new Bairro();
            HttpResponseMessage reposta;

            HttpClient cliente = new HttpClient();
            string baseApiAddress = "http://www.sidra.ibge.gov.br";
            cliente.BaseAddress = new Uri(baseApiAddress);
            cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //POPULAÇÃO TOTAL POR BAIRRO
            reposta = cliente.GetAsync("/api/values/t/202/n102/" + codigo + "/v/93/p/last/c2/4/f/u").Result;
            if (reposta.IsSuccessStatusCode)
            {
                List<Extrator> valores = reposta.Content.ReadAsAsync<List<Extrator>>().Result;
                
                bairro.setPopulacaoH(valores[1].V);
            }

            reposta = cliente.GetAsync("/api/values/t/202/n102/" + codigo + "/v/93/p/last/c2/5/f/u").Result;
            if (reposta.IsSuccessStatusCode)
            {
                List<Extrator> valores = reposta.Content.ReadAsAsync<List<Extrator>>().Result;

                bairro.setPopulacaoM(valores[1].V);
            }

            //NUMERO DE ALFABETIZADOS POR BAIRRO
            reposta = cliente.GetAsync("/api/values/t/1699/n102/" + codigo + "/v/1645/p/last/c2/4/f/u").Result;
            if (reposta.IsSuccessStatusCode)
            {
                List<Extrator> valores = reposta.Content.ReadAsAsync<List<Extrator>>().Result;
                bairro.setAlfabetizadosH(valores[1].V);
            }
            reposta = cliente.GetAsync("/api/values/t/1699/n102/" + codigo + "/v/1645/p/last/c2/5/f/u").Result;
            if (reposta.IsSuccessStatusCode)
            {
                List<Extrator> valores = reposta.Content.ReadAsAsync<List<Extrator>>().Result;
                bairro.setAlfabetizadosM(valores[1].V);
            }

            //RENDA MEDIA MENSAL
            reposta = cliente.GetAsync("/api/values/t/3170/n102/" + codigo + "/v/842/p/last/c2/4/f/u").Result;
            if (reposta.IsSuccessStatusCode)
            {
                List<Extrator> valores = reposta.Content.ReadAsAsync<List<Extrator>>().Result;
                bairro.setRendaMediaH(valores[1].V);
            }

            reposta = cliente.GetAsync("/api/values/t/3170/n102/" + codigo + "/v/842/p/last/c2/5/f/u").Result;
            if (reposta.IsSuccessStatusCode)
            {
                List<Extrator> valores = reposta.Content.ReadAsAsync<List<Extrator>>().Result;
                bairro.setRendaMediaM(valores[1].V);
            }

            //NUMERO TOTAL DE ALFABETIZADOS 
            reposta = cliente.GetAsync("/api/values/t/1699/n102/" + codigo + "/v/1645/p/last/c2/6794/f/u").Result;
            if (reposta.IsSuccessStatusCode)
            {
                List<Extrator> valores = reposta.Content.ReadAsAsync<List<Extrator>>().Result;
                bairro.setAlfabetizadosTotal(valores[1].V);

                int nao_alfa = Convert.ToInt32(bairro.getPopulacaoTotal()) - Convert.ToInt32(bairro.getAlfabetizadosTotal());
                bairro.setNaoAlfabetizadosTotal(nao_alfa.ToString());
            }

            return bairro;
        }
    }
}
