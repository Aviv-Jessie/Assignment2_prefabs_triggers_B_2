using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag, with a SerializedField lives
 */
public class DestroyOnTriggerWithLives : MonoBehaviour{

    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag="Enemy";
    [Tooltip("Number of lives")]
    [SerializeField] int lives = 3;
    [SerializeField] TextMeshPro textMesh;
    string prefix = "Lives: ";

    void Start(){
        if (textMesh.text.Length != 0){
            prefix = textMesh.text;
        }
        textMesh.text = prefix + lives.ToString();
    }


    private void OnTriggerEnter2D(Collider2D other){
        if (other.tag == triggeringTag && enabled){
            lives--;
            textMesh.text = prefix + lives.ToString();
            if (lives == 0){
                Destroy(this.gameObject);
                Destroy(other.gameObject);
            }
        }
    }
}
