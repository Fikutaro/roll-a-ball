using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    void FixedUpdate()
    {
        // 入力をxとzに代入
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        // xとzに10をかけて押す力をアップ
        rigidbody.AddForce(x * speed, 0, z * speed);

    }

}
