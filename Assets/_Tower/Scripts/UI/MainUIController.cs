using UnityEngine;
using UnityEngine.UIElements;
using VContainer;

public class MainUIController : MonoBehaviour
{
    [SerializeField] private HealthView _health;

    [Inject]
    private HealthService _healthService;

    public void OnEnable()
    {
        var uiDocument = GetComponent<UIDocument>();

        var healthBar = uiDocument.rootVisualElement.Q<ProgressBar>("healthBar");
        healthBar.dataSource = _health;

        var addHealthBtn = uiDocument.rootVisualElement.Q<Button>("addHealthBtn");
        var removeHealthBtn = uiDocument.rootVisualElement.Q<Button>("removeHealthBtn");

        addHealthBtn.RegisterCallback<ClickEvent>(AddHealthBtnClick);
        removeHealthBtn.RegisterCallback<ClickEvent>(RemoveHealthBtnClick);
    }

    private void AddHealthBtnClick(ClickEvent e)
    {
        _healthService.Heal(10);
    }

    private void RemoveHealthBtnClick(ClickEvent e)
    {
        _healthService.Damage(10);
    }
}
