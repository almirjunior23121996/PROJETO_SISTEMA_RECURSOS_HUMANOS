using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace iRh.Windows.Core
{
    class Endereco
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Clomplemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Ibge { get; set; }
        public string Gia { get; set; }
        public string Ddd { get; set; }
        public string Siafi { get; set; }
        public Endereco ObterPorCep(string cep) 
        {
            var enderecoDaApi = new Endereco();
            //Instancia HTTP que permite obter informações de internet de uma URL
            var http = new HttpClient();

            var url = new Uri("https://viacep.com.br/" + cep + "/json");
            var result = http.GetAsync(url).GetAwaiter().GetResult();

            //Converte o resultado obtido em uma string
            var resultContent = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            //Converte a string json para nossa classe ViacepHrapper
            enderecoDaApi = JsonConvert.DeserializeObject<Endereco>(resultContent);


            return enderecoDaApi;
        }

    }
}