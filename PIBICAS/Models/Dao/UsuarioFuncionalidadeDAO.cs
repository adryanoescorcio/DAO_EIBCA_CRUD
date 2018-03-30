using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using PIBICAS.Models.Context;

namespace PIBICAS.Models.Dao
{
    public class UsuarioFuncionalidadeDAO
    {
        IBCAContext db = new IBCAContext();

        public void InsertOrUpdate(UsuarioFuncionalidade obj)
        {
            try
            {
                db.Entry(obj).State = obj.UsuarioFuncionalidadeId == 0 ? EntityState.Added : EntityState.Modified;
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
                var obj = db.UsuarioFuncionalidades.Find(id);
                db.UsuarioFuncionalidades.Remove(obj);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao excluir Objeto" + ex.Message);
            }
        }

        public IQueryable<UsuarioFuncionalidade> CarregarDados()
        {
            try
            {
                var dados = db.UsuarioFuncionalidades;

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public UsuarioFuncionalidade PesquisarPorId(int id)
        {
            try
            {
                return db.UsuarioFuncionalidades.FirstOrDefault(x => x.UsuarioFuncionalidadeId == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}