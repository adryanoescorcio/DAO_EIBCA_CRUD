using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using PIBICAS.Models.Context;

namespace PIBICAS.Models.Dao
{
    public class FrequenciaDAO
    {
        IBCAContext db = new IBCAContext();

        public void InsertOrUpdate(Frequencia obj)
        {
            try
            {
                db.Entry(obj).State = obj.FrequenciaId == 0 ? EntityState.Added : EntityState.Modified;
                db.SaveChanges();
                db.Dispose();
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
                var obj = db.Frequencias.Find(id);
                db.Frequencias.Remove(obj);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao excluir Objeto" + ex.Message);
            }
        }

        public IQueryable<Object> CarregarDados(int idClasse)
        {
            try
            {
                var dados = (from a in db.Frequencias
                             join b in db.Planoes on a.PlanoId equals b.PlanoId
                             where a.ClasseId == idClasse select new { a.Plano.PlanoDescricao, a.ClasseId, a.FrequenciaUnique,a.FrequenciaData }).Distinct();

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public Frequencia PesquisarPorId(int id)
        {
            try
            {
                var _dado = db.Frequencias.FirstOrDefault(x => x.FrequenciaId == id);
                return _dado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Frequencia PesquisarPorIdUnique(String id)
        {
            try
            {
                var _dado = db.Frequencias.FirstOrDefault(x => x.FrequenciaUnique == id);
                return _dado;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}