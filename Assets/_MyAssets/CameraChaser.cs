using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChaser : MonoBehaviour
{

    Transform myCamera;
    Transform myTrans;

    [Header("字幕とカメラからの距離")]
    [SerializeField]
    float distanse = 1;

    [Header("字幕の高さ")]
    [SerializeField]
    float hight = -1;



    [Header("字幕の追従速度 0.01fが標準速度")]
    [SerializeField]
    float lerp = 0.01f;


    // Start is called before the first frame update
    void Start()
    {
        myTrans = this.transform;
        myCamera = GameObject.FindGameObjectWithTag("MainCamera").transform;    
    }

    // Update is called once per frame
    void Update()
    {
        //字幕が存在する理想地点
        Vector3 v = myCamera.rotation * Vector3.forward * distanse + myCamera.rotation * Vector3.up * hight;
        myTrans.position = Vector3.Lerp(myTrans.position, v, lerp);
        myTrans.LookAt(myTrans.position * 2 -  myCamera.position);


    }
}
