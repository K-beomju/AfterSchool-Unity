using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Numerics;

public class GameManager : MonoBehaviour
{
    public int speedUp = 1;
    void Update()
    {
                Data.Instance.attackSpeed = 1 / (1f * Mathf.Sqrt(Data.Instance.ATTACK_SPEED));
        Data.Instance.ATTACK_SPEED = 100 * Data.Instance.ATTACK_SPEED * Data.Instance.ATTACK_SPEED;




        Data.Instance.stage.text = string.Format("Lv.{0}", Data.Instance.upStage);
        Data.Instance.goldTxt.text = string.Format("Gold:{0}", Data.Instance.gold);
        Data.Instance.attackSpeed.text = string.Format("AttackSpeed:{0}", Data.Instance.ATTACK_SPEED);
    }

    public void Upgrading() {
            if(Data.Instance.gold == 100 ) {
                //Data.Instance.gold -= 100 * Data.Instance.ATTACK_SPEED * Data.Instance.ATTACK_SPEED;
                //Data.Instance.ATTACK_SPEED++;
            }
    }


 /// 1초 나누기 공속  총알 나오는 간격
//공속 레벨 돈 유지 스테이지 레벨 초기화


    /*
    public BigInteger gold = 1;
    public BigInteger gold_2 = 1;
    BigInteger _gold = 0;
    BigInteger _gold_2 = 0;
    string resultString = null;
    string resultString_2 = null;

    public Text goldTxt;
    public Text goldTxt_2;

    string[] countGold = { " ", "K", "M", "B", "T", "E + 15" };
    string[] countGold_s = { ",", ",", ",", "," };
    List<int> goldList = new List<int>();
    List<int> goldList_s = new List<int>();

    void Update()
    {
        goldTxt.text = resultString;
        goldTxt_2.text = resultString_2;
    }

    public void OnClickCopyGold()
    {
        gold *= 123;
        gold_2 *= 123;
        goldList.Clear();
        goldList_s.Clear();
        _gold = gold;
        _gold_2 = gold;
        while (_gold > 0)
        {
            goldList.Add((int)(_gold % 10000));
            _gold /= 10000;
        }
        while (_gold_2 > 0)
        {
            goldList_s.Add((int)(_gold_2 % 1000));
            _gold_2 /= 1000;
        }

        resultString = string.Empty;
        resultString_2 = string.Empty;
        for (int i = 0; i < goldList_s.Count; i++)
        {
            resultString_2 = goldList_s[i] + countGold_s[i] + resultString_2;
        }
        //for (int i = 0; i < goldList.Count; i++)
        //{
        resultString = goldList[goldList.Count - 1] + countGold[goldList.Count - 1];
        //}
    }
    */
}

