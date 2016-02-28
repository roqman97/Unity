﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float playerSpeed = 15.0f;
    public float padding = 1f;

    float xmin;
    float xmax;

    // Use this for initialization
    void Start()
    {
        float distance = transform.position.z - Camera.main.transform.position.z;
        Vector3 leftmost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        Vector3 rightmost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance));
        xmin = leftmost.x + padding;
        xmax = rightmost.x - padding;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += Vector3.right * playerSpeed * Time.deltaTime;
            Debug.Log("moving right");
            Debug.Log(transform.position);
        }else if (Input.GetKey(KeyCode.LeftArrow)){
            transform.position += Vector3.left * playerSpeed * Time.deltaTime;
            Debug.Log("moving left");
            Debug.Log(transform.position);
        }

        float newX = Mathf.Clamp(transform.position.x, xmin, xmax);

        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
