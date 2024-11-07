using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // expecting other
    void OnCollisionEnter(Collision other)
    {
        // if (other.gameObject.tag == "Player")
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            Debug.Log("I hit something!");

            gameObject.tag = "Hit";
        } 
    }
}
