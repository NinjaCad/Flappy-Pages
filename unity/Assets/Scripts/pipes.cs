using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class pipes : MonoBehaviour
{
    public LayerMask player;
    public Pipe pipe;

    public float speed;

    void Awake() {
        pipe.top = transform.Find("Top").gameObject.GetComponent<BoxCollider2D>();
        pipe.bottom = transform.Find("Bottom").gameObject.GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);

        if (isTouching()) {
            SceneManager.LoadScene("GameScene");
        }

        if (transform.position.x < -15) {
            Destroy(GameObject.Find("Pipes(Clone)"), 0);
        }
    }

    private bool isTouching() {
        Collider2D top = Physics2D.OverlapBox(pipe.top.bounds.center, pipe.top.bounds.size, 0f, player);
        Collider2D bottom = Physics2D.OverlapBox(pipe.bottom.bounds.center, pipe.bottom.bounds.size, 0f, player);
        return top != null || bottom != null;
    }
}

[System.Serializable]
public class Pipe
{
    public BoxCollider2D top;
    public BoxCollider2D bottom;
}