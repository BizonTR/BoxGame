using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed;
    public GameObject finishScreen;
    void Start()
    {
        speed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            finishScreen.SetActive(true);
            finishScreen.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = $"Your Score \n {GameObject.Find("Score").GetComponent<ScoreController>().score}";
            Destroy(gameObject);
        }
    }
}
