// Decompiled with JetBrains decompiler
// Type: ProjectM.PathGroupAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class PathGroupAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_IsVisible;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 631690, RefRangeEnd = 631694, XrefRangeStart = 631690, XrefRangeEnd = 631694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PathGroupAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathGroupAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PathGroupAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PathGroupAuthoring()
    {
      Il2CppClassPointerStore<PathGroupAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PathGroupAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathGroupAuthoring>.NativeClassPtr);
      PathGroupAuthoring.NativeFieldInfoPtr_IsVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathGroupAuthoring>.NativeClassPtr, nameof (IsVisible));
      PathGroupAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathGroupAuthoring>.NativeClassPtr, 100665809);
    }

    public PathGroupAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool IsVisible
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PathGroupAuthoring.NativeFieldInfoPtr_IsVisible));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PathGroupAuthoring.NativeFieldInfoPtr_IsVisible)) = value;
      }
    }
  }
}
