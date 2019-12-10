using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewListItem.Producers
{
    class ProducerManagement
    {
        private MyDataBaseSuperMarketEntities db;
        public Producer[] getProducer()
        {
            db = new MyDataBaseSuperMarketEntities();
            return db.Producers.ToArray();
        }
        public Producer getProducers(int id)
        {
            db = new MyDataBaseSuperMarketEntities();
            return db.Producers.Find(id);
        }
        public void AddProducer(string code, string name)
        {
            var producer = new Producer();
            producer.Code = code;
            producer.Name = name;

            db = new MyDataBaseSuperMarketEntities();
            db.Producers.Add(producer);
        }
        public void UpdateProducer(int id, string name)
        {
            var producer = new Producer();
            producer.Name = name;

            db = new MyDataBaseSuperMarketEntities();
            db.Entry(producer).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteProducer(int id)
        {
            db = new MyDataBaseSuperMarketEntities();
            var producer = this.db.Producers.Find(id);
            db.Producers.Remove(producer);
        }
    }
}
