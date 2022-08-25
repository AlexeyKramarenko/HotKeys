﻿using Accelerators.Handlers;
using SMMTool.Utils.WindowsApi;
using static SMMTool.Utils.WindowsApi.WinApi;

namespace Accelerators.FileExplorer.Modes.Insert
{
    public class Return : HandlerBase
    {

        public Return() { }
        public Return(IHandler next) : base(next) { }


        protected override VirtualKey[] AcceleratorKeys => new[]
        {
            VirtualKey.VK_RETURN
        };


        protected override void SendKeys(IntPtr hwnd, WinApiWrapper winApi) => winApi
            .SendKey(VirtualKey.VK_RETURN);
    }
}

