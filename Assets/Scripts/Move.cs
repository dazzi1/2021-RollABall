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
        float h = Input.GetAxis("Horizontal");//��ȡ���̰�������
        float v = Input.GetAxis("Vertical");//��ȡ���̰�������
        rd.AddForce(new Vector3(h, 0, v));
    }
    //��ײ���
    /*private void OnCollisionEnter(Collision collision)
    {
        //��ȡ��Ϸ����ı�ǩ
        if (collision.gameObject.tag == "Food") {
            //��������
            Destroy(collision.gameObject);
        }
    }*/
    /*private void OnCollisionExit(Collision collision)
    {
   
    }
    private void OnCollisionStay(Collision collision)
    {
     
    }*/
    //�������
    private void OnTriggerEnter(Collider collision)
    {
        //��ȡ��Ϸ����ı�ǩ
        if (collision.gameObject.tag == "Food")
        {
            //��������
            Destroy(collision.gameObject);

            score++;

            scoreText.text = "������" + score;

            if (score == 12) {
                //����ʤ��UI
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
