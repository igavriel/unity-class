using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public GameObject plane;
    public int numberOfStartObjects = 10;
    public int objectValue = 1;

    Bounds bounds;

    void Start()
    {
        // Get the bounds of the plane
        MeshCollider planeCollider = plane.GetComponent<MeshCollider>();
        bounds = planeCollider.bounds;

        Debug.Log($"Plane Bounds {bounds}");
        // reduce the invisible walls
        Vector3 invisibleWall = new Vector3(2.0f, 0, 2.0f);
        bounds.SetMinMax(bounds.min + invisibleWall, bounds.max - invisibleWall);
        Debug.Log($"Plane Bounds without invisible walls {bounds}");
        SpawnRandomObjects();
    }

    void SpawnRandomObjects()
    {
        for (int i = 0; i < numberOfStartObjects; i++)
        {
            SpawnSingleObject();
        }
    }

    public void SpawnSingleObject()
    {
        // Generate random position within the bounds of the plane
        float randomX = Random.Range(bounds.min.x, bounds.max.x);
        float randomZ = Random.Range(bounds.min.z, bounds.max.z);

        // Raycast down from above to find the height of the surface
        RaycastHit hit;
        if (Physics.Raycast(new Vector3(randomX, 100f, randomZ), Vector3.down, out hit))
        {
            // Spawn the box just above the surface
            Vector3 spawnPosition = new Vector3(randomX, hit.point.y + 0.01f, randomZ); // Adjust Y to be above the surface

            // Get the GameObject that was hit
            GameObject hitObject = hit.collider.gameObject;
            Debug.Log($"Spawn: {spawnPosition}, Hit Object Name: {hitObject.name}, Type: {hitObject.GetType()} Position: {hit.point}");

            // create a new object and set its price
            var newObject = Instantiate(objectPrefab, spawnPosition , Quaternion.identity);
            var collector = newObject.GetComponent<ObjectCollector>();
            collector.objectValue = objectValue;
        }
    }
}
