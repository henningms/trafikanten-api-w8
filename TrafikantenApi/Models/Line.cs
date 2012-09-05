using System;
using System.Net;
using System.Runtime.Serialization;
using System.Windows;

namespace TrafikantenApi.Models
{
    [DataContract]
    public class Line : BaseModel
    {
        private int _lineId, _transportation;
        private string _lineName;

        [DataMember]
        public int LineID
        {
            get
            {
                return _lineId;
            }
            set
            {
                if (_lineId == value) return;

                _lineId = value;
                NotifyPropertyChanged("LineID");
            }
        }

        [DataMember]
        public string LineName
        {
            get
            {
                return _lineName;
            }
            set
            {
                if (_lineName == value) return;

                _lineName = value;
                NotifyPropertyChanged("LineName");
            }
        }

        [DataMember]
        public int Transportation
        {
            get
            {
                return _transportation;
            }
            set
            {
                if (_transportation == value) return;

                _transportation = value;
                NotifyPropertyChanged("Transportation");
            }
        }
    }
}
