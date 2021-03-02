using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevRoadMaps.Domain.Models
{
    public class RoadMap : INotifyPropertyChanged
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
                OnPropertChanged("Id");
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertChanged("Name");
            }
        }

        private List<RoadMapElement> skills;
        public List<RoadMapElement> Skills
        {
            get
            {
                return skills;
            }
            set
            {
                skills = value;
                OnPropertChanged("Skills");
            }
        }

        public RoadMap()
        {
            Skills = new List<RoadMapElement>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
