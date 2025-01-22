using UnityEngine;

namespace Howard.Tools
{
    /// <summary>
    /// 輸出系統
    /// </summary>
    public class LogSystem : MonoBehaviour
    {
        /// <summary>
        /// 輸出系統
        /// </summary>
        /// <param name="message">輸出內容</param>
        /// <param name="color">顏色</param>
        public static void Log(string message, string color = "#fff")
        {
            Debug.Log($"<color={color}>{message}</color>");
        }
    }
}
