using UnityEngine;

namespace DefaultNamespace
{
    public class CameraEditorRotator : MonoBehaviour
    {
        private float rotationSpeed = 5.0f;
        private float verticalRotationLimit = 80.0f;
        private float rotationX = 0.0f;
        private float rotationY = 0.0f;

#if UNITY_EDITOR
        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButton(1)) // Правая кнопка мыши
            {
                rotationX += Input.GetAxis("Mouse X") * rotationSpeed;
                rotationY += Input.GetAxis("Mouse Y") * rotationSpeed;
                rotationY = Mathf.Clamp(rotationY, -verticalRotationLimit, verticalRotationLimit);

                transform.eulerAngles = new Vector3(-rotationY, rotationX, 0.0f);
            }
        }
#endif
    }
}
