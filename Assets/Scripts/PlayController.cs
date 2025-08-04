using UnityEngine;

public class PlayController : MonoBehaviour
{
    [SerializeField] float xRotationSpeed = 5f;
    [SerializeField] float yRotationSpeed = 5f;

    [SerializeField] Transform followObject;     // 視界の正面に常に置きたいオブジェクト
    [SerializeField] Vector3 positionOffset = new Vector3(1f, 0.2f, 1f);  // カメラからの相対オフセット
    [SerializeField] Vector3 fixedRotationEuler = new Vector3(80f, -3f, 0f); // 固定回転角度

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

        // followObject の位置と回転をカメラ基準で設定
        if (followObject != null && mainCamera != null)
        {
            // カメラの位置 + カメラの回転を考慮したオフセットを計算
            Vector3 worldPosition = mainCamera.transform.position + mainCamera.transform.rotation * positionOffset;
            followObject.position = worldPosition;

            // 固定回転を設定（ワールド座標で固定したい場合はこう書く）
            followObject.rotation = Quaternion.Euler(fixedRotationEuler);
        }
    }
}
