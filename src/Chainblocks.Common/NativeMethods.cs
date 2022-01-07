using System;
using System.Runtime.InteropServices;

namespace Chainblocks
{
  internal static class NativeMethods
  {
    private const string Dll = "libcbl";
    private const CallingConvention Conv = CallingConvention.Cdecl;

    [DllImport(Dll, CallingConvention = Conv)]
    internal static extern IntPtr chainblocksInterface(int version);

    [DllImport(Dll, CallingConvention = Conv, CharSet = CharSet.Ansi)]
    internal static extern IntPtr cbLispCreate(string path);

    [DllImport(Dll, CallingConvention = Conv)]
    internal static extern void cbLispDestroy(IntPtr lisp);

    [DllImport(Dll, CallingConvention = Conv, CharSet = CharSet.Ansi)]
    internal static extern byte cbLispEval(IntPtr lisp, string code, IntPtr output);
  }
}
