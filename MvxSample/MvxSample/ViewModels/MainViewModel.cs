using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace MvxSample.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public void ShowChat()
        {
            ShowViewModel<ChatViewModel>();
        }

        public void ShowFriends()
        {
            ShowViewModel<FriendsViewModel>();
        }

        public void ShowExtras()
        {
            ShowViewModel<ExtrasViewModel>();
        }


        public void ShowMy()
        {
            ShowViewModel<MyViewModel>();
        }
    }
}
