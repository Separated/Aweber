using UnityEngine;
using System.Collections;


public class Messages : MonoBehaviour
{

    public GameObject tutObj;
    public GameObject targetText;


    public bool message1 = false;
    public bool message2 = false;
    public bool message3 = false;
    public bool person1 = false;
    public bool person2 = false;
    public bool person3 = false;
    public bool person4 = false;
    public bool person5 = false;
    public bool coin1 = false;
    public bool coin2 = false;
    public bool coin4 = false;



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && gameObject.name == "Message1")
        {
            message1 = true;
            targetText.SetActive(true);
            Time.timeScale = 0;
        }

        if (other.tag == "Player" && gameObject.name == "Message2")
        {
            message2 = true;
            targetText.SetActive(true);
            Time.timeScale = 0;
        }

        if (other.tag == "Player" && gameObject.name == "Message3")
        {
            message3 = true;
            targetText.SetActive(true);
            Time.timeScale = 0;
        }

        if (other.tag == "Player" && gameObject.name == "Person1")
        {
            person1 = true;
            targetText.SetActive(true);
     
        }

        if (other.tag == "Player" && gameObject.name == "Person2")
        {
            person2 = true;
            targetText.SetActive(true);
     
        }

        if (other.tag == "Player" && gameObject.name == "Person3")
        {
            person3 = true;
            targetText.SetActive(true);
       
        }

        if (other.tag == "Player" && gameObject.name == "Person4")
        {
            person4 = true;
            targetText.SetActive(true);
     
        }

        if (other.tag == "Player" && gameObject.name == "Person5")
        {
            person5 = true;
            targetText.SetActive(true);
     
        }

        if (other.tag == "Player" && gameObject.name == "Coin1Collider")
        {
            coin1 = true;
            targetText.SetActive(true);
            Time.timeScale = 0;
        }

        if (other.tag == "Player" && gameObject.name == "Coin3Collider")
        {
            coin2 = true;
            targetText.SetActive(true);
            Time.timeScale = 0;
        }

        if (other.tag == "Player" && gameObject.name == "Coin2Collider")
        {
            coin4 = true;
            targetText.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (person1 == true && gameObject.name == "Person1")
        {
            person1 = false;
            targetText.SetActive(false);
       
        }

        if (person2 == true && gameObject.name == "Person2")
        {
            person2 = false;
            targetText.SetActive(false);
   
        }

        if (person3 == true && gameObject.name == "Person3")
        {
            person3 = false;
            targetText.SetActive(false);
        
        }

        if (person4 == true && gameObject.name == "Person4")
        {
            person4 = false;
            targetText.SetActive(false);
       
        }

        if (person5 == true && gameObject.name == "Person5")
        {
            person5 = false;
            targetText.SetActive(false);
   
        }
    }

    void Update()
    {
        if (message1 == true && gameObject.name == "Message1" && Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            message1 = false;
            targetText.SetActive(false);
            Time.timeScale = 1;

        }

        if (message2 == true && gameObject.name == "Message2" && Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            message2 = false;
            targetText.SetActive(false);
            Time.timeScale = 1;
        }

        if (message3 == true && gameObject.name == "Message3" && Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            message3 = false;
            targetText.SetActive(false);
            Time.timeScale = 1;
        }

        if (coin1 == true && gameObject.name == "Coin1Collider" && Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            coin1 = false;
            targetText.SetActive(false);
            Time.timeScale = 1;
            Destroy(gameObject);
        }
        if (coin2 == true && gameObject.name == "Coin3Collider" && Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            coin2 = false;
            targetText.SetActive(false);
            Time.timeScale = 1;
            Destroy(gameObject);
        }

        if (coin4 == true && gameObject.name == "Coin2Collider" && Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            coin4 = false;
            targetText.SetActive(false);
            Time.timeScale = 1;
            Destroy(gameObject);
        }
    }
}