﻿using System;

namespace Crdt.Abstract.Interfaces
{
    public interface ICounter : IComparable
    {
        void Increment();

        Int64 Value { get; }

        ICounter Merge(ICounter counter);

        Int64 this[Int32 i] { get; set; }
    }
}
