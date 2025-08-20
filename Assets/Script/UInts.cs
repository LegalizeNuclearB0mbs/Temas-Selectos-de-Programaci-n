using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UInts : MonoBehaviour {
    // Variables de control
    static int currentIndex = 0;

    // Variables de objetos
    [SerializeField]
    public List<string> message;
    [SerializeField]
    public TextMeshProUGUI text;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        currentIndex = 0;
    }

    public void CycleText() {
        UpdateText();
        currentIndex = (currentIndex + 1) % message.Count;
    }

    public void UpdateText() {
        if (message.Count > 0 && text != null) {
            text.text = message[currentIndex];
        }
    }

    // Update is called once per frame
    void Update() {
        
    }
}
