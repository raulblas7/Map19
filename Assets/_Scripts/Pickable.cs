﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
