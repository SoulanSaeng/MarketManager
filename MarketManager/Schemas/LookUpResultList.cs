using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MarketManager.Schemas
{ 
    public class LookupResultList
    {
        public  List<LookupResult> Lookup { get; set; }  
    }
}
