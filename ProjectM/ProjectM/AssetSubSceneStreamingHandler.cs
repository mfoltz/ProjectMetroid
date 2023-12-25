// Decompiled with JetBrains decompiler
// Type: ProjectM.AssetSubSceneStreamingHandler
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Scenes;

#nullable disable
namespace ProjectM
{
  public class AssetSubSceneStreamingHandler : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__UseSubScenes_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__KeepAllAssetsLoaded;
    private static readonly System.IntPtr NativeFieldInfoPtr__SubSceneEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__SceneSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SectionsLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr__AssetSectionLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReferenceManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__ActiveTokenLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr___FindSectionsLookup_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___FindSectionsLookup_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterLoadedSceneScenes_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterLoadedSceneScenes_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSubSceneGUID_Protected_Abstract_Virtual_New_SubSceneGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UseSubScenes_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UseSubScenes_Private_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClaimToken_Public_AssetReferenceToken_AssetGuid_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseToken_Public_Boolean_AssetReferenceToken_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MarkUsedThisFrame_Public_Void_AssetGuid_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MarkEverythingUsedThisFrame_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAsset_Public_Boolean_AssetGuid_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EnsureSectionLoadRequest_Private_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetLoadAndKeepAllAssetsLoaded_Protected_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpStreamingState_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetQuickDebugState_Public_Void_byref_Int32_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForFindSectionsLookup_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegisterLoadedSceneScenes_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    public virtual unsafe SubSceneGUID GetSubSceneGUID()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AssetSubSceneStreamingHandler.NativeMethodInfoPtr_GetSubSceneGUID_Protected_Abstract_Virtual_New_SubSceneGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SubSceneGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    public unsafe bool UseSubScenes
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.NativeMethodInfoPtr_get_UseSubScenes_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.NativeMethodInfoPtr_set_UseSubScenes_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1073368, RefRangeEnd = 1073370, XrefRangeStart = 1073357, XrefRangeEnd = 1073368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AssetSubSceneStreamingHandler.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073370, XrefRangeEnd = 1073376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AssetSubSceneStreamingHandler.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1073396, RefRangeEnd = 1073400, XrefRangeStart = 1073376, XrefRangeEnd = 1073396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AssetReferenceToken ClaimToken(AssetGuid assetGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &assetGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.NativeMethodInfoPtr_ClaimToken_Public_AssetReferenceToken_AssetGuid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AssetReferenceToken*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1073422, RefRangeEnd = 1073428, XrefRangeStart = 1073400, XrefRangeEnd = 1073422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ReleaseToken(AssetReferenceToken token)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &token;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.NativeMethodInfoPtr_ReleaseToken_Public_Boolean_AssetReferenceToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1073442, RefRangeEnd = 1073443, XrefRangeStart = 1073428, XrefRangeEnd = 1073442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void MarkUsedThisFrame(AssetGuid assetGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &assetGuid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.NativeMethodInfoPtr_MarkUsedThisFrame_Public_Void_AssetGuid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1073461, RefRangeEnd = 1073463, XrefRangeStart = 1073443, XrefRangeEnd = 1073461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void MarkEverythingUsedThisFrame()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.NativeMethodInfoPtr_MarkEverythingUsedThisFrame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 1073496, RefRangeEnd = 1073513, XrefRangeStart = 1073463, XrefRangeEnd = 1073496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetAsset<T>(AssetGuid assetGuid, out T asset) where T : UnityEngine.Object
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &assetGuid;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref asset;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.MethodInfoStoreGeneric_TryGetAsset_Public_Boolean_AssetGuid_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref asset;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1073522, RefRangeEnd = 1073526, XrefRangeStart = 1073513, XrefRangeEnd = 1073522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EnsureSectionLoadRequest(Entity sectionEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &sectionEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.NativeMethodInfoPtr_EnsureSectionLoadRequest_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1073527, RefRangeEnd = 1073528, XrefRangeStart = 1073526, XrefRangeEnd = 1073527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetLoadAndKeepAllAssetsLoaded(bool loadAllAssets)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &loadAllAssets;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.NativeMethodInfoPtr_SetLoadAndKeepAllAssetsLoaded_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1073589, RefRangeEnd = 1073590, XrefRangeStart = 1073528, XrefRangeEnd = 1073589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AssetSubSceneStreamingHandler.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1073699, RefRangeEnd = 1073704, XrefRangeStart = 1073590, XrefRangeEnd = 1073699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpStreamingState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.NativeMethodInfoPtr_DumpStreamingState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073704, XrefRangeEnd = 1073722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetQuickDebugState(out int totalSections, out int loadedSections)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref totalSections;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref loadedSections;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.NativeMethodInfoPtr_GetQuickDebugState_Public_Void_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1073730, RefRangeEnd = 1073733, XrefRangeStart = 1073722, XrefRangeEnd = 1073730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AssetSubSceneStreamingHandler()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1073769, RefRangeEnd = 1073772, XrefRangeStart = 1073733, XrefRangeEnd = 1073769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AssetSubSceneStreamingHandler.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073772, XrefRangeEnd = 1073791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForFindSectionsLookup_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.NativeMethodInfoPtr___GetEntityQuery_ForFindSectionsLookup_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1073816, RefRangeEnd = 1073817, XrefRangeStart = 1073791, XrefRangeEnd = 1073816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegisterLoadedSceneScenes_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.NativeMethodInfoPtr___GetEntityQuery_ForRegisterLoadedSceneScenes_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AssetSubSceneStreamingHandler()
    {
      Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AssetSubSceneStreamingHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr);
      AssetSubSceneStreamingHandler.NativeFieldInfoPtr__UseSubScenes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, "<UseSubScenes>k__BackingField");
      AssetSubSceneStreamingHandler.NativeFieldInfoPtr__KeepAllAssetsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, nameof (_KeepAllAssetsLoaded));
      AssetSubSceneStreamingHandler.NativeFieldInfoPtr__SubSceneEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, nameof (_SubSceneEntity));
      AssetSubSceneStreamingHandler.NativeFieldInfoPtr__SceneSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, nameof (_SceneSystem));
      AssetSubSceneStreamingHandler.NativeFieldInfoPtr__SectionsLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, nameof (_SectionsLookup));
      AssetSubSceneStreamingHandler.NativeFieldInfoPtr__AssetSectionLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, nameof (_AssetSectionLookup));
      AssetSubSceneStreamingHandler.NativeFieldInfoPtr__ReferenceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, nameof (_ReferenceManager));
      AssetSubSceneStreamingHandler.NativeFieldInfoPtr__ActiveTokenLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, nameof (_ActiveTokenLookup));
      AssetSubSceneStreamingHandler.NativeFieldInfoPtr___FindSectionsLookup_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, "<>FindSectionsLookup_entityQuery");
      AssetSubSceneStreamingHandler.NativeFieldInfoPtr___FindSectionsLookup_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, "<>FindSectionsLookup_profilerMarker");
      AssetSubSceneStreamingHandler.NativeFieldInfoPtr___RegisterLoadedSceneScenes_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, "<>RegisterLoadedSceneScenes_entityQuery");
      AssetSubSceneStreamingHandler.NativeFieldInfoPtr___RegisterLoadedSceneScenes_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, "<>RegisterLoadedSceneScenes_profilerMarker");
      AssetSubSceneStreamingHandler.NativeMethodInfoPtr_GetSubSceneGUID_Protected_Abstract_Virtual_New_SubSceneGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, 100684563);
      AssetSubSceneStreamingHandler.NativeMethodInfoPtr_get_UseSubScenes_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, 100684564);
      AssetSubSceneStreamingHandler.NativeMethodInfoPtr_set_UseSubScenes_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, 100684565);
      AssetSubSceneStreamingHandler.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, 100684566);
      AssetSubSceneStreamingHandler.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, 100684567);
      AssetSubSceneStreamingHandler.NativeMethodInfoPtr_ClaimToken_Public_AssetReferenceToken_AssetGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, 100684568);
      AssetSubSceneStreamingHandler.NativeMethodInfoPtr_ReleaseToken_Public_Boolean_AssetReferenceToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, 100684569);
      AssetSubSceneStreamingHandler.NativeMethodInfoPtr_MarkUsedThisFrame_Public_Void_AssetGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, 100684570);
      AssetSubSceneStreamingHandler.NativeMethodInfoPtr_MarkEverythingUsedThisFrame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, 100684571);
      AssetSubSceneStreamingHandler.NativeMethodInfoPtr_TryGetAsset_Public_Boolean_AssetGuid_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, 100684572);
      AssetSubSceneStreamingHandler.NativeMethodInfoPtr_EnsureSectionLoadRequest_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, 100684573);
      AssetSubSceneStreamingHandler.NativeMethodInfoPtr_SetLoadAndKeepAllAssetsLoaded_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, 100684574);
      AssetSubSceneStreamingHandler.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, 100684575);
      AssetSubSceneStreamingHandler.NativeMethodInfoPtr_DumpStreamingState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, 100684576);
      AssetSubSceneStreamingHandler.NativeMethodInfoPtr_GetQuickDebugState_Public_Void_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, 100684577);
      AssetSubSceneStreamingHandler.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, 100684578);
      AssetSubSceneStreamingHandler.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, 100684579);
      AssetSubSceneStreamingHandler.NativeMethodInfoPtr___GetEntityQuery_ForFindSectionsLookup_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, 100684580);
      AssetSubSceneStreamingHandler.NativeMethodInfoPtr___GetEntityQuery_ForRegisterLoadedSceneScenes_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, 100684581);
    }

    public AssetSubSceneStreamingHandler(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool _UseSubScenes_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr__UseSubScenes_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr__UseSubScenes_k__BackingField)) = value;
      }
    }

    public unsafe bool _KeepAllAssetsLoaded
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr__KeepAllAssetsLoaded));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr__KeepAllAssetsLoaded)) = value;
      }
    }

    public unsafe Entity _SubSceneEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr__SubSceneEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr__SubSceneEntity)) = value;
      }
    }

    public unsafe SceneSystem _SceneSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr__SceneSystem));
        return pointer == System.IntPtr.Zero ? (SceneSystem) null : new SceneSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr__SceneSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ManagedAssetSections _SectionsLookup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr__SectionsLookup));
        return pointer == System.IntPtr.Zero ? (ManagedAssetSections) null : new ManagedAssetSections(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr__SectionsLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<AssetGuid, Entity> _AssetSectionLookup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr__AssetSectionLookup));
        return pointer == System.IntPtr.Zero ? (Dictionary<AssetGuid, Entity>) null : new Dictionary<AssetGuid, Entity>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr__AssetSectionLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ReferenceManager<Entity> _ReferenceManager
    {
      get
      {
        return *(ReferenceManager<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr__ReferenceManager));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr__ReferenceManager), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReferenceManager<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<ReferenceToken_Unboxed<Entity>, AssetGuid> _ActiveTokenLookup
    {
      get
      {
        return *(NativeHashMap<ReferenceToken_Unboxed<Entity>, AssetGuid>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr__ActiveTokenLookup));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr__ActiveTokenLookup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<ReferenceToken_Unboxed<Entity>, AssetGuid>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __FindSectionsLookup_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr___FindSectionsLookup_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr___FindSectionsLookup_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __FindSectionsLookup_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr___FindSectionsLookup_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr___FindSectionsLookup_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RegisterLoadedSceneScenes_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr___RegisterLoadedSceneScenes_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr___RegisterLoadedSceneScenes_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterLoadedSceneScenes_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr___RegisterLoadedSceneScenes_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.NativeFieldInfoPtr___RegisterLoadedSceneScenes_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Mapped
    {
      static Mapped()
      {
        Il2CppClassPointerStore<AssetSubSceneStreamingHandler.Mapped>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, nameof (Mapped));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.Mapped>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.Mapped>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.AssetSubSceneStreamingHandler/<>c__DisplayClass22_0")]
    public sealed class __c__DisplayClass22_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_subSceneGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_ManagedAssetSections_byref_SceneSection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_ManagedAssetReference_byref_SceneSection_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass22_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass22_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        ManagedAssetSections assetSections,
        [In] ref SceneSection SceneSection)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) assetSections);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref SceneSection;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.__c__DisplayClass22_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_ManagedAssetSections_byref_SceneSection_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ManagedAssetReference reference,
        [In] ref SceneSection SceneSection)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) reference);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref SceneSection;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.__c__DisplayClass22_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_ManagedAssetReference_byref_SceneSection_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass22_0()
      {
        Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, "<>c__DisplayClass22_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass22_0>.NativeClassPtr);
        AssetSubSceneStreamingHandler.__c__DisplayClass22_0.NativeFieldInfoPtr_subSceneGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass22_0>.NativeClassPtr, nameof (subSceneGUID));
        AssetSubSceneStreamingHandler.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass22_0>.NativeClassPtr, "<>4__this");
        AssetSubSceneStreamingHandler.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass22_0>.NativeClassPtr, 100684582);
        AssetSubSceneStreamingHandler.__c__DisplayClass22_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_ManagedAssetSections_byref_SceneSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass22_0>.NativeClassPtr, 100684583);
        AssetSubSceneStreamingHandler.__c__DisplayClass22_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_ManagedAssetReference_byref_SceneSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass22_0>.NativeClassPtr, 100684584);
      }

      public __c__DisplayClass22_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass22_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass22_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass22_0>.NativeClassPtr, data));
      }

      public unsafe SubSceneGUID subSceneGUID
      {
        get
        {
          return *(SubSceneGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass22_0.NativeFieldInfoPtr_subSceneGUID));
        }
        [param: In] set
        {
          *(SubSceneGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass22_0.NativeFieldInfoPtr_subSceneGUID)) = value;
        }
      }

      public unsafe AssetSubSceneStreamingHandler __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (AssetSubSceneStreamingHandler) null : new AssetSubSceneStreamingHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.AssetSubSceneStreamingHandler/ProjectM.<>c__DisplayClass_FindSectionsLookup")]
    public sealed class __c__DisplayClass_FindSectionsLookup : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_subSceneGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_ManagedAssetSections_byref_SceneSection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSubSceneStreamingHandler_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1073271, RefRangeEnd = 1073272, XrefRangeStart = 1073266, XrefRangeEnd = 1073271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ManagedAssetSections assetSections,
        [In] ref SceneSection SceneSection)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) assetSections);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref SceneSection;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_ManagedAssetSections_byref_SceneSection_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 742766, RefRangeEnd = 742768, XrefRangeStart = 742766, XrefRangeEnd = 742768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AssetSubSceneStreamingHandler.__c__DisplayClass22_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 735237, RefRangeEnd = 735248, XrefRangeStart = 735237, XrefRangeEnd = 735248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AssetSubSceneStreamingHandler.__c__DisplayClass22_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073272, XrefRangeEnd = 1073274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1073280, RefRangeEnd = 1073281, XrefRangeStart = 1073274, XrefRangeEnd = 1073280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) runtimes);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1073283, RefRangeEnd = 1073284, XrefRangeStart = 1073281, XrefRangeEnd = 1073283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AssetSubSceneStreamingHandler componentSystem,
        ref AssetSubSceneStreamingHandler.__c__DisplayClass22_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSubSceneStreamingHandler_byref___c__DisplayClass22_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073284, XrefRangeEnd = 1073290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_FindSectionsLookup()
      {
        Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, "<>c__DisplayClass_FindSectionsLookup");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup>.NativeClassPtr);
        AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeFieldInfoPtr_subSceneGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup>.NativeClassPtr, nameof (subSceneGUID));
        AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup>.NativeClassPtr, "<>4__this");
        AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup>.NativeClassPtr, nameof (_runtimes));
        AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_ManagedAssetSections_byref_SceneSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup>.NativeClassPtr, 100684585);
        AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup>.NativeClassPtr, 100684586);
        AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup>.NativeClassPtr, 100684587);
        AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup>.NativeClassPtr, 100684588);
        AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup>.NativeClassPtr, 100684589);
        AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSubSceneStreamingHandler_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup>.NativeClassPtr, 100684590);
        AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup>.NativeClassPtr, 100684591);
      }

      public __c__DisplayClass_FindSectionsLookup(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_FindSectionsLookup()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup>.NativeClassPtr, data));
      }

      public unsafe SubSceneGUID subSceneGUID
      {
        get
        {
          return *(SubSceneGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeFieldInfoPtr_subSceneGUID));
        }
        [param: In] set
        {
          *(SubSceneGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeFieldInfoPtr_subSceneGUID)) = value;
        }
      }

      public unsafe AssetSubSceneStreamingHandler __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (AssetSubSceneStreamingHandler) null : new AssetSubSceneStreamingHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_assetSections;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_SceneSection;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSubSceneStreamingHandler_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_ManagedComponentData<ManagedAssetSections> forParameter_assetSections;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_ISharedComponentData_Unboxed<SceneSection> forParameter_SceneSection;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1073257, RefRangeEnd = 1073258, XrefRangeStart = 1073251, XrefRangeEnd = 1073257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AssetSubSceneStreamingHandler componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSubSceneStreamingHandler_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1073265, RefRangeEnd = 1073266, XrefRangeStart = 1073258, XrefRangeEnd = 1073265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return new AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.Runtimes(pointer);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_assetSections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_assetSections));
          AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_SceneSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_SceneSection));
          AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSubSceneStreamingHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders>.NativeClassPtr, 100684592);
          AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders>.NativeClassPtr, 100684593);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public sealed class Runtimes : Il2CppSystem.ValueType
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_assetSections;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_SceneSection;

          static Runtimes()
          {
            Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_assetSections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_assetSections));
            AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_SceneSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_SceneSection));
          }

          public Runtimes(System.IntPtr pointer)
            : base(pointer)
          {
          }

          public Runtimes()
          {
            // ISSUE: cast to a reference type
            // ISSUE: untyped stack allocation
            System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            // ISSUE: explicit constructor call
            base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, data));
          }

          public LambdaParameterValueProvider_ManagedComponentData<ManagedAssetSections>.Runtime runtime_assetSections
          {
            get
            {
              System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_assetSections);
              return new LambdaParameterValueProvider_ManagedComponentData<ManagedAssetSections>.Runtime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<ManagedAssetSections>.Runtime>.NativeClassPtr, data));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_assetSections), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<ManagedAssetSections>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }

          public unsafe LambdaParameterValueProvider_ISharedComponentData_Unboxed<SceneSection>.Runtime_Unboxed_Unboxed runtime_SceneSection
          {
            get
            {
              return *(LambdaParameterValueProvider_ISharedComponentData_Unboxed<SceneSection>.Runtime_Unboxed_Unboxed*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_SceneSection));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass_FindSectionsLookup.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_SceneSection), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_ISharedComponentData_Unboxed<SceneSection>.Runtime_Unboxed_Unboxed>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AssetSubSceneStreamingHandler/ProjectM.<>c__DisplayClass_RegisterLoadedSceneScenes")]
    public sealed class __c__DisplayClass_RegisterLoadedSceneScenes : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_subSceneGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_ManagedAssetReference_byref_SceneSection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSubSceneStreamingHandler_byref___c__DisplayClass22_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1073335, RefRangeEnd = 1073336, XrefRangeStart = 1073306, XrefRangeEnd = 1073335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ManagedAssetReference reference,
        [In] ref SceneSection SceneSection)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) reference);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref SceneSection;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_ManagedAssetReference_byref_SceneSection_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AssetSubSceneStreamingHandler.__c__DisplayClass22_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 735237, RefRangeEnd = 735248, XrefRangeStart = 735237, XrefRangeEnd = 735248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AssetSubSceneStreamingHandler.__c__DisplayClass22_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073336, XrefRangeEnd = 1073350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1073356, RefRangeEnd = 1073357, XrefRangeStart = 1073350, XrefRangeEnd = 1073356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 735267, RefRangeEnd = 735275, XrefRangeStart = 735267, XrefRangeEnd = 735275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AssetSubSceneStreamingHandler componentSystem,
        ref AssetSubSceneStreamingHandler.__c__DisplayClass22_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSubSceneStreamingHandler_byref___c__DisplayClass22_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterLoadedSceneScenes()
      {
        Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr, "<>c__DisplayClass_RegisterLoadedSceneScenes");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes>.NativeClassPtr);
        AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeFieldInfoPtr_subSceneGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes>.NativeClassPtr, nameof (subSceneGUID));
        AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes>.NativeClassPtr, "<>4__this");
        AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes>.NativeClassPtr, nameof (_runtimes));
        AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes>.NativeClassPtr, nameof (_performLambdaDelegate));
        AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_ManagedAssetReference_byref_SceneSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes>.NativeClassPtr, 100684594);
        AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes>.NativeClassPtr, 100684595);
        AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes>.NativeClassPtr, 100684596);
        AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes>.NativeClassPtr, 100684598);
        AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes>.NativeClassPtr, 100684599);
        AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSubSceneStreamingHandler_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes>.NativeClassPtr, 100684600);
      }

      public __c__DisplayClass_RegisterLoadedSceneScenes(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_RegisterLoadedSceneScenes()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes>.NativeClassPtr, data));
      }

      public unsafe SubSceneGUID subSceneGUID
      {
        get
        {
          return *(SubSceneGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeFieldInfoPtr_subSceneGUID));
        }
        [param: In] set
        {
          *(SubSceneGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeFieldInfoPtr_subSceneGUID)) = value;
        }
      }

      public unsafe AssetSubSceneStreamingHandler __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (AssetSubSceneStreamingHandler) null : new AssetSubSceneStreamingHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_reference;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_SceneSection;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSubSceneStreamingHandler_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_ManagedComponentData<ManagedAssetReference> forParameter_reference;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_ISharedComponentData_Unboxed<SceneSection> forParameter_SceneSection;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073290, XrefRangeEnd = 1073297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AssetSubSceneStreamingHandler componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSubSceneStreamingHandler_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1073305, RefRangeEnd = 1073306, XrefRangeStart = 1073297, XrefRangeEnd = 1073305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_reference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_reference));
          AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_SceneSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_SceneSection));
          AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSubSceneStreamingHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders>.NativeClassPtr, 100684601);
          AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders>.NativeClassPtr, 100684602);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_reference;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_SceneSection;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_ManagedComponentData<ManagedAssetReference>.StructuralChangeRuntime runtime_reference;
          [FieldOffset(80)]
          public LambdaParameterValueProvider_ISharedComponentData_Unboxed<SceneSection>.StructuralChangeRuntime_Unboxed_Unboxed runtime_SceneSection;

          static Runtimes()
          {
            Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_reference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_reference));
            AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_SceneSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_SceneSection));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSubSceneStreamingHandler.__c__DisplayClass_RegisterLoadedSceneScenes.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_TryGetAsset_Public_Boolean_AssetGuid_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetSubSceneStreamingHandler.NativeMethodInfoPtr_TryGetAsset_Public_Boolean_AssetGuid_byref_T_0, Il2CppClassPointerStore<AssetSubSceneStreamingHandler>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
