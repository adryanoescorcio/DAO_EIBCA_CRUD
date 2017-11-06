using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace PIBICAS.Models.Dao
{
    public class AlunoDAO
    {
        IBCAContext db = new IBCAContext();

        public void InsertOrUpdate(Aluno aluno)
        {
            try
            {
                db.Entry(aluno).State = aluno.AlunoId == 0 ? EntityState.Added : EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao cadastrar um Aluno!" + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var aluno = db.Alunoes.Find(id);
                db.Alunoes.Remove(aluno);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao excluir o Aluno" + ex.Message);
            }
        }

        public IQueryable<Aluno> CarregarDados()
        {
            try
            {
                var dados = db.Alunoes;

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public Aluno PesquisarPorId(int id)
        {
            try
            {
                return db.Alunoes.FirstOrDefault(x => x.AlunoId == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}