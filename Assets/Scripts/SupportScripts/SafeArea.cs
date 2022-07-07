using UnityEngine;

namespace SupportScripts
{
    public class SafeArea : MonoBehaviour
    {
        private void Awake()
        {
            UpdateSafeArea();
        }

        private void UpdateSafeArea()
        {
            Rect safeArea = Screen.safeArea;
            RectTransform myRect = GetComponent<RectTransform>();

            Vector2 anchorMin = safeArea.position;
            Vector2 anchorMax = safeArea.position + safeArea.size;

            anchorMin.x /= Screen.width;
            anchorMin.y /= Screen.height;
            
            anchorMax.x /= Screen.width;
            anchorMax.y /= Screen.height;

            myRect.anchorMin = anchorMin;
            myRect.anchorMax = anchorMax;
        }
    }
}
