// Decompiled with JetBrains decompiler
// Type: ProjectM.RuntimeConversionSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class RuntimeConversionSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_IsReadyToLoadPrefabs;
    private static readonly System.IntPtr NativeFieldInfoPtr_RUNTIME_ERROR;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Entity_GameObject_RuntimeConversionSettingsFlags_NativeList_1_PrefabGUID_NativeHashMap_2_PrefabGUID_ConvertedAssetData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrintConvertOnDemandDump_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyConvertedPrefabsAndPostProcess_Public_Void_World_Boolean_Nullable_Unboxed_1_LoadToTargetWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetProcessingWorld_Public_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RuntimeConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 722114, RefRangeEnd = 722115, XrefRangeStart = 722108, XrefRangeEnd = 722114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity Convert(
      GameObject gameObject,
      RuntimeConversionSettingsFlags conversionSettingsFlags = RuntimeConversionSettingsFlags.None,
      NativeList<PrefabGUID> requiredRootPrefabs = default (NativeList<PrefabGUID>),
      NativeHashMap<PrefabGUID, ConvertedAssetData> startupConversionStateTracker = default (NativeHashMap<PrefabGUID, ConvertedAssetData>))
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &conversionSettingsFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &requiredRootPrefabs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &startupConversionStateTracker;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RuntimeConversionSystem.NativeMethodInfoPtr_Convert_Public_Entity_GameObject_RuntimeConversionSettingsFlags_NativeList_1_PrefabGUID_NativeHashMap_2_PrefabGUID_ConvertedAssetData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722115, XrefRangeEnd = 722121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrintConvertOnDemandDump(string causeOfDump = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(causeOfDump);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RuntimeConversionSystem.NativeMethodInfoPtr_PrintConvertOnDemandDump_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 722127, RefRangeEnd = 722131, XrefRangeStart = 722121, XrefRangeEnd = 722127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CopyConvertedPrefabsAndPostProcess(
      World fromUnprocessedConversionWorld,
      bool showProgressBar,
      Nullable_Unboxed<LoadToTargetWorld> simulatedLoadToWorld = default (Nullable_Unboxed<LoadToTargetWorld>))
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromUnprocessedConversionWorld);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &showProgressBar;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &simulatedLoadToWorld;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RuntimeConversionSystem.NativeMethodInfoPtr_CopyConvertedPrefabsAndPostProcess_Public_Void_World_Boolean_Nullable_Unboxed_1_LoadToTargetWorld_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 722137, RefRangeEnd = 722141, XrefRangeStart = 722131, XrefRangeEnd = 722137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe World GetProcessingWorld()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RuntimeConversionSystem.NativeMethodInfoPtr_GetProcessingWorld_Public_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RuntimeConversionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeConversionSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RuntimeConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RuntimeConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RuntimeConversionSystem()
    {
      Il2CppClassPointerStore<RuntimeConversionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RuntimeConversionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeConversionSystem>.NativeClassPtr);
      RuntimeConversionSystem.NativeFieldInfoPtr_IsReadyToLoadPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeConversionSystem>.NativeClassPtr, nameof (IsReadyToLoadPrefabs));
      RuntimeConversionSystem.NativeFieldInfoPtr_RUNTIME_ERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeConversionSystem>.NativeClassPtr, nameof (RUNTIME_ERROR));
      RuntimeConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeConversionSystem>.NativeClassPtr, 100663760);
      RuntimeConversionSystem.NativeMethodInfoPtr_Convert_Public_Entity_GameObject_RuntimeConversionSettingsFlags_NativeList_1_PrefabGUID_NativeHashMap_2_PrefabGUID_ConvertedAssetData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeConversionSystem>.NativeClassPtr, 100663761);
      RuntimeConversionSystem.NativeMethodInfoPtr_PrintConvertOnDemandDump_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeConversionSystem>.NativeClassPtr, 100663762);
      RuntimeConversionSystem.NativeMethodInfoPtr_CopyConvertedPrefabsAndPostProcess_Public_Void_World_Boolean_Nullable_Unboxed_1_LoadToTargetWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeConversionSystem>.NativeClassPtr, 100663763);
      RuntimeConversionSystem.NativeMethodInfoPtr_GetProcessingWorld_Public_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeConversionSystem>.NativeClassPtr, 100663764);
      RuntimeConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeConversionSystem>.NativeClassPtr, 100663765);
      RuntimeConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeConversionSystem>.NativeClassPtr, 100663766);
    }

    public RuntimeConversionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool IsReadyToLoadPrefabs
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RuntimeConversionSystem.NativeFieldInfoPtr_IsReadyToLoadPrefabs));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RuntimeConversionSystem.NativeFieldInfoPtr_IsReadyToLoadPrefabs)) = value;
      }
    }

    public static unsafe string RUNTIME_ERROR
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(RuntimeConversionSystem.NativeFieldInfoPtr_RUNTIME_ERROR, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RuntimeConversionSystem.NativeFieldInfoPtr_RUNTIME_ERROR, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
