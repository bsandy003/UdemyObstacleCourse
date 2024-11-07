using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeVar = 6f;
    
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;

    void Start()
    {
        // This means component should be invisible
        myMeshRenderer = GetComponent<MeshRenderer>();
        myMeshRenderer.enabled = false;
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = false;

        
    }

    void Update()
    {
        if (Time.time > timeVar)
        {
            myRigidbody.useGravity = true;
            myMeshRenderer.enabled = true;
            // Debug.Log(Time.time);
        }
    }
}
