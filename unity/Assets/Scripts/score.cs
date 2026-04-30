using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    Text scores;

    public int points;
    public float timer1;
    float timer2;

    void Awake() {
        scores = GetComponent<Text>();
    }

    void Start() {
        timer1 = 2;
        timer2 = 2;
    }

    void Update() {
        scores.text = points.ToString();
        if (timer1 < 0) {
            if (timer2 < 0) {
                timer2 = 2;
                points++;
                scores.text = points.ToString();
            } else {
                timer2 -= Time.deltaTime;
            }
        } else {
            timer1 -= Time.deltaTime;
        }
    }
}
