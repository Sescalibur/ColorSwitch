using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    
    [SerializeField] float jumpPower ;
    [SerializeField] string color;
    [SerializeField] private Text scor;
    [SerializeField] static int scorValue = 0;
    [SerializeField] GameObject[] sricle;
    [SerializeField] GameObject colorSricle;
    // Start is called before the first frame update
    void Start()
    {
        RandomColor();
        scor.text = scorValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpPower;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int chance = Random.Range(0, 2);
        if (collision.tag == "ScorUp")
        {
            scorValue += 100;
            Destroy(collision);
            scor.text = scorValue.ToString();
            Instantiate(sricle[chance], new Vector3(transform.position.x, transform.position.y + 12f, transform.position.z),
                transform.rotation);
            return;
            
        }
        else if (collision.tag == "ColorSwitch")
        {
            RandomColor();
            Instantiate(colorSricle,
                new Vector3(transform.position.x, transform.position.y + 12f, transform.position.z),
                transform.rotation);
            Destroy(collision.gameObject);
            return;
        }
        else if (collision.tag != color)
        {
            Destroy(gameObject);
            scorValue = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }

    void RandomColor()
    {
        int random = Random.Range(0, 4);
        switch (random)
        {
            case 0: 
                color = "Turkuaz";
                GetComponent<SpriteRenderer>().color = Color.cyan;
                break;
            case 1: 
                color = "Sari";
                GetComponent<SpriteRenderer>().color = Color.yellow;
                break;
            case 2:
                color = "Mor";
                GetComponent<SpriteRenderer>().color = new Color32(170, 0, 255, 255);
                break;
            case 3:
                color = "Pembe";
                GetComponent<SpriteRenderer>().color = new Color32(255,56,131,255);
                break;

        }
    }
}
