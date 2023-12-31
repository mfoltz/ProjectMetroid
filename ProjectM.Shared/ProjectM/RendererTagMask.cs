// Decompiled with JetBrains decompiler
// Type: ProjectM.RendererTagMask
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class RendererTagMask : ScriptableObject
  {
    private static readonly IntPtr NativeMethodInfoPtr_GetMask_Public_Abstract_Virtual_New_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    [CallerCount(0)]
    public virtual unsafe int GetMask()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RendererTagMask.NativeMethodInfoPtr_GetMask_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RendererTagMask()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererTagMask>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RendererTagMask.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RendererTagMask()
    {
      Il2CppClassPointerStore<RendererTagMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RendererTagMask));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererTagMask>.NativeClassPtr);
      RendererTagMask.NativeMethodInfoPtr_GetMask_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererTagMask>.NativeClassPtr, 100665977);
      RendererTagMask.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererTagMask>.NativeClassPtr, 100665978);
    }

    public RendererTagMask(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
