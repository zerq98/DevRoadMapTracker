using DevRoadMaps.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevRoadMaps.Domain.Models
{
    public class RoadMapElement : INotifyPropertyChanged
    {
        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        private string linkToInformations;
        public string LinkToInformations
        {
            get { return linkToInformations; }
            set
            {
                linkToInformations = value;
                OnPropertyChanged("LinkToInformations");
            }
        }

        private bool isFinished;
        public bool IsFinished
        {
            get
            {
                return isFinished;
            }
            set
            {
                isFinished = value;
                OnPropertyChanged("IsFinished");
            }
        }

        private List<RoadMapElement> elements;
        public List<RoadMapElement> Elements
        {
            get
            {
                return elements;
            }
            set
            {
                elements = value;
                OnPropertyChanged("Elements");
            }
        }

        private PriorityLevel priorityLevel;
        public PriorityLevel PriorityLevel
        {
            get
            {
                return priorityLevel;
            }
            set
            {
                priorityLevel = value;
                OnPropertyChanged("PriorityLevel");
            }
        }

        public RoadMapElement()
        {
            Elements = new List<RoadMapElement>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
