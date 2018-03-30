using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using PIBICAS.Models.Context;

namespace PIBICAS.Models.Dao
{
    public class FuncionalidadeDAO
    {
        IBCAContext db = new IBCAContext();

        public void InsertOrUpdate(Funcionalidade obj)
        {
            try
            {
                db.Entry(obj).State = obj.FuncionalidadeId == 0 ? EntityState.Added : EntityState.Modified;
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
                var obj = db.Funcionalidades.Find(id);
                db.Funcionalidades.Remove(obj);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao excluir Objeto" + ex.Message);
            }
        }

        public IQueryable<Funcionalidade> CarregarDados()
        {
            try
            {
                var dados = db.Funcionalidades;

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public Funcionalidade PesquisarPorId(int id)
        {
            try
            {
                return db.Funcionalidades.FirstOrDefault(x => x.FuncionalidadeId == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}