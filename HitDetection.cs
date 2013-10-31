using UnityEngine;
using System.Collections;

public class HitDetection : MonoBehaviour
{

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Enter called.");
        // Cubes were used as a placeholder for the weapon and player character
        if (col.gameObject.name == "Cube2:SonOfCube") {
            // Placeholder until I have the blocking variable
            if (col.gameObject.renderer.material.color ==  Color.red)
            {
                Debug.Log("Blocked.");
            }
            else
            {
                Destroy(col.gameObject);
                Debug.Log("Object Destroyed.");
            }
        }
    }
    
