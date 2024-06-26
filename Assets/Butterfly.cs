using UnityEngine;

public class ButterflyMovement : MonoBehaviour
{
    public float speed = 3.0f;       // x ������ �̵��ϴ� �ӵ�
    public float amplitude = 2.0f;   // y ������ �����̴� ��
    public float frequency = 1.0f;   // y ������ �����̴� ��

    private Vector3 startPos;
    private float startTime;

    private void Awake()
    {
        transform.position = GetComponent<Transform>().position;
    }

    void Start()
    {
        startPos = transform.position;  // ���� ��ġ ����
        startTime = Time.time;          // ���� �ð� ����
    }

    void Update()
    {
        float elapsedTime = Time.time - startTime;  // ��� �ð� ���
        float newX = startPos.x - speed * elapsedTime;  // x ��ġ ���

        // �ʱ� ��ġ���� �����ϵ��� ���� (��ġ�� ������)
        float newY = startPos.y + Mathf.Sin(elapsedTime * frequency) * amplitude;

        transform.position = new Vector3(newX, newY, startPos.z);
    }
}
