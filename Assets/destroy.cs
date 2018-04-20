using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            return;
        }

        Destroy(other.gameObject);
        Destroy(gameObject);
        //gamefunction.Instance.AddScore();
    }
}
