using System.ComponentModel;
using System.Xml.Serialization;

namespace MarketManager.Schemas
{ 
    public class LookupResult : INotifyPropertyChanged
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Exchange { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}