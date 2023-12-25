// Decompiled with JetBrains decompiler
// Type: ProjectM.Community.PlayerPresenceClientSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Community
{
  public class PlayerPresenceClientSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TimeBetweenRichPresenceUpdates;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlayerPresenceQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuildMenuQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileModelSpatialLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr___CheckVBloodTracking_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CheckVBloodTracking_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_58;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_59;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsBuilding_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsFishing_Private_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsFightingVBlood_Private_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHuntingVBlood_Private_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBaseActivity_Private_Boolean_float2_Team_byref_PlayerActivities_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateClanPresence_Private_Void_byref_PlayerPresence_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCheckVBloodTracking_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125459, XrefRangeEnd = 1125503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayerPresenceClientSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125503, XrefRangeEnd = 1125547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayerPresenceClientSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125547, XrefRangeEnd = 1125548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsBuilding()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.NativeMethodInfoPtr_IsBuilding_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125548, XrefRangeEnd = 1125553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsFishing(Entity localPlayer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &localPlayer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.NativeMethodInfoPtr_IsFishing_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125553, XrefRangeEnd = 1125557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsFightingVBlood(Entity localPlayer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &localPlayer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.NativeMethodInfoPtr_IsFightingVBlood_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1125571, RefRangeEnd = 1125572, XrefRangeStart = 1125557, XrefRangeEnd = 1125571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsHuntingVBlood(Entity localPlayer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &localPlayer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.NativeMethodInfoPtr_IsHuntingVBlood_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1125627, RefRangeEnd = 1125628, XrefRangeStart = 1125572, XrefRangeEnd = 1125627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetBaseActivity(
      float2 position,
      Team localUserTeam,
      out PlayerActivities baseActivity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localUserTeam;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref baseActivity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.NativeMethodInfoPtr_TryGetBaseActivity_Private_Boolean_float2_Team_byref_PlayerActivities_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1125657, RefRangeEnd = 1125658, XrefRangeStart = 1125628, XrefRangeEnd = 1125657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateClanPresence(ref PlayerPresence playerPresence, Entity clanEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref playerPresence;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &clanEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.NativeMethodInfoPtr_UpdateClanPresence_Private_Void_byref_PlayerPresence_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayerPresenceClientSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125658, XrefRangeEnd = 1125707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayerPresenceClientSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125707, XrefRangeEnd = 1125726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCheckVBloodTracking_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.NativeMethodInfoPtr___GetEntityQuery_ForCheckVBloodTracking_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1125730, RefRangeEnd = 1125731, XrefRangeStart = 1125726, XrefRangeEnd = 1125730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlayerPresenceClientSystem()
    {
      Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Community", nameof (PlayerPresenceClientSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr);
      PlayerPresenceClientSystem.NativeFieldInfoPtr__TimeBetweenRichPresenceUpdates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, nameof (_TimeBetweenRichPresenceUpdates));
      PlayerPresenceClientSystem.NativeFieldInfoPtr__PlayerPresenceQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, nameof (_PlayerPresenceQuery));
      PlayerPresenceClientSystem.NativeFieldInfoPtr__BuildMenuQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, nameof (_BuildMenuQuery));
      PlayerPresenceClientSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, nameof (_TileModelSpatialLookupMap));
      PlayerPresenceClientSystem.NativeFieldInfoPtr___CheckVBloodTracking_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, "<>CheckVBloodTracking_entityQuery");
      PlayerPresenceClientSystem.NativeFieldInfoPtr___CheckVBloodTracking_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, "<>CheckVBloodTracking_profilerMarker");
      PlayerPresenceClientSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_58 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalUser_58));
      PlayerPresenceClientSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_59 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalCharacter_59));
      PlayerPresenceClientSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, 100689270);
      PlayerPresenceClientSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, 100689271);
      PlayerPresenceClientSystem.NativeMethodInfoPtr_IsBuilding_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, 100689272);
      PlayerPresenceClientSystem.NativeMethodInfoPtr_IsFishing_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, 100689273);
      PlayerPresenceClientSystem.NativeMethodInfoPtr_IsFightingVBlood_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, 100689274);
      PlayerPresenceClientSystem.NativeMethodInfoPtr_IsHuntingVBlood_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, 100689275);
      PlayerPresenceClientSystem.NativeMethodInfoPtr_TryGetBaseActivity_Private_Boolean_float2_Team_byref_PlayerActivities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, 100689276);
      PlayerPresenceClientSystem.NativeMethodInfoPtr_UpdateClanPresence_Private_Void_byref_PlayerPresence_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, 100689277);
      PlayerPresenceClientSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, 100689278);
      PlayerPresenceClientSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, 100689279);
      PlayerPresenceClientSystem.NativeMethodInfoPtr___GetEntityQuery_ForCheckVBloodTracking_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, 100689280);
      PlayerPresenceClientSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, 100689281);
    }

    public PlayerPresenceClientSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe double _TimeBetweenRichPresenceUpdates
    {
      get
      {
        double richPresenceUpdates;
        IL2CPP.il2cpp_field_static_get_value(PlayerPresenceClientSystem.NativeFieldInfoPtr__TimeBetweenRichPresenceUpdates, (void*) &richPresenceUpdates);
        return richPresenceUpdates;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerPresenceClientSystem.NativeFieldInfoPtr__TimeBetweenRichPresenceUpdates, (void*) &value);
      }
    }

    public unsafe EntityQuery _PlayerPresenceQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPresenceClientSystem.NativeFieldInfoPtr__PlayerPresenceQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPresenceClientSystem.NativeFieldInfoPtr__PlayerPresenceQuery)) = value;
      }
    }

    public unsafe EntityQuery _BuildMenuQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPresenceClientSystem.NativeFieldInfoPtr__BuildMenuQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPresenceClientSystem.NativeFieldInfoPtr__BuildMenuQuery)) = value;
      }
    }

    public unsafe TileModelSpatialLookupMap _TileModelSpatialLookupMap
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPresenceClientSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap));
        return pointer == System.IntPtr.Zero ? (TileModelSpatialLookupMap) null : new TileModelSpatialLookupMap(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerPresenceClientSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __CheckVBloodTracking_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPresenceClientSystem.NativeFieldInfoPtr___CheckVBloodTracking_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPresenceClientSystem.NativeFieldInfoPtr___CheckVBloodTracking_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CheckVBloodTracking_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPresenceClientSystem.NativeFieldInfoPtr___CheckVBloodTracking_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPresenceClientSystem.NativeFieldInfoPtr___CheckVBloodTracking_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalUser_58
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPresenceClientSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_58));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPresenceClientSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_58)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalCharacter_59
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPresenceClientSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_59));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPresenceClientSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_59)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Community.PlayerPresenceClientSystem/<>c__DisplayClass9_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass9_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_isHunting;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__IsHuntingVBlood_b__0_Internal_Void_byref_Buff_0;
      [FieldOffset(0)]
      public bool isHunting;
      [FieldOffset(4)]
      public Entity localPlayer;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass9_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _IsHuntingVBlood_b__0([In] ref Buff buff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref buff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__IsHuntingVBlood_b__0_Internal_Void_byref_Buff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass9_0()
      {
        Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, "<>c__DisplayClass9_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass9_0>.NativeClassPtr);
        PlayerPresenceClientSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_isHunting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (isHunting));
        PlayerPresenceClientSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_localPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (localPlayer));
        PlayerPresenceClientSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass9_0>.NativeClassPtr, 100689282);
        PlayerPresenceClientSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__IsHuntingVBlood_b__0_Internal_Void_byref_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass9_0>.NativeClassPtr, 100689283);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass9_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Community.PlayerPresenceClientSystem/ProjectM.Community.<>c__DisplayClass_CheckVBloodTracking")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CheckVBloodTracking
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_isHunting;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Buff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PlayerPresenceClientSystem_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public bool isHunting;
      [FieldOffset(4)]
      public Entity localPlayer;
      [FieldOffset(16)]
      public PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(48)]
      public unsafe PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1125433, RefRangeEnd = 1125434, XrefRangeStart = 1125432, XrefRangeEnd = 1125433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref Buff buff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref buff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Buff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1125434, RefRangeEnd = 1125436, XrefRangeStart = 1125434, XrefRangeEnd = 1125434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PlayerPresenceClientSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1125436, RefRangeEnd = 1125438, XrefRangeStart = 1125436, XrefRangeEnd = 1125436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PlayerPresenceClientSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125438, XrefRangeEnd = 1125440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1125445, RefRangeEnd = 1125446, XrefRangeStart = 1125440, XrefRangeEnd = 1125445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1125448, RefRangeEnd = 1125449, XrefRangeStart = 1125446, XrefRangeEnd = 1125448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PlayerPresenceClientSystem componentSystem,
        ref PlayerPresenceClientSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PlayerPresenceClientSystem_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125449, XrefRangeEnd = 1125453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125453, XrefRangeEnd = 1125459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CheckVBloodTracking()
      {
        Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerPresenceClientSystem>.NativeClassPtr, "<>c__DisplayClass_CheckVBloodTracking");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking>.NativeClassPtr);
        PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeFieldInfoPtr_isHunting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking>.NativeClassPtr, nameof (isHunting));
        PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeFieldInfoPtr_localPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking>.NativeClassPtr, nameof (localPlayer));
        PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking>.NativeClassPtr, nameof (_runtimes));
        PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking>.NativeClassPtr, 100689284);
        PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking>.NativeClassPtr, 100689285);
        PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking>.NativeClassPtr, 100689286);
        PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking>.NativeClassPtr, 100689287);
        PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking>.NativeClassPtr, 100689288);
        PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PlayerPresenceClientSystem_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking>.NativeClassPtr, 100689289);
        PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking>.NativeClassPtr, 100689290);
        PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking>.NativeClassPtr, 100689291);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PlayerPresenceClientSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1125352, RefRangeEnd = 1125353, XrefRangeStart = 1125349, XrefRangeEnd = 1125352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PlayerPresenceClientSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PlayerPresenceClientSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1125356, RefRangeEnd = 1125357, XrefRangeStart = 1125353, XrefRangeEnd = 1125356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PlayerPresenceClientSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.LambdaParameterValueProviders>.NativeClassPtr, 100689292);
          PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.LambdaParameterValueProviders>.NativeClassPtr, 100689293);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;

          static Runtimes()
          {
            Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Community.PlayerPresenceClientSystem/ProjectM.Community.<>c__DisplayClass_CheckVBloodTracking/ProjectM.Community.RunWithoutJobSystem_00005A9D$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking>.NativeClassPtr, "RunWithoutJobSystem_00005A9D$PostfixBurstDelegate");
          PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100689294);
          PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100689295);
          PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100689296);
          PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100689297);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Community.PlayerPresenceClientSystem/ProjectM.Community.<>c__DisplayClass_CheckVBloodTracking/ProjectM.Community.RunWithoutJobSystem_00005A9D$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125357, XrefRangeEnd = 1125371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125371, XrefRangeEnd = 1125389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125389, XrefRangeEnd = 1125404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1125431, RefRangeEnd = 1125432, XrefRangeStart = 1125404, XrefRangeEnd = 1125431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking>.NativeClassPtr, "RunWithoutJobSystem_00005A9D$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100689298);
          PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100689299);
          PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100689300);
          PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100689301);
          PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100689303);
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
            IL2CPP.il2cpp_field_static_get_value(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PlayerPresenceClientSystem.__c__DisplayClass_CheckVBloodTracking.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
