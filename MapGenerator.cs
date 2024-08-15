using UnityEngine;
using Mapbox.Unity.Map;
using Mapbox.Utils;

public class MapGenerator : MonoBehaviour
{
    // Mapbox AbstractMap Component Reference 
    public AbstractMap map;

    // coordinates of the map center (lat, long)
    public Vector2d coordinates = new Vector2d(40.7128, -74.0060); // Example: Nova York

    // zoom level
    public float zoom = 16f;

    // terrain scale
    public float terrainScale = 1f;

    void Start()
    {
        // Set the map with the coordinates and zoom level
        map.SetCenterLatitudeLongitude(coordinates);
        map.SetZoom(zoom);

        // Apply the terrain sclaw
        map.transform.localScale = new Vector3(terrainScale, terrainScale, terrainScale);

        // update the map
        map.UpdateMap();
    }
}
