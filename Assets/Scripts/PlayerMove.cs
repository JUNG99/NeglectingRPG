using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 2f; //�̵� �ӵ�
    public bool isFighting = false;

    void Update()
    {
        //�����߾ƴҶ����̵�
        if (!isFighting)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}
