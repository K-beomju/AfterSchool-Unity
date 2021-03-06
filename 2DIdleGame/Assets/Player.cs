using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    float rightMax = 4.0f;
    float leftMax = -4.0f;
    float currentPosition;
    float direction = 10.0f;

    public GameObject Bullet;

    void Start()
    {
        currentPosition = transform.position.y;
     InvokeRepeating("Shoot", 3, 1);
    }

    void Update()
    {
        currentPosition += Time.deltaTime * direction;
        if (currentPosition >= rightMax)
        {
            direction *= -1;
            currentPosition = rightMax;
        }
        else if (currentPosition <= leftMax)
        {
            direction *= -1;
            currentPosition = leftMax;
        }
        transform.position = new Vector3(-7.86f, currentPosition, 0);


    }
     void OnTriggerEnter2D(Collider2D collision) {
         if(collision.tag == "Enemy") {
             Destroy(this.gameObject);
              Data.Instance.enableSpawn = false;
               Invoke("SampleScene",3f);
         }
     }

    void Shoot() {
         GameObject bullet =(GameObject)Instantiate(Bullet,transform.position, Quaternion.identity);
    }

    void Scene() {
        SceneManager.LoadScene("SampleScene");
    }
}
