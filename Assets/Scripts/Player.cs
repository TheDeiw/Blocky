using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
   [SerializeField] KeyCode keyone;
   [SerializeField] KeyCode keytwo;
   [SerializeField] Vector3 move;

    private void FixedUpdate()
    {
      if  (Input.GetKey(keyone))
        {
            GetComponent<Rigidbody>().velocity += move;
        }
        if (Input.GetKey(keytwo))
        {
            GetComponent<Rigidbody>().velocity -= move;
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
       // if(this.CompareTag("cube") && other.CompareTag("cube"))
       // {
       //     foreach (Activator button in FindObjectsOfType<Activator>())
        //    {
       //         button.canPush = false;
       //     }
       // } 
    }
   
}

