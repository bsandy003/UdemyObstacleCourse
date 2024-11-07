using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour

    // Start is called once before the first execution of Update after the MonoBehaviour is created
{
    [SerializeField] float moveSpeed = 20f;
    
 
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move using arrow keys or wasd!");
        Debug.Log("Don't bump into objects!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0.0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);

    }
}
