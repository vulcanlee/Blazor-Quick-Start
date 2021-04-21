using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BQS12
{
    public class AppState
    {
        public Action OnChange;
        public Action<string> OnMessageChange;

        public void UpdateAllView()
        {
            NotifyStateChanged();
        }

        public void RefreshMessageAllView(string message)
        {
            NotifyMessageStateChanged(message);
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
        private void NotifyMessageStateChanged(string message) => OnMessageChange?.Invoke(message);
    }
}
