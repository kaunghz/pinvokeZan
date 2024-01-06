#include <iostream>

#ifdef _WIN32
#define DLL_EXPORT __declspec(dllexport)
#else
#define DLL_EXPORT __attribute__((visibility("default")))
#endif

extern "C" {
    DLL_EXPORT int add(int a, int b) {
        std::cout << "[add] called, adding in Native C++\n";
        return a + b;
    }
}
