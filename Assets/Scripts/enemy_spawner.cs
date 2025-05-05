using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnpoint;
    void Start()
    {
        StartCoroutine(spawn_new_enemy());
    }

    
    void Update()
    {
        
    }
    IEnumerator spawn_new_enemy()
    {
        while(true)
        {
            Vector3 punto_aleatorio = new Vector3(transform.position.x, Random.Range(-4, 4), 0);
            Instantiate(spawnpoint, punto_aleatorio, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        
    }
}
