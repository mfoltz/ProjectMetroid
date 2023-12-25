// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MapZoneAreaMarker
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class MapZoneAreaMarker : UIEntry
  {
    private static readonly IntPtr NativeFieldInfoPtr_CanvasMesh;
    private static readonly IntPtr NativeFieldInfoPtr_CanvasMeshRect;
    private static readonly IntPtr NativeFieldInfoPtr__Mesh;
    private static readonly IntPtr NativeFieldInfoPtr__NormalColor;
    private static readonly IntPtr NativeFieldInfoPtr__HoverColor;
    private static readonly IntPtr NativeFieldInfoPtr__Vertices;
    private static readonly IntPtr NativeFieldInfoPtr__Uvs;
    private static readonly IntPtr NativeFieldInfoPtr__Indices;
    private static readonly IntPtr NativeFieldInfoPtr__Hover;
    private static readonly IntPtr NativeFieldInfoPtr__PrevHover;
    private static readonly IntPtr NativeFieldInfoPtr__Time;
    private static readonly IntPtr NativeFieldInfoPtr__PrevFrame;
    private static readonly IntPtr NativeFieldInfoPtr__MeshIndex;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Boolean_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Int32_Int32_Color_float3_byref_Vector3_byref_Vector2_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetDataNew_Public_Void_Color_Mesh_Int32_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsInAnyTriangle_Private_Boolean_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Int32_Vector2_0;
    private static readonly IntPtr NativeMethodInfoPtr_BoundsFromCorners_Private_Bounds_Il2CppStructArray_1_Vector3_0;
    private static readonly IntPtr NativeMethodInfoPtr_Triangulate_Private_Void_byref_Il2CppStructArray_1_Vector3_0;
    private static readonly IntPtr NativeMethodInfoPtr_Area_Private_Single_byref_Il2CppStructArray_1_Vector3_0;
    private static readonly IntPtr NativeMethodInfoPtr_Snip_Private_Boolean_byref_Il2CppStructArray_1_Vector3_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_InsideTriangle_Private_Boolean_Vector2_Vector2_Vector2_Vector2_0;
    private static readonly IntPtr NativeMethodInfoPtr_InsideTriangle2_Public_Boolean_Vector2_Vector2_Vector2_Vector2_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271298, XrefRangeEnd = 1271301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneAreaMarker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271301, XrefRangeEnd = 1271368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SetData(
      Il2CppStructArray<Vector3> vertices,
      Il2CppStructArray<int> indices,
      int frameIndex,
      Color baseColor,
      float3 mouseWorldPosition,
      out Vector3 centerPoint,
      out Vector2 sizeDelta)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[7];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vertices);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) indices);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &frameIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &baseColor;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &mouseWorldPosition;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) ref centerPoint;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) ref sizeDelta;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneAreaMarker.NativeMethodInfoPtr_SetData_Public_Boolean_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Int32_Int32_Color_float3_byref_Vector3_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271368, XrefRangeEnd = 1271370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetDataNew(Color baseColor, Mesh mesh, int meshIndex, bool hover)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &baseColor;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mesh);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &meshIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &hover;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneAreaMarker.NativeMethodInfoPtr_SetDataNew_Public_Void_Color_Mesh_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1271371, RefRangeEnd = 1271372, XrefRangeStart = 1271370, XrefRangeEnd = 1271371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsInAnyTriangle(
      Il2CppStructArray<Vector3> vertices,
      Il2CppStructArray<int> indices,
      Vector2 position)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vertices);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) indices);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &position;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneAreaMarker.NativeMethodInfoPtr_IsInAnyTriangle_Private_Boolean_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271372, XrefRangeEnd = 1271373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Bounds BoundsFromCorners(Il2CppStructArray<Vector3> corners)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) corners);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneAreaMarker.NativeMethodInfoPtr_BoundsFromCorners_Private_Bounds_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Bounds*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271373, XrefRangeEnd = 1271403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Triangulate(ref Il2CppStructArray<Vector3> m_points)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) m_points);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneAreaMarker.NativeMethodInfoPtr_Triangulate_Private_Void_byref_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe float Area(ref Il2CppStructArray<Vector3> m_points)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) m_points);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneAreaMarker.NativeMethodInfoPtr_Area_Private_Single_byref_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1271407, RefRangeEnd = 1271408, XrefRangeStart = 1271403, XrefRangeEnd = 1271407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Snip(
      ref Il2CppStructArray<Vector3> m_points,
      int u,
      int v,
      int w,
      int n,
      Il2CppStructArray<int> V)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[6];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) m_points);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &u;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &v;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &w;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &n;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) V);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneAreaMarker.NativeMethodInfoPtr_Snip_Private_Boolean_byref_Il2CppStructArray_1_Vector3_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1271409, RefRangeEnd = 1271410, XrefRangeStart = 1271408, XrefRangeEnd = 1271409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool InsideTriangle(Vector2 A, Vector2 B, Vector2 C, Vector2 P)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &A;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &B;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &C;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &P;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneAreaMarker.NativeMethodInfoPtr_InsideTriangle_Private_Boolean_Vector2_Vector2_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271410, XrefRangeEnd = 1271411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool InsideTriangle2(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &p0;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &p1;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &p2;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &p;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneAreaMarker.NativeMethodInfoPtr_InsideTriangle2_Public_Boolean_Vector2_Vector2_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271411, XrefRangeEnd = 1271412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapZoneAreaMarker()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneAreaMarker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MapZoneAreaMarker()
    {
      Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MapZoneAreaMarker));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr);
      MapZoneAreaMarker.NativeFieldInfoPtr_CanvasMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, nameof (CanvasMesh));
      MapZoneAreaMarker.NativeFieldInfoPtr_CanvasMeshRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, nameof (CanvasMeshRect));
      MapZoneAreaMarker.NativeFieldInfoPtr__Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, nameof (_Mesh));
      MapZoneAreaMarker.NativeFieldInfoPtr__NormalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, nameof (_NormalColor));
      MapZoneAreaMarker.NativeFieldInfoPtr__HoverColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, nameof (_HoverColor));
      MapZoneAreaMarker.NativeFieldInfoPtr__Vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, nameof (_Vertices));
      MapZoneAreaMarker.NativeFieldInfoPtr__Uvs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, nameof (_Uvs));
      MapZoneAreaMarker.NativeFieldInfoPtr__Indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, nameof (_Indices));
      MapZoneAreaMarker.NativeFieldInfoPtr__Hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, nameof (_Hover));
      MapZoneAreaMarker.NativeFieldInfoPtr__PrevHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, nameof (_PrevHover));
      MapZoneAreaMarker.NativeFieldInfoPtr__Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, nameof (_Time));
      MapZoneAreaMarker.NativeFieldInfoPtr__PrevFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, nameof (_PrevFrame));
      MapZoneAreaMarker.NativeFieldInfoPtr__MeshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, nameof (_MeshIndex));
      MapZoneAreaMarker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, 100668024);
      MapZoneAreaMarker.NativeMethodInfoPtr_SetData_Public_Boolean_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Int32_Int32_Color_float3_byref_Vector3_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, 100668025);
      MapZoneAreaMarker.NativeMethodInfoPtr_SetDataNew_Public_Void_Color_Mesh_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, 100668026);
      MapZoneAreaMarker.NativeMethodInfoPtr_IsInAnyTriangle_Private_Boolean_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, 100668027);
      MapZoneAreaMarker.NativeMethodInfoPtr_BoundsFromCorners_Private_Bounds_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, 100668028);
      MapZoneAreaMarker.NativeMethodInfoPtr_Triangulate_Private_Void_byref_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, 100668029);
      MapZoneAreaMarker.NativeMethodInfoPtr_Area_Private_Single_byref_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, 100668030);
      MapZoneAreaMarker.NativeMethodInfoPtr_Snip_Private_Boolean_byref_Il2CppStructArray_1_Vector3_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, 100668031);
      MapZoneAreaMarker.NativeMethodInfoPtr_InsideTriangle_Private_Boolean_Vector2_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, 100668032);
      MapZoneAreaMarker.NativeMethodInfoPtr_InsideTriangle2_Public_Boolean_Vector2_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, 100668033);
      MapZoneAreaMarker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneAreaMarker>.NativeClassPtr, 100668034);
    }

    public MapZoneAreaMarker(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CanvasMesh CanvasMesh
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneAreaMarker.NativeFieldInfoPtr_CanvasMesh));
        return pointer == IntPtr.Zero ? (CanvasMesh) null : new CanvasMesh(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapZoneAreaMarker.NativeFieldInfoPtr_CanvasMesh), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform CanvasMeshRect
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneAreaMarker.NativeFieldInfoPtr_CanvasMeshRect));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapZoneAreaMarker.NativeFieldInfoPtr_CanvasMeshRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Mesh _Mesh
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneAreaMarker.NativeFieldInfoPtr__Mesh));
        return pointer == IntPtr.Zero ? (Mesh) null : new Mesh(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapZoneAreaMarker.NativeFieldInfoPtr__Mesh), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color _NormalColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneAreaMarker.NativeFieldInfoPtr__NormalColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneAreaMarker.NativeFieldInfoPtr__NormalColor)) = value;
      }
    }

    public unsafe Color _HoverColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneAreaMarker.NativeFieldInfoPtr__HoverColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneAreaMarker.NativeFieldInfoPtr__HoverColor)) = value;
      }
    }

    public static unsafe List<Vector3> _Vertices
    {
      get
      {
        IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(MapZoneAreaMarker.NativeFieldInfoPtr__Vertices, (void*) &num);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<Vector3>) null : new List<Vector3>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MapZoneAreaMarker.NativeFieldInfoPtr__Vertices, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe List<Vector2> _Uvs
    {
      get
      {
        IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(MapZoneAreaMarker.NativeFieldInfoPtr__Uvs, (void*) &num);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<Vector2>) null : new List<Vector2>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MapZoneAreaMarker.NativeFieldInfoPtr__Uvs, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe List<int> _Indices
    {
      get
      {
        IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(MapZoneAreaMarker.NativeFieldInfoPtr__Indices, (void*) &num);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MapZoneAreaMarker.NativeFieldInfoPtr__Indices, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _Hover
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneAreaMarker.NativeFieldInfoPtr__Hover));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneAreaMarker.NativeFieldInfoPtr__Hover)) = value;
      }
    }

    public unsafe bool _PrevHover
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneAreaMarker.NativeFieldInfoPtr__PrevHover));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneAreaMarker.NativeFieldInfoPtr__PrevHover)) = value;
      }
    }

    public unsafe float _Time
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneAreaMarker.NativeFieldInfoPtr__Time));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneAreaMarker.NativeFieldInfoPtr__Time)) = value;
      }
    }

    public unsafe int _PrevFrame
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneAreaMarker.NativeFieldInfoPtr__PrevFrame));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneAreaMarker.NativeFieldInfoPtr__PrevFrame)) = value;
      }
    }

    public unsafe int _MeshIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneAreaMarker.NativeFieldInfoPtr__MeshIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneAreaMarker.NativeFieldInfoPtr__MeshIndex)) = value;
      }
    }
  }
}
