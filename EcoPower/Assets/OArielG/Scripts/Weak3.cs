using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Weak3 : MonoBehaviour
{
    AudioSource m_AudioSource;
    SpriteRenderer m_SpriteRenderer;
    BoxCollider2D m_BoxCollider;
    public float salto = 3;
    private float m_Time = 0;
    private bool m_end = false;
    private void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_AudioSource = GetComponent<AudioSource>();
        m_BoxCollider = GetComponent<BoxCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(collision.gameObject.GetComponent<Rigidbody2D>().velocity.x, salto);
            m_BoxCollider.enabled = false;
            m_SpriteRenderer.enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
            m_end = true;
        }
    }
    private void Update()
    {
        if (m_end == true)
        {
            m_Time += Time.deltaTime;
            m_AudioSource.Play();
            if (m_Time > 5f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
