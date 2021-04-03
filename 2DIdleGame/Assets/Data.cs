using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Numerics;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    private static Data instance;
    public static Data Instance
    {
        get
        {
            if(instance == null)
            {
                var obj = FindObjectOfType<Data>();
                if(obj != null)
                {
                    instance = obj;
                }
                else
                {
                    var newSingleton = new GameObject("Singleton Class").AddComponent<Data>();
                    instance = newSingleton;
                }

            }
            return instance;
        }
        private set
        {
            instance = value;
        }
    }



    public  Text stage;
    public int upStage = 1;
    public int onEnemy = 0;

   public bool enableSpawn = false;

    public BigInteger gold = 1;
    BigInteger _gold = 0;
    string resultString = null;
    int ePlueNum = 0;

    public Text goldTxt;

    public Text attackSpeed;


    public float ATTACK_SPEED = 1;
    public float ATTACK_LEVEL = 1;

    string[] countGold = {" ","K","M","B","T"};
    List<int> goldList = new List<int>();

    private void Awake()
    {

        if (null == instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }

    public void OnClickCopyGold()
    {

        ePlueNum = -3;
        goldList.Clear();

        _gold = gold;

        while(_gold > 0)
        {
            goldList.Add((int)(_gold % 10000));
            _gold /= 1000;
            ePlueNum +=3;
        }

        resultString = string.Empty;

        if(goldList.Count -1 >= 5 && goldList[goldList.Count-1] >= 100)
        {
            resultString = string.Format("{0:F2}E+{1}",(float)goldList[goldList.Count-1]/100,ePlueNum + 2);
        }
        else if(goldList.Count -1 >= 5 && goldList[goldList.Count-1] >= 10)
        {
            resultString = string.Format("{0:F2}E+{1}",(float)goldList[goldList.Count-1]/10,ePlueNum + 1);
        }
        else if(goldList.Count -1 >= 5)
        {
            resultString = string.Format("{0:F2}E+{1}",(float)goldList[goldList.Count-2]/1000,ePlueNum);
        }
        else
            resultString = goldList[goldList.Count-1] + countGold[goldList.Count-1];
    }

    void Update() {

        ATTACK_SPEED = (1/Mathf.Sqrt(ATTACK_SPEED));

        if(onEnemy == 10) {
            upStage++;
            onEnemy = 0;
        }

    }
}