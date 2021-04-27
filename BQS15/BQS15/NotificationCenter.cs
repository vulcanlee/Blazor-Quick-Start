using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BQS15
{
    /// <summary>
    /// 狀態容器 State Container ，用來觸發有變更的事件通知
    /// </summary>
    public class NotificationCenter
    {
        /// <summary>
        /// 觸發事件 (Delegate 委派方法)
        /// </summary>
        public Action<string> OnMessageChange;

        public void RefreshMessageAllView(string message)
        {
            NotifyMessageStateChanged(message);
        }
        private void NotifyMessageStateChanged(string message) => OnMessageChange?.Invoke(message);
        // 傳統舊的寫法 
        //private void NotifyMessageStateChangedOld(string message)
        //{
        //    if (OnMessageChange is null)
        //        OnMessageChange.Invoke(message); 
        //}
    }
}
