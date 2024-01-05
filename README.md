Test to platform invoke C++ libraries from C#

C++
Compile C++ codes into Dynamic Link Library (dll) file:
This will generate object .o files and we can bundle them together into "NativeLibrary.dll"
```
  g++ -c <hello.cpp>
  g++ -shared <NativeLibrary.dll> <obj files hello.o>
```

C#
Place this .dll file in the .NetCore build folder. Then we can run it by:
  ```dotnet run```

