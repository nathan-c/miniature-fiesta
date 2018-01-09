using System;
using System.Runtime.InteropServices;
namespace Foo
{
    public class Bar
    {
        [DllImport("foobar")]
        public static extern int addOne(int i);
    }
}