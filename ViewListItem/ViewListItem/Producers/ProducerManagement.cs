using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewListItem.Producers
{
    class ProducerManagement
    {
        public Producer[] getProducer()
        {
            var db = new MyDataBaseSuperMarketEntities();
            return db.Producers.ToArray();
        }
        public Producer getProducers(int id)
        {
            var db = new 
        }
    }
}
