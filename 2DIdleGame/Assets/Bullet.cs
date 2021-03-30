using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
        void Update()
    {
        gameObject.transform.Translate(Vector3.right * Time.deltaTime * 10f);

    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy") {
             Destroy(collision.gameObject);
             Data.Instance.onEnemy++;
             Debug.Log("적 잡음");
             Data.Instance.gold += /*111*/  Data.Instance.upStage *  Data.Instance.upStage;
        }

    }
}
