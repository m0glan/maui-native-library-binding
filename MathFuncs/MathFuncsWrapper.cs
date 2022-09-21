﻿using System.Runtime.InteropServices;

namespace MathFuncs
{
    internal static class MyMathFuncsWrapper
    {
        const string DllName = "MathFuncs";

        [DllImport(DllName, EntryPoint = "CreateMyMathFuncsClass")]
        internal static extern MyMathFuncsSafeHandle CreateMyMathFuncs();

        [DllImport(DllName, EntryPoint = "DisposeMyMathFuncsClass")]
        internal static extern void DisposeMyMathFuncs(MyMathFuncsSafeHandle ptr);

        [DllImport(DllName, EntryPoint = "MyMathFuncsAdd")]
        internal static extern double Add(MyMathFuncsSafeHandle ptr, double a, double b);

        [DllImport(DllName, EntryPoint = "MyMathFuncsSubtract")]
        internal static extern double Subtract(MyMathFuncsSafeHandle ptr, double a, double b);

        [DllImport(DllName, EntryPoint = "MyMathFuncsMultiply")]
        internal static extern double Multiply(MyMathFuncsSafeHandle ptr, double a, double b);

        [DllImport(DllName, EntryPoint = "MyMathFuncsDivide")]
        internal static extern double Divide(MyMathFuncsSafeHandle ptr, double a, double b);
    }
}