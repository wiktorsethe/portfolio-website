using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    public void OpenInNewTab(string url)
        {
            #if UNITY_WEBGL && !UNITY_EDITOR
            Application.ExternalEval($"openNewTab('{url}')");
            #else
            Application.OpenURL(url); // Na wypadek innych platform
            #endif
        }
}
