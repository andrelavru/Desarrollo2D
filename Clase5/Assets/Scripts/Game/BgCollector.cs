﻿using UnityEngine;
using System.Collections;

public class BgCollector : MonoBehaviour {

    // Use this for initialization
    void OnTriggerEnter2D(Collider2D coll)
    {
        coll.gameObject.SetActive(false);
    }
}
