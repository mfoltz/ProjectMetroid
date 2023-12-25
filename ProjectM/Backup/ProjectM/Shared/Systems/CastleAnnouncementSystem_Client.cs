// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.Systems.CastleAnnouncementSystem_Client
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Gameplay.Clan;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Shared.Systems
{
  public class CastleAnnouncementSystem_Client : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__EventQueryBreach;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventQueryAttacked;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventQuerySiegeMaking;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleCastleBreachedEvent_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleCastleBreachedEvent_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleSiegeMakingEvent_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleSiegeMakingEvent_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleCastleAttackedEvent_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleCastleAttackedEvent_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleCastleBreachedEvent_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleSiegeMakingEvent_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleCastleAttackedEvent_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119497, XrefRangeEnd = 1119503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleAnnouncementSystem_Client.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119503, XrefRangeEnd = 1119576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleAnnouncementSystem_Client.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleAnnouncementSystem_Client()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119576, XrefRangeEnd = 1119659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleAnnouncementSystem_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119659, XrefRangeEnd = 1119675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleCastleBreachedEvent_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.NativeMethodInfoPtr___GetEntityQuery_ForHandleCastleBreachedEvent_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119675, XrefRangeEnd = 1119691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleSiegeMakingEvent_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.NativeMethodInfoPtr___GetEntityQuery_ForHandleSiegeMakingEvent_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119691, XrefRangeEnd = 1119707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleCastleAttackedEvent_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.NativeMethodInfoPtr___GetEntityQuery_ForHandleCastleAttackedEvent_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CastleAnnouncementSystem_Client()
    {
      Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Shared.Systems", nameof (CastleAnnouncementSystem_Client));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr);
      CastleAnnouncementSystem_Client.NativeFieldInfoPtr__EventQueryBreach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, nameof (_EventQueryBreach));
      CastleAnnouncementSystem_Client.NativeFieldInfoPtr__EventQueryAttacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, nameof (_EventQueryAttacked));
      CastleAnnouncementSystem_Client.NativeFieldInfoPtr__EventQuerySiegeMaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, nameof (_EventQuerySiegeMaking));
      CastleAnnouncementSystem_Client.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      CastleAnnouncementSystem_Client.NativeFieldInfoPtr___HandleCastleBreachedEvent_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, "<>HandleCastleBreachedEvent_entityQuery");
      CastleAnnouncementSystem_Client.NativeFieldInfoPtr___HandleCastleBreachedEvent_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, "<>HandleCastleBreachedEvent_profilerMarker");
      CastleAnnouncementSystem_Client.NativeFieldInfoPtr___HandleSiegeMakingEvent_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, "<>HandleSiegeMakingEvent_entityQuery");
      CastleAnnouncementSystem_Client.NativeFieldInfoPtr___HandleSiegeMakingEvent_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, "<>HandleSiegeMakingEvent_profilerMarker");
      CastleAnnouncementSystem_Client.NativeFieldInfoPtr___HandleCastleAttackedEvent_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, "<>HandleCastleAttackedEvent_entityQuery");
      CastleAnnouncementSystem_Client.NativeFieldInfoPtr___HandleCastleAttackedEvent_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, "<>HandleCastleAttackedEvent_profilerMarker");
      CastleAnnouncementSystem_Client.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, 100688795);
      CastleAnnouncementSystem_Client.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, 100688796);
      CastleAnnouncementSystem_Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, 100688797);
      CastleAnnouncementSystem_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, 100688798);
      CastleAnnouncementSystem_Client.NativeMethodInfoPtr___GetEntityQuery_ForHandleCastleBreachedEvent_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, 100688799);
      CastleAnnouncementSystem_Client.NativeMethodInfoPtr___GetEntityQuery_ForHandleSiegeMakingEvent_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, 100688800);
      CastleAnnouncementSystem_Client.NativeMethodInfoPtr___GetEntityQuery_ForHandleCastleAttackedEvent_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, 100688801);
    }

    public CastleAnnouncementSystem_Client(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _EventQueryBreach
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAnnouncementSystem_Client.NativeFieldInfoPtr__EventQueryBreach));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAnnouncementSystem_Client.NativeFieldInfoPtr__EventQueryBreach)) = value;
      }
    }

    public unsafe EntityQuery _EventQueryAttacked
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAnnouncementSystem_Client.NativeFieldInfoPtr__EventQueryAttacked));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAnnouncementSystem_Client.NativeFieldInfoPtr__EventQueryAttacked)) = value;
      }
    }

    public unsafe EntityQuery _EventQuerySiegeMaking
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAnnouncementSystem_Client.NativeFieldInfoPtr__EventQuerySiegeMaking));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAnnouncementSystem_Client.NativeFieldInfoPtr__EventQuerySiegeMaking)) = value;
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAnnouncementSystem_Client.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleAnnouncementSystem_Client.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __HandleCastleBreachedEvent_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAnnouncementSystem_Client.NativeFieldInfoPtr___HandleCastleBreachedEvent_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAnnouncementSystem_Client.NativeFieldInfoPtr___HandleCastleBreachedEvent_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleCastleBreachedEvent_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAnnouncementSystem_Client.NativeFieldInfoPtr___HandleCastleBreachedEvent_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAnnouncementSystem_Client.NativeFieldInfoPtr___HandleCastleBreachedEvent_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __HandleSiegeMakingEvent_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAnnouncementSystem_Client.NativeFieldInfoPtr___HandleSiegeMakingEvent_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAnnouncementSystem_Client.NativeFieldInfoPtr___HandleSiegeMakingEvent_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleSiegeMakingEvent_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAnnouncementSystem_Client.NativeFieldInfoPtr___HandleSiegeMakingEvent_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAnnouncementSystem_Client.NativeFieldInfoPtr___HandleSiegeMakingEvent_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __HandleCastleAttackedEvent_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAnnouncementSystem_Client.NativeFieldInfoPtr___HandleCastleAttackedEvent_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAnnouncementSystem_Client.NativeFieldInfoPtr___HandleCastleAttackedEvent_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleCastleAttackedEvent_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAnnouncementSystem_Client.NativeFieldInfoPtr___HandleCastleAttackedEvent_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleAnnouncementSystem_Client.NativeFieldInfoPtr___HandleCastleAttackedEvent_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Shared.Systems.CastleAnnouncementSystem_Client/<>c__DisplayClass5_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass5_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_clanSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_playBreachSound;
      private static readonly System.IntPtr NativeFieldInfoPtr_playGolemSound;
      private static readonly System.IntPtr NativeFieldInfoPtr_playAttackSound;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_CastleWallBreachedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_NewSiegeWeapon_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_CastleAttackedEvent_0;
      [FieldOffset(0)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(16)]
      public ClanSystemSettingsComponent clanSettings;
      [FieldOffset(592)]
      public bool playBreachSound;
      [FieldOffset(593)]
      public bool playGolemSound;
      [FieldOffset(594)]
      public bool playAttackSound;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass5_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, [In] ref CastleWallBreachedEvent evt)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_CastleWallBreachedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(Entity entity, [In] ref NewSiegeWeapon evt)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_NewSiegeWeapon_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(Entity entity, [In] ref CastleAttackedEvent evt)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_CastleAttackedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass5_0()
      {
        Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, "<>c__DisplayClass5_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass5_0>.NativeClassPtr);
        CastleAnnouncementSystem_Client.__c__DisplayClass5_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass5_0>.NativeClassPtr, nameof (commandBuffer));
        CastleAnnouncementSystem_Client.__c__DisplayClass5_0.NativeFieldInfoPtr_clanSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass5_0>.NativeClassPtr, nameof (clanSettings));
        CastleAnnouncementSystem_Client.__c__DisplayClass5_0.NativeFieldInfoPtr_playBreachSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass5_0>.NativeClassPtr, nameof (playBreachSound));
        CastleAnnouncementSystem_Client.__c__DisplayClass5_0.NativeFieldInfoPtr_playGolemSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass5_0>.NativeClassPtr, nameof (playGolemSound));
        CastleAnnouncementSystem_Client.__c__DisplayClass5_0.NativeFieldInfoPtr_playAttackSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass5_0>.NativeClassPtr, nameof (playAttackSound));
        CastleAnnouncementSystem_Client.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass5_0>.NativeClassPtr, 100688802);
        CastleAnnouncementSystem_Client.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_CastleWallBreachedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass5_0>.NativeClassPtr, 100688803);
        CastleAnnouncementSystem_Client.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_NewSiegeWeapon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass5_0>.NativeClassPtr, 100688804);
        CastleAnnouncementSystem_Client.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_CastleAttackedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass5_0>.NativeClassPtr, 100688805);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass5_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Shared.Systems.CastleAnnouncementSystem_Client/ProjectM.Shared.Systems.<>c__DisplayClass_HandleCastleBreachedEvent")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_HandleCastleBreachedEvent
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_clanSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_playBreachSound;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleWallBreachedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleAnnouncementSystem_Client_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      [FieldOffset(0)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(16)]
      public ClanSystemSettingsComponent clanSettings;
      [FieldOffset(592)]
      public bool playBreachSound;
      [FieldOffset(596)]
      public CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(608)]
      public unsafe CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1119408, RefRangeEnd = 1119409, XrefRangeStart = 1119405, XrefRangeEnd = 1119408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref CastleWallBreachedEvent evt)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleWallBreachedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1119409, RefRangeEnd = 1119410, XrefRangeStart = 1119409, XrefRangeEnd = 1119409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref CastleAnnouncementSystem_Client.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1119410, RefRangeEnd = 1119411, XrefRangeStart = 1119410, XrefRangeEnd = 1119410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref CastleAnnouncementSystem_Client.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119411, XrefRangeEnd = 1119413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1119419, RefRangeEnd = 1119420, XrefRangeStart = 1119413, XrefRangeEnd = 1119419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1119422, RefRangeEnd = 1119423, XrefRangeStart = 1119420, XrefRangeEnd = 1119422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        CastleAnnouncementSystem_Client componentSystem,
        ref CastleAnnouncementSystem_Client.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleAnnouncementSystem_Client_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119423, XrefRangeEnd = 1119429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleCastleBreachedEvent()
      {
        Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, "<>c__DisplayClass_HandleCastleBreachedEvent");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent>.NativeClassPtr);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent>.NativeClassPtr, nameof (commandBuffer));
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeFieldInfoPtr_clanSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent>.NativeClassPtr, nameof (clanSettings));
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeFieldInfoPtr_playBreachSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent>.NativeClassPtr, nameof (playBreachSound));
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent>.NativeClassPtr, nameof (_runtimes));
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleWallBreachedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent>.NativeClassPtr, 100688806);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent>.NativeClassPtr, 100688807);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent>.NativeClassPtr, 100688808);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent>.NativeClassPtr, 100688809);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent>.NativeClassPtr, 100688810);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleAnnouncementSystem_Client_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent>.NativeClassPtr, 100688811);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent>.NativeClassPtr, 100688812);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_evt;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleAnnouncementSystem_Client_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(4)]
        public LambdaParameterValueProvider_IComponentData_Tag<CastleWallBreachedEvent> forParameter_evt;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1119399, RefRangeEnd = 1119400, XrefRangeStart = 1119395, XrefRangeEnd = 1119399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(CastleAnnouncementSystem_Client componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleAnnouncementSystem_Client_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1119404, RefRangeEnd = 1119405, XrefRangeStart = 1119400, XrefRangeEnd = 1119404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_evt));
          CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleAnnouncementSystem_Client_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders>.NativeClassPtr, 100688813);
          CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders>.NativeClassPtr, 100688814);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_evt;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData_Tag<CastleWallBreachedEvent>.Runtime runtime_evt;

          static Runtimes()
          {
            Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_evt));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleBreachedEvent.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Shared.Systems.CastleAnnouncementSystem_Client/ProjectM.Shared.Systems.<>c__DisplayClass_HandleSiegeMakingEvent")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_HandleSiegeMakingEvent
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_clanSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_playGolemSound;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_NewSiegeWeapon_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleAnnouncementSystem_Client_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      [FieldOffset(0)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(16)]
      public ClanSystemSettingsComponent clanSettings;
      [FieldOffset(592)]
      public bool playGolemSound;
      [FieldOffset(596)]
      public CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(608)]
      public unsafe CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1119442, RefRangeEnd = 1119443, XrefRangeStart = 1119439, XrefRangeEnd = 1119442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref NewSiegeWeapon evt)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_NewSiegeWeapon_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1119443, RefRangeEnd = 1119444, XrefRangeStart = 1119443, XrefRangeEnd = 1119443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref CastleAnnouncementSystem_Client.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1119444, RefRangeEnd = 1119445, XrefRangeStart = 1119444, XrefRangeEnd = 1119444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref CastleAnnouncementSystem_Client.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119445, XrefRangeEnd = 1119447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1119453, RefRangeEnd = 1119454, XrefRangeStart = 1119447, XrefRangeEnd = 1119453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1119456, RefRangeEnd = 1119457, XrefRangeStart = 1119454, XrefRangeEnd = 1119456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        CastleAnnouncementSystem_Client componentSystem,
        ref CastleAnnouncementSystem_Client.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleAnnouncementSystem_Client_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119457, XrefRangeEnd = 1119463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleSiegeMakingEvent()
      {
        Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, "<>c__DisplayClass_HandleSiegeMakingEvent");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent>.NativeClassPtr);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent>.NativeClassPtr, nameof (commandBuffer));
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeFieldInfoPtr_clanSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent>.NativeClassPtr, nameof (clanSettings));
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeFieldInfoPtr_playGolemSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent>.NativeClassPtr, nameof (playGolemSound));
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent>.NativeClassPtr, nameof (_runtimes));
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_NewSiegeWeapon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent>.NativeClassPtr, 100688815);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent>.NativeClassPtr, 100688816);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent>.NativeClassPtr, 100688817);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent>.NativeClassPtr, 100688818);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent>.NativeClassPtr, 100688819);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleAnnouncementSystem_Client_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent>.NativeClassPtr, 100688820);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent>.NativeClassPtr, 100688821);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_evt;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleAnnouncementSystem_Client_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(4)]
        public LambdaParameterValueProvider_IComponentData_Tag<NewSiegeWeapon> forParameter_evt;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1119433, RefRangeEnd = 1119434, XrefRangeStart = 1119429, XrefRangeEnd = 1119433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(CastleAnnouncementSystem_Client componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleAnnouncementSystem_Client_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1119438, RefRangeEnd = 1119439, XrefRangeStart = 1119434, XrefRangeEnd = 1119438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_evt));
          CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleAnnouncementSystem_Client_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders>.NativeClassPtr, 100688822);
          CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders>.NativeClassPtr, 100688823);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_evt;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData_Tag<NewSiegeWeapon>.Runtime runtime_evt;

          static Runtimes()
          {
            Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_evt));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleSiegeMakingEvent.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Shared.Systems.CastleAnnouncementSystem_Client/ProjectM.Shared.Systems.<>c__DisplayClass_HandleCastleAttackedEvent")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_HandleCastleAttackedEvent
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_clanSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_playAttackSound;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleAttackedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleAnnouncementSystem_Client_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      [FieldOffset(0)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(16)]
      public ClanSystemSettingsComponent clanSettings;
      [FieldOffset(592)]
      public bool playAttackSound;
      [FieldOffset(596)]
      public CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(608)]
      public unsafe CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1119476, RefRangeEnd = 1119477, XrefRangeStart = 1119473, XrefRangeEnd = 1119476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref CastleAttackedEvent evt)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleAttackedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1119477, RefRangeEnd = 1119478, XrefRangeStart = 1119477, XrefRangeEnd = 1119477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref CastleAnnouncementSystem_Client.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1119478, RefRangeEnd = 1119479, XrefRangeStart = 1119478, XrefRangeEnd = 1119478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref CastleAnnouncementSystem_Client.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119479, XrefRangeEnd = 1119481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1119487, RefRangeEnd = 1119488, XrefRangeStart = 1119481, XrefRangeEnd = 1119487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1119490, RefRangeEnd = 1119491, XrefRangeStart = 1119488, XrefRangeEnd = 1119490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        CastleAnnouncementSystem_Client componentSystem,
        ref CastleAnnouncementSystem_Client.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleAnnouncementSystem_Client_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119491, XrefRangeEnd = 1119497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleCastleAttackedEvent()
      {
        Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleAnnouncementSystem_Client>.NativeClassPtr, "<>c__DisplayClass_HandleCastleAttackedEvent");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent>.NativeClassPtr);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent>.NativeClassPtr, nameof (commandBuffer));
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeFieldInfoPtr_clanSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent>.NativeClassPtr, nameof (clanSettings));
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeFieldInfoPtr_playAttackSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent>.NativeClassPtr, nameof (playAttackSound));
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent>.NativeClassPtr, nameof (_runtimes));
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleAttackedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent>.NativeClassPtr, 100688824);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent>.NativeClassPtr, 100688825);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent>.NativeClassPtr, 100688826);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent>.NativeClassPtr, 100688827);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent>.NativeClassPtr, 100688828);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleAnnouncementSystem_Client_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent>.NativeClassPtr, 100688829);
        CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent>.NativeClassPtr, 100688830);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_evt;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleAnnouncementSystem_Client_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(4)]
        public LambdaParameterValueProvider_IComponentData_Tag<CastleAttackedEvent> forParameter_evt;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1119467, RefRangeEnd = 1119468, XrefRangeStart = 1119463, XrefRangeEnd = 1119467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(CastleAnnouncementSystem_Client componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleAnnouncementSystem_Client_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1119472, RefRangeEnd = 1119473, XrefRangeStart = 1119468, XrefRangeEnd = 1119472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_evt));
          CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleAnnouncementSystem_Client_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders>.NativeClassPtr, 100688831);
          CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders>.NativeClassPtr, 100688832);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_evt;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData_Tag<CastleAttackedEvent>.Runtime runtime_evt;

          static Runtimes()
          {
            Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_evt));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleAnnouncementSystem_Client.__c__DisplayClass_HandleCastleAttackedEvent.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
