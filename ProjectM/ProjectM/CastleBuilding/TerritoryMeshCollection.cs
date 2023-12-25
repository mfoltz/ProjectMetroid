// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.TerritoryMeshCollection
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class TerritoryMeshCollection : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_BorderCursorFadeRadius;
    private static readonly IntPtr NativeFieldInfoPtr_SideMaterial;
    private static readonly IntPtr NativeFieldInfoPtr_Sides_1;
    private static readonly IntPtr NativeFieldInfoPtr_Sides_2_Corner;
    private static readonly IntPtr NativeFieldInfoPtr_Sides_2_Opposite;
    private static readonly IntPtr NativeFieldInfoPtr_Sides_3;
    private static readonly IntPtr NativeFieldInfoPtr_Sides_4;
    private static readonly IntPtr NativeMethodInfoPtr_GetMeshFromBorders_Public_Boolean_Int32_byref_Mesh_byref_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1129027, RefRangeEnd = 1129028, XrefRangeStart = 1129006, XrefRangeEnd = 1129027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetMeshFromBorders(int cornerSetup, out Mesh mesh, out int rotation)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr1 = stackalloc IntPtr[3];
      numPtr1[0] = (IntPtr) &cornerSetup;
      IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
      IntPtr zero = IntPtr.Zero;
      IntPtr* numPtr2 = &zero;
      *(IntPtr*) num1 = (IntPtr) numPtr2;
      *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref rotation;
      IntPtr exc;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TerritoryMeshCollection.NativeMethodInfoPtr_GetMeshFromBorders_Public_Boolean_Int32_byref_Mesh_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Mesh local = ref mesh;
      IntPtr pointer = zero;
      Mesh mesh1 = pointer == IntPtr.Zero ? (Mesh) null : new Mesh(pointer);
      local = mesh1;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129028, XrefRangeEnd = 1129029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TerritoryMeshCollection()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerritoryMeshCollection>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerritoryMeshCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TerritoryMeshCollection()
    {
      Il2CppClassPointerStore<TerritoryMeshCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (TerritoryMeshCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerritoryMeshCollection>.NativeClassPtr);
      TerritoryMeshCollection.NativeFieldInfoPtr_BorderCursorFadeRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMeshCollection>.NativeClassPtr, nameof (BorderCursorFadeRadius));
      TerritoryMeshCollection.NativeFieldInfoPtr_SideMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMeshCollection>.NativeClassPtr, nameof (SideMaterial));
      TerritoryMeshCollection.NativeFieldInfoPtr_Sides_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMeshCollection>.NativeClassPtr, nameof (Sides_1));
      TerritoryMeshCollection.NativeFieldInfoPtr_Sides_2_Corner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMeshCollection>.NativeClassPtr, nameof (Sides_2_Corner));
      TerritoryMeshCollection.NativeFieldInfoPtr_Sides_2_Opposite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMeshCollection>.NativeClassPtr, nameof (Sides_2_Opposite));
      TerritoryMeshCollection.NativeFieldInfoPtr_Sides_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMeshCollection>.NativeClassPtr, nameof (Sides_3));
      TerritoryMeshCollection.NativeFieldInfoPtr_Sides_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryMeshCollection>.NativeClassPtr, nameof (Sides_4));
      TerritoryMeshCollection.NativeMethodInfoPtr_GetMeshFromBorders_Public_Boolean_Int32_byref_Mesh_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritoryMeshCollection>.NativeClassPtr, 100689720);
      TerritoryMeshCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritoryMeshCollection>.NativeClassPtr, 100689721);
    }

    public TerritoryMeshCollection(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float BorderCursorFadeRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMeshCollection.NativeFieldInfoPtr_BorderCursorFadeRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMeshCollection.NativeFieldInfoPtr_BorderCursorFadeRadius)) = value;
      }
    }

    public unsafe Material SideMaterial
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMeshCollection.NativeFieldInfoPtr_SideMaterial));
        return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMeshCollection.NativeFieldInfoPtr_SideMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Mesh Sides_1
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMeshCollection.NativeFieldInfoPtr_Sides_1));
        return pointer == IntPtr.Zero ? (Mesh) null : new Mesh(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMeshCollection.NativeFieldInfoPtr_Sides_1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Mesh Sides_2_Corner
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMeshCollection.NativeFieldInfoPtr_Sides_2_Corner));
        return pointer == IntPtr.Zero ? (Mesh) null : new Mesh(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMeshCollection.NativeFieldInfoPtr_Sides_2_Corner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Mesh Sides_2_Opposite
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMeshCollection.NativeFieldInfoPtr_Sides_2_Opposite));
        return pointer == IntPtr.Zero ? (Mesh) null : new Mesh(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMeshCollection.NativeFieldInfoPtr_Sides_2_Opposite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Mesh Sides_3
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMeshCollection.NativeFieldInfoPtr_Sides_3));
        return pointer == IntPtr.Zero ? (Mesh) null : new Mesh(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMeshCollection.NativeFieldInfoPtr_Sides_3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Mesh Sides_4
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMeshCollection.NativeFieldInfoPtr_Sides_4));
        return pointer == IntPtr.Zero ? (Mesh) null : new Mesh(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TerritoryMeshCollection.NativeFieldInfoPtr_Sides_4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
