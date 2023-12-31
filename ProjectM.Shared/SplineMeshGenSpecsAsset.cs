// Decompiled with JetBrains decompiler
// Type: SplineMeshGenSpecsAsset
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
public class SplineMeshGenSpecsAsset : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_MeshMaterial;
  private static readonly IntPtr NativeFieldInfoPtr_MeshName;
  private static readonly IntPtr NativeFieldInfoPtr_UVTiling;
  private static readonly IntPtr NativeFieldInfoPtr_GeneratedMeshType;
  private static readonly IntPtr NativeFieldInfoPtr_NumSegmentsPerMeter;
  private static readonly IntPtr NativeFieldInfoPtr_NumCylinderSegments;
  private static readonly IntPtr NativeFieldInfoPtr_Width;
  private static readonly IntPtr NativeFieldInfoPtr_ShouldCastShadows;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714246, XrefRangeEnd = 714248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SplineMeshGenSpecsAsset()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplineMeshGenSpecsAsset>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SplineMeshGenSpecsAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SplineMeshGenSpecsAsset()
  {
    Il2CppClassPointerStore<SplineMeshGenSpecsAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (SplineMeshGenSpecsAsset));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplineMeshGenSpecsAsset>.NativeClassPtr);
    SplineMeshGenSpecsAsset.NativeFieldInfoPtr_MeshMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineMeshGenSpecsAsset>.NativeClassPtr, nameof (MeshMaterial));
    SplineMeshGenSpecsAsset.NativeFieldInfoPtr_MeshName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineMeshGenSpecsAsset>.NativeClassPtr, nameof (MeshName));
    SplineMeshGenSpecsAsset.NativeFieldInfoPtr_UVTiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineMeshGenSpecsAsset>.NativeClassPtr, nameof (UVTiling));
    SplineMeshGenSpecsAsset.NativeFieldInfoPtr_GeneratedMeshType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineMeshGenSpecsAsset>.NativeClassPtr, nameof (GeneratedMeshType));
    SplineMeshGenSpecsAsset.NativeFieldInfoPtr_NumSegmentsPerMeter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineMeshGenSpecsAsset>.NativeClassPtr, nameof (NumSegmentsPerMeter));
    SplineMeshGenSpecsAsset.NativeFieldInfoPtr_NumCylinderSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineMeshGenSpecsAsset>.NativeClassPtr, nameof (NumCylinderSegments));
    SplineMeshGenSpecsAsset.NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineMeshGenSpecsAsset>.NativeClassPtr, nameof (Width));
    SplineMeshGenSpecsAsset.NativeFieldInfoPtr_ShouldCastShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineMeshGenSpecsAsset>.NativeClassPtr, nameof (ShouldCastShadows));
    SplineMeshGenSpecsAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplineMeshGenSpecsAsset>.NativeClassPtr, 100663332);
  }

  public SplineMeshGenSpecsAsset(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Material MeshMaterial
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineMeshGenSpecsAsset.NativeFieldInfoPtr_MeshMaterial));
      return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplineMeshGenSpecsAsset.NativeFieldInfoPtr_MeshMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string MeshName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineMeshGenSpecsAsset.NativeFieldInfoPtr_MeshName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplineMeshGenSpecsAsset.NativeFieldInfoPtr_MeshName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Vector2 UVTiling
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineMeshGenSpecsAsset.NativeFieldInfoPtr_UVTiling));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineMeshGenSpecsAsset.NativeFieldInfoPtr_UVTiling)) = value;
    }
  }

  public unsafe SplineMeshGenSpecsAsset.MeshType GeneratedMeshType
  {
    get
    {
      return *(SplineMeshGenSpecsAsset.MeshType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineMeshGenSpecsAsset.NativeFieldInfoPtr_GeneratedMeshType));
    }
    [param: In] set
    {
      *(SplineMeshGenSpecsAsset.MeshType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineMeshGenSpecsAsset.NativeFieldInfoPtr_GeneratedMeshType)) = value;
    }
  }

  public unsafe float NumSegmentsPerMeter
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineMeshGenSpecsAsset.NativeFieldInfoPtr_NumSegmentsPerMeter));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineMeshGenSpecsAsset.NativeFieldInfoPtr_NumSegmentsPerMeter)) = value;
    }
  }

  public unsafe float NumCylinderSegments
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineMeshGenSpecsAsset.NativeFieldInfoPtr_NumCylinderSegments));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineMeshGenSpecsAsset.NativeFieldInfoPtr_NumCylinderSegments)) = value;
    }
  }

  public unsafe float Width
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineMeshGenSpecsAsset.NativeFieldInfoPtr_Width));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineMeshGenSpecsAsset.NativeFieldInfoPtr_Width)) = value;
    }
  }

  public unsafe bool ShouldCastShadows
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineMeshGenSpecsAsset.NativeFieldInfoPtr_ShouldCastShadows));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineMeshGenSpecsAsset.NativeFieldInfoPtr_ShouldCastShadows)) = value;
    }
  }

  public enum MeshType
  {
    QuadStrip,
    Cylinder,
    HalfCylinder,
  }
}
