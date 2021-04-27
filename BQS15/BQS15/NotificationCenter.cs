using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BQS15
{
    public class NotificationCenter
    {
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
