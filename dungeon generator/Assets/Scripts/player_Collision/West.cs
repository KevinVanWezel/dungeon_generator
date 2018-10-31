using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class West : MonoBehaviour {
    [SerializeField]
    PlayerMovement _PlayerMovement;
    void OnTriggerEnter2D(Collider2D other)
    {
        print("test");
        if (other.tag == "Wall")
            _PlayerMovement.West_Colider();
    }
}
