using UnityEngine;

public class MoveToPosition : MonoBehaviour
{
    public Vector3 targetPosition = new Vector3(5f, 0f, 0f); 

    void Update()
    {
        transform.position = targetPosition/100f;
    }
}