﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Threading.Tasks;

namespace SF_DataExport
{
    public static class TaskExtension
    {
        public static ConfiguredTaskAwaitable GoOn(this Task task) => task.ConfigureAwait(false);

        public static ConfiguredTaskAwaitable<TResult> GoOn<TResult>(this Task<TResult> task) => task.ConfigureAwait(false);
    }
}
