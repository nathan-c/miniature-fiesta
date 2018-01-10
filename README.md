Demo code to link C or C++ with C# PInvoke code to make a single C#-compatible assembly
```
cl.exe /Zi /MD /c foo.cpp
csc /target:module bar.cs
link foo.obj bar.netmodule /dll /out:foobar.dll /ltcg
csc /reference:foobar.dll main.cs
```
