// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.MaterialChangeSystem_Dots
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM.Sequencer
{
  public class MaterialChangeSystem_Dots : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__EntityMaterialChanges;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastFrameChanges;
    private static readonly System.IntPtr NativeFieldInfoPtr__Entity_OriginalMaterials;
    private static readonly System.IntPtr NativeFieldInfoPtr__CopiedMaterials;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaterialPool;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddMaterialChange_Public_Void_Entity_Material_Int32_Int32_Single_Boolean_Boolean_ShadowCastingMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RestoreMaterials_Private_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102229, XrefRangeEnd = 1102260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialChangeSystem_Dots.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102260, XrefRangeEnd = 1102289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialChangeSystem_Dots.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1102306, RefRangeEnd = 1102307, XrefRangeStart = 1102289, XrefRangeEnd = 1102306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddMaterialChange(
      Entity entity,
      Material material,
      int rendererMask,
      int importance,
      float startTime,
      bool copyNormalMap,
      bool copyBaseMap,
      ShadowCastingMode shadowCastingMode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rendererMask;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &importance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &startTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &copyNormalMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &copyBaseMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &shadowCastingMode;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialChangeSystem_Dots.NativeMethodInfoPtr_AddMaterialChange_Public_Void_Entity_Material_Int32_Int32_Single_Boolean_Boolean_ShadowCastingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102307, XrefRangeEnd = 1102418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialChangeSystem_Dots.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1102458, RefRangeEnd = 1102460, XrefRangeStart = 1102418, XrefRangeEnd = 1102458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RestoreMaterials(Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialChangeSystem_Dots.NativeMethodInfoPtr_RestoreMaterials_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MaterialChangeSystem_Dots()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialChangeSystem_Dots>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialChangeSystem_Dots.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialChangeSystem_Dots.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MaterialChangeSystem_Dots()
    {
      Il2CppClassPointerStore<MaterialChangeSystem_Dots>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (MaterialChangeSystem_Dots));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialChangeSystem_Dots>.NativeClassPtr);
      MaterialChangeSystem_Dots.NativeFieldInfoPtr__EntityMaterialChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Dots>.NativeClassPtr, nameof (_EntityMaterialChanges));
      MaterialChangeSystem_Dots.NativeFieldInfoPtr__LastFrameChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Dots>.NativeClassPtr, nameof (_LastFrameChanges));
      MaterialChangeSystem_Dots.NativeFieldInfoPtr__Entity_OriginalMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Dots>.NativeClassPtr, nameof (_Entity_OriginalMaterials));
      MaterialChangeSystem_Dots.NativeFieldInfoPtr__CopiedMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Dots>.NativeClassPtr, nameof (_CopiedMaterials));
      MaterialChangeSystem_Dots.NativeFieldInfoPtr__MaterialPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Dots>.NativeClassPtr, nameof (_MaterialPool));
      MaterialChangeSystem_Dots.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem_Dots>.NativeClassPtr, 100687476);
      MaterialChangeSystem_Dots.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem_Dots>.NativeClassPtr, 100687477);
      MaterialChangeSystem_Dots.NativeMethodInfoPtr_AddMaterialChange_Public_Void_Entity_Material_Int32_Int32_Single_Boolean_Boolean_ShadowCastingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem_Dots>.NativeClassPtr, 100687478);
      MaterialChangeSystem_Dots.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem_Dots>.NativeClassPtr, 100687479);
      MaterialChangeSystem_Dots.NativeMethodInfoPtr_RestoreMaterials_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem_Dots>.NativeClassPtr, 100687480);
      MaterialChangeSystem_Dots.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem_Dots>.NativeClassPtr, 100687481);
      MaterialChangeSystem_Dots.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem_Dots>.NativeClassPtr, 100687482);
    }

    public MaterialChangeSystem_Dots(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<MaterialChangeSystem_Dots.EntityMaterialChange> _EntityMaterialChanges
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.NativeFieldInfoPtr__EntityMaterialChanges));
        return pointer == System.IntPtr.Zero ? (List<MaterialChangeSystem_Dots.EntityMaterialChange>) null : new List<MaterialChangeSystem_Dots.EntityMaterialChange>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.NativeFieldInfoPtr__EntityMaterialChanges), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<MaterialChangeSystem_Dots.EntityMaterialChange> _LastFrameChanges
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.NativeFieldInfoPtr__LastFrameChanges));
        return pointer == System.IntPtr.Zero ? (List<MaterialChangeSystem_Dots.EntityMaterialChange>) null : new List<MaterialChangeSystem_Dots.EntityMaterialChange>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.NativeFieldInfoPtr__LastFrameChanges), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<Entity, List<MaterialChangeSystem_Dots.OriginalMaterial>> _Entity_OriginalMaterials
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.NativeFieldInfoPtr__Entity_OriginalMaterials));
        return pointer == System.IntPtr.Zero ? (Dictionary<Entity, List<MaterialChangeSystem_Dots.OriginalMaterial>>) null : new Dictionary<Entity, List<MaterialChangeSystem_Dots.OriginalMaterial>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.NativeFieldInfoPtr__Entity_OriginalMaterials), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<Entity, Material> _CopiedMaterials
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.NativeFieldInfoPtr__CopiedMaterials));
        return pointer == System.IntPtr.Zero ? (Dictionary<Entity, Material>) null : new Dictionary<Entity, Material>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.NativeFieldInfoPtr__CopiedMaterials), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MaterialPool _MaterialPool
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.NativeFieldInfoPtr__MaterialPool));
        return pointer == System.IntPtr.Zero ? (MaterialPool) null : new MaterialPool(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.NativeFieldInfoPtr__MaterialPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class OriginalMaterial : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_Material;
      private static readonly System.IntPtr NativeFieldInfoPtr_ShadowCasting;

      static OriginalMaterial()
      {
        Il2CppClassPointerStore<MaterialChangeSystem_Dots.OriginalMaterial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialChangeSystem_Dots>.NativeClassPtr, nameof (OriginalMaterial));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialChangeSystem_Dots.OriginalMaterial>.NativeClassPtr);
        MaterialChangeSystem_Dots.OriginalMaterial.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Dots.OriginalMaterial>.NativeClassPtr, nameof (Entity));
        MaterialChangeSystem_Dots.OriginalMaterial.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Dots.OriginalMaterial>.NativeClassPtr, nameof (Material));
        MaterialChangeSystem_Dots.OriginalMaterial.NativeFieldInfoPtr_ShadowCasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Dots.OriginalMaterial>.NativeClassPtr, nameof (ShadowCasting));
      }

      public OriginalMaterial(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public OriginalMaterial()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MaterialChangeSystem_Dots.OriginalMaterial>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialChangeSystem_Dots.OriginalMaterial>.NativeClassPtr, data));
      }

      public unsafe Entity Entity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.OriginalMaterial.NativeFieldInfoPtr_Entity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.OriginalMaterial.NativeFieldInfoPtr_Entity)) = value;
        }
      }

      public unsafe Material Material
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.OriginalMaterial.NativeFieldInfoPtr_Material));
          return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.OriginalMaterial.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ShadowCastingMode ShadowCasting
      {
        get
        {
          return *(ShadowCastingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.OriginalMaterial.NativeFieldInfoPtr_ShadowCasting));
        }
        [param: In] set
        {
          *(ShadowCastingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.OriginalMaterial.NativeFieldInfoPtr_ShadowCasting)) = value;
        }
      }
    }

    public sealed class EntityMaterialChange : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Material;
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
      private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_CopyNormalMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_CopyBaseMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_ShadowCasting;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_EntityMaterialChange_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EntityMaterialChange_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102211, XrefRangeEnd = 1102214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(
        MaterialChangeSystem_Dots.EntityMaterialChange other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MaterialChangeSystem_Dots.EntityMaterialChange.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_EntityMaterialChange_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1102216, RefRangeEnd = 1102217, XrefRangeStart = 1102214, XrefRangeEnd = 1102216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(
        MaterialChangeSystem_Dots.EntityMaterialChange other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MaterialChangeSystem_Dots.EntityMaterialChange.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EntityMaterialChange_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102217, XrefRangeEnd = 1102221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe bool Equals(Il2CppSystem.Object obj)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MaterialChangeSystem_Dots.EntityMaterialChange.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102221, XrefRangeEnd = 1102229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MaterialChangeSystem_Dots.EntityMaterialChange.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static EntityMaterialChange()
      {
        Il2CppClassPointerStore<MaterialChangeSystem_Dots.EntityMaterialChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialChangeSystem_Dots>.NativeClassPtr, nameof (EntityMaterialChange));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialChangeSystem_Dots.EntityMaterialChange>.NativeClassPtr);
        MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Dots.EntityMaterialChange>.NativeClassPtr, nameof (Material));
        MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Dots.EntityMaterialChange>.NativeClassPtr, nameof (Entity));
        MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Dots.EntityMaterialChange>.NativeClassPtr, nameof (Importance));
        MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Dots.EntityMaterialChange>.NativeClassPtr, nameof (StartTime));
        MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_CopyNormalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Dots.EntityMaterialChange>.NativeClassPtr, nameof (CopyNormalMap));
        MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_CopyBaseMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Dots.EntityMaterialChange>.NativeClassPtr, nameof (CopyBaseMap));
        MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_ShadowCasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Dots.EntityMaterialChange>.NativeClassPtr, nameof (ShadowCasting));
        MaterialChangeSystem_Dots.EntityMaterialChange.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_EntityMaterialChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem_Dots.EntityMaterialChange>.NativeClassPtr, 100687483);
        MaterialChangeSystem_Dots.EntityMaterialChange.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EntityMaterialChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem_Dots.EntityMaterialChange>.NativeClassPtr, 100687484);
        MaterialChangeSystem_Dots.EntityMaterialChange.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem_Dots.EntityMaterialChange>.NativeClassPtr, 100687485);
        MaterialChangeSystem_Dots.EntityMaterialChange.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem_Dots.EntityMaterialChange>.NativeClassPtr, 100687486);
      }

      public EntityMaterialChange(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public EntityMaterialChange()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MaterialChangeSystem_Dots.EntityMaterialChange>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialChangeSystem_Dots.EntityMaterialChange>.NativeClassPtr, data));
      }

      public unsafe Material Material
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_Material));
          return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity Entity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_Entity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_Entity)) = value;
        }
      }

      public unsafe int Importance
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_Importance));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_Importance)) = value;
        }
      }

      public unsafe float StartTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_StartTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_StartTime)) = value;
        }
      }

      public unsafe bool CopyNormalMap
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_CopyNormalMap));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_CopyNormalMap)) = value;
        }
      }

      public unsafe bool CopyBaseMap
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_CopyBaseMap));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_CopyBaseMap)) = value;
        }
      }

      public unsafe ShadowCastingMode ShadowCasting
      {
        get
        {
          return *(ShadowCastingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_ShadowCasting));
        }
        [param: In] set
        {
          *(ShadowCastingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Dots.EntityMaterialChange.NativeFieldInfoPtr_ShadowCasting)) = value;
        }
      }
    }
  }
}
