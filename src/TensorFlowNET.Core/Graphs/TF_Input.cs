﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Tensorflow
{
    [StructLayout(LayoutKind.Sequential)]
    public struct TF_Input
    {
        public IntPtr oper;
        public int index;
    }
}
