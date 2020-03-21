using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinitionExtraction
{
    static internal class CurrentSession
    {
        public static EventHandler<EventArgs> OnUserChanged;
        delegate void UserChanged();
        private static User currentUser;

        internal static User CurrentUser 
        {
            get { return currentUser; }
            set 
            { 
                currentUser = value;
                EventHandler<EventArgs> userChangedEvent = OnUserChanged;
                if (userChangedEvent != null)
                    userChangedEvent.Invoke(CurrentUser, new EventArgs());
            } 
        }

        

    }
}
