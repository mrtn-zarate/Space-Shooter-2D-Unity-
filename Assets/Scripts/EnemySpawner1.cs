using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner1 : MonoBehaviour
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
        while (kills<=5)
        {
            Vector3 punto_aleatorio = new Vector3(transform.position.x, Random.Range(-3, 3), 0);
            Instantiate(spawnpoint, punto_aleatorio, Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
        while (kills > 5 && kills <= 10)
        {
            Vector3 punto_aleatorio = new Vector3(transform.position.x, Random.Range(-4, 4), 0);
            Instantiate(spawnpoint, punto_aleatorio, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
        while (kills > 10 && kills <= 20)
        {
            Vector3 punto_aleatorio = new Vector3(transform.position.x, Random.Range(-5, 5), 0);
            Instantiate(spawnpoint, punto_aleatorio, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        while (kills > 20 && kills <= 50)
        {
            Vector3 punto_aleatorio = new Vector3(transform.position.x, Random.Range(-5, 5), 0);
            Instantiate(spawnpoint, punto_aleatorio, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
        while (kills > 50)
        {
            Vector3 punto_aleatorio = new Vector3(transform.position.x, Random.Range(-5, 6), 0);
            Instantiate(spawnpoint, punto_aleatorio, Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
        }

    }
}