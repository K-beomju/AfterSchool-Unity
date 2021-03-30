using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    void Update()
    {
        gameObject.transform.Translate(Vector3.left * Time.deltaTime * 3f);
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
