using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private CharacterController characterController;
    public Camera playerCamera;

    private Vector3 velocity;
    public float gravity = 9.8f;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Применяем гравитацию
        if (characterController.isGrounded)
        {
            velocity.y = -2; // Обнуляем вертикальную скорость, если игрок на земле
        }
        else
        {
            velocity.y -= gravity * Time.deltaTime; // Применяем гравитацию
        }

        // Проверяем нажатие кнопки "Fire1"
        if (Input.GetButton("Fire1"))
        {
            MoveForward();
        }
        characterController.Move(velocity * Time.deltaTime);
    }

    void MoveForward()
    {
        // Определяем направление движения (в направлении взгляда)
        Vector3 moveDirectionFrd = playerCamera.transform.forward;
        //Vector3 moveDirection = transform.forward;
        // Применяем движение, умноженное на скорость
        Vector3 move = moveDirectionFrd * moveSpeed * Time.deltaTime;
        // Ограничиваем движение по земле (нулевая вертикальная скорость)
        move.y = 0;

        // Двигаем игрока
        characterController.Move(move);

        // Также добавим изменение скорости направления движения, чтобы не прерывать обработку гравитации
        //velocity += move;
    }
}
