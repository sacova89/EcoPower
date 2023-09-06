using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer: MonoBehaviour
{
    TextMeshProUGUI texto;
    private float tiempo;

    private int tiempoM, tiempoS;
    private void Start()
    {
        tiempo = 0;
        texto = GetComponent<TextMeshProUGUI>();
    }
    void Cronometro()
    {
        tiempo += Time.deltaTime;
        tiempoM = Mathf.FloorToInt(tiempo / 60);
        tiempoS = Mathf.FloorToInt(tiempo % 60);
        texto.text = string.Format("{0:00}:{1:00}", tiempoM, tiempoS);
    }
    // Update is called once per frame
    void Update()
    {
        if (pauseManager.pause == false)
        {
            Cronometro();
        }
    }
}
