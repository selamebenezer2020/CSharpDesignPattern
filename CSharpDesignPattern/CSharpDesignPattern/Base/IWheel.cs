﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace CSharpDesignPattern
{
    public interface IWheel : IVisitable
    {
        int size { get; }
        bool isWide { get; }
        void AcceptVisitor(IWheelVisitor visitor);
    }
}
