using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Результат для Partition.
    /// </summary>
    public class PartitionRes<T>
    {
        /// <summary>
        /// Элементы, отвечающие условию.
        /// </summary>
        public IEnumerable<T> True { get; }

        /// <summary>
        /// Элементы, не отвечающие условию.
        /// </summary>
        public IEnumerable<T> False { get; }

        public PartitionRes(IEnumerable<T> trueCollection, IEnumerable<T> falseCollection)
        {
            True = trueCollection;
            False = falseCollection;
        }

        public void Deconstruct(out IEnumerable<T> trueCollection, out IEnumerable<T> falseCollection)
        {
            trueCollection = True;
            falseCollection = False;
        }

        public override string ToString()
        {
            return $"[{True.NilOrString()} - {False.NilOrString()}]";
        }
    }
}
