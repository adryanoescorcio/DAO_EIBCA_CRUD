using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace PIBICAS.Models.Dao
{
    public class PerfilDAO
    {
        IBCAContext db = new IBCAContext();

        public void InsertOrUpdate(Perfil obj)
        {
            try
            {
                db.Entry(obj).State = obj.PerfilId == 0 ? EntityState.Added : EntityState.Modified;
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
                var obj = db.Perfils.Find(id);
                db.Perfils.Remove(obj);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao excluir Objeto" + ex.Message);
            }
        }

        public IQueryable<Perfil> CarregarDados()
        {
            try
            {
                var dados = db.Perfils;

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public Perfil PesquisarPorId(int id)
        {
            try
            {
                return db.Perfils.FirstOrDefault(x => x.PerfilId == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}