﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Deactivate : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
         gameObject.SetActive(false);
        }
    }
}
