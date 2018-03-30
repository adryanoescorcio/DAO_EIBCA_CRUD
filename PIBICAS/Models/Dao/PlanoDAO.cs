using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using PIBICAS.Models.Context;

namespace PIBICAS.Models.Dao
{
    public class PlanoDAO
    {
        IBCAContext db = new IBCAContext();

        public void InsertOrUpdate(Plano obj)
        {
            try
            {
                db.Entry(obj).State = obj.PlanoId == 0 ? EntityState.Added : EntityState.Modified;
                db.SaveChanges();

                db.Dispose();

            }
            catch (Exception ex)
            {
                throw new Exception("Error ao cadastrar Objeto!" + ex.Message);
            }
        }

        public IEnumerable<Object> CarregarDadosDataSet(int v)
        {
            var dados = (from a in db.Planoes
                        join b in db.ClassePlanoAulas on a.PlanoClasseId equals b.ClasseId
                        where b.ClasseId == v && a.PlanoId == b.PlanoAulaId
                        select new { a.PlanoId,a.PlanoClasseId }).AsEnumerable();

            
            return dados;

        }

        public void Delete(int id)
        {
            try
            {
                var obj = db.Planoes.Find(id);
                db.Planoes.Remove(obj);
                db.SaveChanges();

                db.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao excluir Objeto" + ex.Message);
            }
        }

        public IQueryable<Plano> CarregarDados(int idClasse)
        {
            try
            {
                var dados = from a in db.Planoes
                            join b in db.ClassePlanoAulas on a.PlanoClasseId equals b.ClasseId
                            where b.ClasseId == idClasse && a.PlanoId == b.PlanoAulaId
                            select a;

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public Plano PesquisarPorId(int id)
        {
            try
            {
                var obj = db.Planoes.FirstOrDefault(x => x.PlanoId == id);
                db.Dispose();

                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}