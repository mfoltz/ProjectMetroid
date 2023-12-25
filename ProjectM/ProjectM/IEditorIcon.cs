// Decompiled with JetBrains decompiler
// Type: ProjectM.IEditorIcon
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class IEditorIcon : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_GetIcon_Public_Abstract_Virtual_New_Texture_0;

    [CallerCount(0)]
    public virtual unsafe Texture GetIcon()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IEditorIcon.NativeMethodInfoPtr_GetIcon_Public_Abstract_Virtual_New_Texture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Texture) null : new Texture(pointer);
    }

    static IEditorIcon()
    {
      Il2CppClassPointerStore<IEditorIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (IEditorIcon));
      IEditorIcon.NativeMethodInfoPtr_GetIcon_Public_Abstract_Virtual_New_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEditorIcon>.NativeClassPtr, 100681917);
    }

    public IEditorIcon(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
