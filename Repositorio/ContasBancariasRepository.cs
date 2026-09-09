using Entidades;
using Repositorio.Infra;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio
{
    public class ContasBancariasRepository
    {
        private readonly DataContext _dataContext;
        
        public ContasBancariasRepository()
        {
            _dataContext = GeradorDeServicos.CarregarContexto();
        }
        
        public void Inserir(ContaBancaria contaBancaria)
        {
            //Inserir no banco de dados;

            contaBancaria.Id = Guid.NewGuid();

            _dataContext.Add(contaBancaria);

            _dataContext.SaveChanges();
        }
    }
}
