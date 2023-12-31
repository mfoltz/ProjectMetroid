// Decompiled with JetBrains decompiler
// Type: ProjectM.SplinePointPlacer
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
  public class SplinePointPlacer : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_PreviousNodePos;
    private static readonly IntPtr NativeFieldInfoPtr_SplineColor;
    private static readonly IntPtr NativeFieldInfoPtr_EnableGizmoDrawer;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750347, XrefRangeEnd = 750349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SplinePointPlacer()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplinePointPlacer>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SplinePointPlacer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SplinePointPlacer()
    {
      Il2CppClassPointerStore<SplinePointPlacer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SplinePointPlacer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplinePointPlacer>.NativeClassPtr);
      SplinePointPlacer.NativeFieldInfoPtr_PreviousNodePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplinePointPlacer>.NativeClassPtr, nameof (PreviousNodePos));
      SplinePointPlacer.NativeFieldInfoPtr_SplineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplinePointPlacer>.NativeClassPtr, nameof (SplineColor));
      SplinePointPlacer.NativeFieldInfoPtr_EnableGizmoDrawer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplinePointPlacer>.NativeClassPtr, nameof (EnableGizmoDrawer));
      SplinePointPlacer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplinePointPlacer>.NativeClassPtr, 100666052);
    }

    public SplinePointPlacer(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Vector3 PreviousNodePos
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplinePointPlacer.NativeFieldInfoPtr_PreviousNodePos));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplinePointPlacer.NativeFieldInfoPtr_PreviousNodePos)) = value;
      }
    }

    public unsafe Color SplineColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplinePointPlacer.NativeFieldInfoPtr_SplineColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplinePointPlacer.NativeFieldInfoPtr_SplineColor)) = value;
      }
    }

    public unsafe bool EnableGizmoDrawer
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplinePointPlacer.NativeFieldInfoPtr_EnableGizmoDrawer));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplinePointPlacer.NativeFieldInfoPtr_EnableGizmoDrawer)) = value;
      }
    }
  }
}
