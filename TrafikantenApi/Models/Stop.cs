using System;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace TrafikantenApi.Models
{
    public class Stop : Place
    {
        private int _walkingdistance, _rank;
        private bool? _alightingAllowed, _boardingAllowed;
        private bool? _realtimestop;
        private String _departureTime, _arrivalTime;
        private ObservableCollection<Line> _lines;
        private ObservableCollection<StopPoint> _stopPoints;

        [DataMember]
        public int WalkingDistance
        {
            get
            {
                return _walkingdistance;
            }
            set
            {
                if (_walkingdistance == value) return;

                _walkingdistance = value;
                NotifyPropertyChanged("WalkingDistance");
            }
        }

        [DataMember(Name = "ArrivalTime")]
        private String arrivalTime
        {
            get
            {
                return _arrivalTime;
            }
            set
            {
                if (_arrivalTime == value) return;
                
                _arrivalTime = value;

                NotifyPropertyChanged("ArrivalTime");
            }
        }

        public DateTime ArrivalTime
        {
            get
            {
                if (!String.IsNullOrEmpty(arrivalTime))
                    return DateTime.Parse(arrivalTime);
                else
                    return default(DateTime);
            }
        }

        [DataMember]
        public bool? AlightingAllowed
        {
            get
            {
                return _alightingAllowed;
            }
            set
            {
                if (_alightingAllowed == value) return;

                _alightingAllowed = value;
                NotifyPropertyChanged("AlightingAllowed");
            }
        }

        [DataMember(Name = "DepartureTime")]
        private String departureTime
        {
            get
            {
                return _departureTime;
            }
            set
            {
                if (_departureTime == value) return;

                _departureTime = value;
                NotifyPropertyChanged("DepartureTime");
            }
        }

        public DateTime DepartureTime
        {
            get
            {
                if (!String.IsNullOrEmpty(departureTime))
                    return DateTime.Parse(departureTime);
                else
                    return default(DateTime);
            }
        }

        [DataMember]
        public bool? BoardingAllowed
        {
            get
            {
                return _boardingAllowed;
            }
            set
            {
                if (_boardingAllowed == value) return;

                _boardingAllowed = value;
                NotifyPropertyChanged("BoardingAllowed");
            }
        }

        [DataMember]
        public bool? RealTimeStop
        {
            get
            {
                return _realtimestop;
            }
            set
            {
                if (_realtimestop == value) return;

                _realtimestop = value;
                NotifyPropertyChanged("RealTimeStop");
            }
        }

        [DataMember]
        public int Rank
        {
            get
            {
                return _rank;
            }
            set
            {
                if (_rank == value) return;

                _rank = value;
                NotifyPropertyChanged("Rank");
            }
        }

        [DataMember]
        public ObservableCollection<Line> Lines
        {
            get
            {
                return _lines;
            }
            set
            {
                if (_lines == value) return;

                _lines = value;
                NotifyPropertyChanged("Lines");
            }
        }

        [DataMember]
        public ObservableCollection<StopPoint> StopPoints
        {
            get
            {
                return _stopPoints;
            }
            set
            {
                if (_stopPoints == value) return;

                _stopPoints = value;
                NotifyPropertyChanged("StopPoints");
            }
        }
    }
}
