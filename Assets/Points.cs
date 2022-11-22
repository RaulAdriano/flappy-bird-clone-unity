using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GameController controller;
    public AudioSource audioSource;
    public AudioClip audioClip;

    private void Start()
    {
        controller = FindObjectOfType<GameController>();
    }

    void OnTriggerEnter2D(Collider2D colisor)
    {
        audioSource.PlayOneShot(audioClip);
        controller.score++;
        controller.scoreText.text = controller.score.ToString();
    }
}
