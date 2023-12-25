// Decompiled with JetBrains decompiler
// Type: ProjectM.ShareUnitRecipeSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class ShareUnitRecipeSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr___ShareUnitRecipeJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ShareUnitRecipeJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForShareUnitRecipeJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041786, XrefRangeEnd = 1041795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShareUnitRecipeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041795, XrefRangeEnd = 1041798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShareUnitRecipeSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041798, XrefRangeEnd = 1041815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShareUnitRecipeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ShareUnitRecipeSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShareUnitRecipeSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShareUnitRecipeSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041815, XrefRangeEnd = 1041838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShareUnitRecipeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041838, XrefRangeEnd = 1041857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForShareUnitRecipeJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShareUnitRecipeSystem.NativeMethodInfoPtr___GetEntityQuery_ForShareUnitRecipeJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ShareUnitRecipeSystem()
    {
      Il2CppClassPointerStore<ShareUnitRecipeSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ShareUnitRecipeSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShareUnitRecipeSystem>.NativeClassPtr);
      ShareUnitRecipeSystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      ShareUnitRecipeSystem.NativeFieldInfoPtr__EventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem>.NativeClassPtr, nameof (_EventQuery));
      ShareUnitRecipeSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem>.NativeClassPtr, nameof (_SyncedServerDebugSettingsAccessor));
      ShareUnitRecipeSystem.NativeFieldInfoPtr___ShareUnitRecipeJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem>.NativeClassPtr, "<>ShareUnitRecipeJob_entityQuery");
      ShareUnitRecipeSystem.NativeFieldInfoPtr___ShareUnitRecipeJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem>.NativeClassPtr, "<>ShareUnitRecipeJob_profilerMarker");
      ShareUnitRecipeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShareUnitRecipeSystem>.NativeClassPtr, 100681602);
      ShareUnitRecipeSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShareUnitRecipeSystem>.NativeClassPtr, 100681603);
      ShareUnitRecipeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShareUnitRecipeSystem>.NativeClassPtr, 100681604);
      ShareUnitRecipeSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShareUnitRecipeSystem>.NativeClassPtr, 100681605);
      ShareUnitRecipeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShareUnitRecipeSystem>.NativeClassPtr, 100681606);
      ShareUnitRecipeSystem.NativeMethodInfoPtr___GetEntityQuery_ForShareUnitRecipeJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShareUnitRecipeSystem>.NativeClassPtr, 100681607);
    }

    public ShareUnitRecipeSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _EventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.NativeFieldInfoPtr__EventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.NativeFieldInfoPtr__EventQuery)) = value;
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _SyncedServerDebugSettingsAccessor
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.NativeFieldInfoPtr__SyncedServerDebugSettingsAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __ShareUnitRecipeJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.NativeFieldInfoPtr___ShareUnitRecipeJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.NativeFieldInfoPtr___ShareUnitRecipeJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ShareUnitRecipeJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.NativeFieldInfoPtr___ShareUnitRecipeJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.NativeFieldInfoPtr___ShareUnitRecipeJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.ShareUnitRecipeSystem/<>c__DisplayClass5_0")]
    public sealed class __c__DisplayClass5_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_skipProgressionCheck;
      private static readonly System.IntPtr NativeFieldInfoPtr_syncedServerDebugSettings;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ShareUnitspawnerRecipesEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass5_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass5_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShareUnitRecipeSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref ShareUnitspawnerRecipesEvent shareUnitspawnerRecipes,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref shareUnitspawnerRecipes;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShareUnitRecipeSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ShareUnitspawnerRecipesEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass5_0()
      {
        Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShareUnitRecipeSystem>.NativeClassPtr, "<>c__DisplayClass5_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass5_0>.NativeClassPtr);
        ShareUnitRecipeSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (networkIdToEntityMap));
        ShareUnitRecipeSystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
        ShareUnitRecipeSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_skipProgressionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (skipProgressionCheck));
        ShareUnitRecipeSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_syncedServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (syncedServerDebugSettings));
        ShareUnitRecipeSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass5_0>.NativeClassPtr, 100681608);
        ShareUnitRecipeSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ShareUnitspawnerRecipesEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass5_0>.NativeClassPtr, 100681609);
      }

      public __c__DisplayClass5_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass5_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass5_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass5_0>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ShareUnitRecipeSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ShareUnitRecipeSystem) null : new ShareUnitRecipeSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool skipProgressionCheck
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_skipProgressionCheck));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_skipProgressionCheck)) = value;
        }
      }

      public unsafe SyncedServerDebugSettings syncedServerDebugSettings
      {
        get
        {
          return *(SyncedServerDebugSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_syncedServerDebugSettings));
        }
        [param: In] set
        {
          *(SyncedServerDebugSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_syncedServerDebugSettings)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.ShareUnitRecipeSystem/ProjectM.<>c__DisplayClass_ShareUnitRecipeJob")]
    public sealed class __c__DisplayClass_ShareUnitRecipeJob : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_skipProgressionCheck;
      private static readonly System.IntPtr NativeFieldInfoPtr_syncedServerDebugSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ShareUnitspawnerRecipesEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShareUnitRecipeSystem_byref___c__DisplayClass5_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1041759, RefRangeEnd = 1041760, XrefRangeStart = 1041726, XrefRangeEnd = 1041759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref ShareUnitspawnerRecipesEvent shareUnitspawnerRecipes,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref shareUnitspawnerRecipes;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ShareUnitspawnerRecipesEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041760, XrefRangeEnd = 1041761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ShareUnitRecipeSystem.__c__DisplayClass5_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1041762, RefRangeEnd = 1041763, XrefRangeStart = 1041761, XrefRangeEnd = 1041762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ShareUnitRecipeSystem.__c__DisplayClass5_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041763, XrefRangeEnd = 1041777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1041783, RefRangeEnd = 1041784, XrefRangeStart = 1041777, XrefRangeEnd = 1041783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1041785, RefRangeEnd = 1041786, XrefRangeStart = 1041784, XrefRangeEnd = 1041785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ShareUnitRecipeSystem componentSystem,
        ref ShareUnitRecipeSystem.__c__DisplayClass5_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShareUnitRecipeSystem_byref___c__DisplayClass5_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ShareUnitRecipeJob()
      {
        Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShareUnitRecipeSystem>.NativeClassPtr, "<>c__DisplayClass_ShareUnitRecipeJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob>.NativeClassPtr);
        ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob>.NativeClassPtr, nameof (networkIdToEntityMap));
        ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob>.NativeClassPtr, "<>4__this");
        ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr_skipProgressionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob>.NativeClassPtr, nameof (skipProgressionCheck));
        ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr_syncedServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob>.NativeClassPtr, nameof (syncedServerDebugSettings));
        ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob>.NativeClassPtr, nameof (_runtimes));
        ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob>.NativeClassPtr, nameof (_performLambdaDelegate));
        ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ShareUnitspawnerRecipesEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob>.NativeClassPtr, 100681610);
        ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob>.NativeClassPtr, 100681611);
        ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob>.NativeClassPtr, 100681612);
        ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob>.NativeClassPtr, 100681614);
        ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob>.NativeClassPtr, 100681615);
        ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShareUnitRecipeSystem_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob>.NativeClassPtr, 100681616);
      }

      public __c__DisplayClass_ShareUnitRecipeJob(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_ShareUnitRecipeJob()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ShareUnitRecipeSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ShareUnitRecipeSystem) null : new ShareUnitRecipeSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool skipProgressionCheck
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr_skipProgressionCheck));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr_skipProgressionCheck)) = value;
        }
      }

      public unsafe SyncedServerDebugSettings syncedServerDebugSettings
      {
        get
        {
          return *(SyncedServerDebugSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr_syncedServerDebugSettings));
        }
        [param: In] set
        {
          *(SyncedServerDebugSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr_syncedServerDebugSettings)) = value;
        }
      }

      public unsafe ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_shareUnitspawnerRecipes;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShareUnitRecipeSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ShareUnitspawnerRecipesEvent> forParameter_shareUnitspawnerRecipes;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041710, XrefRangeEnd = 1041717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ShareUnitRecipeSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShareUnitRecipeSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1041725, RefRangeEnd = 1041726, XrefRangeStart = 1041717, XrefRangeEnd = 1041725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_shareUnitspawnerRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_shareUnitspawnerRecipes));
          ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShareUnitRecipeSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders>.NativeClassPtr, 100681617);
          ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders>.NativeClassPtr, 100681618);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_shareUnitspawnerRecipes;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<ShareUnitspawnerRecipesEvent>.StructuralChangeRuntime runtime_shareUnitspawnerRecipes;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.StructuralChangeRuntime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_shareUnitspawnerRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_shareUnitspawnerRecipes));
            ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShareUnitRecipeSystem.__c__DisplayClass_ShareUnitRecipeJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
