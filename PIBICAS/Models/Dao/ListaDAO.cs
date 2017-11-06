using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace PIBICAS.Models.Dao
{
    public class ListaDAO
    {
        IBCAContext db = new IBCAContext();

        public void InsertOrUpdate(Lista obj)
        {
            try
            {
                db.Entry(obj).State = obj.ListaId == 0 ? EntityState.Added : EntityState.Modified;
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
                var obj = db.Listas.Find(id);
                db.Listas.Remove(obj);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao excluir Objeto" + ex.Message);
            }
        }

        public IQueryable<Lista> CarregarDados()
        {
            try
            {
                var dados = db.Listas;

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public Lista PesquisarPorId(int id)
        {
            try
            {
                return db.Listas.FirstOrDefault(x => x.ListaId == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}