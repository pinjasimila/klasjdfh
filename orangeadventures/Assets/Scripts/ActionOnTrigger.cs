using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionOnTrigger : MonoBehaviour
{
    float scale = 1.0f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("grow"))
        {
            scale += 0.05f;
            transform.localScale = new Vector2(scale, scale);
            if (scale > 10.0f)
            {
                scale = 10.0f;
            }
        }
        if (other.gameObject.CompareTag("shrink"))
        {
            scale -= 0.05f;
            transform.localScale = new Vector2(scale, scale);
            if (scale < 0.1f)
            {
                scale = 1.0f;
            }
        }

    }
}

