using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Serialization;
using UnityEngine.UI;
public class ButtonController : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;
    
    private void OnTriggerEnter(Collider other)
    {
        canvasGroup.DOFade(1, 1f);
    }

    private void OnTriggerExit(Collider other)
    {
        canvasGroup.DOFade(0, 1f);
    }
}
