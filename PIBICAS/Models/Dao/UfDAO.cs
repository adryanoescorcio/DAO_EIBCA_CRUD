using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using PIBICAS.Models.Context;

namespace PIBICAS.Models.Dao
{
    public class UfDAO
    {
        IBCAContext db = new IBCAContext();

        public void InsertOrUpdate(Uf obj)
        {
            try
            {
                db.Entry(obj).State = obj.UfId == 0 ? EntityState.Added : EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao cadastrar Objeto!" + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var obj = db.Ufs.Find(id);
                db.Ufs.Remove(obj);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao excluir Objeto" + ex.Message);
            }
        }

        public IQueryable<Uf> CarregarDados()
        {
            try
            {
                var dados = db.Ufs;

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public Uf PesquisarPorId(int id)
        {
            try
            {
                return db.Ufs.FirstOrDefault(x => x.UfId == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}