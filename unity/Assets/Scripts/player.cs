using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float jump;

    void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
	}

    void Update()
    {
        if (Input.anyKeyDown) {
            if (Input.GetKeyDown(KeyCode.Escape)) {
                //pause
            } else {
                rb.velocity = Vector2.up * jump;
            }
        }
    }
}
