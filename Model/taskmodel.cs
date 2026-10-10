using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementAPI.Model
{
    public class taskmodel
    {
        public int Id{get; set;}
        public string Title{get; set;}="";
        public bool IsCompleted{get; set;}
    }
}