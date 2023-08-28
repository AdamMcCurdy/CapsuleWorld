using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private GameObject prefabPlayer;
    [SerializeField] private int xRange = 10;
    [SerializeField] private int zRange = 10;
    [SerializeField] private int numPlayers = 5;

    void Awake()
    {
        Vector3 pos = new Vector3();
        pos.y = 1;

        for (int i = 0; i < numPlayers; i++)
        {
            pos.x = Random.Range(-xRange, xRange);
            pos.z = Random.Range(-zRange, zRange);
            Instantiate(prefabPlayer, pos, Quaternion.identity);
        }
    }
}