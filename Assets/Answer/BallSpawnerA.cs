using UnityEngine;

public class BallSpawnerA : MonoBehaviour
{
    public GameObject ballPrefab;  // アタッチするボールのプレハブ
    public int numberOfBalls = 100;  // 生成するボールの数

    void Start()
    {
        for (int i = 0; i < numberOfBalls; i++)
        {
            Instantiate(ballPrefab, Random.insideUnitSphere * 10, Quaternion.identity);  // ボールをランダムな位置にインスタンシエイトする
        }
    }
}