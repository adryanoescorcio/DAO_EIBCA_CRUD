﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

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
                var dados = db.Classes;

                return dados;
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