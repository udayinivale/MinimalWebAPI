using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagementAPI.Model;

namespace TaskManagementAPI.services
{
    public class TaskServices:Itaskservices
    {
        private static List<taskmodel> tasks=new List<taskmodel>
        {
            new taskmodel { Id = 1, Title = "Learn C#", IsCompleted = false },
            new taskmodel{ Id = 2, Title = "Practice Web API", IsCompleted = true },
            new taskmodel{ Id = 3, Title = "Learn SQL", IsCompleted = false }
        };
        private static int nextid=4;
        public List<taskmodel> GetTasks()
        {
            return tasks;
        }
        public taskmodel? gettaskbyID(int id)
        {
            return tasks.FirstOrDefault(s=>s.Id==id);
        }
        public taskmodel createtask(taskmodel task)
        {
            task.Id=nextid++;
            tasks.Add(task);
            return task;
        }
        public taskmodel? updatetask(int id,taskmodel task)
        {
            var task1=tasks.FirstOrDefault(s=>s.Id==id);
            if (task1 == null)
            {
                return null;
            }
            task1.Title=task.Title;
            task1.IsCompleted=task.IsCompleted;
            return task1;
        }
        public taskmodel? deletetask(int id)
        {
            var task2=tasks.FirstOrDefault(s=>s.Id==id);
            if (task2 == null)
            {
                return null;
            }
            tasks.Remove(task2);
            return task2;
        }
    }
}
