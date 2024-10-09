using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public string informacion;
    public int cantidadDeMunicion;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //spriteRenderer.color = Color.clear;
    }

    private void OnTriggerEnter2D(Collider2D referenciaDelColliderQueEntro)
    {
        if (referenciaDelColliderQueEntro.gameObject.CompareTag("Player"))
        {
            PlayerController player = referenciaDelColliderQueEntro.gameObject.GetComponent<PlayerController>();
            //player.estaEnLaZona = true;
            //player.AñadirMunicion(cantidadDeMunicion);
            //player.MostrarInformacion(informacion);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerController player = other.gameObject.GetComponent<PlayerController>();
            player.estaEnLaZona = false;
        }
    }
}