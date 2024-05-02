using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class exam09Main : MonoBehaviour
{
    [SerializeField] TMP_Text tx_info;
    [SerializeField] GameObject ArrowObj;
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    

        //Vector3 pos = ArrowObj.transform.position;
        //pos += Vector3.forward *Time.deltaTime;
        //ArrowObj.transform.position = pos;        이 세 줄을 한줄로 줄임 

        //ArrowObj.transform.Translate(Vector3.forward*Time.deltaTime);   //기말 고사에 무조껀 나옴 일정 프레임으로 애니메이션 진행 할 때 *Time.deltaTime 쓰면 일정 시간으로 진행 가능 

        if(Input.GetKey(KeyCode.W) ){
            ArrowObj.transform.Translate(Vector3.forward*Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.S)){
            ArrowObj.transform.Translate(Vector3.back*Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D)){
            ArrowObj.transform.Translate(Vector3.right*Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A)){
            ArrowObj.transform.Translate(Vector3.left*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q)){
            ArrowObj.transform.Rotate(Vector3.up*Time.deltaTime * -45.0f);
        }
        else if (Input.GetKey(KeyCode.E)){
            ArrowObj.transform.Rotate(Vector3.up * Time.deltaTime * 45.0f);
        }

        tx_info.text = "position : "+ ArrowObj.transform.position.ToString();
    
    }
}
