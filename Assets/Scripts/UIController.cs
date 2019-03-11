using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class UIController : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI scoreLabel;
    [SerializeField] private SettingsPopup settingsPopup;

    private int _score;

    private void Awake() {
        Messenger.AddListener(GameEvent.ENEMY_HIT, OnEnemyHit);
    }

    private void OnDestroy() {
        Messenger.RemoveListener(GameEvent.ENEMY_HIT, OnEnemyHit);
    }

    private void Start() {
        _score = 0;
        scoreLabel.text = _score.ToString();

        settingsPopup.Close();
    }

    private void OnEnemyHit() {
        _score += 1;
        scoreLabel.text = _score.ToString();
    }

    public void OnOpenSettings() {
        settingsPopup.Open();
    }
}
