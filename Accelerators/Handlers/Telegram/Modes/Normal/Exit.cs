﻿using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.Telegram.Modes.Normal
{
    public class Exit : HandlerBase
    {

        public Exit() { }
        public Exit(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_MENU,
            VirtualKey.Q_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
            .Press(VirtualKey.VK_MENU, VirtualKey.VK_F4);

    }
}


