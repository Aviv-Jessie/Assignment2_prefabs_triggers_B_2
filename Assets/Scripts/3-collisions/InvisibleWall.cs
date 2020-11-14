using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleWall : MonoBehaviour{
    [Tooltip("Every object over the wall will destroy")]
    [SerializeField] string triggeringTag;

    // Invisible wall- every other (Enemy/Laser) tag that over - will destroy.
    private void OnTriggerEnter2D(Collider2D other){
        if (other.tag == triggeringTag){
            Destroy(other.gameObject);
        }
    }
}
