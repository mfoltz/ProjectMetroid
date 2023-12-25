// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.GetCharacterHUDSystem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Entities.UniversalDelegates;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM.UI
{
  public class GetCharacterHUDSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbsorbBuffQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__UIDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__Entries;
    private static readonly System.IntPtr NativeFieldInfoPtr__EntitiesWithHideHudBuffs;
    private static readonly System.IntPtr NativeFieldInfoPtr__EntitiesWithModifiableHud;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetName_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetName_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetHideTargetHUDBuffs_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetHideTargetHUDBuffs_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetModifyTargetHUDHeightBuffs_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetModifyTargetHUDHeightBuffs_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Entries_Public_get_NativeArray_1_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSetName_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForGetHideTargetHUDBuffs_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForGetModifyTargetHUDHeightBuffs_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;

    public unsafe NativeArray<CharacterHUDEntry.Data> Entries
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1218530, RefRangeEnd = 1218531, XrefRangeStart = 1218527, XrefRangeEnd = 1218530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.NativeMethodInfoPtr_get_Entries_Public_get_NativeArray_1_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeArray<CharacterHUDEntry.Data>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218531, XrefRangeEnd = 1218581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GetCharacterHUDSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218581, XrefRangeEnd = 1218590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GetCharacterHUDSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218590, XrefRangeEnd = 1218765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GetCharacterHUDSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GetCharacterHUDSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218765, XrefRangeEnd = 1218851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GetCharacterHUDSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1218873, RefRangeEnd = 1218874, XrefRangeStart = 1218851, XrefRangeEnd = 1218873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSetName_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetName_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218874, XrefRangeEnd = 1218893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForGetHideTargetHUDBuffs_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.NativeMethodInfoPtr___GetEntityQuery_ForGetHideTargetHUDBuffs_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218893, XrefRangeEnd = 1218912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForGetModifyTargetHUDHeightBuffs_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.NativeMethodInfoPtr___GetEntityQuery_ForGetModifyTargetHUDHeightBuffs_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1218916, RefRangeEnd = 1218917, XrefRangeStart = 1218912, XrefRangeEnd = 1218916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1218921, RefRangeEnd = 1218922, XrefRangeStart = 1218917, XrefRangeEnd = 1218921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1218926, RefRangeEnd = 1218927, XrefRangeStart = 1218922, XrefRangeEnd = 1218926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GetCharacterHUDSystem()
    {
      Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (GetCharacterHUDSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr);
      GetCharacterHUDSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, nameof (_Query));
      GetCharacterHUDSystem.NativeFieldInfoPtr__AbsorbBuffQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, nameof (_AbsorbBuffQuery));
      GetCharacterHUDSystem.NativeFieldInfoPtr__UIDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, nameof (_UIDataSystem));
      GetCharacterHUDSystem.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, nameof (_CommonClientDataSystem));
      GetCharacterHUDSystem.NativeFieldInfoPtr__Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, nameof (_Entries));
      GetCharacterHUDSystem.NativeFieldInfoPtr__EntitiesWithHideHudBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, nameof (_EntitiesWithHideHudBuffs));
      GetCharacterHUDSystem.NativeFieldInfoPtr__EntitiesWithModifiableHud = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, nameof (_EntitiesWithModifiableHud));
      GetCharacterHUDSystem.NativeFieldInfoPtr___SetName_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, "<>SetName_entityQuery");
      GetCharacterHUDSystem.NativeFieldInfoPtr___SetName_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, "<>SetName_profilerMarker");
      GetCharacterHUDSystem.NativeFieldInfoPtr___GetHideTargetHUDBuffs_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, "<>GetHideTargetHUDBuffs_entityQuery");
      GetCharacterHUDSystem.NativeFieldInfoPtr___GetHideTargetHUDBuffs_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, "<>GetHideTargetHUDBuffs_profilerMarker");
      GetCharacterHUDSystem.NativeFieldInfoPtr___GetModifyTargetHUDHeightBuffs_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, "<>GetModifyTargetHUDHeightBuffs_entityQuery");
      GetCharacterHUDSystem.NativeFieldInfoPtr___GetModifyTargetHUDHeightBuffs_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, "<>GetModifyTargetHUDHeightBuffs_profilerMarker");
      GetCharacterHUDSystem.NativeMethodInfoPtr_get_Entries_Public_get_NativeArray_1_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, 100664369);
      GetCharacterHUDSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, 100664370);
      GetCharacterHUDSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, 100664371);
      GetCharacterHUDSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, 100664372);
      GetCharacterHUDSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, 100664373);
      GetCharacterHUDSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, 100664374);
      GetCharacterHUDSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetName_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, 100664375);
      GetCharacterHUDSystem.NativeMethodInfoPtr___GetEntityQuery_ForGetHideTargetHUDBuffs_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, 100664376);
      GetCharacterHUDSystem.NativeMethodInfoPtr___GetEntityQuery_ForGetModifyTargetHUDHeightBuffs_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, 100664377);
      GetCharacterHUDSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, 100664378);
      GetCharacterHUDSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, 100664379);
      GetCharacterHUDSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, 100664380);
    }

    public GetCharacterHUDSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe EntityQuery _AbsorbBuffQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr__AbsorbBuffQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr__AbsorbBuffQuery)) = value;
      }
    }

    public unsafe UIDataSystem _UIDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr__UIDataSystem));
        return pointer == System.IntPtr.Zero ? (UIDataSystem) null : new UIDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr__UIDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<CharacterHUDEntry.Data> _Entries
    {
      get
      {
        return *(NativeList<CharacterHUDEntry.Data>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr__Entries));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr__Entries), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<CharacterHUDEntry.Data>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<Entity> _EntitiesWithHideHudBuffs
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr__EntitiesWithHideHudBuffs));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr__EntitiesWithHideHudBuffs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<GetCharacterHUDSystem.EntityWithModifiableHud> _EntitiesWithModifiableHud
    {
      get
      {
        return *(NativeList<GetCharacterHUDSystem.EntityWithModifiableHud>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr__EntitiesWithModifiableHud));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr__EntitiesWithModifiableHud), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<GetCharacterHUDSystem.EntityWithModifiableHud>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __SetName_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr___SetName_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr___SetName_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SetName_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr___SetName_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr___SetName_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __GetHideTargetHUDBuffs_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr___GetHideTargetHUDBuffs_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr___GetHideTargetHUDBuffs_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __GetHideTargetHUDBuffs_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr___GetHideTargetHUDBuffs_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr___GetHideTargetHUDBuffs_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __GetModifyTargetHUDHeightBuffs_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr___GetModifyTargetHUDHeightBuffs_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr___GetModifyTargetHUDHeightBuffs_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __GetModifyTargetHUDHeightBuffs_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr___GetModifyTargetHUDHeightBuffs_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetCharacterHUDSystem.NativeFieldInfoPtr___GetModifyTargetHUDHeightBuffs_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct EntityWithModifiableHud
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_ModifiedHUDHeight;
      [FieldOffset(0)]
      public Entity Entity;
      [FieldOffset(8)]
      public float ModifiedHUDHeight;

      static EntityWithModifiableHud()
      {
        Il2CppClassPointerStore<GetCharacterHUDSystem.EntityWithModifiableHud>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, nameof (EntityWithModifiableHud));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetCharacterHUDSystem.EntityWithModifiableHud>.NativeClassPtr);
        GetCharacterHUDSystem.EntityWithModifiableHud.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.EntityWithModifiableHud>.NativeClassPtr, nameof (Entity));
        GetCharacterHUDSystem.EntityWithModifiableHud.NativeFieldInfoPtr_ModifiedHUDHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.EntityWithModifiableHud>.NativeClassPtr, nameof (ModifiedHUDHeight));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetCharacterHUDSystem.EntityWithModifiableHud>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct AbsorbArrays
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AbsorbBuffs;
      private static readonly System.IntPtr NativeFieldInfoPtr_Buffs;
      [FieldOffset(0)]
      public NativeArray<AbsorbBuff> AbsorbBuffs;
      [FieldOffset(16)]
      public NativeArray<Buff> Buffs;

      static AbsorbArrays()
      {
        Il2CppClassPointerStore<GetCharacterHUDSystem.AbsorbArrays>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, nameof (AbsorbArrays));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetCharacterHUDSystem.AbsorbArrays>.NativeClassPtr);
        GetCharacterHUDSystem.AbsorbArrays.NativeFieldInfoPtr_AbsorbBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.AbsorbArrays>.NativeClassPtr, nameof (AbsorbBuffs));
        GetCharacterHUDSystem.AbsorbArrays.NativeFieldInfoPtr_Buffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.AbsorbArrays>.NativeClassPtr, nameof (Buffs));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetCharacterHUDSystem.AbsorbArrays>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GetDataJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CurrentFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_CharacterHUDType;
      private static readonly System.IntPtr NativeFieldInfoPtr_HealthBarHUDType;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_HealthType;
      private static readonly System.IntPtr NativeFieldInfoPtr_TeamType;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityPrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_NameableInteractableType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServantConnectedCoffinType;
      private static readonly System.IntPtr NativeFieldInfoPtr_TranslationType;
      private static readonly System.IntPtr NativeFieldInfoPtr_CheckOnScreenType;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlayerCharacterType;
      private static readonly System.IntPtr NativeFieldInfoPtr_BloodConsumeSourceType;
      private static readonly System.IntPtr NativeFieldInfoPtr_AggroConsumerType;
      private static readonly System.IntPtr NativeFieldInfoPtr_UnitLevelType;
      private static readonly System.IntPtr NativeFieldInfoPtr_UnitStatsType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServantPowerType;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilityBar_ClientType;
      private static readonly System.IntPtr NativeFieldInfoPtr_CharacterHudProgressBarType;
      private static readonly System.IntPtr NativeFieldInfoPtr_InventoryType;
      private static readonly System.IntPtr NativeFieldInfoPtr_JumpDownType;
      private static readonly System.IntPtr NativeFieldInfoPtr_EquipmentType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetAbilityCastTimeData;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetServantCoffinstation;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCharVoiceActivity;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPlayerCharacter;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntitiesWithHideHudBuffs;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntitiesWithModifiableHud;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbsorbArrays;
      private static readonly System.IntPtr NativeFieldInfoPtr_CameraData;
      private static readonly System.IntPtr NativeFieldInfoPtr_LocalPlayerPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_PickedEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_LocalCharacter;
      private static readonly System.IntPtr NativeFieldInfoPtr_LocalCharacterTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_LocalCharacterAverageLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_Time;
      private static readonly System.IntPtr NativeFieldInfoPtr_NormalizedZoom;
      private static readonly System.IntPtr NativeFieldInfoPtr_ShowBloodHud;
      private static readonly System.IntPtr NativeFieldInfoPtr_Entries;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHudIndex_Private_Int32_Entity_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public int CurrentFrame;
      [FieldOffset(8)]
      public ComponentTypeHandle<CharacterHUD> CharacterHUDType;
      [FieldOffset(40)]
      public ComponentTypeHandle<HealthBarHUD> HealthBarHUDType;
      [FieldOffset(72)]
      public EntityTypeHandle EntityType;
      [FieldOffset(80)]
      public ComponentTypeHandle<Health> HealthType;
      [FieldOffset(112)]
      public ComponentTypeHandle<Team> TeamType;
      [FieldOffset(144)]
      public ComponentTypeHandle<PrefabGUID> EntityPrefabGUID;
      [FieldOffset(176)]
      public ComponentTypeHandle<NameableInteractable> NameableInteractableType;
      [FieldOffset(208)]
      public ComponentTypeHandle<ServantConnectedCoffin> ServantConnectedCoffinType;
      [FieldOffset(240)]
      public ComponentTypeHandle<Translation> TranslationType;
      [FieldOffset(272)]
      public ComponentTypeHandle<CheckOnScreen> CheckOnScreenType;
      [FieldOffset(304)]
      public ComponentTypeHandle<PlayerCharacter> PlayerCharacterType;
      [FieldOffset(336)]
      public ComponentTypeHandle<BloodConsumeSource> BloodConsumeSourceType;
      [FieldOffset(368)]
      public ComponentTypeHandle<AggroConsumer> AggroConsumerType;
      [FieldOffset(400)]
      public ComponentTypeHandle<UnitLevel> UnitLevelType;
      [FieldOffset(432)]
      public ComponentTypeHandle<UnitStats> UnitStatsType;
      [FieldOffset(464)]
      public ComponentTypeHandle<ServantPower> ServantPowerType;
      [FieldOffset(496)]
      public ComponentTypeHandle<AbilityBar_Client> AbilityBar_ClientType;
      [FieldOffset(528)]
      public ComponentTypeHandle<CharacterHudProgressBar> CharacterHudProgressBarType;
      [FieldOffset(560)]
      public BufferTypeHandle<InventoryBuffer> InventoryType;
      [FieldOffset(600)]
      public ComponentTypeHandle<JumpFromCliffs> JumpDownType;
      [FieldOffset(632)]
      public ComponentTypeHandle<Equipment> EquipmentType;
      [FieldOffset(664)]
      public ComponentDataFromEntity<AbilityCastTimeData> GetAbilityCastTimeData;
      [FieldOffset(696)]
      public ComponentDataFromEntity<ServantCoffinstation> GetServantCoffinstation;
      [FieldOffset(728)]
      public ComponentDataFromEntity<CharacterVoiceActivity> GetCharVoiceActivity;
      [FieldOffset(760)]
      public ComponentDataFromEntity<PlayerCharacter> GetPlayerCharacter;
      [FieldOffset(792)]
      public NativeArray<Entity> EntitiesWithHideHudBuffs;
      [FieldOffset(808)]
      public NativeArray<GetCharacterHUDSystem.EntityWithModifiableHud> EntitiesWithModifiableHud;
      [FieldOffset(824)]
      public GetCharacterHUDSystem.AbsorbArrays AbsorbArrays;
      [FieldOffset(856)]
      public HybridCameraData CameraData;
      [FieldOffset(1040)]
      public float3 LocalPlayerPosition;
      [FieldOffset(1052)]
      public Entity PickedEntity;
      [FieldOffset(1060)]
      public Entity LocalCharacter;
      [FieldOffset(1068)]
      public Team LocalCharacterTeam;
      [FieldOffset(1076)]
      public Nullable_Unboxed<float> LocalCharacterAverageLevel;
      [FieldOffset(1088)]
      public double ServerTime;
      [FieldOffset(1096)]
      public double Time;
      [FieldOffset(1104)]
      public float NormalizedZoom;
      [FieldOffset(1108)]
      public bool ShowBloodHud;
      [FieldOffset(1112)]
      public NativeList<CharacterHUDEntry.Data> Entries;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1217973, RefRangeEnd = 1217974, XrefRangeStart = 1217954, XrefRangeEnd = 1217973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int GetHudIndex(Entity entity, int hudIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hudIndex;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.GetDataJob.NativeMethodInfoPtr_GetHudIndex_Private_Int32_Entity_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217974, XrefRangeEnd = 1218182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.GetDataJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static GetDataJob()
      {
        Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, nameof (GetDataJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr);
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_CurrentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (CurrentFrame));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_CharacterHUDType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (CharacterHUDType));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_HealthBarHUDType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (HealthBarHUDType));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (EntityType));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_HealthType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (HealthType));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_TeamType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (TeamType));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_EntityPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (EntityPrefabGUID));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_NameableInteractableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (NameableInteractableType));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_ServantConnectedCoffinType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (ServantConnectedCoffinType));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_TranslationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (TranslationType));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_CheckOnScreenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (CheckOnScreenType));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_PlayerCharacterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (PlayerCharacterType));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_BloodConsumeSourceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (BloodConsumeSourceType));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_AggroConsumerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (AggroConsumerType));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_UnitLevelType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (UnitLevelType));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_UnitStatsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (UnitStatsType));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_ServantPowerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (ServantPowerType));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_AbilityBar_ClientType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (AbilityBar_ClientType));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_CharacterHudProgressBarType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (CharacterHudProgressBarType));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_InventoryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (InventoryType));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_JumpDownType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (JumpDownType));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_EquipmentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (EquipmentType));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_GetAbilityCastTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (GetAbilityCastTimeData));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_GetServantCoffinstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (GetServantCoffinstation));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_GetCharVoiceActivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (GetCharVoiceActivity));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_GetPlayerCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (GetPlayerCharacter));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_EntitiesWithHideHudBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (EntitiesWithHideHudBuffs));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_EntitiesWithModifiableHud = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (EntitiesWithModifiableHud));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_AbsorbArrays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (AbsorbArrays));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_CameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (CameraData));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_LocalPlayerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (LocalPlayerPosition));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_PickedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (PickedEntity));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_LocalCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (LocalCharacter));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_LocalCharacterTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (LocalCharacterTeam));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_LocalCharacterAverageLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (LocalCharacterAverageLevel));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (ServerTime));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (Time));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_NormalizedZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (NormalizedZoom));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_ShowBloodHud = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (ShowBloodHud));
        GetCharacterHUDSystem.GetDataJob.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, nameof (Entries));
        GetCharacterHUDSystem.GetDataJob.NativeMethodInfoPtr_GetHudIndex_Private_Int32_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, 100664381);
        GetCharacterHUDSystem.GetDataJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, 100664382);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetCharacterHUDSystem.GetDataJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.GetCharacterHUDSystem/<>c__DisplayClass12_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass12_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entitiesWithHideHudBuffs;
      private static readonly System.IntPtr NativeFieldInfoPtr_entitiesWithModifiableHud;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_Buff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_Buff_byref_ModifyTargetHUDHeight_0;
      [FieldOffset(0)]
      public NativeList<Entity> entitiesWithHideHudBuffs;
      [FieldOffset(16)]
      public NativeList<GetCharacterHUDSystem.EntityWithModifiableHud> entitiesWithModifiableHud;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass12_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1([In] ref Buff buff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref buff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_Buff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        [In] ref Buff buff,
        [In] ref ModifyTargetHUDHeight modifyTargetHUDHeight)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifyTargetHUDHeight;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_Buff_byref_ModifyTargetHUDHeight_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass12_0()
      {
        Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, "<>c__DisplayClass12_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass12_0>.NativeClassPtr);
        GetCharacterHUDSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_entitiesWithHideHudBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (entitiesWithHideHudBuffs));
        GetCharacterHUDSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_entitiesWithModifiableHud = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (entitiesWithModifiableHud));
        GetCharacterHUDSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass12_0>.NativeClassPtr, 100664383);
        GetCharacterHUDSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass12_0>.NativeClassPtr, 100664384);
        GetCharacterHUDSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_Buff_byref_ModifyTargetHUDHeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass12_0>.NativeClassPtr, 100664385);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass12_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.GetCharacterHUDSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__12_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__12_0_Internal_Void_byref_CharacterHUD_byref_PlayerCharacter_byref_CheckOnScreen_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetCharacterHUDSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__12_0(
        ref CharacterHUD characterHud,
        [In] ref PlayerCharacter playerCharacter,
        [In] ref CheckOnScreen checkOnScreen)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref characterHud;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref playerCharacter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref checkOnScreen;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c.NativeMethodInfoPtr__OnUpdate_b__12_0_Internal_Void_byref_CharacterHUD_byref_PlayerCharacter_byref_CheckOnScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<GetCharacterHUDSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetCharacterHUDSystem.__c>.NativeClassPtr);
        GetCharacterHUDSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c>.NativeClassPtr, "<>9");
        GetCharacterHUDSystem.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c>.NativeClassPtr, "<>9__12_0");
        GetCharacterHUDSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c>.NativeClassPtr, 100664387);
        GetCharacterHUDSystem.__c.NativeMethodInfoPtr__OnUpdate_b__12_0_Internal_Void_byref_CharacterHUD_byref_PlayerCharacter_byref_CheckOnScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c>.NativeClassPtr, 100664388);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe GetCharacterHUDSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GetCharacterHUDSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (GetCharacterHUDSystem.__c) null : new GetCharacterHUDSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GetCharacterHUDSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe RII<CharacterHUD, PlayerCharacter, CheckOnScreen> __9__12_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GetCharacterHUDSystem.__c.NativeFieldInfoPtr___9__12_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (RII<CharacterHUD, PlayerCharacter, CheckOnScreen>) null : new RII<CharacterHUD, PlayerCharacter, CheckOnScreen>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GetCharacterHUDSystem.__c.NativeFieldInfoPtr___9__12_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.GetCharacterHUDSystem/ProjectM.UI.<>c__DisplayClass_SetName")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SetName
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CharacterHUD_byref_PlayerCharacter_byref_CheckOnScreen_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetCharacterHUDSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(96)]
      public unsafe GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1218277, RefRangeEnd = 1218278, XrefRangeStart = 1218277, XrefRangeEnd = 1218277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref CharacterHUD characterHud,
        [In] ref PlayerCharacter playerCharacter,
        [In] ref CheckOnScreen checkOnScreen)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref characterHud;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref playerCharacter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref checkOnScreen;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_SetName.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CharacterHUD_byref_PlayerCharacter_byref_CheckOnScreen_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218278, XrefRangeEnd = 1218280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_SetName.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1218291, RefRangeEnd = 1218292, XrefRangeStart = 1218280, XrefRangeEnd = 1218291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_SetName.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1218293, RefRangeEnd = 1218294, XrefRangeStart = 1218292, XrefRangeEnd = 1218293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(GetCharacterHUDSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_SetName.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetCharacterHUDSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218294, XrefRangeEnd = 1218298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_SetName.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218298, XrefRangeEnd = 1218304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_SetName.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SetName()
      {
        Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, "<>c__DisplayClass_SetName");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName>.NativeClassPtr);
        GetCharacterHUDSystem.__c__DisplayClass_SetName.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GetCharacterHUDSystem.__c__DisplayClass_SetName.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName>.NativeClassPtr, nameof (_runtimes));
        GetCharacterHUDSystem.__c__DisplayClass_SetName.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GetCharacterHUDSystem.__c__DisplayClass_SetName.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GetCharacterHUDSystem.__c__DisplayClass_SetName.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CharacterHUD_byref_PlayerCharacter_byref_CheckOnScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName>.NativeClassPtr, 100664389);
        GetCharacterHUDSystem.__c__DisplayClass_SetName.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName>.NativeClassPtr, 100664390);
        GetCharacterHUDSystem.__c__DisplayClass_SetName.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName>.NativeClassPtr, 100664391);
        GetCharacterHUDSystem.__c__DisplayClass_SetName.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetCharacterHUDSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName>.NativeClassPtr, 100664392);
        GetCharacterHUDSystem.__c__DisplayClass_SetName.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName>.NativeClassPtr, 100664393);
        GetCharacterHUDSystem.__c__DisplayClass_SetName.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName>.NativeClassPtr, 100664394);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GetCharacterHUDSystem.__c__DisplayClass_SetName.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GetCharacterHUDSystem.__c__DisplayClass_SetName.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GetCharacterHUDSystem.__c__DisplayClass_SetName.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GetCharacterHUDSystem.__c__DisplayClass_SetName.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_characterHud;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_playerCharacter;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_checkOnScreen;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetCharacterHUDSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<CharacterHUD> forParameter_characterHud;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<PlayerCharacter> forParameter_playerCharacter;
        [FieldOffset(64)]
        public LambdaParameterValueProvider_IComponentData<CheckOnScreen> forParameter_checkOnScreen;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1218191, RefRangeEnd = 1218192, XrefRangeStart = 1218182, XrefRangeEnd = 1218191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GetCharacterHUDSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetCharacterHUDSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1218201, RefRangeEnd = 1218202, XrefRangeStart = 1218192, XrefRangeEnd = 1218201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_characterHud = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_characterHud));
          GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_playerCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_playerCharacter));
          GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_checkOnScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_checkOnScreen));
          GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetCharacterHUDSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders>.NativeClassPtr, 100664395);
          GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders>.NativeClassPtr, 100664396);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_characterHud;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_playerCharacter;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_checkOnScreen;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<CharacterHUD>.Runtime runtime_characterHud;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<PlayerCharacter>.Runtime runtime_playerCharacter;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<CheckOnScreen>.Runtime runtime_checkOnScreen;

          static Runtimes()
          {
            Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_characterHud = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_characterHud));
            GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_playerCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_playerCharacter));
            GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_checkOnScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_checkOnScreen));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UI.GetCharacterHUDSystem/ProjectM.UI.<>c__DisplayClass_SetName/ProjectM.UI.RunWithoutJobSystem_000003C2$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_SetName.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_SetName.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_SetName.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_SetName.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName>.NativeClassPtr, "RunWithoutJobSystem_000003C2$PostfixBurstDelegate");
          GetCharacterHUDSystem.__c__DisplayClass_SetName.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664397);
          GetCharacterHUDSystem.__c__DisplayClass_SetName.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664398);
          GetCharacterHUDSystem.__c__DisplayClass_SetName.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664399);
          GetCharacterHUDSystem.__c__DisplayClass_SetName.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664400);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.GetCharacterHUDSystem/ProjectM.UI.<>c__DisplayClass_SetName/ProjectM.UI.RunWithoutJobSystem_000003C2$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218202, XrefRangeEnd = 1218216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218216, XrefRangeEnd = 1218234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218234, XrefRangeEnd = 1218249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1218276, RefRangeEnd = 1218277, XrefRangeStart = 1218249, XrefRangeEnd = 1218276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName>.NativeClassPtr, "RunWithoutJobSystem_000003C2$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664401);
          GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664402);
          GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664403);
          GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664404);
          GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664406);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GetCharacterHUDSystem.__c__DisplayClass_SetName.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.GetCharacterHUDSystem/ProjectM.UI.<>c__DisplayClass_GetHideTargetHUDBuffs")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_GetHideTargetHUDBuffs
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entitiesWithHideHudBuffs;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Buff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetCharacterHUDSystem_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeList<Entity> entitiesWithHideHudBuffs;
      [FieldOffset(16)]
      public GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(48)]
      public unsafe GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218387, XrefRangeEnd = 1218390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref Buff buff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref buff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Buff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GetCharacterHUDSystem.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GetCharacterHUDSystem.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218390, XrefRangeEnd = 1218392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1218397, RefRangeEnd = 1218398, XrefRangeStart = 1218392, XrefRangeEnd = 1218397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1218400, RefRangeEnd = 1218401, XrefRangeStart = 1218398, XrefRangeEnd = 1218400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GetCharacterHUDSystem componentSystem,
        ref GetCharacterHUDSystem.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetCharacterHUDSystem_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218401, XrefRangeEnd = 1218405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218405, XrefRangeEnd = 1218411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_GetHideTargetHUDBuffs()
      {
        Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, "<>c__DisplayClass_GetHideTargetHUDBuffs");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs>.NativeClassPtr);
        GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeFieldInfoPtr_entitiesWithHideHudBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs>.NativeClassPtr, nameof (entitiesWithHideHudBuffs));
        GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs>.NativeClassPtr, nameof (_runtimes));
        GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs>.NativeClassPtr, 100664407);
        GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs>.NativeClassPtr, 100664408);
        GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs>.NativeClassPtr, 100664409);
        GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs>.NativeClassPtr, 100664410);
        GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs>.NativeClassPtr, 100664411);
        GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetCharacterHUDSystem_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs>.NativeClassPtr, 100664412);
        GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs>.NativeClassPtr, 100664413);
        GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs>.NativeClassPtr, 100664414);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetCharacterHUDSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1218307, RefRangeEnd = 1218308, XrefRangeStart = 1218304, XrefRangeEnd = 1218307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GetCharacterHUDSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetCharacterHUDSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1218311, RefRangeEnd = 1218312, XrefRangeStart = 1218308, XrefRangeEnd = 1218311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetCharacterHUDSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.LambdaParameterValueProviders>.NativeClassPtr, 100664415);
          GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.LambdaParameterValueProviders>.NativeClassPtr, 100664416);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;

          static Runtimes()
          {
            Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UI.GetCharacterHUDSystem/ProjectM.UI.<>c__DisplayClass_GetHideTargetHUDBuffs/ProjectM.UI.RunWithoutJobSystem_000003CB$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs>.NativeClassPtr, "RunWithoutJobSystem_000003CB$PostfixBurstDelegate");
          GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664417);
          GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664418);
          GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664419);
          GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664420);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.GetCharacterHUDSystem/ProjectM.UI.<>c__DisplayClass_GetHideTargetHUDBuffs/ProjectM.UI.RunWithoutJobSystem_000003CB$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218312, XrefRangeEnd = 1218326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218326, XrefRangeEnd = 1218344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218344, XrefRangeEnd = 1218359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1218386, RefRangeEnd = 1218387, XrefRangeStart = 1218359, XrefRangeEnd = 1218386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs>.NativeClassPtr, "RunWithoutJobSystem_000003CB$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664421);
          GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664422);
          GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664423);
          GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664424);
          GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664426);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GetCharacterHUDSystem.__c__DisplayClass_GetHideTargetHUDBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.GetCharacterHUDSystem/ProjectM.UI.<>c__DisplayClass_GetModifyTargetHUDHeightBuffs")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_GetModifyTargetHUDHeightBuffs
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entitiesWithModifiableHud;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Buff_byref_ModifyTargetHUDHeight_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetCharacterHUDSystem_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeList<GetCharacterHUDSystem.EntityWithModifiableHud> entitiesWithModifiableHud;
      [FieldOffset(16)]
      public GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218500, XrefRangeEnd = 1218503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref Buff buff,
        [In] ref ModifyTargetHUDHeight modifyTargetHUDHeight)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref modifyTargetHUDHeight;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Buff_byref_ModifyTargetHUDHeight_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 752617, RefRangeEnd = 752621, XrefRangeStart = 752617, XrefRangeEnd = 752621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GetCharacterHUDSystem.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 752621, RefRangeEnd = 752625, XrefRangeStart = 752621, XrefRangeEnd = 752625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GetCharacterHUDSystem.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218503, XrefRangeEnd = 1218505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1218513, RefRangeEnd = 1218514, XrefRangeStart = 1218505, XrefRangeEnd = 1218513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1218516, RefRangeEnd = 1218517, XrefRangeStart = 1218514, XrefRangeEnd = 1218516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GetCharacterHUDSystem componentSystem,
        ref GetCharacterHUDSystem.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetCharacterHUDSystem_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218517, XrefRangeEnd = 1218521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218521, XrefRangeEnd = 1218527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_GetModifyTargetHUDHeightBuffs()
      {
        Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetCharacterHUDSystem>.NativeClassPtr, "<>c__DisplayClass_GetModifyTargetHUDHeightBuffs");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs>.NativeClassPtr);
        GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeFieldInfoPtr_entitiesWithModifiableHud = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs>.NativeClassPtr, nameof (entitiesWithModifiableHud));
        GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs>.NativeClassPtr, nameof (_runtimes));
        GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Buff_byref_ModifyTargetHUDHeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs>.NativeClassPtr, 100664427);
        GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs>.NativeClassPtr, 100664428);
        GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs>.NativeClassPtr, 100664429);
        GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs>.NativeClassPtr, 100664430);
        GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs>.NativeClassPtr, 100664431);
        GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetCharacterHUDSystem_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs>.NativeClassPtr, 100664432);
        GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs>.NativeClassPtr, 100664433);
        GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs>.NativeClassPtr, 100664434);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_modifyTargetHUDHeight;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetCharacterHUDSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<ModifyTargetHUDHeight> forParameter_modifyTargetHUDHeight;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1218417, RefRangeEnd = 1218418, XrefRangeStart = 1218411, XrefRangeEnd = 1218417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GetCharacterHUDSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetCharacterHUDSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1218424, RefRangeEnd = 1218425, XrefRangeStart = 1218418, XrefRangeEnd = 1218424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_modifyTargetHUDHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_modifyTargetHUDHeight));
          GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetCharacterHUDSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders>.NativeClassPtr, 100664435);
          GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders>.NativeClassPtr, 100664436);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_modifyTargetHUDHeight;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ModifyTargetHUDHeight>.Runtime runtime_modifyTargetHUDHeight;

          static Runtimes()
          {
            Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_modifyTargetHUDHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_modifyTargetHUDHeight));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UI.GetCharacterHUDSystem/ProjectM.UI.<>c__DisplayClass_GetModifyTargetHUDHeightBuffs/ProjectM.UI.RunWithoutJobSystem_000003D4$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs>.NativeClassPtr, "RunWithoutJobSystem_000003D4$PostfixBurstDelegate");
          GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664437);
          GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664438);
          GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664439);
          GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664440);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.GetCharacterHUDSystem/ProjectM.UI.<>c__DisplayClass_GetModifyTargetHUDHeightBuffs/ProjectM.UI.RunWithoutJobSystem_000003D4$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218425, XrefRangeEnd = 1218439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218439, XrefRangeEnd = 1218457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218457, XrefRangeEnd = 1218472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1218499, RefRangeEnd = 1218500, XrefRangeStart = 1218472, XrefRangeEnd = 1218499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs>.NativeClassPtr, "RunWithoutJobSystem_000003D4$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664441);
          GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664442);
          GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664443);
          GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664444);
          GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664446);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GetCharacterHUDSystem.__c__DisplayClass_GetModifyTargetHUDHeightBuffs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
