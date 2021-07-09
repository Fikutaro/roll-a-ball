using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Player"))
        {
            // このコンポーネントを持つGameObjectを破棄する
            Destroy(gameObject);
        }

    }

}
