using System;
using System.Collections.Generic;
using System.Linq;

namespace Host
{
    static partial class Program
    {
        static bool Parity(this IEnumerable<bool> bitVector) =>
            bitVector.Aggregate(
                (acc, next) => acc ^ next
            );

        static string ToDelimitedString(this IEnumerable<bool> values) =>
            String.Join(", ", values.Select(x => x.ToString()));
    }
}
