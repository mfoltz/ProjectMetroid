// Decompiled with JetBrains decompiler
// Type: ProjectM.MeshGizmo
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class MeshGizmo : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MeshGizmosToDraw;
    private static readonly IntPtr NativeFieldInfoPtr_ColorOfGizmos;
    private static readonly IntPtr NativeFieldInfoPtr_GizmoScaleMod;
    private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049524, XrefRangeEnd = 1049553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmos()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MeshGizmo.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049553, XrefRangeEnd = 1049554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MeshGizmo()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MeshGizmo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MeshGizmo()
    {
      Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (MeshGizmo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr);
      MeshGizmo.NativeFieldInfoPtr_MeshGizmosToDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, nameof (MeshGizmosToDraw));
      MeshGizmo.NativeFieldInfoPtr_ColorOfGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, nameof (ColorOfGizmos));
      MeshGizmo.NativeFieldInfoPtr_GizmoScaleMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, nameof (GizmoScaleMod));
      MeshGizmo.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, 100682354);
      MeshGizmo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGizmo>.NativeClassPtr, 100682355);
    }

    public MeshGizmo(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<Mesh> MeshGizmosToDraw
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshGizmo.NativeFieldInfoPtr_MeshGizmosToDraw));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Mesh>) null : new Il2CppReferenceArray<Mesh>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshGizmo.NativeFieldInfoPtr_MeshGizmosToDraw), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color ColorOfGizmos
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshGizmo.NativeFieldInfoPtr_ColorOfGizmos));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshGizmo.NativeFieldInfoPtr_ColorOfGizmos)) = value;
      }
    }

    public unsafe Vector3 GizmoScaleMod
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshGizmo.NativeFieldInfoPtr_GizmoScaleMod));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshGizmo.NativeFieldInfoPtr_GizmoScaleMod)) = value;
      }
    }
  }
}
