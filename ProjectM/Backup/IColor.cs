// Decompiled with JetBrains decompiler
// Type: IColor
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
public class IColor : Il2CppObjectBase
{
  private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_Abstract_Virtual_New_get_Color_0;

  public virtual unsafe Color Color
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IColor.NativeMethodInfoPtr_get_Color_Public_Abstract_Virtual_New_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  static IColor()
  {
    Il2CppClassPointerStore<IColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (IColor));
    IColor.NativeMethodInfoPtr_get_Color_Public_Abstract_Virtual_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IColor>.NativeClassPtr, 100663375);
  }

  public IColor(IntPtr pointer)
    : base(pointer)
  {
  }
}
