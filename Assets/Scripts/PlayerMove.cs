using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 2f; //�̵� �ӵ�

    void Update()
    {
        //���� �ӵ��� ������ �̵�
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
