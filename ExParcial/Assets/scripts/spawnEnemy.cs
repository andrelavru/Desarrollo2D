using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawnEnemy : MonoBehaviour {

    // Use this for initialization
    public GameObject[] elements;
    List<GameObject> mobs;
    float elapsed;
    float azar;
	void Start () {
        mobs = new List<GameObject>();
        initMobs();
        elapsed = 0;
       
	}

    void initMobs()
    {
        int total = elements.Length * 5;
        for (int i = 0; i < total; i++)
        {
            int index = Random.Range(0, elements.Length);
            GameObject go = Instantiate(elements[index], transform.position, transform.rotation) as GameObject;
            mobs.Add(go);
            go.SetActive(false);
        }
    }
	// Update is called once per frame
	void Update () {
        azar = Random.Range(-5, 5);
        elapsed += Time.deltaTime;
        if (elapsed >= 1f)
        {
            elapsed = 0;
            callMobs();
        }
	}

    void callMobs()
    {
        int index = Random.Range(0, mobs.Count);
        while (true)
        {
            if (!mobs[index].activeInHierarchy)
            {
                mobs[index].SetActive(true);
                mobs[index].transform.position = new Vector3(azar, transform.position.y, transform.position.z);
                break;
            }
            else
            {
                index = Random.Range(0,mobs.Count);
            }
        }
    }
}
