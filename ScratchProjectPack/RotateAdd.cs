using NaughtyAttributes;
using UnityEngine;

public class RotateAdd : MonoBehaviour
{
    [SerializeField, Label("回転角度の指定")] private int _rotateAngle = 15;
    [Button("実行")]
    public void RotateAddAngle()
    {
        transform.Rotate(0, 0, -_rotateAngle);
        // //  
        // var angle = transform.eulerAngles;
        // angle.z -= _rotateAngle;
        // transform.eulerAngles = angle;
    }
}
