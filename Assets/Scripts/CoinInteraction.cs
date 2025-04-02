using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinInteraction : MonoBehaviour
{
    private AudioSource audioSource;
    private BoxCollider2D boxCollider;
    public AudioClip coinSFX;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Player"));
        {
            
            audioSource.PlayOneShot(coinSFX);
            spriteRenderer.enabled = false;
            Destroy(gameObject,0.5f);
        }
                
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
