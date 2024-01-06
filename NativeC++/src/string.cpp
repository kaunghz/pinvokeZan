#include <iostream>

#ifdef _WIN32
#define DLL_EXPORT __declspec(dllexport)
#else
#define DLL_EXPORT __attribute__((visibility("default")))
#endif

extern "C" {
    DLL_EXPORT const char* get_message() {
        return "a message from native C++";
    }

    DLL_EXPORT void read_message(char* message) {
        std::cout << message;
    }
}
