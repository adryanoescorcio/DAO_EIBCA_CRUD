﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace PIBICAS.Models.Dao
{
    public class MembresiaDAO
    {
        IBCAContext db = new IBCAContext();

        public void InsertOrUpdate(Membresia obj)
        {
            try
            {
                db.Entry(obj).State = obj.MembresiaId == 0 ? EntityState.Added : EntityState.Modified;
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
                var obj = db.Membresias.Find(id);
                db.Membresias.Remove(obj);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao excluir Objeto" + ex.Message);
            }
        }

        public Membresia PesquisarPorUsuarioId(int usuarioId)
        {
            try
            {
                var objeto = db.Membresias.FirstOrDefault(x => x.MembresiaUsuarioId == usuarioId);
                db.Dispose();
                return objeto;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<Membresia> CarregarDados()
        {
            try
            {
                var dados = db.Membresias;

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public Membresia PesquisarPorId(int id)
        {
            try
            {
                var objeto = db.Membresias.FirstOrDefault(x => x.MembresiaId == id);
                db.Dispose();
                return objeto;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}