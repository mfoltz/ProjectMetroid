// Decompiled with JetBrains decompiler
// Type: ProjectM.SetPlayerTeamSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class SetPlayerTeamSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetPlayerTeamJob2_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetPlayerTeamJob2_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetNewTeam_Private_TeamReference_FromCharacter_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateNewTeam_Private_TeamReference_FromCharacter_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindTeam_Private_Boolean_Int32_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSetPlayerTeamJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420339, XrefRangeEnd = 1420355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetPlayerTeamSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420355, XrefRangeEnd = 1420368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetPlayerTeamSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1420398, RefRangeEnd = 1420399, XrefRangeStart = 1420368, XrefRangeEnd = 1420398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TeamReference SetNewTeam(FromCharacter character, Entity newTeamEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newTeamEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetPlayerTeamSystem.NativeMethodInfoPtr_SetNewTeam_Private_TeamReference_FromCharacter_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TeamReference*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420399, XrefRangeEnd = 1420402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TeamReference CreateNewTeam(FromCharacter character, Entity playerTeamPrefab)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &playerTeamPrefab;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetPlayerTeamSystem.NativeMethodInfoPtr_CreateNewTeam_Private_TeamReference_FromCharacter_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TeamReference*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1420423, RefRangeEnd = 1420424, XrefRangeStart = 1420402, XrefRangeEnd = 1420423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryFindTeam(int teamId, out Entity teamEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &teamId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref teamEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetPlayerTeamSystem.NativeMethodInfoPtr_TryFindTeam_Private_Boolean_Int32_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SetPlayerTeamSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetPlayerTeamSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetPlayerTeamSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420424, XrefRangeEnd = 1420447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetPlayerTeamSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420447, XrefRangeEnd = 1420466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSetPlayerTeamJob2_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetPlayerTeamSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetPlayerTeamJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SetPlayerTeamSystem()
    {
      Il2CppClassPointerStore<SetPlayerTeamSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (SetPlayerTeamSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPlayerTeamSystem>.NativeClassPtr);
      SetPlayerTeamSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPlayerTeamSystem>.NativeClassPtr, nameof (_Query));
      SetPlayerTeamSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPlayerTeamSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      SetPlayerTeamSystem.NativeFieldInfoPtr___SetPlayerTeamJob2_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPlayerTeamSystem>.NativeClassPtr, "<>SetPlayerTeamJob2_entityQuery");
      SetPlayerTeamSystem.NativeFieldInfoPtr___SetPlayerTeamJob2_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPlayerTeamSystem>.NativeClassPtr, "<>SetPlayerTeamJob2_profilerMarker");
      SetPlayerTeamSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPlayerTeamSystem>.NativeClassPtr, 100669598);
      SetPlayerTeamSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPlayerTeamSystem>.NativeClassPtr, 100669599);
      SetPlayerTeamSystem.NativeMethodInfoPtr_SetNewTeam_Private_TeamReference_FromCharacter_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPlayerTeamSystem>.NativeClassPtr, 100669600);
      SetPlayerTeamSystem.NativeMethodInfoPtr_CreateNewTeam_Private_TeamReference_FromCharacter_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPlayerTeamSystem>.NativeClassPtr, 100669601);
      SetPlayerTeamSystem.NativeMethodInfoPtr_TryFindTeam_Private_Boolean_Int32_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPlayerTeamSystem>.NativeClassPtr, 100669602);
      SetPlayerTeamSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPlayerTeamSystem>.NativeClassPtr, 100669603);
      SetPlayerTeamSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPlayerTeamSystem>.NativeClassPtr, 100669604);
      SetPlayerTeamSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetPlayerTeamJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPlayerTeamSystem>.NativeClassPtr, 100669605);
    }

    public SetPlayerTeamSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPlayerTeamSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPlayerTeamSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPlayerTeamSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetPlayerTeamSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __SetPlayerTeamJob2_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPlayerTeamSystem.NativeFieldInfoPtr___SetPlayerTeamJob2_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPlayerTeamSystem.NativeFieldInfoPtr___SetPlayerTeamJob2_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SetPlayerTeamJob2_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPlayerTeamSystem.NativeFieldInfoPtr___SetPlayerTeamJob2_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPlayerTeamSystem.NativeFieldInfoPtr___SetPlayerTeamJob2_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.SetPlayerTeamSystem/<>c__DisplayClass3_0")]
    public sealed class __c__DisplayClass3_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_playerTeamPrefab;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_SetPlayerTeamDebugEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass3_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass3_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetPlayerTeamSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref SetPlayerTeamDebugEvent setTeamEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref setTeamEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetPlayerTeamSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_SetPlayerTeamDebugEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass3_0()
      {
        Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetPlayerTeamSystem>.NativeClassPtr, "<>c__DisplayClass3_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass3_0>.NativeClassPtr);
        SetPlayerTeamSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
        SetPlayerTeamSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_playerTeamPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (playerTeamPrefab));
        SetPlayerTeamSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass3_0>.NativeClassPtr, 100669606);
        SetPlayerTeamSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_SetPlayerTeamDebugEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass3_0>.NativeClassPtr, 100669607);
      }

      public __c__DisplayClass3_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass3_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass3_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass3_0>.NativeClassPtr, data));
      }

      public unsafe SetPlayerTeamSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPlayerTeamSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SetPlayerTeamSystem) null : new SetPlayerTeamSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetPlayerTeamSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity playerTeamPrefab
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPlayerTeamSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_playerTeamPrefab));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPlayerTeamSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_playerTeamPrefab)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.SetPlayerTeamSystem/ProjectM.<>c__DisplayClass_SetPlayerTeamJob2")]
    public sealed class __c__DisplayClass_SetPlayerTeamJob2 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_playerTeamPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SetPlayerTeamDebugEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetPlayerTeamSystem_byref___c__DisplayClass3_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1420317, RefRangeEnd = 1420318, XrefRangeStart = 1420282, XrefRangeEnd = 1420317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref SetPlayerTeamDebugEvent setTeamEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref setTeamEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SetPlayerTeamDebugEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 975279, RefRangeEnd = 975282, XrefRangeStart = 975279, XrefRangeEnd = 975282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SetPlayerTeamSystem.__c__DisplayClass3_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 975283, RefRangeEnd = 975294, XrefRangeStart = 975283, XrefRangeEnd = 975294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SetPlayerTeamSystem.__c__DisplayClass3_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420318, XrefRangeEnd = 1420332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1420338, RefRangeEnd = 1420339, XrefRangeStart = 1420332, XrefRangeEnd = 1420338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 977780, RefRangeEnd = 977788, XrefRangeStart = 977780, XrefRangeEnd = 977788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SetPlayerTeamSystem componentSystem,
        ref SetPlayerTeamSystem.__c__DisplayClass3_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetPlayerTeamSystem_byref___c__DisplayClass3_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SetPlayerTeamJob2()
      {
        Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetPlayerTeamSystem>.NativeClassPtr, "<>c__DisplayClass_SetPlayerTeamJob2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2>.NativeClassPtr);
        SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2>.NativeClassPtr, "<>4__this");
        SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeFieldInfoPtr_playerTeamPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2>.NativeClassPtr, nameof (playerTeamPrefab));
        SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2>.NativeClassPtr, nameof (_runtimes));
        SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2>.NativeClassPtr, nameof (_performLambdaDelegate));
        SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SetPlayerTeamDebugEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2>.NativeClassPtr, 100669608);
        SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2>.NativeClassPtr, 100669609);
        SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2>.NativeClassPtr, 100669610);
        SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2>.NativeClassPtr, 100669612);
        SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2>.NativeClassPtr, 100669613);
        SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetPlayerTeamSystem_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2>.NativeClassPtr, 100669614);
      }

      public __c__DisplayClass_SetPlayerTeamJob2(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_SetPlayerTeamJob2()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2>.NativeClassPtr, data));
      }

      public unsafe SetPlayerTeamSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SetPlayerTeamSystem) null : new SetPlayerTeamSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity playerTeamPrefab
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeFieldInfoPtr_playerTeamPrefab));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeFieldInfoPtr_playerTeamPrefab)) = value;
        }
      }

      public unsafe SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_setTeamEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetPlayerTeamSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<SetPlayerTeamDebugEvent> forParameter_setTeamEvent;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420266, XrefRangeEnd = 1420273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SetPlayerTeamSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetPlayerTeamSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1420281, RefRangeEnd = 1420282, XrefRangeStart = 1420273, XrefRangeEnd = 1420281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_setTeamEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_setTeamEvent));
          SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetPlayerTeamSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders>.NativeClassPtr, 100669615);
          SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders>.NativeClassPtr, 100669616);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_setTeamEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<SetPlayerTeamDebugEvent>.StructuralChangeRuntime runtime_setTeamEvent;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.StructuralChangeRuntime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_setTeamEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_setTeamEvent));
            SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetPlayerTeamSystem.__c__DisplayClass_SetPlayerTeamJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
