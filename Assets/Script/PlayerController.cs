using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    void FixedUpdate()
    {
        // ���͂�x��z�ɑ��
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        // x��z��10�������ĉ����͂��A�b�v
        rigidbody.AddForce(x * speed, 0, z * speed);

    }

}
