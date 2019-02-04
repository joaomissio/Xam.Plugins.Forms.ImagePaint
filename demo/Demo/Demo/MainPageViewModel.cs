using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Demo
{
    public class MainPageViewModel
    {
        public Command ImgCommand { get; set; }

        public MainPageViewModel()
        {
            ImgCommand = new Command(ExecuteImgCommand);
        }

        private void ExecuteImgCommand(object obj)
        {
            
        }
    }
}
