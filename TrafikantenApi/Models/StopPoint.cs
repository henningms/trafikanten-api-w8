using System;
using System.Net;
using System.Runtime.Serialization;
using System.Windows;

namespace TrafikantenApi.Models
{
    [DataContract]
    public class StopPoint : BaseModel
    {
        private int _id;
        private long _x, _y;
        private string _name;

        [DataMember]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id == value) return;

                _id = value;
                NotifyPropertyChanged("ID");
            }
        }

        [DataMember]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name == value) return;

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
                if (_x == value) return;

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
                if (_y == value) return;

                _y = value;
                NotifyPropertyChanged("Y");
            }
        }

    }
}
