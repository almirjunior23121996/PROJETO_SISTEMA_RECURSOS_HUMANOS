using System.Collections.Generic;

namespace iRh.Windows.Core
{
    class Estados
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public List<Estados> ObterTodosEstados()
        {
            var listaEstados = new List<Estados>();
            listaEstados.Add(new Estados{ Nome = "Rndônia",Sigla = "RO" });
            listaEstados.Add(new Estados { Nome = "Acre", Sigla = "AC" });
            listaEstados.Add(new Estados { Nome = "Espirito Santo", Sigla = "ES" });
            listaEstados.Add(new Estados { Nome = "Rio de Janeiro", Sigla = "RJ" });
            listaEstados.Add(new Estados { Nome = "Minas Gerais", Sigla = "MG" });
            listaEstados.Add(new Estados { Nome = "São Paulo", Sigla = "SP" });
            listaEstados.Add(new Estados { Nome = "Rio Grande do Sul", Sigla = "RS" });
            listaEstados.Add(new Estados { Nome = "Santa Catarina", Sigla = "SC" });
            listaEstados.Add(new Estados { Nome = "Parana", Sigla = "PR" });
            listaEstados.Add(new Estados { Nome = "Alagoas", Sigla = "AL" });
            listaEstados.Add(new Estados { Nome = "Amapá", Sigla = "AP" });
            listaEstados.Add(new Estados { Nome = "Amazonas", Sigla = "AM" });
            listaEstados.Add(new Estados { Nome = "Bahia", Sigla = "BA" });
            listaEstados.Add(new Estados { Nome = "	Ceara", Sigla = "CE" });
            listaEstados.Add(new Estados { Nome = "Distrito Federal", Sigla = "DF" });
            listaEstados.Add(new Estados { Nome = "	Goiás", Sigla = "GO" });
            listaEstados.Add(new Estados { Nome = "	Maranhão", Sigla = "MA" });
            listaEstados.Add(new Estados { Nome = "Mato Grosso", Sigla = "MT" });
            listaEstados.Add(new Estados { Nome = "Mato Grosso do Sul", Sigla = "MS" });
            listaEstados.Add(new Estados { Nome = "	Pará", Sigla = "PA" });
            listaEstados.Add(new Estados { Nome = "	Paraíba", Sigla = "PB" });
            listaEstados.Add(new Estados { Nome = "	Pernambuco", Sigla = "PE" });
            listaEstados.Add(new Estados { Nome = "	Piauí", Sigla = "PI" });
            listaEstados.Add(new Estados { Nome = "	Rio Grande do Norte", Sigla = "RN" });
            listaEstados.Add(new Estados { Nome = "	Roraima", Sigla = "RR" });
            listaEstados.Add(new Estados { Nome = "	Sergipe", Sigla = "SE" });
            listaEstados.Add(new Estados { Nome = "Tocantins", Sigla = "TO" });



            return listaEstados;

        }
    }
}
