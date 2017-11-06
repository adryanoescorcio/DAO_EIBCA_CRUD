using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace PIBICAS.Models.Dao
{
    public class MembresiaDAO
    {
        IBCAContext db = new IBCAContext();

        public void InsertOrUpdate(Membresia obj)
        {
            try
            {
                db.Entry(obj).State = obj.MembresiaId == 0 ? EntityState.Added : EntityState.Modified;
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
                var obj = db.Membresias.Find(id);
                db.Membresias.Remove(obj);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao excluir Objeto" + ex.Message);
            }
        }

        public IQueryable<Membresia> CarregarDados()
        {
            try
            {
                var dados = db.Membresias;

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public Membresia PesquisarPorId(int id)
        {
            try
            {
                return db.Membresias.FirstOrDefault(x => x.MembresiaId == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}