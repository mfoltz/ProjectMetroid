// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridModelRendererComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using ProjectM.ContentTesting;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM.Hybrid
{
  public class HybridModelRendererComponent : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__RendererAndTag;
    private static readonly System.IntPtr NativeFieldInfoPtr__Block;
    private static readonly System.IntPtr NativeFieldInfoPtr__DynamicBlock;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultRendererTag;
    private static readonly System.IntPtr NativeFieldInfoPtr__RendererChangeVersion_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__NestedRenderers;
    private static readonly System.IntPtr NativeFieldInfoPtr_Masks;
    private static readonly System.IntPtr NativeFieldInfoPtr_OriginalMaterials;
    private static readonly System.IntPtr NativeFieldInfoPtr_Renderers;
    private static readonly System.IntPtr NativeFieldInfoPtr__CustomizationTags;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastLineOfSightVisibility;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastUpdatedAlpha;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleObjectDyeProperties;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomizationColors;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_EmissiveColor;
    private static readonly System.IntPtr NativeFieldInfoPtr__NPCCustomizationTags;
    private static readonly System.IntPtr NativeFieldInfoPtr_NPCCustomizationColors;
    private static readonly System.IntPtr NativeFieldInfoPtr_SkinColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_HairColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_EyeColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExtraColor;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RendererChangeVersion_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RendererChangeVersion_Private_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetMaterialVisible_Public_Void_Renderer_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetMaterialVisibleInternal_Private_Void_Renderer_Boolean_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetLineOfSightVisible_Public_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetOccludedState_Public_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHybridFading_Public_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RestoreMaterial_Public_Void_Renderer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetOriginalMaterialForRendererNotNested_Public_Void_Renderer_Material_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RestoreMaterialInternal_Private_Void_Renderer_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddOtherPropertiesToBlock_Public_Void_Renderer_MaterialPropertyBlock_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCastleDyeProperties_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCastleDyePropertiesToBlock_Private_Void_MaterialPropertyBlock_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCustomizationColors_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomizationColorToBlock_Private_Void_HybridRendererCustomizationTagEnum_MaterialPropertyBlock_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddOtherNPCPropertiesToBlock_Public_Void_Renderer_MaterialPropertyBlock_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateNPCCustomizationColors_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetNPCCustomizationColorToBlock_Private_Void_HybridRendererNPCCustomizationTagEnum_MaterialPropertyBlock_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddHybridRenderer_Public_Void_HybridModelRendererComponent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveHybridRenderer_Public_Void_HybridModelRendererComponent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOriginalMaterialForRenderer_Public_Material_Renderer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllRenderers_Public_Void_List_1_Renderer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllMasks_Public_Void_List_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderersWithMask_Public_Void_List_1_Renderer_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RendererExists_Private_Boolean_Renderer_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderTags_Public_Void_List_1_RendererAndTag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRendererAndTags_Private_Static_Void_Transform_RendererTagAsset_List_1_RendererAndTag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Test_Public_Static_Void_TestContext_1_GameObject_List_1_ContentIssue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe int RendererChangeVersion
    {
      [CallerCount(36), CachedScanResults(RefRangeStart = 29682, RefRangeEnd = 29718, XrefRangeStart = 29682, XrefRangeEnd = 29718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_get_RendererChangeVersion_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_set_RendererChangeVersion_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796151, XrefRangeEnd = 796257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 796262, RefRangeEnd = 796264, XrefRangeStart = 796257, XrefRangeEnd = 796262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetMaterialVisible(Renderer changeRenderer, bool materialVisible)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) changeRenderer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &materialVisible;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_SetMaterialVisible_Public_Void_Renderer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 796274, RefRangeEnd = 796275, XrefRangeStart = 796264, XrefRangeEnd = 796274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetMaterialVisibleInternal(
      Renderer changeRenderer,
      bool materialVisible,
      out bool foundRenderer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) changeRenderer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &materialVisible;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref foundRenderer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_SetMaterialVisibleInternal_Private_Void_Renderer_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 796300, RefRangeEnd = 796303, XrefRangeStart = 796275, XrefRangeEnd = 796300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetLineOfSightVisible(bool visible)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &visible;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_SetLineOfSightVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 796321, RefRangeEnd = 796323, XrefRangeStart = 796303, XrefRangeEnd = 796321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetOccludedState(bool occluded)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &occluded;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_SetOccludedState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 796364, RefRangeEnd = 796366, XrefRangeStart = 796323, XrefRangeEnd = 796364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateHybridFading(float alpha)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &alpha;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_UpdateHybridFading_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 796368, RefRangeEnd = 796370, XrefRangeStart = 796366, XrefRangeEnd = 796368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RestoreMaterial(Renderer renderer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_RestoreMaterial_Public_Void_Renderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 796376, RefRangeEnd = 796378, XrefRangeStart = 796370, XrefRangeEnd = 796376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetOriginalMaterialForRendererNotNested(Renderer renderer, Material material)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_SetOriginalMaterialForRendererNotNested_Public_Void_Renderer_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 796389, RefRangeEnd = 796390, XrefRangeStart = 796378, XrefRangeEnd = 796389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RestoreMaterialInternal(Renderer renderer, out bool foundRenderer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref foundRenderer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_RestoreMaterialInternal_Private_Void_Renderer_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 796396, RefRangeEnd = 796398, XrefRangeStart = 796390, XrefRangeEnd = 796396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddOtherPropertiesToBlock(
      Renderer renderer,
      MaterialPropertyBlock block,
      int rendererIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) block);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rendererIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_AddOtherPropertiesToBlock_Public_Void_Renderer_MaterialPropertyBlock_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 796433, RefRangeEnd = 796436, XrefRangeStart = 796398, XrefRangeEnd = 796433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateCastleDyeProperties()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_UpdateCastleDyeProperties_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 796453, RefRangeEnd = 796456, XrefRangeStart = 796436, XrefRangeEnd = 796453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetCastleDyePropertiesToBlock(MaterialPropertyBlock block, int rendererIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) block);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rendererIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_SetCastleDyePropertiesToBlock_Private_Void_MaterialPropertyBlock_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 796489, RefRangeEnd = 796495, XrefRangeStart = 796456, XrefRangeEnd = 796489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateCustomizationColors()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_UpdateCustomizationColors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 796508, RefRangeEnd = 796511, XrefRangeStart = 796495, XrefRangeEnd = 796508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetCustomizationColorToBlock(
      HybridRendererCustomizationTagEnum customizationTags,
      MaterialPropertyBlock block)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &customizationTags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) block);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_SetCustomizationColorToBlock_Private_Void_HybridRendererCustomizationTagEnum_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796511, XrefRangeEnd = 796517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddOtherNPCPropertiesToBlock(
      Renderer renderer,
      MaterialPropertyBlock block,
      int rendererIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) block);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rendererIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_AddOtherNPCPropertiesToBlock_Public_Void_Renderer_MaterialPropertyBlock_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 796550, RefRangeEnd = 796552, XrefRangeStart = 796517, XrefRangeEnd = 796550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateNPCCustomizationColors()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_UpdateNPCCustomizationColors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 796569, RefRangeEnd = 796570, XrefRangeStart = 796552, XrefRangeEnd = 796569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetNPCCustomizationColorToBlock(
      HybridRendererNPCCustomizationTagEnum customizationTags,
      MaterialPropertyBlock block)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &customizationTags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) block);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_SetNPCCustomizationColorToBlock_Private_Void_HybridRendererNPCCustomizationTagEnum_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 796575, RefRangeEnd = 796576, XrefRangeStart = 796570, XrefRangeEnd = 796575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddHybridRenderer(HybridModelRendererComponent hybridRenderer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hybridRenderer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_AddHybridRenderer_Public_Void_HybridModelRendererComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 796579, RefRangeEnd = 796581, XrefRangeStart = 796576, XrefRangeEnd = 796579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveHybridRenderer(HybridModelRendererComponent hybridRenderer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hybridRenderer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_RemoveHybridRenderer_Public_Void_HybridModelRendererComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 796590, RefRangeEnd = 796593, XrefRangeStart = 796581, XrefRangeEnd = 796590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Material GetOriginalMaterialForRenderer(Renderer renderer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderer);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_GetOriginalMaterialForRenderer_Public_Material_Renderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 796613, RefRangeEnd = 796618, XrefRangeStart = 796593, XrefRangeEnd = 796613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetAllRenderers(List<Renderer> renderers)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderers);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_GetAllRenderers_Public_Void_List_1_Renderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 796638, RefRangeEnd = 796640, XrefRangeStart = 796618, XrefRangeEnd = 796638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetAllMasks(List<int> masks)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) masks);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_GetAllMasks_Public_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 796660, RefRangeEnd = 796664, XrefRangeStart = 796640, XrefRangeEnd = 796660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetRenderersWithMask(List<Renderer> renderers, int rendererTagMask)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderers);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rendererTagMask;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_GetRenderersWithMask_Public_Void_List_1_Renderer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 796671, RefRangeEnd = 796677, XrefRangeStart = 796664, XrefRangeEnd = 796671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool RendererExists(Renderer renderer, int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_RendererExists_Private_Boolean_Renderer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796677, XrefRangeEnd = 796682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetRenderTags(
      List<HybridModelRendererComponent.RendererAndTag> renderers)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderers);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_GetRenderTags_Public_Void_List_1_RendererAndTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 796700, RefRangeEnd = 796703, XrefRangeStart = 796682, XrefRangeEnd = 796700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetRendererAndTags(
      Transform transform,
      RendererTagAsset currentTag,
      List<HybridModelRendererComponent.RendererAndTag> renderers)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentTag);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderers);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_GetRendererAndTags_Private_Static_Void_Transform_RendererTagAsset_List_1_RendererAndTag_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796703, XrefRangeEnd = 796705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void AddComponent(
      World world,
      PrefabLookupMap prefabLookupMap,
      Entity hybridEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hybridEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Test(TestContext<GameObject> context, List<ContentIssue> outIssues)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr_Test_Public_Static_Void_TestContext_1_GameObject_List_1_ContentIssue_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796705, XrefRangeEnd = 796719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridModelRendererComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridModelRendererComponent()
    {
      Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Hybrid", nameof (HybridModelRendererComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr);
      HybridModelRendererComponent.NativeFieldInfoPtr__RendererAndTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (_RendererAndTag));
      HybridModelRendererComponent.NativeFieldInfoPtr__Block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (_Block));
      HybridModelRendererComponent.NativeFieldInfoPtr__DynamicBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (_DynamicBlock));
      HybridModelRendererComponent.NativeFieldInfoPtr_DefaultRendererTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (DefaultRendererTag));
      HybridModelRendererComponent.NativeFieldInfoPtr__RendererChangeVersion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, "<RendererChangeVersion>k__BackingField");
      HybridModelRendererComponent.NativeFieldInfoPtr__NestedRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (_NestedRenderers));
      HybridModelRendererComponent.NativeFieldInfoPtr_Masks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (Masks));
      HybridModelRendererComponent.NativeFieldInfoPtr_OriginalMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (OriginalMaterials));
      HybridModelRendererComponent.NativeFieldInfoPtr_Renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (Renderers));
      HybridModelRendererComponent.NativeFieldInfoPtr__CustomizationTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (_CustomizationTags));
      HybridModelRendererComponent.NativeFieldInfoPtr__LastLineOfSightVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (_LastLineOfSightVisibility));
      HybridModelRendererComponent.NativeFieldInfoPtr__LastUpdatedAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (_LastUpdatedAlpha));
      HybridModelRendererComponent.NativeFieldInfoPtr_CastleObjectDyeProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (CastleObjectDyeProperties));
      HybridModelRendererComponent.NativeFieldInfoPtr_CustomizationColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (CustomizationColors));
      HybridModelRendererComponent.NativeFieldInfoPtr_BaseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (BaseColor));
      HybridModelRendererComponent.NativeFieldInfoPtr_EmissiveColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (EmissiveColor));
      HybridModelRendererComponent.NativeFieldInfoPtr__NPCCustomizationTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (_NPCCustomizationTags));
      HybridModelRendererComponent.NativeFieldInfoPtr_NPCCustomizationColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (NPCCustomizationColors));
      HybridModelRendererComponent.NativeFieldInfoPtr_SkinColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (SkinColor));
      HybridModelRendererComponent.NativeFieldInfoPtr_HairColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (HairColor));
      HybridModelRendererComponent.NativeFieldInfoPtr_EyeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (EyeColor));
      HybridModelRendererComponent.NativeFieldInfoPtr_ExtraColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (ExtraColor));
      HybridModelRendererComponent.NativeMethodInfoPtr_get_RendererChangeVersion_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670262);
      HybridModelRendererComponent.NativeMethodInfoPtr_set_RendererChangeVersion_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670263);
      HybridModelRendererComponent.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670264);
      HybridModelRendererComponent.NativeMethodInfoPtr_SetMaterialVisible_Public_Void_Renderer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670265);
      HybridModelRendererComponent.NativeMethodInfoPtr_SetMaterialVisibleInternal_Private_Void_Renderer_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670266);
      HybridModelRendererComponent.NativeMethodInfoPtr_SetLineOfSightVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670267);
      HybridModelRendererComponent.NativeMethodInfoPtr_SetOccludedState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670268);
      HybridModelRendererComponent.NativeMethodInfoPtr_UpdateHybridFading_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670269);
      HybridModelRendererComponent.NativeMethodInfoPtr_RestoreMaterial_Public_Void_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670270);
      HybridModelRendererComponent.NativeMethodInfoPtr_SetOriginalMaterialForRendererNotNested_Public_Void_Renderer_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670271);
      HybridModelRendererComponent.NativeMethodInfoPtr_RestoreMaterialInternal_Private_Void_Renderer_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670272);
      HybridModelRendererComponent.NativeMethodInfoPtr_AddOtherPropertiesToBlock_Public_Void_Renderer_MaterialPropertyBlock_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670273);
      HybridModelRendererComponent.NativeMethodInfoPtr_UpdateCastleDyeProperties_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670274);
      HybridModelRendererComponent.NativeMethodInfoPtr_SetCastleDyePropertiesToBlock_Private_Void_MaterialPropertyBlock_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670275);
      HybridModelRendererComponent.NativeMethodInfoPtr_UpdateCustomizationColors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670276);
      HybridModelRendererComponent.NativeMethodInfoPtr_SetCustomizationColorToBlock_Private_Void_HybridRendererCustomizationTagEnum_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670277);
      HybridModelRendererComponent.NativeMethodInfoPtr_AddOtherNPCPropertiesToBlock_Public_Void_Renderer_MaterialPropertyBlock_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670278);
      HybridModelRendererComponent.NativeMethodInfoPtr_UpdateNPCCustomizationColors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670279);
      HybridModelRendererComponent.NativeMethodInfoPtr_SetNPCCustomizationColorToBlock_Private_Void_HybridRendererNPCCustomizationTagEnum_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670280);
      HybridModelRendererComponent.NativeMethodInfoPtr_AddHybridRenderer_Public_Void_HybridModelRendererComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670281);
      HybridModelRendererComponent.NativeMethodInfoPtr_RemoveHybridRenderer_Public_Void_HybridModelRendererComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670282);
      HybridModelRendererComponent.NativeMethodInfoPtr_GetOriginalMaterialForRenderer_Public_Material_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670283);
      HybridModelRendererComponent.NativeMethodInfoPtr_GetAllRenderers_Public_Void_List_1_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670284);
      HybridModelRendererComponent.NativeMethodInfoPtr_GetAllMasks_Public_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670285);
      HybridModelRendererComponent.NativeMethodInfoPtr_GetRenderersWithMask_Public_Void_List_1_Renderer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670286);
      HybridModelRendererComponent.NativeMethodInfoPtr_RendererExists_Private_Boolean_Renderer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670287);
      HybridModelRendererComponent.NativeMethodInfoPtr_GetRenderTags_Public_Void_List_1_RendererAndTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670288);
      HybridModelRendererComponent.NativeMethodInfoPtr_GetRendererAndTags_Private_Static_Void_Transform_RendererTagAsset_List_1_RendererAndTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670289);
      HybridModelRendererComponent.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670290);
      HybridModelRendererComponent.NativeMethodInfoPtr_Test_Public_Static_Void_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670291);
      HybridModelRendererComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, 100670292);
    }

    public HybridModelRendererComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe List<HybridModelRendererComponent.RendererAndTag> _RendererAndTag
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(HybridModelRendererComponent.NativeFieldInfoPtr__RendererAndTag, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<HybridModelRendererComponent.RendererAndTag>) null : new List<HybridModelRendererComponent.RendererAndTag>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HybridModelRendererComponent.NativeFieldInfoPtr__RendererAndTag, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe MaterialPropertyBlock _Block
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(HybridModelRendererComponent.NativeFieldInfoPtr__Block, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (MaterialPropertyBlock) null : new MaterialPropertyBlock(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HybridModelRendererComponent.NativeFieldInfoPtr__Block, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe MaterialPropertyBlock _DynamicBlock
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(HybridModelRendererComponent.NativeFieldInfoPtr__DynamicBlock, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (MaterialPropertyBlock) null : new MaterialPropertyBlock(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HybridModelRendererComponent.NativeFieldInfoPtr__DynamicBlock, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RendererTagAsset DefaultRendererTag
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr_DefaultRendererTag));
        return pointer == System.IntPtr.Zero ? (RendererTagAsset) null : new RendererTagAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr_DefaultRendererTag), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _RendererChangeVersion_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr__RendererChangeVersion_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr__RendererChangeVersion_k__BackingField)) = value;
      }
    }

    public unsafe List<HybridModelRendererComponent> _NestedRenderers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr__NestedRenderers));
        return pointer == System.IntPtr.Zero ? (List<HybridModelRendererComponent>) null : new List<HybridModelRendererComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr__NestedRenderers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<int> Masks
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr_Masks));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr_Masks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<HybridModelRendererComponent.OriginalMaterial> OriginalMaterials
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr_OriginalMaterials));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<HybridModelRendererComponent.OriginalMaterial>) null : new Il2CppReferenceArray<HybridModelRendererComponent.OriginalMaterial>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr_OriginalMaterials), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<HybridModelRendererComponent.RendererData> Renderers
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr_Renderers));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<HybridModelRendererComponent.RendererData>) null : new Il2CppReferenceArray<HybridModelRendererComponent.RendererData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr_Renderers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<HybridRendererCustomizationTagEnum> _CustomizationTags
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr__CustomizationTags));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<HybridRendererCustomizationTagEnum>) null : new Il2CppStructArray<HybridRendererCustomizationTagEnum>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr__CustomizationTags), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Nullable_Unboxed<bool> _LastLineOfSightVisibility
    {
      get
      {
        return *(Nullable_Unboxed<bool>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr__LastLineOfSightVisibility));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr__LastLineOfSightVisibility), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<float> _LastUpdatedAlpha
    {
      get
      {
        return *(Nullable_Unboxed<float>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr__LastUpdatedAlpha));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr__LastUpdatedAlpha), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe CastleObjectDyeProperties CastleObjectDyeProperties
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr_CastleObjectDyeProperties));
        return pointer == System.IntPtr.Zero ? (CastleObjectDyeProperties) null : new CastleObjectDyeProperties(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr_CastleObjectDyeProperties), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomizationColors CustomizationColors
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr_CustomizationColors));
        return pointer == System.IntPtr.Zero ? (CustomizationColors) null : new CustomizationColors(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr_CustomizationColors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe int BaseColor
    {
      get
      {
        int baseColor;
        IL2CPP.il2cpp_field_static_get_value(HybridModelRendererComponent.NativeFieldInfoPtr_BaseColor, (void*) &baseColor);
        return baseColor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HybridModelRendererComponent.NativeFieldInfoPtr_BaseColor, (void*) &value);
      }
    }

    public static unsafe int EmissiveColor
    {
      get
      {
        int emissiveColor;
        IL2CPP.il2cpp_field_static_get_value(HybridModelRendererComponent.NativeFieldInfoPtr_EmissiveColor, (void*) &emissiveColor);
        return emissiveColor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HybridModelRendererComponent.NativeFieldInfoPtr_EmissiveColor, (void*) &value);
      }
    }

    public unsafe Il2CppStructArray<HybridRendererNPCCustomizationTagEnum> _NPCCustomizationTags
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr__NPCCustomizationTags));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<HybridRendererNPCCustomizationTagEnum>) null : new Il2CppStructArray<HybridRendererNPCCustomizationTagEnum>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr__NPCCustomizationTags), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NPCCustomizationColors NPCCustomizationColors
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr_NPCCustomizationColors));
        return pointer == System.IntPtr.Zero ? (NPCCustomizationColors) null : new NPCCustomizationColors(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.NativeFieldInfoPtr_NPCCustomizationColors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe int SkinColor
    {
      get
      {
        int skinColor;
        IL2CPP.il2cpp_field_static_get_value(HybridModelRendererComponent.NativeFieldInfoPtr_SkinColor, (void*) &skinColor);
        return skinColor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HybridModelRendererComponent.NativeFieldInfoPtr_SkinColor, (void*) &value);
      }
    }

    public static unsafe int HairColor
    {
      get
      {
        int hairColor;
        IL2CPP.il2cpp_field_static_get_value(HybridModelRendererComponent.NativeFieldInfoPtr_HairColor, (void*) &hairColor);
        return hairColor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HybridModelRendererComponent.NativeFieldInfoPtr_HairColor, (void*) &value);
      }
    }

    public static unsafe int EyeColor
    {
      get
      {
        int eyeColor;
        IL2CPP.il2cpp_field_static_get_value(HybridModelRendererComponent.NativeFieldInfoPtr_EyeColor, (void*) &eyeColor);
        return eyeColor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HybridModelRendererComponent.NativeFieldInfoPtr_EyeColor, (void*) &value);
      }
    }

    public static unsafe int ExtraColor
    {
      get
      {
        int extraColor;
        IL2CPP.il2cpp_field_static_get_value(HybridModelRendererComponent.NativeFieldInfoPtr_ExtraColor, (void*) &extraColor);
        return extraColor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HybridModelRendererComponent.NativeFieldInfoPtr_ExtraColor, (void*) &value);
      }
    }

    public sealed class RendererAndTag : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Renderer;
      private static readonly System.IntPtr NativeFieldInfoPtr_Tag;

      static RendererAndTag()
      {
        Il2CppClassPointerStore<HybridModelRendererComponent.RendererAndTag>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (RendererAndTag));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelRendererComponent.RendererAndTag>.NativeClassPtr);
        HybridModelRendererComponent.RendererAndTag.NativeFieldInfoPtr_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent.RendererAndTag>.NativeClassPtr, nameof (Renderer));
        HybridModelRendererComponent.RendererAndTag.NativeFieldInfoPtr_Tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent.RendererAndTag>.NativeClassPtr, nameof (Tag));
      }

      public RendererAndTag(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public RendererAndTag()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HybridModelRendererComponent.RendererAndTag>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelRendererComponent.RendererAndTag>.NativeClassPtr, data));
      }

      public unsafe Renderer Renderer
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.RendererAndTag.NativeFieldInfoPtr_Renderer));
          return pointer == System.IntPtr.Zero ? (Renderer) null : new Renderer(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.RendererAndTag.NativeFieldInfoPtr_Renderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe RendererTagAsset Tag
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.RendererAndTag.NativeFieldInfoPtr_Tag));
          return pointer == System.IntPtr.Zero ? (RendererTagAsset) null : new RendererTagAsset(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.RendererAndTag.NativeFieldInfoPtr_Tag), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public sealed class OriginalMaterial : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Renderer;
      private static readonly System.IntPtr NativeFieldInfoPtr_Material;
      private static readonly System.IntPtr NativeFieldInfoPtr_ShadowCastingMode;

      static OriginalMaterial()
      {
        Il2CppClassPointerStore<HybridModelRendererComponent.OriginalMaterial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (OriginalMaterial));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelRendererComponent.OriginalMaterial>.NativeClassPtr);
        HybridModelRendererComponent.OriginalMaterial.NativeFieldInfoPtr_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent.OriginalMaterial>.NativeClassPtr, nameof (Renderer));
        HybridModelRendererComponent.OriginalMaterial.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent.OriginalMaterial>.NativeClassPtr, nameof (Material));
        HybridModelRendererComponent.OriginalMaterial.NativeFieldInfoPtr_ShadowCastingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent.OriginalMaterial>.NativeClassPtr, nameof (ShadowCastingMode));
      }

      public OriginalMaterial(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public OriginalMaterial()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HybridModelRendererComponent.OriginalMaterial>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelRendererComponent.OriginalMaterial>.NativeClassPtr, data));
      }

      public unsafe Renderer Renderer
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.OriginalMaterial.NativeFieldInfoPtr_Renderer));
          return pointer == System.IntPtr.Zero ? (Renderer) null : new Renderer(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.OriginalMaterial.NativeFieldInfoPtr_Renderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Material Material
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.OriginalMaterial.NativeFieldInfoPtr_Material));
          return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.OriginalMaterial.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ShadowCastingMode ShadowCastingMode
      {
        get
        {
          return *(ShadowCastingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.OriginalMaterial.NativeFieldInfoPtr_ShadowCastingMode));
        }
        [param: In] set
        {
          *(ShadowCastingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.OriginalMaterial.NativeFieldInfoPtr_ShadowCastingMode)) = value;
        }
      }
    }

    public sealed class RendererData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Renderer;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsLineOfSightVisible;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsMaterialVisible;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetLineOfSightVisible_Public_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetMaterialVisible_Public_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVisibiltiy_Private_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 796143, RefRangeEnd = 796144, XrefRangeStart = 796141, XrefRangeEnd = 796143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetLineOfSightVisible(bool newValue)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &newValue;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.RendererData.NativeMethodInfoPtr_SetLineOfSightVisible_Public_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 796147, RefRangeEnd = 796148, XrefRangeStart = 796144, XrefRangeEnd = 796147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetMaterialVisible(bool newValue)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &newValue;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.RendererData.NativeMethodInfoPtr_SetMaterialVisible_Public_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796148, XrefRangeEnd = 796151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdateVisibiltiy()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelRendererComponent.RendererData.NativeMethodInfoPtr_UpdateVisibiltiy_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RendererData()
      {
        Il2CppClassPointerStore<HybridModelRendererComponent.RendererData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridModelRendererComponent>.NativeClassPtr, nameof (RendererData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelRendererComponent.RendererData>.NativeClassPtr);
        HybridModelRendererComponent.RendererData.NativeFieldInfoPtr_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent.RendererData>.NativeClassPtr, nameof (Renderer));
        HybridModelRendererComponent.RendererData.NativeFieldInfoPtr_IsLineOfSightVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent.RendererData>.NativeClassPtr, nameof (IsLineOfSightVisible));
        HybridModelRendererComponent.RendererData.NativeFieldInfoPtr_IsMaterialVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelRendererComponent.RendererData>.NativeClassPtr, nameof (IsMaterialVisible));
        HybridModelRendererComponent.RendererData.NativeMethodInfoPtr_SetLineOfSightVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent.RendererData>.NativeClassPtr, 100670294);
        HybridModelRendererComponent.RendererData.NativeMethodInfoPtr_SetMaterialVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent.RendererData>.NativeClassPtr, 100670295);
        HybridModelRendererComponent.RendererData.NativeMethodInfoPtr_UpdateVisibiltiy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelRendererComponent.RendererData>.NativeClassPtr, 100670296);
      }

      public RendererData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public RendererData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HybridModelRendererComponent.RendererData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelRendererComponent.RendererData>.NativeClassPtr, data));
      }

      public unsafe Renderer Renderer
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.RendererData.NativeFieldInfoPtr_Renderer));
          return pointer == System.IntPtr.Zero ? (Renderer) null : new Renderer(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.RendererData.NativeFieldInfoPtr_Renderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool IsLineOfSightVisible
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.RendererData.NativeFieldInfoPtr_IsLineOfSightVisible));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.RendererData.NativeFieldInfoPtr_IsLineOfSightVisible)) = value;
        }
      }

      public unsafe bool IsMaterialVisible
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.RendererData.NativeFieldInfoPtr_IsMaterialVisible));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelRendererComponent.RendererData.NativeFieldInfoPtr_IsMaterialVisible)) = value;
        }
      }
    }
  }
}
