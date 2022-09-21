namespace MathFuncs
{
    public class MathFuncs : IDisposable
    {
        private readonly MyMathFuncsSafeHandle _handle;
        
        public MathFuncs()
        {
            _handle = MyMathFuncsWrapper.CreateMyMathFuncs();
        }

        public double Add(double x, double y) => MyMathFuncsWrapper.Add(_handle, x, y);

        public double Substract(double x, double y) => MyMathFuncsWrapper.Subtract(_handle, x, y);

        public void Dispose()
        {
            if (_handle is not null)
            {
                MyMathFuncsWrapper.DisposeMyMathFuncs(_handle);
            }
        }
    }
}
