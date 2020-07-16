using System.Collections.Generic;

namespace Library
{
    public interface IYieldExample
    {
        IEnumerable<int> YeildExampleMethod(IEnumerable<int> list);
    }
}