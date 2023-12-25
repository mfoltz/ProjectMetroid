// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.OccluderAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM.Presentation
{
  public class OccluderAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DoubleSided;
    private static readonly IntPtr NativeFieldInfoPtr_Offset;
    private static readonly IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly IntPtr NativeFieldInfoPtr_Size;
    private static readonly IntPtr NativeFieldInfoPtr_OccluderMesh;
    private static readonly IntPtr NativeMethodInfoPtr_GetQuadTriangleVerts_Private_Il2CppStructArray_1_Triangle_Boolean_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Vector3_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetTriangles_Private_Il2CppStructArray_1_Triangle_Boolean_Mesh_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Vector3_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1112749, RefRangeEnd = 1112751, XrefRangeStart = 1112707, XrefRangeEnd = 1112749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppStructArray<Triangle> GetQuadTriangleVerts(
      bool transformOffset,
      out Il2CppStructArray<int> indices,
      out Il2CppStructArray<Vector3> vertices)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr1 = stackalloc IntPtr[3];
      numPtr1[0] = (IntPtr) &transformOffset;
      IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
      IntPtr zero1 = IntPtr.Zero;
      IntPtr* numPtr2 = &zero1;
      *(IntPtr*) num1 = (IntPtr) numPtr2;
      IntPtr num2 = (IntPtr) numPtr1 + checked (new IntPtr(2) * sizeof (IntPtr));
      IntPtr zero2 = IntPtr.Zero;
      IntPtr* numPtr3 = &zero2;
      *(IntPtr*) num2 = (IntPtr) numPtr3;
      IntPtr exc;
      IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(OccluderAuthoring.NativeMethodInfoPtr_GetQuadTriangleVerts_Private_Il2CppStructArray_1_Triangle_Boolean_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppStructArray<int> local1 = ref indices;
      IntPtr nativeObject1 = zero1;
      Il2CppStructArray<> il2CppStructArray1 = nativeObject1 == IntPtr.Zero ? (Il2CppStructArray<>) null : new Il2CppStructArray<>(nativeObject1);
      local1 = (Il2CppStructArray<int>) il2CppStructArray1;
      ref Il2CppStructArray<Vector3> local2 = ref vertices;
      IntPtr nativeObject2 = zero2;
      Il2CppStructArray<> il2CppStructArray2 = nativeObject2 == IntPtr.Zero ? (Il2CppStructArray<>) null : new Il2CppStructArray<>(nativeObject2);
      local2 = (Il2CppStructArray<Vector3>) il2CppStructArray2;
      IntPtr nativeObject3 = num3;
      return nativeObject3 == IntPtr.Zero ? (Il2CppStructArray<Triangle>) null : new Il2CppStructArray<Triangle>(nativeObject3);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1112779, RefRangeEnd = 1112781, XrefRangeStart = 1112751, XrefRangeEnd = 1112779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppStructArray<Triangle> GetTriangles(
      bool transformOffset,
      Mesh mesh,
      out Il2CppStructArray<int> indices,
      out Il2CppStructArray<Vector3> vertices)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr1 = stackalloc IntPtr[4];
      numPtr1[0] = (IntPtr) &transformOffset;
      *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mesh);
      IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(2) * sizeof (IntPtr));
      IntPtr zero1 = IntPtr.Zero;
      IntPtr* numPtr2 = &zero1;
      *(IntPtr*) num1 = (IntPtr) numPtr2;
      IntPtr num2 = (IntPtr) numPtr1 + checked (new IntPtr(3) * sizeof (IntPtr));
      IntPtr zero2 = IntPtr.Zero;
      IntPtr* numPtr3 = &zero2;
      *(IntPtr*) num2 = (IntPtr) numPtr3;
      IntPtr exc;
      IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(OccluderAuthoring.NativeMethodInfoPtr_GetTriangles_Private_Il2CppStructArray_1_Triangle_Boolean_Mesh_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppStructArray<int> local1 = ref indices;
      IntPtr nativeObject1 = zero1;
      Il2CppStructArray<> il2CppStructArray1 = nativeObject1 == IntPtr.Zero ? (Il2CppStructArray<>) null : new Il2CppStructArray<>(nativeObject1);
      local1 = (Il2CppStructArray<int>) il2CppStructArray1;
      ref Il2CppStructArray<Vector3> local2 = ref vertices;
      IntPtr nativeObject2 = zero2;
      Il2CppStructArray<> il2CppStructArray2 = nativeObject2 == IntPtr.Zero ? (Il2CppStructArray<>) null : new Il2CppStructArray<>(nativeObject2);
      local2 = (Il2CppStructArray<Vector3>) il2CppStructArray2;
      IntPtr nativeObject3 = num3;
      return nativeObject3 == IntPtr.Zero ? (Il2CppStructArray<Triangle>) null : new Il2CppStructArray<Triangle>(nativeObject3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112781, XrefRangeEnd = 1112809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OccluderAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112809, XrefRangeEnd = 1112836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmos()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OccluderAuthoring.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112836, XrefRangeEnd = 1112840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OccluderAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OccluderAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OccluderAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OccluderAuthoring()
    {
      Il2CppClassPointerStore<OccluderAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (OccluderAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OccluderAuthoring>.NativeClassPtr);
      OccluderAuthoring.NativeFieldInfoPtr_DoubleSided = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderAuthoring>.NativeClassPtr, nameof (DoubleSided));
      OccluderAuthoring.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderAuthoring>.NativeClassPtr, nameof (Offset));
      OccluderAuthoring.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderAuthoring>.NativeClassPtr, nameof (Rotation));
      OccluderAuthoring.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderAuthoring>.NativeClassPtr, nameof (Size));
      OccluderAuthoring.NativeFieldInfoPtr_OccluderMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderAuthoring>.NativeClassPtr, nameof (OccluderMesh));
      OccluderAuthoring.NativeMethodInfoPtr_GetQuadTriangleVerts_Private_Il2CppStructArray_1_Triangle_Boolean_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderAuthoring>.NativeClassPtr, 100688087);
      OccluderAuthoring.NativeMethodInfoPtr_GetTriangles_Private_Il2CppStructArray_1_Triangle_Boolean_Mesh_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderAuthoring>.NativeClassPtr, 100688088);
      OccluderAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderAuthoring>.NativeClassPtr, 100688089);
      OccluderAuthoring.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderAuthoring>.NativeClassPtr, 100688090);
      OccluderAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderAuthoring>.NativeClassPtr, 100688091);
    }

    public OccluderAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool DoubleSided
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OccluderAuthoring.NativeFieldInfoPtr_DoubleSided));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OccluderAuthoring.NativeFieldInfoPtr_DoubleSided)) = value;
      }
    }

    public unsafe float3 Offset
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OccluderAuthoring.NativeFieldInfoPtr_Offset));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OccluderAuthoring.NativeFieldInfoPtr_Offset)) = value;
      }
    }

    public unsafe float3 Rotation
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OccluderAuthoring.NativeFieldInfoPtr_Rotation));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OccluderAuthoring.NativeFieldInfoPtr_Rotation)) = value;
      }
    }

    public unsafe float3 Size
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OccluderAuthoring.NativeFieldInfoPtr_Size));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OccluderAuthoring.NativeFieldInfoPtr_Size)) = value;
      }
    }

    public unsafe Mesh OccluderMesh
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OccluderAuthoring.NativeFieldInfoPtr_OccluderMesh));
        return pointer == IntPtr.Zero ? (Mesh) null : new Mesh(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OccluderAuthoring.NativeFieldInfoPtr_OccluderMesh), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
