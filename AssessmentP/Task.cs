using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;

namespace AssessmentP
{
    internal class Task
    {
        private string task;
        private int hour;
        private int minute;
       
        public override string ToString()
        {
            return hour + ":" + minute + " - " + task;
        }
        public string GetTask()
        {
            return task;
        }
        public int GetHour()
        {
            return hour;
        }
        public int GetMinute()
        {
            return minute;
        }
        public void SetTask(string newTask)
        {
            if (newTask.Length > 0)
            {
                task = newTask;
            }
        }
        public void SetHour(int newHour)
        {
            if (newHour < 24 && newHour > 0)
            {
                hour = newHour;
            }
        }
        public void SetMinute(int newMinute)
        {
            if (newMinute <= 59 && newMinute >= 0)
            {
                minute = newMinute;
            }
        }
    }
}
