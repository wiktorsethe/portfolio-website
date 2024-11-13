using System;
using Cinemachine;
using UnityEngine;

public class CameraZone : MonoBehaviour
{
    public Color gizmoColor = Color.cyan;
    public event Action<CameraZone> OnZoneEnter;
    public event Action OnZoneExit;
    public CameraZoneManager cameraZoneManager;
    public CinemachineVirtualCamera virtualCamera;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && cameraZoneManager.currentZone != this)
        {
            OnZoneEnter?.Invoke(this);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnZoneExit?.Invoke();
        }
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        Collider zoneCollider = GetComponent<Collider>();
        if (zoneCollider != null && zoneCollider is BoxCollider box)
        {
            Gizmos.matrix = transform.localToWorldMatrix;
            Gizmos.DrawCube(box.center, box.size);
        }
    }
}