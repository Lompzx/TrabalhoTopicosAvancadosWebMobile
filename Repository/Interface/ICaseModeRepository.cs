using System.Collections.Generic;
using Trabalho.Models;

namespace Trabalho.Repository.Interface
{
    public interface ICaseModeRepository
    {
        //Interface que impelemtara os métodos do \repositorio
        IEnumerable<CaseModeModel> GetAll();
        CaseModeModel GetById(int id);
        void Save(CaseModeModel model);
        void Delete(int id);
        void Update(CaseModeModel model);
    }
}
