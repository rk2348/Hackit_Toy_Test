using UnityEngine;

public class PlayController : MonoBehaviour
{
    [SerializeField] float xRotationSpeed = 5f;
    [SerializeField] float yRotationSpeed = 5f;

    [SerializeField] Transform followObject;     // 視界の正面に常に置きたいオブジェクト
    [SerializeField] float distanceInFront = 2f;  // カメラからの距離

    private Vector3 startMousePosition = Vector3.zero;
    private Vector3 startCameraRotation = Vector3.zero;

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;

        if (mainCamera == null)
        {
            Debug.LogError("Main Camera が見つかりません。カメラに 'MainCamera' タグを付けてください。");
        }
    }

    void Update()
    {
        // カメラの回転操作（マウスドラッグ）
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

        // カメラの正面に followObject を表示（毎フレーム更新）
        if (followObject != null && mainCamera != null)
        {
            Vector3 forward = mainCamera.transform.forward;
            Vector3 up = mainCamera.transform.up;
            Vector3 right = mainCamera.transform.right;

            followObject.position = new Vector3(1f, 0.2f, 1f);  // 例：ワールド座標 (0,1.5,0) に固定

            // 回転を固定（ワールド座標で0度回転に設定）
            followObject.rotation = Quaternion.Euler(80f, -3f, 0f);

        }
    }
}
