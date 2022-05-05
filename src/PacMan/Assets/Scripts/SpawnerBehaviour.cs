using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToSpawn;

    private void Start()
    {
        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
    }
}
