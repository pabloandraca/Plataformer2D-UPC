using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZonaDeMuerte : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D objQueEntroAlTrigger)
    {
        if (objQueEntroAlTrigger.gameObject.CompareTag("Player"))
        {
            Invoke("ReiniciarEscena", 1.5f);
        }
    }

    private void ReiniciarEscena()
    {
        SceneManager.LoadScene("Nivel 1");
    }
}