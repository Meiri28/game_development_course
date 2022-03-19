using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawn : MonoBehaviour
{
    public float dificalty = 2f;
    public Transform Zombie_asset;
    public Transform Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0,100) < dificalty) {
            Transform zom = Instantiate(Zombie_asset,
                new Vector3(Random.Range(-5f, 5f), 0.375f, Random.Range(-5f, 5f)),
                transform.rotation);
            zom.GetComponent<Zombie>().target = Player;
        }
    }
}
