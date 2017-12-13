using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace PIBICAS.Models.Dao
{
    public class ClassePlanoAulaDAO
    {
        IBCAContext db = new IBCAContext();

        public void InsertOrUpdate(ClassePlanoAula obj)
        {
            try
            {
                db.Entry(obj).State = obj.ClassePlanoAulaId == 0 ? EntityState.Added : EntityState.Modified;
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
                var obj = db.ClassePlanoAulas.Find(id);
                db.ClassePlanoAulas.Remove(obj);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao excluir Objeto" + ex.Message);
            }
        }

        public IQueryable<ClassePlanoAula> CarregarDados()
        {
            try
            {
                var dados = db.ClassePlanoAulas;

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public int PesquisarPorClassePlano(int idPlano, int idClasse)
        {
            return db.ClassePlanoAulas.FirstOrDefault(x => x.ClasseId == idClasse && x.PlanoAulaId == idPlano).ClassePlanoAulaId;
        }

        public ClassePlanoAula PesquisarPorId(int id)
        {
            try
            {
                return db.ClassePlanoAulas.FirstOrDefault(x => x.ClassePlanoAulaId == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}