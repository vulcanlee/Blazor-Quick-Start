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
    }
}
