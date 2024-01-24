using UnityEngine;

public class Terrain : MonoBehaviour
{
    private int seed;

    public void GiveField()
    {
        seed = Random.Range(0, 100000);
        Random.InitState(seed);
        Debug.Log($"Seed : {seed}");
    }
}
