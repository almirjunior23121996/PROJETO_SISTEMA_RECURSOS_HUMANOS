using System.Collections.Generic;
namespace iRh.Windows.Core
{
     class Documento
     {
        public string Id { get; set; }
        public string Descricao { get; set; }

        public List<Documento> obterTodosDocumentos()
        {

        var listaDocumento = new List<Documento>();
        listaDocumento.Add(new Documento { Id = "1", Descricao = "Registro Geral (RG)" });
        listaDocumento.Add(new Documento { Id = "2", Descricao = "Carteira Nacional de Habilitação (CNH)" });
        listaDocumento.Add(new Documento { Id = "3", Descricao = "Carteira de Trabalho" });
        listaDocumento.Add(new Documento { Id = "4", Descricao = "Passaporte" });
        listaDocumento.Add(new Documento { Id = "5", Descricao = "CPF" });

        return listaDocumento;
        }
     }
}  
