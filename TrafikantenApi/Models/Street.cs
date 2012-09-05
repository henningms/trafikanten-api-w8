using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Runtime.Serialization;
using System.Windows;

namespace TrafikantenApi.Models
{
    [DataContract]
    public class Street : Place
    {
        private ObservableCollection<House> _houses;

        [DataMember]
        public ObservableCollection<House> Houses
        {
            get
            {
                return _houses;
            }
            set
            {
                _houses = value;
                NotifyPropertyChanged("Houses");
            }
        }
    }

    [DataContract]
    public class House : BaseModel
    {
        private long _x, _y;
        private string _name;

        [DataMember]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }
        
        [DataMember]
        public long X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
                NotifyPropertyChanged("X");
            }
        }

        [DataMember]
        public long Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
                NotifyPropertyChanged("Y");
            }
        }
    }
}
