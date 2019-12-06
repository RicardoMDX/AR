using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip clip1, clip2, clip3;
    public AudioSource source;

    private bool alreadyHit = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (hit.transform.tag == "Audio1" && alreadyHit==false)
            {
                source.PlayOneShot(clip1);
                alreadyHit = true;
            }
            else if (hit.transform.tag == "Audio2" && alreadyHit == false)
            {
                source.PlayOneShot(clip2);
                alreadyHit = true;
            }
            else if (hit.transform.tag == "Audio3" && alreadyHit == false)
            {
                source.PlayOneShot(clip3);
                alreadyHit = true;
            }
        }
        else
        {
            source.Stop();
            alreadyHit = false;
        }
    }
}
