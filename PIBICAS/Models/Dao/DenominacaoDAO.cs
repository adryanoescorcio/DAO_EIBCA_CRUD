using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using PIBICAS.Models.Context;

namespace PIBICAS.Models.Dao
{
    public class DenominacaoDAO
    {
        IBCAContext db = new IBCAContext();

        public void InsertOrUpdate(Denominacao obj)
        {
            try
            {
                db.Entry(obj).State = obj.DenominacaoId == 0 ? EntityState.Added : EntityState.Modified;
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
                var obj = db.Denominacaos.Find(id);
                db.Denominacaos.Remove(obj);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao excluir Objeto" + ex.Message);
            }
        }

        public IQueryable<Denominacao> CarregarDados()
        {
            try
            {
                var dados = db.Denominacaos;

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public Denominacao PesquisarPorId(int id)
        {
            try
            {
                return db.Denominacaos.FirstOrDefault(x => x.DenominacaoId == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}