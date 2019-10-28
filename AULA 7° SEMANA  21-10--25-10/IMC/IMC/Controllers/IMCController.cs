using IMC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace IMC.Controllers
{
    
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class IMCController : ApiController
    {
        Model1 dbContext = new Model1();
        public string Get(string nome, double peso, double altura)
        {
            var imc = (peso / (altura * altura)).ToString("N2");
            return $"Olá {nome} seu IMC é {imc} e ele foi calculado de acordo com sua Altura: {altura}m e Peso: {peso}kg";
        }
        
        public string Post(Table param)
        {
            var imc = (param.Peso / (param.Altura*param.Altura)).ToString("N2");
            return $"Olá {param.Nome} seu IMC é {imc} e ele foi calculado de acordo com sua Altura: {param.Altura}m e Peso: {param.Peso}kg";
        }

        public string Put(Table param)
        {
            param.Imc = (param.Peso / (param.Altura * param.Altura));
            if (param.Nome == null)
                return "Operação não realizada";
            dbContext.Tables.Add(param);
            dbContext.SaveChanges();
            return $"Registro salvo com sucesso:  Nome: {param.Nome}  Altura: {param.Altura}m e Peso: {param.Peso}kg";
        }

        public bool Patch(Table param)
        {
            var obj = dbContext.Tables.FirstOrDefault(x => x.Id == param.Id);
            if (obj == null)
                return false;
            obj.Imc = param.Peso / (param.Altura * param.Altura);
            obj.Nome = param.Nome;
            obj.Altura = param.Altura;
            obj.Peso = param.Peso;
            dbContext.SaveChanges();
            return true;
        }

        public IQueryable<Table> Get()
        {
            return dbContext.Tables;
        }
    }
}
