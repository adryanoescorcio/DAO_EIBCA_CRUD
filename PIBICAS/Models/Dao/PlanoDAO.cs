﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace PIBICAS.Models.Dao
{
    public class PlanoDAO
    {
        IBCAContext db = new IBCAContext();

        public void InsertOrUpdate(Plano obj)
        {
            try
            {
                db.Entry(obj).State = obj.PlanoId == 0 ? EntityState.Added : EntityState.Modified;
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
                var obj = db.Planoes.Find(id);
                db.Planoes.Remove(obj);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao excluir Objeto" + ex.Message);
            }
        }

        public IQueryable<Plano> CarregarDados()
        {
            try
            {
                var dados = db.Planoes;

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Error ao carregar os dados" + ex.Message);
            }
        }

        public Plano PesquisarPorId(int id)
        {
            try
            {
                return db.Planoes.FirstOrDefault(x => x.PlanoId == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}