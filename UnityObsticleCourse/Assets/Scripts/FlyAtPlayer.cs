using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [ SerializeField ] Transform player;
    [ SerializeField ] Vector3 playerPosition;
    [ SerializeField ] float speed = 0.01f;
    
    void Awake() 
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        InitPlayerPosition();
    }

    void Update()
    {
        UpdateSpherePosition();
        DestroyWhenReached();
    }

    void InitPlayerPosition()
    {
        playerPosition = player.transform.position;
    }

    void UpdateSpherePosition()
    {
        // diablo style
        transform.position = Vector3
            .MoveTowards(transform.position, playerPosition, Time.deltaTime*speed);
    }

    void DestroyWhenReached()
    {
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
