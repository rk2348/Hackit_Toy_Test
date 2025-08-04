using UnityEngine;

public class PlayController : MonoBehaviour
{
    [SerializeField] float xRotationSpeed = 5f;
    [SerializeField] float yRotationSpeed = 5f;

    [SerializeField] Transform followObject;     // ���E�̐��ʂɏ�ɒu�������I�u�W�F�N�g
    [SerializeField] float distanceInFront = 2f;  // �J��������̋���

    private Vector3 startMousePosition = Vector3.zero;
    private Vector3 startCameraRotation = Vector3.zero;

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;

        if (mainCamera == null)
        {
            Debug.LogError("Main Camera ��������܂���B�J������ 'MainCamera' �^�O��t���Ă��������B");
        }
    }

    void Update()
    {
        // �J�����̉�]����i�}�E�X�h���b�O�j
        if (Input.GetMouseButtonDown(0))
        {
            startMousePosition = Input.mousePosition;
            startCameraRotation = transform.localRotation.eulerAngles;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 def = Input.mousePosition - startMousePosition;
            float x = startCameraRotation.x + def.y * xRotationSpeed * 0.01f;
            float y = startCameraRotation.y - def.x * yRotationSpeed * 0.01f;
            transform.localRotation = Quaternion.Euler(x, y, 0);
        }

        if (Input.GetMouseButtonUp(0))
        {
            startMousePosition = Vector3.zero;
            startCameraRotation = Vector3.zero;
        }

        // �J�����̐��ʂ� followObject ��\���i���t���[���X�V�j
        if (followObject != null && mainCamera != null)
        {
            Vector3 forward = mainCamera.transform.forward;
            Vector3 up = mainCamera.transform.up;
            Vector3 right = mainCamera.transform.right;

            followObject.position = new Vector3(1f, 0.2f, 1f);  // ��F���[���h���W (0,1.5,0) �ɌŒ�

            // ��]���Œ�i���[���h���W��0�x��]�ɐݒ�j
            followObject.rotation = Quaternion.Euler(80f, -3f, 0f);

        }
    }
}
