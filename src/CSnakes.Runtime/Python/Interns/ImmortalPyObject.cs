﻿using CSnakes.Runtime.CPython;
namespace CSnakes.Runtime.Python.Interns;

internal class ImmortalPyObject(nint handle) : PyObject(handle)
{
    protected override bool ReleaseHandle() => true;


    protected override void Dispose(bool disposing)
    {
        // I am immortal!!
    }
}
