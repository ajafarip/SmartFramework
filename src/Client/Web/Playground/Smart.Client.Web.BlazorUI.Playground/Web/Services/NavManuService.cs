﻿using System;

namespace Smart.Client.Web.BlazorUI.Playground.Web.Services
{
    public class NavManuService
    {
        public event Action OnToggleMenu;

        public void ToggleMenu()
        {
            OnToggleMenu.Invoke();
        }
    }
}
