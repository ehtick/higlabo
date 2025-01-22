﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace HigLabo.Core;

public class ParalellExecutionContext
{
    public List<Task> TaskList { get; private set; } = new List<Task>();

    public Exception? Execute()
    {
        return this.Execute(null);
    }
    public Exception? Execute(Int32 milliseconds)
    {
        return this.Execute(TimeSpan.FromMilliseconds(milliseconds));
    }
    public Exception? Execute(TimeSpan? timeout)
    {
        var tt = this.TaskList;
        foreach (var item in tt)
        {
            if (item.Status == TaskStatus.Created)
            {
                item.Start();
            }
        }
        var allTask = Task.WhenAll(tt);
        try
        {
            if (timeout == null)
            {
                allTask.Wait();
            }
            else
            {
                allTask.Wait(timeout.Value);
            }
        }
        catch { }
        if (allTask == null) { return null; }
        return allTask.Exception;
    }
    public async Task<Exception?> ExecuteAsync(Int32 milliseconds)
    {
        return await this.ExecuteAsync(TimeSpan.FromMilliseconds(milliseconds));
    }
    public async Task<Exception?> ExecuteAsync(TimeSpan timeout)
    {
        var tt = this.TaskList;
        foreach (var item in tt)
        {
            if (item.Status == TaskStatus.Created)
            {
                item.Start();
            }
        }
        var allTask = Task.WhenAll(tt);
        try
        {
            await allTask.WaitAsync(timeout);
        }
        catch { }

        if (allTask == null) { return null; }

        return allTask.Exception;
    }

    public List<T> GetResults<T>()
    {
        var l = new List<T>();
        foreach (var item in this.TaskList)
        {
            if (item.Exception != null) { continue; }

            if (item is Task<T> task)
            {
                if (task.Result != null)
                {
                    l.Add(task.Result);
                }
            }
        }
        return l;
    }
}
