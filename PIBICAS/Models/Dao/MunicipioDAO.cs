using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace PIBICAS.Models.Dao
{
    public class MunicipioDAO
    {
        IBCAContext db = new IBCAContext();

        public void InsertOrUpdate(Municipio obj)
        {
            try
            {
                db.Entry(obj).State = obj.MunicipioId == 0 ? EntityState.Added : EntityState.Modified;
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
                var obj = db.Municipios.Find(id);
                db.Municipios.Remove(obj);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao excluir Objeto" + ex.Message);
            }
        }

        public IQueryable<Municipio> CarregarDados()
        {
            try
            {
                var dados = db.Municipios;

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public Municipio PesquisarPorId(int id)
        {
            try
            {
                return db.Municipios.FirstOrDefault(x => x.MunicipioId == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<Municipio> CarregarMunicipios(int _idUf)
        {
            try
            {
                var dados = db.Municipios.Where(x => x.MunicipioIdUf == _idUf);

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }
    }
}