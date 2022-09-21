using Microsoft.Win32.SafeHandles;

namespace MathFuncs
{
    internal class MyMathFuncsSafeHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public MyMathFuncsSafeHandle() : base(true) { }

        public IntPtr Ptr => handle;

        protected override bool ReleaseHandle()
        {
            // TODO: Release the handle here
            return true;
        }
    }
}
