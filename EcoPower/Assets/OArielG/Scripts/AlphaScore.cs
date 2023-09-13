using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlphaScore : MonoBehaviour
{
    TextMeshProUGUI texto;
    public static int score;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            score = 0;
        }
        texto = gameObject.GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        texto.text = string.Format("X {0}", score);
    }
}
