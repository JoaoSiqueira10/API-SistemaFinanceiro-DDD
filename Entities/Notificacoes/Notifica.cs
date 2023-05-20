using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Notificacoes
{
    public class Notifica
    {
        public Notifica()
        {
            notificacoes = new List<Notifica>();
        }

        [NotMapped]
        public string NomePropriedade { get; set; }

        [NotMapped]
        public string mensagem { get; set; }

        [NotMapped]
        public List<Notifica> notificacoes;

        public bool ValidarPropriedadeString(string valor, string nomePropriedade)
        {
            // verifica se campo foi digitado que é string, se nao foi editado,
            // o metodo insere o nome da propriedade e envia uma mensagem de erro
            // para saber qual propriedade que foi validada que irá retornar para o chamador da API
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                notificacoes.Add(new Notifica
                {
                    mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropriedade
                });
                return false;
            }
            return true;
        }

        public bool ValidarPropriedadeInt(int valor, string nomePropriedade)
        {
            // exatamente igual porem para inteiros
            if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                notificacoes.Add(new Notifica
                {
                    mensagem = "Campo Obrigatório",
                    NomePropriedade = "nomePropriedade"
                });
                return false;
            }
            return true;
        }
    }
}
