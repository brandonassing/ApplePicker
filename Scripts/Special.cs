using UnityEngine;
using System.Collections;

public class Special : MonoBehaviour {

    public static float bottomY = -20f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);

        }
    }
}
