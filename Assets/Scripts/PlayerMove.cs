using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 2f; //이동 속도

    void Update()
    {
        //일정 속도로 앞으로 이동
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
