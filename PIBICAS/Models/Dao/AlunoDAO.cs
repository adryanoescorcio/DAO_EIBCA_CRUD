using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using PIBICAS.Models.Context;

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
                db.Dispose();
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

                db.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao excluir o Aluno" + ex.Message);
            }
        }

        public IQueryable<Object> CarregarDados(int idClasse)
        {
            try
            {
                var dados = from a in db.Alunoes
                            join b in db.Listas on a.AlunoId equals b.ListaAlunoId
                            where b.ListaClasseId == idClasse
                            orderby a.AlunoNome
                            select new
                            {
                                a.AlunoNome,
                                a.AlunoCPF,
                                a.AlunoSituacao,
                                a.AlunoId,
                                a.AlunoDiscipulador,
                                b.ListaId,
                                FrequenciaId = 0,
                                FrequenciaSituacao = 1,
                                presenca = (from c in db.Frequencias where b.ListaId == c.ListaId & c.FrequenciaSituacao == "1" select new { c.ListaId }).Count(),
                                faltas = (from c in db.Frequencias where b.ListaId == c.ListaId & c.FrequenciaSituacao == "0" select new { c.Lista }).Count(),
                            };

                var teste = from c in dados select new { c, total = c.presenca + c.faltas };

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public IQueryable<Object> CarregarDadosDiario(int idClasse, string idDiario)
        {
            try
            {
                var dados = from a in db.Alunoes
                            join b in db.Listas on a.AlunoId equals b.ListaAlunoId
                            join c in db.Frequencias on b.ListaId equals c.ListaId
                            where b.ListaClasseId == idClasse && c.FrequenciaUnique == idDiario
                            orderby a.AlunoNome
                            select new { a.AlunoNome, a.AlunoCPF, a.AlunoSituacao, a.AlunoId, b.ListaId, c.FrequenciaId, c.FrequenciaSituacao };

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public IQueryable<Object> CarregarDadosAlunoClasse(int idClasse)
        {
            try
            {
                var dados = from a in db.Alunoes
                            join b in db.Listas on a.AlunoId equals b.ListaAlunoId
                            where b.ListaClasseId == idClasse
                            select new { a, b };

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
                var obj = db.Alunoes.FirstOrDefault(x => x.AlunoId == id);
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