using UnityEngine;
using System.Collections;

public class backgroundSpawn : MonoBehaviour {

    // Use this for initialization
    
    private GameObject[] bgs;
    private float lastx;
    void Start() {
        bgs = GameObject.FindGameObjectsWithTag("background");
        lastx = bgs[0].transform.position.x;
        for (int i = 1; i < bgs.Length; i++)
        {
            if (lastx < bgs[i].transform.position.x)
            {
                lastx = bgs[i].transform.position.x;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
        {
            if (coll.gameObject.transform.position.x == lastx)
            {
                Vector3 tmp = coll.gameObject.transform.position;
                float width = ((BoxCollider2D)coll).size.x;
                for (int i = 0; i < bgs.Length; i++)
                {
                    if (!bgs[i].activeInHierarchy)
                    {
                        tmp.x += width;
                        bgs[i].transform.position = tmp;
                        lastx = tmp.x;
                        bgs[i].SetActive(true);
                    }
                }
            }
        }
    
        void Update () {
	
	    }
}
