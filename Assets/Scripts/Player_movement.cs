using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float shoot_delay;
    [SerializeField] private GameObject bullet_prefab;
    [SerializeField] private GameObject spawnpoint;
    private float temporizador = 0.5f;
    private float vidas = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        Disparar();
        LimitesMovimiento();
    }
    void Movimiento()
    {
        float inputH = Input.GetAxisRaw("Horizontal");
        float inputV = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector2(inputH, inputV).normalized * velocidad * Time.deltaTime);
    }
    void LimitesMovimiento()
    {
        float xClamped = Mathf.Clamp(transform.position.x, -8.4f, 8.4f);
        float yClamped = Mathf.Clamp(transform.position.y, -4.5f, 4.5f);
        transform.position = new Vector3(xClamped, yClamped, 0);
    }
        
    void Disparar()
    {
        temporizador += 1 * Time.deltaTime;

        if(Input.GetKey(KeyCode.Space) && temporizador > shoot_delay)
        {
            Instantiate(bullet_prefab, spawnpoint.transform.position, Quaternion.identity);
            temporizador = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            vidas -= 1;
            Destroy(collision.gameObject);
        }
    }
}
