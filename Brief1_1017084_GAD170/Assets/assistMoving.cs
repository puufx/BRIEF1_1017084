using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assistMoving : MonoBehaviour
{ //essentially this helps player move with moving blocks. Rather than being static and blocks moving away causing you to fall
    private GameObject target = null;
    private Vector3 offset;
    void Start()
    {
        target = null;
    }
    void OnTriggerStay2D(Collider2D col)
    {
        target = col.gameObject;
        offset = target.transform.position - transform.position;
    }
    void OnTriggerExit2D(Collider2D col)
    {
        target = null;
    }
    void LateUpdate()
    {
        if (target != null)
        {
            target.transform.position = transform.position + offset;
        }
    }


}
