using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointControll1 : MonoBehaviour
{
    //Textオブジェクト
    private GameObject pointText = null;
    //変数の代入
    private int point = 0;

    private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        //pointTextにPointTextを代入
        pointText = GameObject.Find("PointText");
        
        //Textを取得
        scoreText = pointText.GetComponent<Text>();

        //Textの表示
        scoreText.text = "score:" + point;


    }

    // Update is called once per frame
    void Update()
    {

    }
    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("LargeCloudTag"))
        {
            point += 40;
        }
        else if (collision.gameObject.CompareTag("SmallCloudTag"))
        {
            point += 25;
        }
        else if (collision.gameObject.CompareTag("LargeStarTag"))
        {
            point += 40;
        }
        else if (collision.gameObject.CompareTag("SmallStarTag"))
        {
            point += 20;
        }

        //Textの表示の更新
        scoreText.text = "score:" + point;


    }

    

}
