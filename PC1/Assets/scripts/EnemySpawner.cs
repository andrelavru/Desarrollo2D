using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour {

    // Use this for initialization
    public GameObject[] elements;
    List<GameObject> enemies;
    float elapsed;
    void Start () {
        enemies = new List<GameObject>();
        createEnemy();
    }

    void createEnemy()
    {
        for (int i = 0; i < elements.Length * 3; i++)
        {
            int index = Random.Range(0, elements.Length);
            GameObject element = Instantiate(elements[index], transform.position, transform.rotation) as GameObject;
            enemies.Add(element);
            element.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
        elapsed += Time.deltaTime;
        if (elapsed >= 1)
        {
            elapsed = 0;
            generateElement();
        }
    }

    void generateElement()
    {

        int index = Random.Range(0, enemies.Count);
        while (true)
        {
            if (!enemies[index].activeInHierarchy)
            {
                enemies[index].SetActive(true);
                enemies[index].transform.position = new Vector3(transform.position.x, Random.Range(-5f, 5f), 0);
                break;
            }
            else {
                index = Random.Range(0, enemies.Count);
            }
        }

    }
}
