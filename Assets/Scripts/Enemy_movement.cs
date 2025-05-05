using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_movement : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float shoot_delay;
    [SerializeField] private GameObject bullet_prefab;
    [SerializeField] private GameObject spawnpoint;

    void Start()
    {
        StartCoroutine(spawn_bullets());
    }

    void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * velocidad * Time.deltaTime);
    }
    IEnumerator spawn_bullets()
    {
        while (true)
        {
            Instantiate(bullet_prefab, spawnpoint.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(shoot_delay);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Barrier"))
        {
            Destroy(this.gameObject);
        }
    }
}
