﻿using Autofac;
using ES.Kubernetes.Reflector.Core.Health;

namespace ES.Kubernetes.Reflector.Secrets
{
    public class SecretsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SecretMirror>().AsImplementedInterfaces().AsSelf().SingleInstance();
            builder.RegisterType<FortiMirror>().AsImplementedInterfaces().AsSelf().SingleInstance();
            builder.RegisterType<UbiquitiMirror>().AsImplementedInterfaces().AsSelf().SingleInstance();
            builder.AddHealthCheck<SecretMirror>();
            builder.AddHealthCheck<FortiMirror>();
            builder.AddHealthCheck<UbiquitiMirror>();
        }
    }
}