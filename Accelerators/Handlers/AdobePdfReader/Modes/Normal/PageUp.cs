﻿using Utils.Window;
using Utils.WinApi;

namespace Accelerators.Handlers.AdobePdfReader.Modes.Normal
{
    public class PageUp : HandlerBase
    {

        public PageUp() { }
        public PageUp(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.U_key
        };


        protected override void SendKeys(WindowGeometry window) => Actions
           .Wait(100)
           .Press(VirtualKey.VK_PRIOR);

    }
}
