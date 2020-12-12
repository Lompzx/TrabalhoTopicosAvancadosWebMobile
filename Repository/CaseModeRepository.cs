using System.Collections.Generic;
using Trabalho.Models;
using Trabalho.Repository.Interface;
using System.Linq;
//Classe responsavel pela obtencao dos dados do banco de dados/rest

namespace Trabalho.Repository
{
    public class CaseModeRepository : ICaseModeRepository
    {
        private readonly TrabalhoContext _context;

        public CaseModeRepository(TrabalhoContext context)
        {
            this._context = context;
        }
        public void Delete(int id)
        {
            CaseModeModel model = this._context.CaseMode.Where(x => x.Id == id).FirstOrDefault();
            this._context.CaseMode.Remove(model);
            this._context.SaveChanges();
        }

        public IEnumerable<CaseModeModel> GetAll()
        {
            return this._context.CaseMode.ToList();
        }

        public CaseModeModel GetById(int id)
        {
            return this._context.CaseMode.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Save(CaseModeModel model)
        {
            this._context.CaseMode.Add(model);
            this._context.SaveChanges();
        }

        public void Update(CaseModeModel model)
        {
            this._context.CaseMode.Update(model);
            this._context.SaveChanges();
        }
    }
}