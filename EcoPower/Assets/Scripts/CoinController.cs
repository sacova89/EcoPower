using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CoinController : MonoBehaviour
{
    public GameObject efectoDesaparicion; // Este es el prefab con la animación.
    public AudioClip sonidoDesaparicion; // El AudioClip para el sonido de desaparición.

    private float rotSpeed = 60f;

    void Update()
    {
        transform.Rotate(0, 0, rotSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collider: " + other.gameObject.name);
        if (other.CompareTag("Player"))
        {
            AudioSource _audio = GetComponent<AudioSource>();
            _audio.Play();
            StartCoroutine(DestroyObjectWithAudio(_audio));
        }
    }

    private IEnumerator DestroyObjectWithAudio(AudioSource _audio)
    {
        yield return new WaitUntil(() => !_audio.isPlaying); // Espera hasta que el audio termine de reproducirse

        if (sonidoDesaparicion != null)
        {
            AudioSource.PlayClipAtPoint(sonidoDesaparicion, transform.position);
        }

        gameObject.SetActive(false);

        if (efectoDesaparicion != null)
        {
            Instantiate(efectoDesaparicion, transform.position, Quaternion.identity);
        }
    }
}
