using UnityEngine;

public class VerticalSpinner : MonoBehaviour
{
    [ SerializeField  ] float x;
    [ SerializeField  ] float y;
    [ SerializeField  ] float z;
    void Start()
    {
        x = 0f;
        y = -70.2f; 
        z = 0f;
    }

    void Update()
    {
        transform.Rotate(x, Time.deltaTime * y, z);
    }
}
