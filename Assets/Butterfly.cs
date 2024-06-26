using UnityEngine;

public class ButterflyMovement : MonoBehaviour
{
    public float speed = 3.0f;       // x 축으로 이동하는 속도
    public float amplitude = 2.0f;   // y 축으로 움직이는 폭
    public float frequency = 1.0f;   // y 축으로 움직이는 빈도

    private Vector3 startPos;
    private float startTime;

    private void Awake()
    {
        transform.position = GetComponent<Transform>().position;
    }

    void Start()
    {
        startPos = transform.position;  // 시작 위치 저장
        startTime = Time.time;          // 시작 시간 저장
    }

    void Update()
    {
        float elapsedTime = Time.time - startTime;  // 경과 시간 계산
        float newX = startPos.x - speed * elapsedTime;  // x 위치 계산

        // 초기 위치에서 시작하도록 조정 (위치의 오프셋)
        float newY = startPos.y + Mathf.Sin(elapsedTime * frequency) * amplitude;

        transform.position = new Vector3(newX, newY, startPos.z);
    }
}
