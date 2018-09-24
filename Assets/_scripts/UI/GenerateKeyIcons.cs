using UnityEngine;
using UnityEngine.UI;

public class GenerateKeyIcons : MonoBehaviour {

    [SerializeField] private GameObject toolIconPrefab;
    private GameObject toolIcon;

    // Use this for initialization
    void Awake() {
        for(int i = 0; i < GameState.colors.Count; i++)
        {
            toolIcon = Instantiate(toolIconPrefab);
            RectTransform rt = toolIcon.GetComponent<RectTransform>();
            rt.SetParent(gameObject.transform);
            rt.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - i * (toolIconPrefab.GetComponent<RectTransform>().rect.height + 50));

            Image img = toolIcon.GetComponent<Image>();
            img.fillCenter = false;
            img.color = GameState.colors[i];

            Text text = toolIcon.GetComponentInChildren<Text>();
            text.text = (i+1).ToString();
        }
	}
}
