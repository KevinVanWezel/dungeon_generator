using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class East : MonoBehaviour {
    [SerializeField]
    PlayerMovement _PlayerMovement;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall")
            _PlayerMovement.East_Colider();
    }
}
