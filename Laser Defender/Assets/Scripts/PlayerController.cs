using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float playerSpeed = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(playerSpeed * Time.deltaTime, 0, 0);
        } else if (Input.GetKey(KeyCode.LeftArrow)){
            transform.position += new Vector3(-playerSpeed * Time.deltaTime, 0, 0);
        }
    }
}
