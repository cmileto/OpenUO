﻿#region License Header

// Copyright (c) 2015 OpenUO Software Team.
// All Right Reserved.
// 
// IChainStep.cs
// 
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 3 of the License, or
// (at your option) any later version.

#endregion

namespace OpenUO.Core.Patterns
{
    public interface IChainStep<T>
        where T : class
    {
        string Name
        {
            get;
        }

        bool CancelExecution
        {
            get;
            set;
        }

        IChainStep<T> Successor
        {
            get;
            set;
        }

        IChain<T> Chain
        {
            get;
            set;
        }

        ChainDependency[] Dependencies
        {
            get;
        }

        void Execute(T state);
    }

    public class ChainDependency
    {
        public ChainDependency(string name, bool mustExist)
        {
            Name = name;
            MustExist = mustExist;
        }

        public string Name
        {
            get;
            set;
        }

        public bool MustExist
        {
            get;
            set;
        }
    }
}