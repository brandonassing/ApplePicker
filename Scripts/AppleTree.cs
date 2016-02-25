using UnityEngine;
using System.Collections;

public class AppleTree : MonoBehaviour
{

    public GameObject applePrefab;
    public GameObject specialPrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirections = 0.1f;
    public float secondsBetweenAppleDrops = 1f;
    public float chanceToDropSpecial = 0.01f;
    
    void Start()
    {
        InvokeRepeating("DropApple", 2f, secondsBetweenAppleDrops);
    }
    void Update()
    {
        if (Random.value < chanceToDropSpecial)
        {
            DropSpecial();
        }
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }
    void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }

    void DropApple()
    {
        GameObject apple = Instantiate(applePrefab) as GameObject;
        apple.transform.position = transform.position;
        
    }
    void DropSpecial()
    {
        GameObject special = Instantiate(specialPrefab) as GameObject;
        special.transform.position = transform.position;
       // special.GetComponent<Rigidbody>().AddForce(Physics.gravity * GetComponent<Rigidbody>().mass);
    }
}
