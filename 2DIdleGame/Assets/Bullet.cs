using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start()
    {
         StartCoroutine("CountTime", Data.Instance.attackSpeed);


        // StartCoroutine(Hi());
        //  IEnumerator Hi() {
        //     while(true) {
        //         yield return new WaitForSeconds( Data.Instance.ATTACK_SPEED);
        //  gameObject.transform.Translate(Vector3.right * 100 * Mathf.Sqrt(Data.Instance.ATTACK_SPEED));
        //     }
    }

    void Update()
    {


    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Data.Instance.onEnemy++;
            Debug.Log("적 잡음");
            Data.Instance.gold += Data.Instance.upStage * Data.Instance.upStage;
        }

    }
    void Shooter()
    {
        // 루트 2분의 1초
        gameObject.transform.Translate(Vector3.right * Time.deltaTime * 10);
    }

    IEnumerator CountTime(float tlqkf )
    {
        yield return new WaitForSeconds(tlqkf);
        Shooter();
    }



}
