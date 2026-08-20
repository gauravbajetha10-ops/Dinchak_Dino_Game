using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class monster : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    private Rigidbody2D myBody;

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
      
    }
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        myBody.linearVelocity = new Vector2(speed, myBody.linearVelocity.y);
    }
}
