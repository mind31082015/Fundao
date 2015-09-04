using System.Dynamic;

namespace PhotoFundao.Test.Common
{
    public static class TestHelper
    {
        public static dynamic Bag { get; private set; }

        static TestHelper()
        {
            Bag = new ExpandoObject();
        }
    }
}
