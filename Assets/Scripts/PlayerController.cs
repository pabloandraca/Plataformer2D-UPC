using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [HideInInspector] public bool estaEnLaZona = false;
    public int municionDelJugador;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && estaEnLaZona)
        {
            // Aca hacemos la accion
            Debug.Log("Estoy aprentado E");
        }
    }

    public void MostrarInformacion(string informacion)
    {
        Debug.Log(informacion);
    }

    public void AñadirMunicion(int municion)
    {
        municionDelJugador += municion;
        Debug.Log("Obtuviste estas municiones" + municion);
    }
}
