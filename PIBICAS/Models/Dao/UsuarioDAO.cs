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
                var obj = db.Usuarios.Find(id);
                db.Usuarios.Remove(obj);
                db.SaveChanges();
                db.Dispose();
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
                db.Dispose();
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
                var obj = db.Usuarios.FirstOrDefault(x => x.UsuarioId == id);
                db.Dispose();
                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuario PesquisarPorEmail(String _email)
        {
            try
            {
                var obj = db.Usuarios.FirstOrDefault(x => x.UsuarioEmail == _email && x.UsuarioStatus == "Ativo");
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