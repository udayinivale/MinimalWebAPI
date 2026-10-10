using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;
using TaskManagementAPI.Model;

namespace TaskManagementAPI.services
{
    public interface Itaskservices
    {
        public List<taskmodel> GetTasks();
        public taskmodel? gettaskbyID(int id);
        public taskmodel? createtask(taskmodel task);
        public taskmodel? updatetask(int id,taskmodel task);
        public taskmodel? deletetask(int id);
    }
}