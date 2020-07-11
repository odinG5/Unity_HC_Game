using UnityEngine;

public class Learn1_Static : MonoBehaviour
{
    private void Start()
    {
        // 靜態成員用法
        // 靜態屬性 Property = 欄位 Field (儲存資料)
        // 語法：類別名稱.靜態屬性名稱
        print(Mathf.PI);
        print(Mathf.Infinity);

        print(Random.value);     // 0 - 1 隨機值

        // 取得 100 - 500 隨機值
        print(Mathf.Abs(-999));
    }

    private void Update()
    {
        // print(Time.time);
    }
}
