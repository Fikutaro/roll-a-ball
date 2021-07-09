using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    void FixedUpdate()
    {
        // “ü—Í‚ðx‚Æz‚É‘ã“ü
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        // x‚Æz‚É10‚ð‚©‚¯‚Ä‰Ÿ‚·—Í‚ðƒAƒbƒv
        rigidbody.AddForce(x * speed, 0, z * speed);

    }

}
