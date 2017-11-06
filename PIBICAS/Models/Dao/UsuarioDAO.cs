using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace PIBICAS.Models.Dao
{
    public class UsuarioDAO
    {
        IBCAContext db = new IBCAContext();

        public void InsertOrUpdate(Usuario obj)
        {
            try
            {
                db.Entry(obj).State = obj.UsuarioId == 0 ? EntityState.Added : EntityState.Modified;
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
                var obj = db.Usuarios.Find(id);
                db.Usuarios.Remove(obj);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao excluir Objeto" + ex.Message);
            }
        }

        public IQueryable<Usuario> CarregarDados()
        {
            try
            {
                var dados = db.Usuarios;

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public Usuario PesquisarPorId(int id)
        {
            try
            {
                return db.Usuarios.FirstOrDefault(x => x.UsuarioId == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}