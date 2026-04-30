using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject pipes;
    public float timerAmount;
    float timer;
    public float range;

    void Update()
    {
        if (timer <= 0) {
            timer = timerAmount;
            Instantiate(pipes, new Vector2 (transform.position.x, transform.position.y + Random.Range(-range, range)), Quaternion.identity);
        } else {
            timer -= Time.deltaTime;
        }
    }
}
