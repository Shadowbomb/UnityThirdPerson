using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class UIController : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI scoreLabel;
    [SerializeField] private SettingsPopup settingsPopup;

    private void Start() {
        settingsPopup.Close();
    }

    // Update is called once per frame
    void Update() {
        scoreLabel.text = Time.realtimeSinceStartup.ToString();
    }

    public void OnOpenSettings() {
        settingsPopup.Open();
    }
}
