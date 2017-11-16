using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace PIBICAS.Models.Dao
{
    public class AcessoDAO
    {
        IBCAContext db = new IBCAContext();

        public void InsertOrUpdate(Acesso acesso)
        {
            try
            {
                db.Entry(acesso).State = acesso.AcessoId == 0 ? EntityState.Added : EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao cadastrar um acesso!" + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var acesso = db.Acessoes.Find(id);
                db.Acessoes.Remove(acesso);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao excluir o Acesso" + ex.Message);
            }
        }

        public IQueryable<Acesso> CarregarDados()
        {
            try
            {
                var dados = db.Acessoes;

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public Acesso PesquisarPorId(int id)
        {
            try
            {
                return db.Acessoes.FirstOrDefault(x => x.AcessoId == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Acesso PesquisarPorIdSaida(int id)
        {
            try
            {
                return db.Acessoes.FirstOrDefault(x => x.AcessoId == id && x.AcessoDataSaida == null);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}