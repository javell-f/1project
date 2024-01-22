using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroid : MonoBehaviour
{
    public float spinSpeed = 2f;   
    public float glideSpeed = 2f;  

    public Canvas gameOverCanvas;   

    void Start()
    {
        
        gameObject.SetActive(false);

        
        Invoke("EnableAsteroid", 2f);

        
        InvokeRepeating("RespawnAsteroid", 2f, 7f);
    }

    void Update()
    {
        
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
        transform.Translate(Vector3.left * glideSpeed * Time.deltaTime);

        
        if (transform.position.x < Camera.main.ScreenToWorldPoint(Vector3.zero).x)
        {
            DestroyAsteroid();
        }
    }

    void RespawnAsteroid()
    {
        
        float screenHeight = Camera.main.orthographicSize * 2f;
        float randomY = Random.Range(-screenHeight / 2f, screenHeight / 2f);

        transform.position = new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x, randomY, transform.position.z);
    }

    void DestroyAsteroid()
    {
        
        Destroy(gameObject);
    }

    void EnableAsteroid()
    {
        
        gameObject.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            
            if (gameOverCanvas != null)
            {
                gameOverCanvas.enabled = true;
            }

            
            Destroy(gameObject);
        }
    }
}