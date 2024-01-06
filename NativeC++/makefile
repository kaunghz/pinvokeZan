STD=--std=c++17
GCC=g++ ${STD}

SRC=src
OBJ=obj
LIB=../Csharp/bin/Debug/net7.0

SRCS=$(wildcard $(SRC)/*.cpp)
OBJS=$(patsubst $(SRC)/%.cpp,$(OBJ)/%.o,$(SRCS))
TARGET=$(LIB)/NativeLibrary.dll

all: $(TARGET)

$(OBJ)/%.o: $(SRC)/%.cpp
	@mkdir -p $(@D)
	${GCC} -c $< -o $@

$(TARGET): $(OBJS)
	${GCC} -shared -o $@ $^

clean:
	rm -rf $(OBJ) $(TARGET)
