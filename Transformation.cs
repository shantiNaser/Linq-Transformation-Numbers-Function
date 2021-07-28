using System.Collections.Generic;

namespace Linq2
{
    // Uncomment the TransformationFunction delegate declaration
    //
    // following the examples in the lessons, declare the type
    // TransformationFunction as a delegate that takes a single
    // int parameter and returns an int result.

    public delegate int TransformationFunction(int A);

    // Write the extension method (and containing class) here,
    // following the examples in the lessons. The method should
    // be called Transform(), extend IEnumerable<int>, take an
    // extra parameter of type TransformationFunction, and
    // return an IEnumerable<int>.

    public static class naser
    {
        public static IEnumerable<int> Transform(this IEnumerable<int> Li, TransformationFunction number)
        {
            foreach (var item in Li)
            {
                yield return number(item);
            }

        }
    }
}