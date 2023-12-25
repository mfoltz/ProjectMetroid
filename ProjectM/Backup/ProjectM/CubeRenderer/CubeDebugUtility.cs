// Decompiled with JetBrains decompiler
// Type: ProjectM.CubeRenderer.CubeDebugUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.CubeRenderer
{
  public static class CubeDebugUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__GizmosCubeMesh;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GizmosCubeMesh_Public_Static_get_Mesh_0;

    public static unsafe Mesh GizmosCubeMesh
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 1124200, RefRangeEnd = 1124202, XrefRangeStart = 1124150, XrefRangeEnd = 1124200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CubeDebugUtility.NativeMethodInfoPtr_get_GizmosCubeMesh_Public_Static_get_Mesh_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Mesh) null : new Mesh(pointer);
      }
    }

    static CubeDebugUtility()
    {
      Il2CppClassPointerStore<CubeDebugUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CubeRenderer", nameof (CubeDebugUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CubeDebugUtility>.NativeClassPtr);
      CubeDebugUtility.NativeFieldInfoPtr__GizmosCubeMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubeDebugUtility>.NativeClassPtr, nameof (_GizmosCubeMesh));
      CubeDebugUtility.NativeMethodInfoPtr_get_GizmosCubeMesh_Public_Static_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubeDebugUtility>.NativeClassPtr, 100689198);
    }

    public CubeDebugUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Mesh _GizmosCubeMesh
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CubeDebugUtility.NativeFieldInfoPtr__GizmosCubeMesh, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Mesh) null : new Mesh(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CubeDebugUtility.NativeFieldInfoPtr__GizmosCubeMesh, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
