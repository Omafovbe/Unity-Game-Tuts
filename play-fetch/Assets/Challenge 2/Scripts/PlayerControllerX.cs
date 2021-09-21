using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool spamCheck = true;
    

    void Start()
    {
        InvokeRepeating("SpamChecker", 0.5f, 0.7f);
    }


    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && spamCheck)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            spamCheck = !spamCheck;
        }
    }

    void SpamChecker()
    {
        spamCheck = !spamCheck;
    }
}
