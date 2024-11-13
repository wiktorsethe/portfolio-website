using System.Collections.Generic;
using UnityEngine;

public class CameraZoneManager : MonoBehaviour
{
    public CameraZone currentZone;
    public List<CameraZone> zones;

    private void OnEnable()
    {
        foreach (var zone in zones)
        {
            zone.cameraZoneManager = this;
            zone.OnZoneEnter += OnZoneEnter;
            zone.OnZoneExit += OnZoneExit;
        }
    }

    private void OnDisable()
    {
        foreach (var zone in zones)
        {
            zone.OnZoneEnter -= OnZoneEnter;
            zone.OnZoneExit -= OnZoneExit;
        }
    }

    private void OnZoneEnter(CameraZone zone)
    {
        currentZone = zone;
    }

    private void OnZoneExit()
    {
        currentZone = null;
    }
}