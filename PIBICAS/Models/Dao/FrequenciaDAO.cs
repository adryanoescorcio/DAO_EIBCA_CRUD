using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

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
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao excluir Objeto" + ex.Message);
            }
        }

        public IQueryable<Frequencia> CarregarDados()
        {
            try
            {
                var dados = db.Frequencias;

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
                return db.Frequencias.FirstOrDefault(x => x.FrequenciaId == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}