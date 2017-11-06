using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace PIBICAS.Models.Dao
{
    public class IgrejaDAO
    {
        IBCAContext db = new IBCAContext();

        public void InsertOrUpdate(Igreja obj)
        {
            try
            {
                db.Entry(obj).State = obj.IgrejaId == 0 ? EntityState.Added : EntityState.Modified;
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
                var obj = db.Igrejas.Find(id);
                db.Igrejas.Remove(obj);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao excluir Objeto" + ex.Message);
            }
        }

        public IQueryable<Igreja> CarregarDados()
        {
            try
            {
                var dados = db.Igrejas;

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public Igreja PesquisarPorId(int id)
        {
            try
            {
                return db.Igrejas.FirstOrDefault(x => x.IgrejaId == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}