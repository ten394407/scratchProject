using NaughtyAttributes;
using UnityEngine;

public class MoveAdd : MonoBehaviour
{
    [SerializeField, Label("歩数の設定")] private int _step = 10;

    [Button("実行")]
    public void MoveAddPosition()
    {
        //  オブジェクトの座標を操作するには transform.position
        //  または transform.localposition を
        //  操作する必要がある
        //  transform.up, transform.right, transform.down, transform.left
        //  はキャラが回転していても指定方向に移動する
        //  += は元の値に加算する命令である
        //  100f で割っているのは、１の移動量が100ドット分なので
        //  ドット数/100が進む距離になる
        transform.position += transform.right * _step / 100f;
    }
}
