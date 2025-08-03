using UnityEngine;

public class HorizontalLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public float keySensitivity = 100f;

    void Update()
    {
        // 1. Shift＋右クリックでマウス操作
        if ((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) && Input.GetMouseButton(1))
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            transform.Rotate(Vector3.up * mouseX);
        }

        // 2. A/Dキーで回転
        float keyInput = 0f;
        if (Input.GetKey(KeyCode.A)) keyInput = -1f;
        if (Input.GetKey(KeyCode.D)) keyInput = 1f;

        if (keyInput != 0f)
        {
            float rotateAmount = keyInput * keySensitivity * Time.deltaTime;
            transform.Rotate(Vector3.up * rotateAmount);
        }
    }
}
