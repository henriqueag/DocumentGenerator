using System.Collections.Generic;

namespace DocumentGenerator.Api.Entities
{
    public class EstadosBR
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public static IList<EstadosBR> GetEstadosBR()
        {
            return new EstadosBR[]
            {
                new EstadosBR{Nome =  "Acre", Sigla =  "AC"},
                new EstadosBR{Nome =  "Alagoas", Sigla =  "AL"},
                new EstadosBR{Nome =  "Amap�", Sigla =  "AP"},
                new EstadosBR{Nome =  "Amazonas", Sigla =  "AM"},
                new EstadosBR{Nome =  "Bahia", Sigla =  "BA"},
                new EstadosBR{Nome =  "Cear�", Sigla =  "CE"},
                new EstadosBR{Nome =  "Distrito Federal", Sigla =  "DF"},
                new EstadosBR{Nome =  "Esp�rito Santo", Sigla =  "ES"},
                new EstadosBR{Nome =  "Goi�s", Sigla =  "GO"},
                new EstadosBR{Nome =  "Maranh�o", Sigla =  "MA"},
                new EstadosBR{Nome =  "Mato Grosso", Sigla =  "MT"},
                new EstadosBR{Nome =  "Mato Grosso do Sul", Sigla =  "MS"},
                new EstadosBR{Nome =  "Minas Gerais", Sigla =  "MG"},
                new EstadosBR{Nome =  "Par�", Sigla =  "PA"},
                new EstadosBR{Nome =  "Para�ba", Sigla =  "PB"},
                new EstadosBR{Nome =  "Paran�", Sigla =  "PR"},
                new EstadosBR{Nome =  "Pernambuco", Sigla =  "PE"},
                new EstadosBR{Nome =  "Piau�", Sigla =  "PI"},
                new EstadosBR{Nome =  "Rio de Janeiro", Sigla =  "RJ"},
                new EstadosBR{Nome =  "Rio Grande do Norte", Sigla =  "RN"},
                new EstadosBR{Nome =  "Rio Grande do Sul", Sigla =  "RS"},
                new EstadosBR{Nome =  "Rond�nia", Sigla =  "RO"},
                new EstadosBR{Nome =  "Roraima", Sigla =  "RR"},
                new EstadosBR{Nome =  "Santa Catarina", Sigla =  "SC"},
                new EstadosBR{Nome =  "S�o Paulo", Sigla =  "SP"},
                new EstadosBR{Nome =  "Sergipe", Sigla =  "SE"},
                new EstadosBR{Nome =  "Tocantins", Sigla =  "TO"}
            };
        }
    }
}