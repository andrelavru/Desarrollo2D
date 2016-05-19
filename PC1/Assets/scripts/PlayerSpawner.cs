using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerSpawner : MonoBehaviour {

    // Use this for initialization
    public GameObject[] players;
    List<GameObject> heros;
	void Start () {
        heros = new List<GameObject>();
        createPlayer();
	}

    void createPlayer()
    {
        int index = Random.Range(0, players.Length);
        GameObject element = Instantiate(players[index], transform.position, transform.rotation) as GameObject;
        heros.Add(element);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
