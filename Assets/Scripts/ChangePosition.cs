using NaughtyAttributes;
using UnityEngine;
using UnityEngine.TestTools;

public class ChangePosition : MonoBehaviour
{
    
    public float moveSpeed = 50f;
    void Update()
    {
        transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0);
       
    }


}
