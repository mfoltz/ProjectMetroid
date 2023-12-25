// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.AdditionalMaterialSystem_Hybrid
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM.Hybrid;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  public class AdditionalMaterialSystem_Hybrid : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__HybridModelSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SequencerEntityAssociationSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalMaterialEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameObjectsThisFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameObjectsLastFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastFrameState;
    private static readonly System.IntPtr NativeFieldInfoPtr__HybridModelRendererVersionLastFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__Renderers;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedMaterialSetter_1;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedMaterialSetter_2;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReplacedMaterialsForRenderer;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaterialPool;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAdditionalMaterial_Public_Void_Entity_Material_Int32_Int32_Single_Boolean_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RestoreMaterialsForHybridModelRendererComponent_Private_Void_HybridRendererAndInstanceId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RestoreMaterialsForRenderer_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100243, XrefRangeEnd = 1100313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AdditionalMaterialSystem_Hybrid.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100313, XrefRangeEnd = 1100315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AdditionalMaterialSystem_Hybrid.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1100347, RefRangeEnd = 1100348, XrefRangeStart = 1100315, XrefRangeEnd = 1100347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddAdditionalMaterial(
      Entity entity,
      Material material,
      int rendererMask,
      int importance,
      float startTime,
      bool copyNormalMap,
      bool copyBaseMap,
      Entity additionalFakeEntity)
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
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &additionalFakeEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AdditionalMaterialSystem_Hybrid.NativeMethodInfoPtr_AddAdditionalMaterial_Public_Void_Entity_Material_Int32_Int32_Single_Boolean_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100348, XrefRangeEnd = 1100517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AdditionalMaterialSystem_Hybrid.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1100544, RefRangeEnd = 1100547, XrefRangeStart = 1100517, XrefRangeEnd = 1100544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RestoreMaterialsForHybridModelRendererComponent(
      AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId id)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) id));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AdditionalMaterialSystem_Hybrid.NativeMethodInfoPtr_RestoreMaterialsForHybridModelRendererComponent_Private_Void_HybridRendererAndInstanceId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1100562, RefRangeEnd = 1100563, XrefRangeStart = 1100547, XrefRangeEnd = 1100562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RestoreMaterialsForRenderer(int instanceId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &instanceId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AdditionalMaterialSystem_Hybrid.NativeMethodInfoPtr_RestoreMaterialsForRenderer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AdditionalMaterialSystem_Hybrid()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AdditionalMaterialSystem_Hybrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AdditionalMaterialSystem_Hybrid.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AdditionalMaterialSystem_Hybrid()
    {
      Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (AdditionalMaterialSystem_Hybrid));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr);
      AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__HybridModelSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, nameof (_HybridModelSystem));
      AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__SequencerEntityAssociationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, nameof (_SequencerEntityAssociationSystem));
      AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__AdditionalMaterialEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, nameof (_AdditionalMaterialEntries));
      AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__GameObjectsThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, nameof (_GameObjectsThisFrame));
      AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__GameObjectsLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, nameof (_GameObjectsLastFrame));
      AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__LastFrameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, nameof (_LastFrameState));
      AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__HybridModelRendererVersionLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, nameof (_HybridModelRendererVersionLastFrame));
      AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__Renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, nameof (_Renderers));
      AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__CachedMaterialSetter_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, nameof (_CachedMaterialSetter_1));
      AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__CachedMaterialSetter_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, nameof (_CachedMaterialSetter_2));
      AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__ReplacedMaterialsForRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, nameof (_ReplacedMaterialsForRenderer));
      AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__MaterialPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, nameof (_MaterialPool));
      AdditionalMaterialSystem_Hybrid.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, 100687313);
      AdditionalMaterialSystem_Hybrid.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, 100687314);
      AdditionalMaterialSystem_Hybrid.NativeMethodInfoPtr_AddAdditionalMaterial_Public_Void_Entity_Material_Int32_Int32_Single_Boolean_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, 100687315);
      AdditionalMaterialSystem_Hybrid.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, 100687316);
      AdditionalMaterialSystem_Hybrid.NativeMethodInfoPtr_RestoreMaterialsForHybridModelRendererComponent_Private_Void_HybridRendererAndInstanceId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, 100687317);
      AdditionalMaterialSystem_Hybrid.NativeMethodInfoPtr_RestoreMaterialsForRenderer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, 100687318);
      AdditionalMaterialSystem_Hybrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, 100687319);
      AdditionalMaterialSystem_Hybrid.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, 100687320);
    }

    public AdditionalMaterialSystem_Hybrid(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe HybridModelSystem _HybridModelSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__HybridModelSystem));
        return pointer == System.IntPtr.Zero ? (HybridModelSystem) null : new HybridModelSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__HybridModelSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequencerEntityAssociationSystem _SequencerEntityAssociationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__SequencerEntityAssociationSystem));
        return pointer == System.IntPtr.Zero ? (SequencerEntityAssociationSystem) null : new SequencerEntityAssociationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__SequencerEntityAssociationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange> _AdditionalMaterialEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__AdditionalMaterialEntries));
        return pointer == System.IntPtr.Zero ? (List<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>) null : new List<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__AdditionalMaterialEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId> _GameObjectsThisFrame
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__GameObjectsThisFrame));
        return pointer == System.IntPtr.Zero ? (List<AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId>) null : new List<AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__GameObjectsThisFrame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId> _GameObjectsLastFrame
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__GameObjectsLastFrame));
        return pointer == System.IntPtr.Zero ? (List<AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId>) null : new List<AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__GameObjectsLastFrame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId, AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange> _LastFrameState
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__LastFrameState));
        return pointer == System.IntPtr.Zero ? (Dictionary<AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId, AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>) null : new Dictionary<AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId, AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__LastFrameState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<int> _HybridModelRendererVersionLastFrame
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__HybridModelRendererVersionLastFrame));
        return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__HybridModelRendererVersionLastFrame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Renderer> _Renderers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__Renderers));
        return pointer == System.IntPtr.Zero ? (List<Renderer>) null : new List<Renderer>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__Renderers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<Material> _CachedMaterialSetter_1
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__CachedMaterialSetter_1));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Material>) null : new Il2CppReferenceArray<Material>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__CachedMaterialSetter_1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<Material> _CachedMaterialSetter_2
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__CachedMaterialSetter_2));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Material>) null : new Il2CppReferenceArray<Material>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__CachedMaterialSetter_2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, AdditionalMaterialSystem_Hybrid.ReplacedMaterial> _ReplacedMaterialsForRenderer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__ReplacedMaterialsForRenderer));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, AdditionalMaterialSystem_Hybrid.ReplacedMaterial>) null : new Dictionary<int, AdditionalMaterialSystem_Hybrid.ReplacedMaterial>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__ReplacedMaterialsForRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MaterialPool _MaterialPool
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__MaterialPool));
        return pointer == System.IntPtr.Zero ? (MaterialPool) null : new MaterialPool(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.NativeFieldInfoPtr__MaterialPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class ReplacedMaterial : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Renderer;
      private static readonly System.IntPtr NativeFieldInfoPtr_Material;
      private static readonly System.IntPtr NativeFieldInfoPtr_ReturnMaterialToPool;

      static ReplacedMaterial()
      {
        Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.ReplacedMaterial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, nameof (ReplacedMaterial));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.ReplacedMaterial>.NativeClassPtr);
        AdditionalMaterialSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.ReplacedMaterial>.NativeClassPtr, nameof (Renderer));
        AdditionalMaterialSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.ReplacedMaterial>.NativeClassPtr, nameof (Material));
        AdditionalMaterialSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_ReturnMaterialToPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.ReplacedMaterial>.NativeClassPtr, nameof (ReturnMaterialToPool));
      }

      public ReplacedMaterial(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public ReplacedMaterial()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.ReplacedMaterial>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.ReplacedMaterial>.NativeClassPtr, data));
      }

      public unsafe Renderer Renderer
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_Renderer));
          return pointer == System.IntPtr.Zero ? (Renderer) null : new Renderer(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_Renderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Material Material
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_Material));
          return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool ReturnMaterialToPool
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_ReturnMaterialToPool));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_ReturnMaterialToPool)) = value;
        }
      }
    }

    public sealed class HybridRendererAndInstanceId : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_HybridRenderer;
      private static readonly System.IntPtr NativeFieldInfoPtr_InstanceId;
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HybridRendererAndInstanceId_0;

      [CallerCount(0)]
      public virtual unsafe bool Equals(
        AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HybridRendererAndInstanceId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static HybridRendererAndInstanceId()
      {
        Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, nameof (HybridRendererAndInstanceId));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId>.NativeClassPtr);
        AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId.NativeFieldInfoPtr_HybridRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId>.NativeClassPtr, nameof (HybridRenderer));
        AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId.NativeFieldInfoPtr_InstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId>.NativeClassPtr, nameof (InstanceId));
        AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId>.NativeClassPtr, nameof (Entity));
        AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HybridRendererAndInstanceId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId>.NativeClassPtr, 100687321);
      }

      public HybridRendererAndInstanceId(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public HybridRendererAndInstanceId()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId>.NativeClassPtr, data));
      }

      public unsafe HybridModelRendererComponent HybridRenderer
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId.NativeFieldInfoPtr_HybridRenderer));
          return pointer == System.IntPtr.Zero ? (HybridModelRendererComponent) null : new HybridModelRendererComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId.NativeFieldInfoPtr_HybridRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int InstanceId
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId.NativeFieldInfoPtr_InstanceId));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId.NativeFieldInfoPtr_InstanceId)) = value;
        }
      }

      public unsafe Entity Entity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId.NativeFieldInfoPtr_Entity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.HybridRendererAndInstanceId.NativeFieldInfoPtr_Entity)) = value;
        }
      }
    }

    public sealed class GameObjectMaterialChange : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_HybridRenderer;
      private static readonly System.IntPtr NativeFieldInfoPtr_Material;
      private static readonly System.IntPtr NativeFieldInfoPtr_RendererMask;
      private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
      private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_CopyNormalMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_CopyBaseMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalFakeEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_GameObjectMaterialChange_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GameObjectMaterialChange_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100183, XrefRangeEnd = 1100188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(
        AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_GameObjectMaterialChange_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100188, XrefRangeEnd = 1100223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1100227, RefRangeEnd = 1100229, XrefRangeStart = 1100223, XrefRangeEnd = 1100227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(
        AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GameObjectMaterialChange_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100229, XrefRangeEnd = 1100233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe bool Equals(Il2CppSystem.Object obj)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100233, XrefRangeEnd = 1100243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static GameObjectMaterialChange()
      {
        Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid>.NativeClassPtr, nameof (GameObjectMaterialChange));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr);
        AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_HybridRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, nameof (HybridRenderer));
        AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, nameof (Material));
        AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_RendererMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, nameof (RendererMask));
        AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, nameof (Importance));
        AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, nameof (StartTime));
        AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_CopyNormalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, nameof (CopyNormalMap));
        AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_CopyBaseMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, nameof (CopyBaseMap));
        AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, nameof (Entity));
        AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_AdditionalFakeEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, nameof (AdditionalFakeEntity));
        AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_GameObjectMaterialChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, 100687322);
        AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, 100687323);
        AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GameObjectMaterialChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, 100687324);
        AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, 100687325);
        AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, 100687326);
      }

      public GameObjectMaterialChange(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public GameObjectMaterialChange()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, data));
      }

      public unsafe HybridModelRendererComponent HybridRenderer
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_HybridRenderer));
          return pointer == System.IntPtr.Zero ? (HybridModelRendererComponent) null : new HybridModelRendererComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_HybridRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Material Material
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_Material));
          return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int RendererMask
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_RendererMask));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_RendererMask)) = value;
        }
      }

      public unsafe int Importance
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_Importance));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_Importance)) = value;
        }
      }

      public unsafe float StartTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_StartTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_StartTime)) = value;
        }
      }

      public unsafe bool CopyNormalMap
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_CopyNormalMap));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_CopyNormalMap)) = value;
        }
      }

      public unsafe bool CopyBaseMap
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_CopyBaseMap));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_CopyBaseMap)) = value;
        }
      }

      public unsafe Entity Entity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_Entity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_Entity)) = value;
        }
      }

      public unsafe Entity AdditionalFakeEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_AdditionalFakeEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdditionalMaterialSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_AdditionalFakeEntity)) = value;
        }
      }
    }
  }
}
