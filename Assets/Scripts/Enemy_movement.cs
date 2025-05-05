using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Enemy_movement : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float shoot_delay;
    [SerializeField] private GameObject bullet_prefab;
    [SerializeField] private GameObject spawnpoint;
    public AudioSource audiosource;
    private bool alive=true;

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
        while (alive)
        {
            Instantiate(bullet_prefab, spawnpoint.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(shoot_delay);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Barrier"))
        {
            Invoke("destroyenemy", 1f);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            alive = false;
            UI_Canvas.kills += 1;
            EnemySpawner1.kills += 1;
            EnemySpawner2.kills += 1;
            audiosource.Play();
            GetComponentInChildren<Collider2D>().enabled = false;
            GetComponentInChildren<SpriteRenderer>().enabled = false;
            Invoke("destroyenemy", 1f);
        }
    }
    void destroyenemy()
    {
        Destroy(this.gameObject);
    }
}
