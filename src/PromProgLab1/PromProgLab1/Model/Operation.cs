﻿using System.Xml.Serialization;

namespace PromProgLab1.Model
{
    [XmlInclude(typeof(Addition))]
    [XmlInclude(typeof(Substraction))]
    [XmlInclude(typeof(Multiplication))]
    [XmlInclude(typeof(IntDivision))]
    [XmlInclude(typeof(DivisionRemainder))]

    public abstract class Operation
    {
        public abstract int Calculate(int lhs, int rhs);

        public abstract override bool Equals(object? obj);

        public abstract override int GetHashCode();

        public abstract override string ToString();

    }
}
