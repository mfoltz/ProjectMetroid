﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.INetworkEventWithTarget
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace ProjectM.Network
{
  public class INetworkEventWithTarget : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_Abstract_Virtual_New_get_NetworkId_0;

    public virtual unsafe NetworkId Target
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), INetworkEventWithTarget.NativeMethodInfoPtr_get_Target_Public_Abstract_Virtual_New_get_NetworkId_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NetworkId*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static INetworkEventWithTarget()
    {
      Il2CppClassPointerStore<INetworkEventWithTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (INetworkEventWithTarget));
      INetworkEventWithTarget.NativeMethodInfoPtr_get_Target_Public_Abstract_Virtual_New_get_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INetworkEventWithTarget>.NativeClassPtr, 100690761);
    }

    public INetworkEventWithTarget(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
