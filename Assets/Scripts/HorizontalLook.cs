using UnityEngine;

public class HorizontalLook : MonoBehaviour
{
    public float sensitivity = 100f;

    void Update()
    {
        // Shift�L�[�ƉE�N���b�N�������ɉ�����Ă���Ƃ��̂ݎ��_����]
        if ((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) && Input.GetMouseButton(1))
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            transform.Rotate(Vector3.up * mouseX);
        }
    }
}
