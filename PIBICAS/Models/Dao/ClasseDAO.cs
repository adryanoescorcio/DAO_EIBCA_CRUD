using System;
using System.Linq;
using System.Data;
using System.Data.Entity;
using PIBICAS.Models.Context;

namespace PIBICAS.Models.Dao
{
    public class ClasseDAO
    {
        IBCAContext db = new IBCAContext();

        public void InsertOrUpdate(Classe obj)
        {
            try
            {
                db.Entry(obj).State = obj.ClasseId == 0 ? EntityState.Added : EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao cadastrar um Classe!" + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var obj = db.Classes.Find(id);
                db.Classes.Remove(obj);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao excluir o Classe" + ex.Message);
            }
        }

        public IQueryable<Classe> CarregarDados()
        {
            try
            {
                var dados = from a in db.Classes
                            orderby a.ClasseDataInicio ascending, a.ClasseStatus ascending
                            select a;

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public DbSet CarregarDadosDS()
        {
            try
            {
                var dados = (from a in db.Classes
                            orderby a.ClasseDataInicio ascending, a.ClasseStatus ascending
                            select new Classe { }).ToList();

                DataTable tb = new DataTable("Classe");
                return db.Classes;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public Classe PesquisarPorId(int id)
        {
            try
            {
                return db.Classes.FirstOrDefault(x => x.ClasseId == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}