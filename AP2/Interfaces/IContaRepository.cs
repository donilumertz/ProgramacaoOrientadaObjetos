using System.Collections.Generic;
using AP2.Models;

namespace AP2.Interfaces
{
    public interface IContaRepository
    {
         Conta GetById(int id);
         List<Conta> GetAll();
         void Save(Conta conta);
         void Delete(Conta conta);
         void Update(Conta conta);
    }
}