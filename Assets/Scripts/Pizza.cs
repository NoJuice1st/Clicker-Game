using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    public float rotateSpeed = 2f;
    public float shrinkSpeed = 5f;
    public Vector3 originalSize = Vector3.one * 1.5f;
    public AudioSource source;
    public ParticleSystem particles;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnMouseDown() 
    {
        GameManager.clicks++;
        transform.localScale = originalSize * 1.5f;

        particles.Play();
        source.PlayOneShot(source.clip);
    }

    private void Update()
    {
        transform.Rotate(Vector3.back * rotateSpeed * Time.deltaTime);
        if(transform.localScale.x > 1.5f)
        {
            transform.localScale -= originalSize * shrinkSpeed * Time.deltaTime;
        }
    }
}
