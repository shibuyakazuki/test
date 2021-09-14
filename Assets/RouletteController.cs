using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; //回転速度
    public float brake = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float brake = 1.0f;
        //マウスが押されたら回転速度を設定する
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
            this.brake = 1;
        }

        //回転速度ぶん、ルーレットを回転させる
        

        //ルーレットを減速させる
        //this.rotSpeed *= brake;
        else if (Input.GetMouseButtonDown(1))
        {
            this.brake = 0.96f;
        }

        transform.Rotate(0, 0, this.rotSpeed);
        this.rotSpeed *= this.brake;
    }
}
