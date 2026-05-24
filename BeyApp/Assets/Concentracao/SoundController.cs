using UnityEngine;
using UnityEngine.UIElements;

public class Scripts : MonoBehaviour
{
    [SerializeField] UIDocument uiDocument;

    [SerializeField] AudioSource audio;

    [SerializeField] AudioClip[] clips;

    [SerializeField] Slider slider;

    Button buttonplay, buttonpause, buttonexit;

    DropdownField dropdown;

#if UNITY_ANDROID

    void Awake()
    {
        GameObject page = GameObject.Find("ImagePageTel");

        uiDocument = page.GetComponent<UIDocument>();

        uiDocument.enabled = true;

        Application.runInBackground = true;
    }

#endif

    void Start()
    {
        dropdown = uiDocument.rootVisualElement.Q<DropdownField>("Selector");

        buttonplay = uiDocument.rootVisualElement.Q<Button>("PlayButton");

        buttonpause = uiDocument.rootVisualElement.Q<Button>("PauseButton");

        buttonexit = uiDocument.rootVisualElement.Q<Button>("ExitButton");

        slider = uiDocument.rootVisualElement.Q<Slider>("Volume");

        slider.RegisterValueChangedCallback(ChangeVolume);

        buttonplay.clicked += PlayMusic;

        buttonpause.clicked += PauseMusic;

        buttonexit.clicked += Exit;

        GameObject effectsound = GameObject.Find("Sounds");

        audio = effectsound.GetComponent<AudioSource>();

        dropdown.RegisterValueChangedCallback(ChangeMusic);
    }

    #region Function Buttons
    void PlayMusic()
    {
        audio.Play();
    }

    void PauseMusic()
    {
        audio.Pause();
    }

    void Exit()
    {
        Application.Quit();
    }
    #endregion

    #region Change Values
    void ChangeMusic(ChangeEvent<string> change)
    {
        audio.Pause();

        audio.clip = clips[dropdown.index];
    }

    void ChangeVolume(ChangeEvent<float> change)
    {
        audio.volume = slider.value/100;
    }
    #endregion
}
