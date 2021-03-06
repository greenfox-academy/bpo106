﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Entities;

namespace TodoApp.Repositories
{
    public class TodoRepository
    {
        Context context;

        public TodoRepository(Context context)
        {
            this.context = context;
        }

        public void Add(string title)
        {
            context.Todos.Add(new Models.Todo { Id = 1, Title = title, IsDone = false, IsUrgent = false });
        }
    }
}
