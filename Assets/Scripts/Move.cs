using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    private Rigidbody rd;
    private int score = 0;
    public Text scoreText;
    public GameObject winText;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");//获取键盘按键左右
        float v = Input.GetAxis("Vertical");//获取键盘按键左右
        rd.AddForce(new Vector3(h, 0, v));
    }
    //碰撞检测
    /*private void OnCollisionEnter(Collision collision)
    {
        //获取游戏物体的标签
        if (collision.gameObject.tag == "Food") {
            //销毁物体
            Destroy(collision.gameObject);
        }
    }*/
    /*private void OnCollisionExit(Collision collision)
    {
   
    }
    private void OnCollisionStay(Collision collision)
    {
     
    }*/
    //触发检测
    private void OnTriggerEnter(Collider collision)
    {
        //获取游戏物体的标签
        if (collision.gameObject.tag == "Food")
        {
            //销毁物体
            Destroy(collision.gameObject);

            score++;

            scoreText.text = "分数：" + score;

            if (score == 12) {
                //激活胜利UI
                winText.SetActive(true);
            }
        }
    }
    /*private void OnTriggerExit(Collider other)
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        
    }*/
}
