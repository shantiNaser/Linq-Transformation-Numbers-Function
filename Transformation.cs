using System.Collections.Generic;

namespace Linq2
{
    // following the examples in the lessons, declare the type
    // TransformationFunction as a delegate that takes a single
    // int parameter and returns an int result.

    public delegate int TransformationFunction(int A);

    // Write the extension method (and containing class) here,
    // following the examples in the lessons. The method should
    // be called Transform(), extend IEnumerable<int>, take an
    // extra parameter of type TransformationFunction, and
    // return an IEnumerable<int>.

    public static class Transformation
    {
        public static IEnumerable<int> Transform(this IEnumerable<int> items, TransformationFunction transformer)
        {
            foreach (var item in items)
            {
                yield return transformer(item);
            }

        }
    }
}