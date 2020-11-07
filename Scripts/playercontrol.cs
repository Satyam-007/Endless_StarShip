using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercontrol : MonoBehaviour
{

    public float speed;
    private Vector3 offset;
    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;
    //public Button LeftButton;
    public button RightButton; 
   // public Button UpButton; 
    //public Button DownButton;

    void Start()
    {
    }
    void Update()
    {

        transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        if (Input.GetKeyDown("w"))
        {
            transform.Rotate(0, 90, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) || RightButton.IsPressed)
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
            image1.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
        }

       /* if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }*/

    }

    void OnCollisionEnter(Collision collision)
    {
       /* if (collision.gameObject.CompareTag("obs1"))
        {
            image1.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            image3.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
            image2.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        }

        else if (collision.gameObject.CompareTag("obs2"))
        {
            image2.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            image1.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
            image3.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        }

        else if (collision.gameObject.CompareTag("obs3"))
        {
            image3.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            image1.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
            image2.GetComponent<Image>().color = new Color32(255, 255, 225, 255);
        }*/

    }

}
