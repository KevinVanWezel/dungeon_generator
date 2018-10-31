using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class South : MonoBehaviour {
    [SerializeField]
    PlayerMovement _PlayerMovement;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall")
            _PlayerMovement.South_Colider();
    }
}
