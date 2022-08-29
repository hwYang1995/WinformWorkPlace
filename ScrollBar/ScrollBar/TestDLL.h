//修改后的代码
#pragma once
#pragma comment(lib,"TestDLL.lib")
#include <iostream>

extern "C" __declspec(dllimport) void SayHello();