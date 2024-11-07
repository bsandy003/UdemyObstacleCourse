using UnityEngine;

public class Scorer : MonoBehaviour
{
    int count = 0;
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {

            Debug.Log($"You've bumped into a thing this many times {++count}");
        }
    }
}
