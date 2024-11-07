using UnityEngine;

public class Rotate : MonoBehaviour
{
    [ SerializeField  ] float x;
    [ SerializeField  ] float y;
    [ SerializeField  ] float z = 0f;
    void Start()
    {
        x = 0f;
        y = 1f;
    }

    void Update()
    {
        transform.Rotate(x, y, z);
    }
}
