﻿using PKISharp.WACS.Plugins.Interfaces;
using PKISharp.WACS.Services.Serialization;
using System;

namespace PKISharp.WACS.Plugins.Base.Factories
{
    public abstract class PluginOptionsFactory<TPlugin, TOptions> :
        IPluginOptionsFactory
        where TOptions : PluginOptions, new()
    {
        private readonly string _name;
        private readonly string _description;

        public PluginOptionsFactory()
        {
            var protoType = new TOptions();
            _name = protoType.Name;
            _description = protoType.Description;
            if (protoType.Instance.FullName != typeof(TPlugin).FullName)
            {
                throw new Exception();
            }
        }

        public virtual int Order => 0;
        string IPluginOptionsFactory.Name => _name;
        string IPluginOptionsFactory.Description => _description;
        bool IPluginOptionsFactory.Match(string name) => string.Equals(name, _name, StringComparison.CurrentCultureIgnoreCase);
        Type IPluginOptionsFactory.OptionsType => typeof(TOptions);
        Type IPluginOptionsFactory.InstanceType => typeof(TPlugin);
        public virtual bool Disabled { get; protected set; } = false;
    }
}
