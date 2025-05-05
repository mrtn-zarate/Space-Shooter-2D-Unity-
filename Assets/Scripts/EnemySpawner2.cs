using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner2 : MonoBehaviour
{
    [SerializeField] private GameObject spawnpoint;
    static public int kills;
    void Start()
    {
        kills = 0;
        StartCoroutine(spawn_new_enemy());
    }


    void Update()
    {

    }
    IEnumerator spawn_new_enemy()
    {
        while (kills <= 10)
        {
            yield return new WaitForSeconds(2f);
        }
        while (kills > 10 && kills <= 20)
        {

            Instantiate(spawnpoint, transform.position, transform.rotation);
            yield return new WaitForSeconds(2f);
        }
        while (kills > 20 && kills <= 50)
        {

            Instantiate(spawnpoint, transform.position, transform.rotation);
            yield return new WaitForSeconds(1f);
        }
        while (kills > 50)
        {

            Instantiate(spawnpoint, transform.position, transform.rotation);
            yield return new WaitForSeconds(0.5f);
        }

    }
}