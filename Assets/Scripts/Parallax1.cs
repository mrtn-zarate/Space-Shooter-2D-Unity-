using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax1 : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private Vector3 direccion;
    [SerializeField] private float ancho_imagen;

    private Vector3 posicion_inicial;
    void Start()
    {
        posicion_inicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        float resto = (velocidad * Time.time) % ancho_imagen;

        transform.position = posicion_inicial + resto * direccion;
    }
}
