#pragma once
#include "CheckpointTimeLogger.h"

#ifdef __cplusplus
extern "C"
{
#endif

	//Put Functions in here
	PLUGIN_API void ResetLogger();

	PLUGIN_API void SaveCheckpointTime(float RTBC);

	PLUGIN_API float GetTotalTime();

	PLUGIN_API float GetCheckpointTime(int index);

	PLUGIN_API int GetNumCheckpoint();

#ifdef __cplusplus
}
#endif