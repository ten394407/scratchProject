using NaughtyAttributes;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public enum ReachedType
    {
        [InspectorName("どこかの場所")]         //  enum の表示を anyPosition から「どこかの場所」に変更する
        anyPosition,
        [InspectorName("マウスのポインター")]
        mousePointer,
    }
    //  条件の選択
    [SerializeField, Label("条件")] private ReachedType _reachedType;
    //  画面左右の幅と、上下の幅の値
    private float _width = 960f / 100f;
    private float _height = 540f / 100f;

    [Button("実行")]
    public void ChangePositionFunc()
    {
        //  どこかの場所を選んだ場合
        if (_reachedType.Equals(ReachedType.anyPosition))
        {
            //  Ｘ座標とＹ座標を指定した範囲の乱数で取得する
            transform.position = new Vector3(Random.Range(-_width, _width), Random.Range(-_height, _height), 0);
        }
        else
        {
            //  マウス座標をスプライトの座標に変換する
            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //  カメラが基準になっているのでＺ座標を０に設定する（カメラは-10なので同じ値だとカメラに映らなくなるため）
            mousePos.z = 0;
            //  座標を指定
            transform.position = mousePos;
        }
    }

    void Update()
    {
        //  マウスをクリックすると実行する（テスト用に組み込み）
        if(Input.GetMouseButtonDown(0))
        {
            ChangePositionFunc();
        }
    }
}
