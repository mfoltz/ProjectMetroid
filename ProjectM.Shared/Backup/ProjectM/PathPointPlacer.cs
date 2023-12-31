// Decompiled with JetBrains decompiler
// Type: ProjectM.PathPointPlacer
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
  public class PathPointPlacer : PathNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_PathColor;
    private static readonly IntPtr NativeFieldInfoPtr_EnableGizmoDrawer;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PathPointPlacer()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathPointPlacer>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PathPointPlacer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PathPointPlacer()
    {
      Il2CppClassPointerStore<PathPointPlacer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PathPointPlacer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathPointPlacer>.NativeClassPtr);
      PathPointPlacer.NativeFieldInfoPtr_PathColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPointPlacer>.NativeClassPtr, nameof (PathColor));
      PathPointPlacer.NativeFieldInfoPtr_EnableGizmoDrawer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPointPlacer>.NativeClassPtr, nameof (EnableGizmoDrawer));
      PathPointPlacer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPointPlacer>.NativeClassPtr, 100665811);
    }

    public PathPointPlacer(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Color PathColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PathPointPlacer.NativeFieldInfoPtr_PathColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PathPointPlacer.NativeFieldInfoPtr_PathColor)) = value;
      }
    }

    public unsafe bool EnableGizmoDrawer
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PathPointPlacer.NativeFieldInfoPtr_EnableGizmoDrawer));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PathPointPlacer.NativeFieldInfoPtr_EnableGizmoDrawer)) = value;
      }
    }
  }
}
