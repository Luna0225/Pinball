using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointControll1 : MonoBehaviour
{
    //Text�I�u�W�F�N�g
    private GameObject pointText = null;�@

    //�ϐ��̑��
    private int point = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        //pointText��PointText����
        this.pointText = GameObject.Find("PointText");
        
        //Text���擾
        Text scoreText = pointText.GetComponent<Text>();

        //Text�̕\��
        scoreText.text = "score:" + point;


    }

    // Update is called once per frame
    void Update()
    {
        //pointText��PointText����
        this.pointText = GameObject.Find("PointText");

        //Text���擾
        Text scoreText = pointText.GetComponent<Text>();

        //Text�̕\��
        scoreText.text = "score:" + point;
    }
    //�Փˎ��ɌĂ΂��֐�
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("LargeCloudTag"))
        {
            point += 40;
        }
        else if(collision.gameObject.CompareTag("SmallCloudTag"))
        {
            point += 25;
        }
        else if(collision.gameObject.CompareTag("LargeStarTag"))
        {
            point += 40;
        }
        else if(collision.gameObject.CompareTag("SmallStarTag"))
        {
            point += 20;
        }

    }

}
