using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ZonaDeVictoria : MonoBehaviour
{
    public GameObject uiFinal;
    public TextMeshProUGUI saludo;

    private void OnTriggerEnter2D(Collider2D objQueEntroAlTrigger)
    {
        if (objQueEntroAlTrigger.gameObject.CompareTag("Player"))
        {
            saludo.text = "ALCANSASTE LA META! FELICIDADES!";
            uiFinal.SetActive(true);
        }
    }

    public void ReiniciarScene()
    {
        SceneManager.LoadScene("Nivel 1");
    }
}
