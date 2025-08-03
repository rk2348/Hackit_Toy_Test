using UnityEngine;

public class HorizontalLook : MonoBehaviour
{
    public float sensitivity = 100f;

    void Update()
    {
        // Shiftキーと右クリックが同時に押されているときのみ視点を回転
        if ((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) && Input.GetMouseButton(1))
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            transform.Rotate(Vector3.up * mouseX);
        }
    }
}
