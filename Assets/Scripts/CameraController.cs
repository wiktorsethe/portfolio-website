using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private CameraZoneManager zoneManager;
    [SerializeField] private CinemachineVirtualCamera mainCamera;
    private List<CinemachineVirtualCamera> virtualCameras = new List<CinemachineVirtualCamera>();

    private void OnEnable()
    {
        foreach (var zone in zoneManager.zones)
        {
            zone.OnZoneEnter += OnZoneEnter;
            zone.OnZoneExit += OnZoneExit;
            virtualCameras.Add(zone.virtualCamera);
        }
    }

    private void OnDisable()
    {
        foreach (var zone in zoneManager.zones)
        {
            zone.OnZoneEnter -= OnZoneEnter;
            zone.OnZoneExit -= OnZoneExit;
        }
        
        virtualCameras.Clear();
    }

    private void OnZoneEnter(CameraZone zone)
    {
        SetActiveCamera(zone.virtualCamera);
    }

    private void OnZoneExit()
    {
        SetActiveCamera(mainCamera);
    }

    private void SetActiveCamera(CinemachineVirtualCamera activeCamera)
    {
        foreach (var virtualCamera in virtualCameras)
        {
            virtualCamera.gameObject.SetActive(virtualCamera == activeCamera);
        }
        mainCamera.gameObject.SetActive(activeCamera == mainCamera);
    }
}