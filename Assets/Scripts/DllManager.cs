using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class DllManager : MonoBehaviour
{

    const string DLL_NAME = "3110UMidtermDLL";

    [DllImport(DLL_NAME)]
    private static extern void ResetLogger();

    [DllImport(DLL_NAME)]
    private static extern void SaveCheckpointTime(float RTBC);

    [DllImport(DLL_NAME)]
    private static extern float GetTotalTime();

    [DllImport(DLL_NAME)]
    private static extern float GetCheckpointTime(int index);

    [DllImport(DLL_NAME)]
    private static extern int GetNumCheckpoint();

    float lastTime = 0.0f;

    public void SaveTime(float checkpointTime)
    {
        SaveCheckpointTime(checkpointTime);
    }

    public float LoadTime(int index)
    {
        if (index >= GetNumCheckpoint())
        {
            return -1.0f;
        }
        else
        {
            return GetCheckpointTime(index);
        }
    }

    public float LoadTotalTime()
    {
        return GetTotalTime();
    }

    public void ResetLoggerFunction()
    {
        ResetLogger();
    }

    // Start is called before the first frame update
    void Start()
    {
        lastTime = Time.time;
    }

    public Text timerText;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            float currentTime = Time.time;
            float checkpointTime = currentTime - lastTime;
            lastTime = currentTime;
            
            SaveTime(checkpointTime);
            Debug.Log(LoadTime(0)); 
            timerText.text = LoadTotalTime().ToString();
        }
    }

    private void OnDestroy()
    {
        ResetLoggerFunction();
    }
}
