using UnityEngine;
using System.Collections;

public class setPointController : MonoBehaviour {

    // Use this for initialization
    public static setPointController instance;
    public Transform position;
    void Awake()
    {
        instance = this;
    }
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
