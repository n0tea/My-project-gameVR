using UnityEngine;

public class Hammer : MonoBehaviour, IInteractive
{
    public GameObject PlayerHammer; // Молот, который будет в руках игрока

    private void Start()
    {
        PlayerHammer.SetActive(false); // Изначально молот в руках не активен
    }

    public void OnPointerClick()
    {
        gameObject.SetActive(false); // Деактивируем молот на сцене
        PlayerHammer.SetActive(true); // Активируем молот в руках игрока
    }

}
