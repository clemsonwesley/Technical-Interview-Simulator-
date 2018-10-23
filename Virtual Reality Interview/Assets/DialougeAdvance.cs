using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougeAdvance : MonoBehaviour
{

    public Text myText;
    private int i;
    private string str;
    public AudioClip logoFX;
    private AudioSource source;

    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();

        myText.text = "";
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            myText.text = "";
            source.PlayOneShot(logoFX, 1);
            StartCoroutine("Dialouge");

        }
    }

    IEnumerator Dialouge()
    {
        i++;
        str = "Test text " + i.ToString();

 

        yield return new WaitForSeconds(5f);

        myText.text = str;

    }
}
