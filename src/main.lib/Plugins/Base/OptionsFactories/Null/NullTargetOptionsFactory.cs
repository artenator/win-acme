﻿using PKISharp.WACS.Plugins.Base.Options;
using PKISharp.WACS.Plugins.Interfaces;
using PKISharp.WACS.Services;
using System;
using System.Threading.Tasks;

namespace PKISharp.WACS.Plugins.Base.Factories.Null
{
    /// <summary>
    /// Null implementation
    /// </summary>
    internal class NullTargetFactory : ITargetPluginOptionsFactory, INull
    {
        Type IPluginOptionsFactory.InstanceType => typeof(object);
        Type IPluginOptionsFactory.OptionsType => typeof(object);
        bool ITargetPluginOptionsFactory.Hidden => true;
        bool IPluginOptionsFactory.Disabled => true;
        bool IPluginOptionsFactory.Match(string name) => false;
        Task<TargetPluginOptions> ITargetPluginOptionsFactory.Aquire(IInputService inputService, RunLevel runLevel) => null;
        Task<TargetPluginOptions> ITargetPluginOptionsFactory.Default() => null;
        string IPluginOptionsFactory.Name => "None";
        string IPluginOptionsFactory.Description => null;
        int IPluginOptionsFactory.Order => int.MaxValue;
    }
}
