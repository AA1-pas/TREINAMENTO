using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculandoIdade.Controllers
{
    public class CalculoIdadeController : ApiController
    {
        /// <summary>
        /// Retorna nome da aplicação e o que ela faz
        /// </summary>
        /// <returns>Retorna o que nosso app faz</returns>
        public string Get()
        {
            return "App para poder beber hoje!";
        }

        public string Get(int anoNascimento, string nome="Defaut")
        {
            

            if ((DateTime.Now.Year - anoNascimento) >= 18)
            {
                return $"De acordo com os calculos realizados em nosso servidor, o sistema indica que você {nome}" +
                    " poderá desfrutar de recursos hídricos alcoólicos.";
            }
            else
            {
                return "Felizmente as fazendos de sucos e leites estão aberta ;)";
            }
        }
    }
}
