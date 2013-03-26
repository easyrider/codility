using System;

namespace CrackingCodingInterview
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class ReferenceAttribute : Attribute
    {
        public string Number { get; set; }
        public int Page { get; set; }
        public string Description { get; set; }
        public int Variant { get; set; }
        public string Comments { get; set; }
        public bool Incorrect { get; set; }
        public bool NoTestRequired { get; set; }
    }
}
