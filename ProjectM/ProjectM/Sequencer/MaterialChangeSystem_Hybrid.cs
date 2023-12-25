// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.MaterialChangeSystem_Hybrid
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Hybrid;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM.Sequencer
{
  public class MaterialChangeSystem_Hybrid : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__HybridModelSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameObjectMaterialChanges;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedRenderers;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReplacedMaterialsForRenderer;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaterialPool;
    private static readonly System.IntPtr NativeFieldInfoPtr__ThisFrameRenderers;
    private static readonly System.IntPtr NativeFieldInfoPtr__RendererUsedLastFrame;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddMaterialChange_Public_Void_Entity_Material_Int32_Int32_Single_Boolean_Boolean_ShadowCastingMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RestoreMaterialsForRenderer_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102460, XrefRangeEnd = 1102506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialChangeSystem_Hybrid.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1102538, RefRangeEnd = 1102539, XrefRangeStart = 1102506, XrefRangeEnd = 1102538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(MaterialChangeSystem_Hybrid.NativeMethodInfoPtr_AddMaterialChange_Public_Void_Entity_Material_Int32_Int32_Single_Boolean_Boolean_ShadowCastingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102539, XrefRangeEnd = 1102661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialChangeSystem_Hybrid.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1102675, RefRangeEnd = 1102677, XrefRangeStart = 1102661, XrefRangeEnd = 1102675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RestoreMaterialsForRenderer(int instanceId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &instanceId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialChangeSystem_Hybrid.NativeMethodInfoPtr_RestoreMaterialsForRenderer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MaterialChangeSystem_Hybrid()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialChangeSystem_Hybrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MaterialChangeSystem_Hybrid.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MaterialChangeSystem_Hybrid()
    {
      Il2CppClassPointerStore<MaterialChangeSystem_Hybrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (MaterialChangeSystem_Hybrid));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid>.NativeClassPtr);
      MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__HybridModelSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid>.NativeClassPtr, nameof (_HybridModelSystem));
      MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__GameObjectMaterialChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid>.NativeClassPtr, nameof (_GameObjectMaterialChanges));
      MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__CachedRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid>.NativeClassPtr, nameof (_CachedRenderers));
      MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__ReplacedMaterialsForRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid>.NativeClassPtr, nameof (_ReplacedMaterialsForRenderer));
      MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__MaterialPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid>.NativeClassPtr, nameof (_MaterialPool));
      MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__ThisFrameRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid>.NativeClassPtr, nameof (_ThisFrameRenderers));
      MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__RendererUsedLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid>.NativeClassPtr, nameof (_RendererUsedLastFrame));
      MaterialChangeSystem_Hybrid.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid>.NativeClassPtr, 100687487);
      MaterialChangeSystem_Hybrid.NativeMethodInfoPtr_AddMaterialChange_Public_Void_Entity_Material_Int32_Int32_Single_Boolean_Boolean_ShadowCastingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid>.NativeClassPtr, 100687488);
      MaterialChangeSystem_Hybrid.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid>.NativeClassPtr, 100687489);
      MaterialChangeSystem_Hybrid.NativeMethodInfoPtr_RestoreMaterialsForRenderer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid>.NativeClassPtr, 100687490);
      MaterialChangeSystem_Hybrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid>.NativeClassPtr, 100687491);
      MaterialChangeSystem_Hybrid.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid>.NativeClassPtr, 100687492);
    }

    public MaterialChangeSystem_Hybrid(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe HybridModelSystem _HybridModelSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__HybridModelSystem));
        return pointer == System.IntPtr.Zero ? (HybridModelSystem) null : new HybridModelSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__HybridModelSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<MaterialChangeSystem_Hybrid.GameObjectMaterialChange> _GameObjectMaterialChanges
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__GameObjectMaterialChanges));
        return pointer == System.IntPtr.Zero ? (List<MaterialChangeSystem_Hybrid.GameObjectMaterialChange>) null : new List<MaterialChangeSystem_Hybrid.GameObjectMaterialChange>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__GameObjectMaterialChanges), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Renderer> _CachedRenderers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__CachedRenderers));
        return pointer == System.IntPtr.Zero ? (List<Renderer>) null : new List<Renderer>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__CachedRenderers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, MaterialChangeSystem_Hybrid.ReplacedMaterial> _ReplacedMaterialsForRenderer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__ReplacedMaterialsForRenderer));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, MaterialChangeSystem_Hybrid.ReplacedMaterial>) null : new Dictionary<int, MaterialChangeSystem_Hybrid.ReplacedMaterial>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__ReplacedMaterialsForRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MaterialPool _MaterialPool
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__MaterialPool));
        return pointer == System.IntPtr.Zero ? (MaterialPool) null : new MaterialPool(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__MaterialPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, MaterialChangeSystem_Hybrid.RendererForThisFrame> _ThisFrameRenderers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__ThisFrameRenderers));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, MaterialChangeSystem_Hybrid.RendererForThisFrame>) null : new Dictionary<int, MaterialChangeSystem_Hybrid.RendererForThisFrame>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__ThisFrameRenderers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<MaterialChangeSystem_Hybrid.RendererInstanceId> _RendererUsedLastFrame
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__RendererUsedLastFrame));
        return pointer == System.IntPtr.Zero ? (List<MaterialChangeSystem_Hybrid.RendererInstanceId>) null : new List<MaterialChangeSystem_Hybrid.RendererInstanceId>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.NativeFieldInfoPtr__RendererUsedLastFrame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
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
      private static readonly System.IntPtr NativeFieldInfoPtr_ShadowCasting;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_GameObjectMaterialChange_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(
        MaterialChangeSystem_Hybrid.GameObjectMaterialChange other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_GameObjectMaterialChange_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static GameObjectMaterialChange()
      {
        Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid>.NativeClassPtr, nameof (GameObjectMaterialChange));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr);
        MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_HybridRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, nameof (HybridRenderer));
        MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, nameof (Material));
        MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_RendererMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, nameof (RendererMask));
        MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, nameof (Importance));
        MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, nameof (StartTime));
        MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_CopyNormalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, nameof (CopyNormalMap));
        MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_CopyBaseMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, nameof (CopyBaseMap));
        MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_ShadowCasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, nameof (ShadowCasting));
        MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_GameObjectMaterialChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, 100687493);
      }

      public GameObjectMaterialChange(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public GameObjectMaterialChange()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.GameObjectMaterialChange>.NativeClassPtr, data));
      }

      public unsafe HybridModelRendererComponent HybridRenderer
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_HybridRenderer));
          return pointer == System.IntPtr.Zero ? (HybridModelRendererComponent) null : new HybridModelRendererComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_HybridRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Material Material
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_Material));
          return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int RendererMask
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_RendererMask));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_RendererMask)) = value;
        }
      }

      public unsafe int Importance
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_Importance));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_Importance)) = value;
        }
      }

      public unsafe float StartTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_StartTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_StartTime)) = value;
        }
      }

      public unsafe bool CopyNormalMap
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_CopyNormalMap));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_CopyNormalMap)) = value;
        }
      }

      public unsafe bool CopyBaseMap
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_CopyBaseMap));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_CopyBaseMap)) = value;
        }
      }

      public unsafe ShadowCastingMode ShadowCasting
      {
        get
        {
          return *(ShadowCastingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_ShadowCasting));
        }
        [param: In] set
        {
          *(ShadowCastingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.GameObjectMaterialChange.NativeFieldInfoPtr_ShadowCasting)) = value;
        }
      }
    }

    public sealed class ReplacedMaterial : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Renderer;
      private static readonly System.IntPtr NativeFieldInfoPtr_OriginalMaterial;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaterialInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr_HybridRenderer;
      private static readonly System.IntPtr NativeFieldInfoPtr_ReturnMaterialToPool;

      static ReplacedMaterial()
      {
        Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.ReplacedMaterial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid>.NativeClassPtr, nameof (ReplacedMaterial));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.ReplacedMaterial>.NativeClassPtr);
        MaterialChangeSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.ReplacedMaterial>.NativeClassPtr, nameof (Renderer));
        MaterialChangeSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_OriginalMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.ReplacedMaterial>.NativeClassPtr, nameof (OriginalMaterial));
        MaterialChangeSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_MaterialInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.ReplacedMaterial>.NativeClassPtr, nameof (MaterialInstance));
        MaterialChangeSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_HybridRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.ReplacedMaterial>.NativeClassPtr, nameof (HybridRenderer));
        MaterialChangeSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_ReturnMaterialToPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.ReplacedMaterial>.NativeClassPtr, nameof (ReturnMaterialToPool));
      }

      public ReplacedMaterial(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public ReplacedMaterial()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.ReplacedMaterial>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.ReplacedMaterial>.NativeClassPtr, data));
      }

      public unsafe Renderer Renderer
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_Renderer));
          return pointer == System.IntPtr.Zero ? (Renderer) null : new Renderer(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_Renderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Material OriginalMaterial
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_OriginalMaterial));
          return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_OriginalMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Material MaterialInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_MaterialInstance));
          return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_MaterialInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe HybridModelRendererComponent HybridRenderer
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_HybridRenderer));
          return pointer == System.IntPtr.Zero ? (HybridModelRendererComponent) null : new HybridModelRendererComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_HybridRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool ReturnMaterialToPool
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_ReturnMaterialToPool));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.ReplacedMaterial.NativeFieldInfoPtr_ReturnMaterialToPool)) = value;
        }
      }
    }

    public sealed class RendererForThisFrame : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Renderer;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChangeIndex;

      static RendererForThisFrame()
      {
        Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.RendererForThisFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid>.NativeClassPtr, nameof (RendererForThisFrame));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.RendererForThisFrame>.NativeClassPtr);
        MaterialChangeSystem_Hybrid.RendererForThisFrame.NativeFieldInfoPtr_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.RendererForThisFrame>.NativeClassPtr, nameof (Renderer));
        MaterialChangeSystem_Hybrid.RendererForThisFrame.NativeFieldInfoPtr_ChangeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.RendererForThisFrame>.NativeClassPtr, nameof (ChangeIndex));
      }

      public RendererForThisFrame(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public RendererForThisFrame()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.RendererForThisFrame>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.RendererForThisFrame>.NativeClassPtr, data));
      }

      public unsafe Renderer Renderer
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.RendererForThisFrame.NativeFieldInfoPtr_Renderer));
          return pointer == System.IntPtr.Zero ? (Renderer) null : new Renderer(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.RendererForThisFrame.NativeFieldInfoPtr_Renderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int ChangeIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.RendererForThisFrame.NativeFieldInfoPtr_ChangeIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialChangeSystem_Hybrid.RendererForThisFrame.NativeFieldInfoPtr_ChangeIndex)) = value;
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RendererInstanceId
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Value;
      [FieldOffset(0)]
      public int Value;

      static RendererInstanceId()
      {
        Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.RendererInstanceId>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid>.NativeClassPtr, nameof (RendererInstanceId));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.RendererInstanceId>.NativeClassPtr);
        MaterialChangeSystem_Hybrid.RendererInstanceId.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.RendererInstanceId>.NativeClassPtr, nameof (Value));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialChangeSystem_Hybrid.RendererInstanceId>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
