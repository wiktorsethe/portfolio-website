using System.Runtime.InteropServices;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void OpenNewTab(string url);

    public void OpenInNewTab(string url)
    {
        #if UNITY_WEBGL && !UNITY_EDITOR
        OpenNewTab(url);
        #else
        Application.OpenURL(url);
        #endif
        
        Debug.Log("Cos tu pyka ale nie pyka");
    }
}