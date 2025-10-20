using NaughtyAttributes;
using UnityEngine;

public class MoveAdd: MonoBehaviour
{
    [SerializeField, Label("歩数の設定")] private int _step;

    [Button]
    public void MoveAddPosition()
    {
        transform.position += transform.right *_step / 100f;
    }
    
        
}
