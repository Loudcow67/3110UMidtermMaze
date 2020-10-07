#pragma once
#ifdef PLUGIN_EXPORT
#define PLUGIN_API __declspec(dllexport)
#elif PLUGIN_EXPORT
#define PLUGIN_API __declspec(dllexport)
#else
#define PLUGIN_API

#endif // 
