using UnityEngine;

public class PlayController : MonoBehaviour
{
    [SerializeField] float xRotationSpeed = 5f;
    [SerializeField] float yRotationSpeed = 5f;

    [SerializeField] Transform followObject;     // ���E�̐��ʂɏ�ɒu�������I�u�W�F�N�g
    [SerializeField] Vector3 positionOffset = new Vector3(1f, 0.2f, 1f);  // �J��������̑��΃I�t�Z�b�g
    [SerializeField] Vector3 fixedRotationEuler = new Vector3(80f, -3f, 0f); // �Œ��]�p�x

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

        // followObject �̈ʒu�Ɖ�]���J������Őݒ�
        if (followObject != null && mainCamera != null)
        {
            // �J�����̈ʒu + �J�����̉�]���l�������I�t�Z�b�g���v�Z
            Vector3 worldPosition = mainCamera.transform.position + mainCamera.transform.rotation * positionOffset;
            followObject.position = worldPosition;

            // �Œ��]��ݒ�i���[���h���W�ŌŒ肵�����ꍇ�͂��������j
            followObject.rotation = Quaternion.Euler(fixedRotationEuler);
        }
    }
}
