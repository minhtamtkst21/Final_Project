using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewListItem
{
    class ItemManagement
    {
        public Item[] getItem()
        {
            var db = new MyDataBaseSuperMarketEntities();
            return db.Items.ToArray();
        }
        public Item getItems(int id)
        {
            var db = new MyDataBaseSuperMarketEntities();
            return db.Items.Find(id);
        }
        public void addItem(string code, string name, int producer, int price, int amount)
        {
            var item = new Item();
            item.Code = code;
            item.Name = name;
            item.Producer = producer;
            item.Amount = amount;

            var db = new MyDataBaseSuperMarketEntities();
            db.Items.Add(item);
            db.SaveChanges();
        }
        public void UpdateItem(int id, string name, int producer, int price, int amount)
        {
            var item = new Item();
            item.Name = name;
            item.Producer = producer;
            item.Amount = amount;

            var db = new MyDataBaseSuperMarketEntities();
            db.Entry(item).State= System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteItem(int id)
        {
            var item = new Item();
            var db = new MyDataBaseSuperMarketEntities();
            db.Items.Remove(item);
            db.SaveChanges();
        }
        public void ViewAZ()
        {
            var item = new Item();
            var db = new MyDataBaseSuperMarketEntities();
            Item[] list = db.Items.ToArray();
            var orderByAZ = from name in list
                            orderby name.Name
                            select name;
        }

    }
}
