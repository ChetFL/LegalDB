using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using LegalDB.Models;

namespace LegalDB.Repositories
{
    public class ICCallLogInfoRepository : IRepository<ICCallLog, int>
    {
        [Dependency]
        public LegalDBWebEntities context { get; set; }

        public IEnumerable<ICCallLog> Get()
        {
            return context.ICCallLogs.ToList();
        }

        public ICCallLog Get(int id)
        {
            return context.ICCallLogs.Find(id);
        }

        public void Add(ICCallLog entity)
        {
            context.ICCallLogs.Add(entity);
            context.SaveChanges();
        }

        public void Remove(ICCallLog entity)
        {
            var obj = context.ICCallLogs.Find(entity.ID);
            context.ICCallLogs.Remove(obj);
            context.SaveChanges();
        }
    }
}