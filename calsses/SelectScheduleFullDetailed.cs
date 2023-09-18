using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project1.classes
{
    public class SelectScheduleFullDetailed
    {
        public int id;
        public string day;
        public string time;
        public string duration;
        public string room;
        public string price;
        public SelectTeacher Teacher = new SelectTeacher();
        public SelectSubject Subject = new SelectSubject();
    }
}
