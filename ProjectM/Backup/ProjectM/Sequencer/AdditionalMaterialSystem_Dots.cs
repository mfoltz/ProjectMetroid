// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.AdditionalMaterialSystem_Dots
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
  public class AdditionalMaterialSystem_Dots : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BlinkColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlphaMultiply;
    private static readonly System.IntPtr NativeFieldInfoPtr_DitherAlpha;
    private static readonly System.IntPtr NativeFieldInfoPtr_RustleForceVector;
    private static readonly System.IntPtr NativeFieldInfoPtr_RustleAnimationTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverlappingAnimationTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__SequencerEntityAssociationSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__Archetype;
    private static readonly System.IntPtr NativeFieldInfoPtr__AdditionMaterialEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr__EntitiesThisFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__EntitiesLastFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalRenderers;
    private static readonly System.IntPtr NativeFieldInfoPtr__CopiedMaterials;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaterialPool;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAdditionalMaterial_Public_Void_Entity_Material_Int32_Single_Boolean_Boolean_ShadowCastingMode_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099737, XrefRangeEnd = 1099840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AdditionalMaterialSystem_Dots.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099840, XrefRangeEnd = 1099869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AdditionalMaterialSystem_Dots.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1099880, RefRangeEnd = 1099881, XrefRangeStart = 1099869, XrefRangeEnd = 1099880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddAdditionalMaterial(
      Entity entity,
      Material material,
      int importance,
      float startTime,
      bool copyNormalMap,
      bool copyBaseMap,
      ShadowCastingMode shadowCastingMode,
      Entity additionalFakeEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &importance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &startTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &copyNormalMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &copyBaseMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &shadowCastingMode;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &additionalFakeEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AdditionalMaterialSystem_Dots.NativeMethodInfoPtr_AddAdditionalMaterial_Public_Void_Entity_Material_Int32_Single_Boolean_Boolean_ShadowCastingMode_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099881, XrefRangeEnd = 1100183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AdditionalMaterialSystem_Dots.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AdditionalMaterialSystem_Dots()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AdditionalMaterialSystem_Dots.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AdditionalMaterialSystem_Dots.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AdditionalMaterialSystem_Dots()
    {
      Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (AdditionalMaterialSystem_Dots));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr);
      AdditionalMaterialSystem_Dots.NativeFieldInfoPtr_BlinkColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, nameof (BlinkColor));
      AdditionalMaterialSystem_Dots.NativeFieldInfoPtr_AlphaMultiply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, nameof (AlphaMultiply));
      AdditionalMaterialSystem_Dots.NativeFieldInfoPtr_DitherAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, nameof (DitherAlpha));
      AdditionalMaterialSystem_Dots.NativeFieldInfoPtr_RustleForceVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, nameof (RustleForceVector));
      AdditionalMaterialSystem_Dots.NativeFieldInfoPtr_RustleAnimationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, nameof (RustleAnimationTime));
      AdditionalMaterialSystem_Dots.NativeFieldInfoPtr_OverlappingAnimationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, nameof (OverlappingAnimationTime));
      AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__SequencerEntityAssociationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, nameof (_SequencerEntityAssociationSystem));
      AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__Archetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, nameof (_Archetype));
      AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__AdditionMaterialEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, nameof (_AdditionMaterialEntries));
      AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__EntitiesThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, nameof (_EntitiesThisFrame));
      AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__EntitiesLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, nameof (_EntitiesLastFrame));
      AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__AdditionalRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, nameof (_AdditionalRenderers));
      AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__CopiedMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, nameof (_CopiedMaterials));
      AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__MaterialPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, nameof (_MaterialPool));
      AdditionalMaterialSystem_Dots.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, 100687305);
      AdditionalMaterialSystem_Dots.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, 100687306);
      AdditionalMaterialSystem_Dots.NativeMethodInfoPtr_AddAdditionalMaterial_Public_Void_Entity_Material_Int32_Single_Boolean_Boolean_ShadowCastingMode_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, 100687307);
      AdditionalMaterialSystem_Dots.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, 100687308);
      AdditionalMaterialSystem_Dots.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, 100687309);
      AdditionalMaterialSystem_Dots.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, 100687311);
    }

    public AdditionalMaterialSystem_Dots(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int BlinkColor
    {
      get
      {
        int blinkColor;
        IL2CPP.il2cpp_field_static_get_value(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr_BlinkColor, (void*) &blinkColor);
        return blinkColor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr_BlinkColor, (void*) &value);
      }
    }

    public static unsafe int AlphaMultiply
    {
      get
      {
        int alphaMultiply;
        IL2CPP.il2cpp_field_static_get_value(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr_AlphaMultiply, (void*) &alphaMultiply);
        return alphaMultiply;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr_AlphaMultiply, (void*) &value);
      }
    }

    public static unsafe int DitherAlpha
    {
      get
      {
        int ditherAlpha;
        IL2CPP.il2cpp_field_static_get_value(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr_DitherAlpha, (void*) &ditherAlpha);
        return ditherAlpha;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr_DitherAlpha, (void*) &value);
      }
    }

    public static unsafe int RustleForceVector
    {
      get
      {
        int rustleForceVector;
        IL2CPP.il2cpp_field_static_get_value(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr_RustleForceVector, (void*) &rustleForceVector);
        return rustleForceVector;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr_RustleForceVector, (void*) &value);
      }
    }

    public static unsafe int RustleAnimationTime
    {
      get
      {
        int rustleAnimationTime;
        IL2CPP.il2cpp_field_static_get_value(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr_RustleAnimationTime, (void*) &rustleAnimationTime);
        return rustleAnimationTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr_RustleAnimationTime, (void*) &value);
      }
    }

    public static unsafe int OverlappingAnimationTime
    {
      get
      {
        int overlappingAnimationTime;
        IL2CPP.il2cpp_field_static_get_value(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr_OverlappingAnimationTime, (void*) &overlappingAnimationTime);
        return overlappingAnimationTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr_OverlappingAnimationTime, (void*) &value);
      }
    }

    public unsafe SequencerEntityAssociationSystem _SequencerEntityAssociationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__SequencerEntityAssociationSystem));
        return pointer == System.IntPtr.Zero ? (SequencerEntityAssociationSystem) null : new SequencerEntityAssociationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__SequencerEntityAssociationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityArchetype _Archetype
    {
      get
      {
        return *(EntityArchetype*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__Archetype));
      }
      [param: In] set
      {
        *(EntityArchetype*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__Archetype)) = value;
      }
    }

    public unsafe List<AdditionalMaterialSystem_Dots.AdditionMaterialEntry> _AdditionMaterialEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__AdditionMaterialEntries));
        return pointer == System.IntPtr.Zero ? (List<AdditionalMaterialSystem_Dots.AdditionMaterialEntry>) null : new List<AdditionalMaterialSystem_Dots.AdditionMaterialEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__AdditionMaterialEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Entity> _EntitiesThisFrame
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__EntitiesThisFrame));
        return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__EntitiesThisFrame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Entity> _EntitiesLastFrame
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__EntitiesLastFrame));
        return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__EntitiesLastFrame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<Entity, AdditionalMaterialSystem_Dots.AdditionalRenderer> _AdditionalRenderers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__AdditionalRenderers));
        return pointer == System.IntPtr.Zero ? (Dictionary<Entity, AdditionalMaterialSystem_Dots.AdditionalRenderer>) null : new Dictionary<Entity, AdditionalMaterialSystem_Dots.AdditionalRenderer>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__AdditionalRenderers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<Entity, List<Material>> _CopiedMaterials
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__CopiedMaterials));
        return pointer == System.IntPtr.Zero ? (Dictionary<Entity, List<Material>>) null : new Dictionary<Entity, List<Material>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__CopiedMaterials), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MaterialPool _MaterialPool
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__MaterialPool));
        return pointer == System.IntPtr.Zero ? (MaterialPool) null : new MaterialPool(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.NativeFieldInfoPtr__MaterialPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class AdditionMaterialEntry : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Material;
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
      private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_CopyNormalMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_CopyBaseMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_ShadowCastingMode;
      private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalFakeEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AdditionMaterialEntry_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099733, XrefRangeEnd = 1099737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(
        AdditionalMaterialSystem_Dots.AdditionMaterialEntry other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AdditionMaterialEntry_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static AdditionMaterialEntry()
      {
        Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.AdditionMaterialEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, nameof (AdditionMaterialEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.AdditionMaterialEntry>.NativeClassPtr);
        AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.AdditionMaterialEntry>.NativeClassPtr, nameof (Material));
        AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.AdditionMaterialEntry>.NativeClassPtr, nameof (Entity));
        AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.AdditionMaterialEntry>.NativeClassPtr, nameof (Importance));
        AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.AdditionMaterialEntry>.NativeClassPtr, nameof (StartTime));
        AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_CopyNormalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.AdditionMaterialEntry>.NativeClassPtr, nameof (CopyNormalMap));
        AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_CopyBaseMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.AdditionMaterialEntry>.NativeClassPtr, nameof (CopyBaseMap));
        AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_ShadowCastingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.AdditionMaterialEntry>.NativeClassPtr, nameof (ShadowCastingMode));
        AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_AdditionalFakeEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.AdditionMaterialEntry>.NativeClassPtr, nameof (AdditionalFakeEntity));
        AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AdditionMaterialEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.AdditionMaterialEntry>.NativeClassPtr, 100687312);
      }

      public AdditionMaterialEntry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public AdditionMaterialEntry()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.AdditionMaterialEntry>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.AdditionMaterialEntry>.NativeClassPtr, data));
      }

      public unsafe Material Material
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_Material));
          return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity Entity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_Entity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_Entity)) = value;
        }
      }

      public unsafe int Importance
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_Importance));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_Importance)) = value;
        }
      }

      public unsafe float StartTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_StartTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_StartTime)) = value;
        }
      }

      public unsafe bool CopyNormalMap
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_CopyNormalMap));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_CopyNormalMap)) = value;
        }
      }

      public unsafe bool CopyBaseMap
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_CopyBaseMap));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_CopyBaseMap)) = value;
        }
      }

      public unsafe ShadowCastingMode ShadowCastingMode
      {
        get
        {
          return *(ShadowCastingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_ShadowCastingMode));
        }
        [param: In] set
        {
          *(ShadowCastingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_ShadowCastingMode)) = value;
        }
      }

      public unsafe Entity AdditionalFakeEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_AdditionalFakeEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.AdditionMaterialEntry.NativeFieldInfoPtr_AdditionalFakeEntity)) = value;
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CopiedEntity
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Parent;
      private static readonly System.IntPtr NativeFieldInfoPtr_Copy;
      [FieldOffset(0)]
      public Entity Parent;
      [FieldOffset(8)]
      public Entity Copy;

      static CopiedEntity()
      {
        Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.CopiedEntity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, nameof (CopiedEntity));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.CopiedEntity>.NativeClassPtr);
        AdditionalMaterialSystem_Dots.CopiedEntity.NativeFieldInfoPtr_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.CopiedEntity>.NativeClassPtr, nameof (Parent));
        AdditionalMaterialSystem_Dots.CopiedEntity.NativeFieldInfoPtr_Copy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.CopiedEntity>.NativeClassPtr, nameof (Copy));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.CopiedEntity>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public sealed class AdditionalRenderer : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_CopiedEntities;

      static AdditionalRenderer()
      {
        Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.AdditionalRenderer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots>.NativeClassPtr, nameof (AdditionalRenderer));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.AdditionalRenderer>.NativeClassPtr);
        AdditionalMaterialSystem_Dots.AdditionalRenderer.NativeFieldInfoPtr_AdditionalEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.AdditionalRenderer>.NativeClassPtr, nameof (AdditionalEntity));
        AdditionalMaterialSystem_Dots.AdditionalRenderer.NativeFieldInfoPtr_CopiedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.AdditionalRenderer>.NativeClassPtr, nameof (CopiedEntities));
      }

      public AdditionalRenderer(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public AdditionalRenderer()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.AdditionalRenderer>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AdditionalMaterialSystem_Dots.AdditionalRenderer>.NativeClassPtr, data));
      }

      public unsafe Entity AdditionalEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.AdditionalRenderer.NativeFieldInfoPtr_AdditionalEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.AdditionalRenderer.NativeFieldInfoPtr_AdditionalEntity)) = value;
        }
      }

      public unsafe List<AdditionalMaterialSystem_Dots.CopiedEntity> CopiedEntities
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.AdditionalRenderer.NativeFieldInfoPtr_CopiedEntities));
          return pointer == System.IntPtr.Zero ? (List<AdditionalMaterialSystem_Dots.CopiedEntity>) null : new List<AdditionalMaterialSystem_Dots.CopiedEntity>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Dots.AdditionalRenderer.NativeFieldInfoPtr_CopiedEntities), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
