using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform Player;
    private Vector3 tempPos;
    [SerializeField]
    private float Minx, Maxx;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!Player)
           return;
        
        tempPos = transform.position;
        tempPos.x = Player.position.x;
        if (tempPos.x < Minx)
        {
            tempPos.x = Minx;
        }
        if (tempPos.x > Maxx)
        {
            tempPos.x = Maxx; 
        }
        transform.position = tempPos;
    }
}