// Decompiled with JetBrains decompiler
// Type: ProjectM.DrawColoredGridSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class DrawColoredGridSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__Query;
    private static readonly IntPtr NativeFieldInfoPtr__Material;
    private static readonly IntPtr NativeFieldInfoPtr__Texture;
    private static readonly IntPtr NativeFieldInfoPtr__Mesh;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateIt_Private_Void_NativeArray_1_Color32_DrawGrid_0;
    private static readonly IntPtr NativeMethodInfoPtr_CreateMesh_Private_Static_Mesh_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733332, XrefRangeEnd = 733362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DrawColoredGridSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733362, XrefRangeEnd = 733384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DrawColoredGridSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 733466, RefRangeEnd = 733467, XrefRangeStart = 733384, XrefRangeEnd = 733466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateIt(NativeArray<Color32> colorBuffer, DrawGrid showgrid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &colorBuffer;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &showgrid;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DrawColoredGridSystem.NativeMethodInfoPtr_UpdateIt_Private_Void_NativeArray_1_Color32_DrawGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 733490, RefRangeEnd = 733491, XrefRangeStart = 733467, XrefRangeEnd = 733490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Mesh CreateMesh()
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawColoredGridSystem.NativeMethodInfoPtr_CreateMesh_Private_Static_Mesh_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Mesh) null : new Mesh(pointer);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DrawColoredGridSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawColoredGridSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DrawColoredGridSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DrawColoredGridSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DrawColoredGridSystem()
    {
      Il2CppClassPointerStore<DrawColoredGridSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DrawColoredGridSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawColoredGridSystem>.NativeClassPtr);
      DrawColoredGridSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawColoredGridSystem>.NativeClassPtr, nameof (_Query));
      DrawColoredGridSystem.NativeFieldInfoPtr__Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawColoredGridSystem>.NativeClassPtr, nameof (_Material));
      DrawColoredGridSystem.NativeFieldInfoPtr__Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawColoredGridSystem>.NativeClassPtr, nameof (_Texture));
      DrawColoredGridSystem.NativeFieldInfoPtr__Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawColoredGridSystem>.NativeClassPtr, nameof (_Mesh));
      DrawColoredGridSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawColoredGridSystem>.NativeClassPtr, 100664815);
      DrawColoredGridSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawColoredGridSystem>.NativeClassPtr, 100664816);
      DrawColoredGridSystem.NativeMethodInfoPtr_UpdateIt_Private_Void_NativeArray_1_Color32_DrawGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawColoredGridSystem>.NativeClassPtr, 100664817);
      DrawColoredGridSystem.NativeMethodInfoPtr_CreateMesh_Private_Static_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawColoredGridSystem>.NativeClassPtr, 100664818);
      DrawColoredGridSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawColoredGridSystem>.NativeClassPtr, 100664819);
      DrawColoredGridSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawColoredGridSystem>.NativeClassPtr, 100664820);
    }

    public DrawColoredGridSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawColoredGridSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawColoredGridSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe Material _Material
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawColoredGridSystem.NativeFieldInfoPtr__Material));
        return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DrawColoredGridSystem.NativeFieldInfoPtr__Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Texture2D _Texture
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawColoredGridSystem.NativeFieldInfoPtr__Texture));
        return pointer == IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DrawColoredGridSystem.NativeFieldInfoPtr__Texture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Mesh _Mesh
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawColoredGridSystem.NativeFieldInfoPtr__Mesh));
        return pointer == IntPtr.Zero ? (Mesh) null : new Mesh(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DrawColoredGridSystem.NativeFieldInfoPtr__Mesh), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
