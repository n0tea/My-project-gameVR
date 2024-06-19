using UnityEngine;

public class Speaker : MonoBehaviour, IInteractive
{
    public Material BrokenMaterial; // Текстура для поломанной колонки
    public Animator Animator; // Анимация удара молотом
    public AudioSource MusicSource; // Источник музыки

    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    public void OnPointerClick()
    {
        if (GameObject.FindGameObjectWithTag("PlayerHammer").activeInHierarchy) // Проверяем, активен ли молот в руках игрока
        {
            Animator.SetTrigger("Hit"); // Запускаем анимацию удара
            _renderer.material = BrokenMaterial; // Меняем текстуру на поломанную
            MusicSource.Stop(); // Останавливаем музыку
        }
    }
}
