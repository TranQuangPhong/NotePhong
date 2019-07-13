using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Note_Phong.Model
{
    public class DBDetailForm
    {
        public static string DB_TABLE_NAME = "DetailForm";

        public string Name { get; set; }
        public int Id { get; set; }
        public int Level { get; set; }
        //public DateTime StartDate { get; set; }
        public DateTime Deadline { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string TaskList { get; set; }
        public int ParentId { get; set; }

        //Constructor, set default values
        public DBDetailForm()
        {
            Name = "";
            Id = -1;
            Level = -1;
            //StartDate = DateTimePicker.MinimumDateTime; //default value - to compatible with range of DateTimePicker.Value in Form
            Deadline = DateTimePicker.MinimumDateTime; //default valueS
            Status = "on going";
            Description = "";
            TaskList = "Task list+";
            ParentId = -1;
        }
        //Constructor with id
        public DBDetailForm(int id)
        {
            Name = "";
            Id = id;
            Level = -1;
            //StartDate = DateTimePicker.MinimumDateTime; //default value
            Deadline = DateTimePicker.MinimumDateTime; //default value
            Status = "on going";
            Description = "";
            TaskList = "Task list+";
            ParentId = -1;
        }
        public DBDetailForm (DBDetailForm db) {
            Name = db.Name;
            Id = db.Id;
            Level = db.Level;
            //StartDate = DateTimePicker.MinimumDateTime; //default value
            Deadline = db.Deadline;
            Status = db.Status;
            Description = db.Description;
            TaskList = db.TaskList;
            ParentId = db.ParentId;
        }
    }
}
