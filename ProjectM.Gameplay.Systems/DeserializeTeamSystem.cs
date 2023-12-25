// Decompiled with JetBrains decompiler
// Type: ProjectM.DeserializeTeamSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class DeserializeTeamSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__DeserializedCastleHearts;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChangedCastleHeartTeams;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChangedCastleHeartConnections;
    private static readonly System.IntPtr NativeFieldInfoPtr___DeserializeCastleParts_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DeserializeCastleParts_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___DeserializeCastleHearts_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DeserializeCastleHearts_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateTeamOnCastleParts_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateTeamOnCastleParts_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDeserializeCastleParts_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDeserializeCastleHearts_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateTeamOnCastleParts_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1393085, XrefRangeEnd = 1393088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DeserializeTeamSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1393088, XrefRangeEnd = 1393091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DeserializeTeamSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1393091, XrefRangeEnd = 1393145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DeserializeTeamSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DeserializeTeamSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1393145, XrefRangeEnd = 1393195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DeserializeTeamSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1393226, RefRangeEnd = 1393227, XrefRangeStart = 1393195, XrefRangeEnd = 1393226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDeserializeCastleParts_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.NativeMethodInfoPtr___GetEntityQuery_ForDeserializeCastleParts_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1393255, RefRangeEnd = 1393256, XrefRangeStart = 1393227, XrefRangeEnd = 1393255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDeserializeCastleHearts_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.NativeMethodInfoPtr___GetEntityQuery_ForDeserializeCastleHearts_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1393281, RefRangeEnd = 1393282, XrefRangeStart = 1393256, XrefRangeEnd = 1393281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateTeamOnCastleParts_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateTeamOnCastleParts_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1393286, RefRangeEnd = 1393287, XrefRangeStart = 1393282, XrefRangeEnd = 1393286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1393291, RefRangeEnd = 1393292, XrefRangeStart = 1393287, XrefRangeEnd = 1393291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1393296, RefRangeEnd = 1393297, XrefRangeStart = 1393292, XrefRangeEnd = 1393296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DeserializeTeamSystem()
    {
      Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (DeserializeTeamSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr);
      DeserializeTeamSystem.NativeFieldInfoPtr__DeserializedCastleHearts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, nameof (_DeserializedCastleHearts));
      DeserializeTeamSystem.NativeFieldInfoPtr__ChangedCastleHeartTeams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, nameof (_ChangedCastleHeartTeams));
      DeserializeTeamSystem.NativeFieldInfoPtr__ChangedCastleHeartConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, nameof (_ChangedCastleHeartConnections));
      DeserializeTeamSystem.NativeFieldInfoPtr___DeserializeCastleParts_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, "<>DeserializeCastleParts_entityQuery");
      DeserializeTeamSystem.NativeFieldInfoPtr___DeserializeCastleParts_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, "<>DeserializeCastleParts_profilerMarker");
      DeserializeTeamSystem.NativeFieldInfoPtr___DeserializeCastleHearts_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, "<>DeserializeCastleHearts_entityQuery");
      DeserializeTeamSystem.NativeFieldInfoPtr___DeserializeCastleHearts_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, "<>DeserializeCastleHearts_profilerMarker");
      DeserializeTeamSystem.NativeFieldInfoPtr___UpdateTeamOnCastleParts_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, "<>UpdateTeamOnCastleParts_entityQuery");
      DeserializeTeamSystem.NativeFieldInfoPtr___UpdateTeamOnCastleParts_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, "<>UpdateTeamOnCastleParts_profilerMarker");
      DeserializeTeamSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, 100666643);
      DeserializeTeamSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, 100666644);
      DeserializeTeamSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, 100666645);
      DeserializeTeamSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, 100666646);
      DeserializeTeamSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, 100666647);
      DeserializeTeamSystem.NativeMethodInfoPtr___GetEntityQuery_ForDeserializeCastleParts_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, 100666648);
      DeserializeTeamSystem.NativeMethodInfoPtr___GetEntityQuery_ForDeserializeCastleHearts_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, 100666649);
      DeserializeTeamSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateTeamOnCastleParts_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, 100666650);
      DeserializeTeamSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, 100666651);
      DeserializeTeamSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, 100666652);
      DeserializeTeamSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, 100666653);
    }

    public DeserializeTeamSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeList<DeserializeTeamSystem.DeserializedCastleHeart> _DeserializedCastleHearts
    {
      get
      {
        return *(NativeList<DeserializeTeamSystem.DeserializedCastleHeart>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeTeamSystem.NativeFieldInfoPtr__DeserializedCastleHearts));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeTeamSystem.NativeFieldInfoPtr__DeserializedCastleHearts), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<DeserializeTeamSystem.DeserializedCastleHeart>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _ChangedCastleHeartTeams
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeTeamSystem.NativeFieldInfoPtr__ChangedCastleHeartTeams));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeTeamSystem.NativeFieldInfoPtr__ChangedCastleHeartTeams)) = value;
      }
    }

    public unsafe EntityQuery _ChangedCastleHeartConnections
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeTeamSystem.NativeFieldInfoPtr__ChangedCastleHeartConnections));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeTeamSystem.NativeFieldInfoPtr__ChangedCastleHeartConnections)) = value;
      }
    }

    public unsafe EntityQuery __DeserializeCastleParts_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeTeamSystem.NativeFieldInfoPtr___DeserializeCastleParts_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeTeamSystem.NativeFieldInfoPtr___DeserializeCastleParts_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __DeserializeCastleParts_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeTeamSystem.NativeFieldInfoPtr___DeserializeCastleParts_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeTeamSystem.NativeFieldInfoPtr___DeserializeCastleParts_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __DeserializeCastleHearts_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeTeamSystem.NativeFieldInfoPtr___DeserializeCastleHearts_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeTeamSystem.NativeFieldInfoPtr___DeserializeCastleHearts_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __DeserializeCastleHearts_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeTeamSystem.NativeFieldInfoPtr___DeserializeCastleHearts_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeTeamSystem.NativeFieldInfoPtr___DeserializeCastleHearts_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateTeamOnCastleParts_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeTeamSystem.NativeFieldInfoPtr___UpdateTeamOnCastleParts_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeTeamSystem.NativeFieldInfoPtr___UpdateTeamOnCastleParts_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateTeamOnCastleParts_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeTeamSystem.NativeFieldInfoPtr___UpdateTeamOnCastleParts_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializeTeamSystem.NativeFieldInfoPtr___UpdateTeamOnCastleParts_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DeserializedCastleHeart
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeart;
      private static readonly System.IntPtr NativeFieldInfoPtr_Team;
      [FieldOffset(0)]
      public Entity CastleHeart;
      [FieldOffset(8)]
      public Team Team;

      static DeserializedCastleHeart()
      {
        Il2CppClassPointerStore<DeserializeTeamSystem.DeserializedCastleHeart>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, nameof (DeserializedCastleHeart));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeserializeTeamSystem.DeserializedCastleHeart>.NativeClassPtr);
        DeserializeTeamSystem.DeserializedCastleHeart.NativeFieldInfoPtr_CastleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.DeserializedCastleHeart>.NativeClassPtr, nameof (CastleHeart));
        DeserializeTeamSystem.DeserializedCastleHeart.NativeFieldInfoPtr_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.DeserializedCastleHeart>.NativeClassPtr, nameof (Team));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeserializeTeamSystem.DeserializedCastleHeart>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DeserializeTeamSystem/<>c__DisplayClass6_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass6_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_deserializedCastleHearts;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_Team_byref_CastleHeartConnection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_CastleHeartCurrentTeam_byref_Team_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeList<DeserializeTeamSystem.DeserializedCastleHeart> deserializedCastleHearts;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass6_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        ref Team team,
        [In] ref CastleHeartConnection castleHeartConnection)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref team;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartConnection;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_Team_byref_CastleHeartConnection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        ref CastleHeartCurrentTeam castleHeartCurrentTeam,
        [In] ref Team team)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartCurrentTeam;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref team;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_CastleHeartCurrentTeam_byref_Team_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass6_0()
      {
        Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, "<>c__DisplayClass6_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass6_0>.NativeClassPtr);
        DeserializeTeamSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (entityManager));
        DeserializeTeamSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_deserializedCastleHearts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (deserializedCastleHearts));
        DeserializeTeamSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass6_0>.NativeClassPtr, 100666654);
        DeserializeTeamSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_Team_byref_CastleHeartConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass6_0>.NativeClassPtr, 100666655);
        DeserializeTeamSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_CastleHeartCurrentTeam_byref_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass6_0>.NativeClassPtr, 100666656);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass6_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DeserializeTeamSystem/<>c__DisplayClass6_1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass6_1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_deserializedCastleHeart;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_Team_byref_CastleHeartConnection_0;
      [FieldOffset(0)]
      public DeserializeTeamSystem.DeserializedCastleHeart deserializedCastleHeart;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass6_1()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass6_1.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        ref Team team,
        [In] ref CastleHeartConnection castleHeartConnection)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref team;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartConnection;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass6_1.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_Team_byref_CastleHeartConnection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass6_1()
      {
        Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass6_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, "<>c__DisplayClass6_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass6_1>.NativeClassPtr);
        DeserializeTeamSystem.__c__DisplayClass6_1.NativeFieldInfoPtr_deserializedCastleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass6_1>.NativeClassPtr, nameof (deserializedCastleHeart));
        DeserializeTeamSystem.__c__DisplayClass6_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass6_1>.NativeClassPtr, 100666657);
        DeserializeTeamSystem.__c__DisplayClass6_1.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_Team_byref_CastleHeartConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass6_1>.NativeClassPtr, 100666658);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass6_1>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DeserializeTeamSystem/ProjectM.<>c__DisplayClass_DeserializeCastleParts")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_DeserializeCastleParts
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Team_byref_CastleHeartConnection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DeserializeTeamSystem_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(72)]
      public unsafe DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392821, XrefRangeEnd = 1392825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref Team team,
        [In] ref CastleHeartConnection castleHeartConnection)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref team;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartConnection;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Team_byref_CastleHeartConnection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(46)]
      [CachedScanResults(RefRangeStart = 927059, RefRangeEnd = 927105, XrefRangeStart = 927059, XrefRangeEnd = 927105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DeserializeTeamSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(47)]
      [CachedScanResults(RefRangeStart = 927105, RefRangeEnd = 927152, XrefRangeStart = 927105, XrefRangeEnd = 927152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DeserializeTeamSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392825, XrefRangeEnd = 1392827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1392835, RefRangeEnd = 1392836, XrefRangeStart = 1392827, XrefRangeEnd = 1392835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1392838, RefRangeEnd = 1392839, XrefRangeStart = 1392836, XrefRangeEnd = 1392838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DeserializeTeamSystem componentSystem,
        ref DeserializeTeamSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DeserializeTeamSystem_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392839, XrefRangeEnd = 1392843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392843, XrefRangeEnd = 1392849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DeserializeCastleParts()
      {
        Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, "<>c__DisplayClass_DeserializeCastleParts");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts>.NativeClassPtr);
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts>.NativeClassPtr, nameof (entityManager));
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts>.NativeClassPtr, nameof (_runtimes));
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Team_byref_CastleHeartConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts>.NativeClassPtr, 100666659);
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts>.NativeClassPtr, 100666660);
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts>.NativeClassPtr, 100666661);
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts>.NativeClassPtr, 100666662);
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts>.NativeClassPtr, 100666663);
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DeserializeTeamSystem_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts>.NativeClassPtr, 100666664);
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts>.NativeClassPtr, 100666665);
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts>.NativeClassPtr, 100666666);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_team;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castleHeartConnection;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DeserializeTeamSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<Team> forParameter_team;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<CastleHeartConnection> forParameter_castleHeartConnection;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1392738, RefRangeEnd = 1392739, XrefRangeStart = 1392732, XrefRangeEnd = 1392738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DeserializeTeamSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DeserializeTeamSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1392745, RefRangeEnd = 1392746, XrefRangeStart = 1392739, XrefRangeEnd = 1392745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_team));
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castleHeartConnection));
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DeserializeTeamSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders>.NativeClassPtr, 100666667);
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders>.NativeClassPtr, 100666668);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_team;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castleHeartConnection;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<Team>.Runtime runtime_team;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<CastleHeartConnection>.Runtime runtime_castleHeartConnection;

          static Runtimes()
          {
            Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_team));
            DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castleHeartConnection));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.DeserializeTeamSystem/ProjectM.<>c__DisplayClass_DeserializeCastleParts/ProjectM.RunWithoutJobSystem_000007FE$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts>.NativeClassPtr, "RunWithoutJobSystem_000007FE$PostfixBurstDelegate");
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666669);
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666670);
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666671);
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666672);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.DeserializeTeamSystem/ProjectM.<>c__DisplayClass_DeserializeCastleParts/ProjectM.RunWithoutJobSystem_000007FE$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392746, XrefRangeEnd = 1392760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392760, XrefRangeEnd = 1392778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392778, XrefRangeEnd = 1392793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1392820, RefRangeEnd = 1392821, XrefRangeStart = 1392793, XrefRangeEnd = 1392820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts>.NativeClassPtr, "RunWithoutJobSystem_000007FE$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666673);
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666674);
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666675);
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666676);
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666678);
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
            IL2CPP.il2cpp_field_static_get_value(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DeserializeTeamSystem/ProjectM.<>c__DisplayClass_DeserializeCastleHearts")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_DeserializeCastleHearts
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_deserializedCastleHearts;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleHeartCurrentTeam_byref_Team_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DeserializeTeamSystem_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeList<DeserializeTeamSystem.DeserializedCastleHeart> deserializedCastleHearts;
      [FieldOffset(16)]
      public DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392940, XrefRangeEnd = 1392944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref CastleHeartCurrentTeam castleHeartCurrentTeam,
        [In] ref Team team)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartCurrentTeam;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref team;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleHeartCurrentTeam_byref_Team_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(34)]
      [CachedScanResults(RefRangeStart = 723251, RefRangeEnd = 723285, XrefRangeStart = 723251, XrefRangeEnd = 723285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DeserializeTeamSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(34)]
      [CachedScanResults(RefRangeStart = 723285, RefRangeEnd = 723319, XrefRangeStart = 723285, XrefRangeEnd = 723319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DeserializeTeamSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392944, XrefRangeEnd = 1392946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1392955, RefRangeEnd = 1392956, XrefRangeStart = 1392946, XrefRangeEnd = 1392955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1392958, RefRangeEnd = 1392959, XrefRangeStart = 1392956, XrefRangeEnd = 1392958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DeserializeTeamSystem componentSystem,
        ref DeserializeTeamSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DeserializeTeamSystem_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392959, XrefRangeEnd = 1392963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392963, XrefRangeEnd = 1392969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DeserializeCastleHearts()
      {
        Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, "<>c__DisplayClass_DeserializeCastleHearts");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr);
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeFieldInfoPtr_deserializedCastleHearts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, nameof (deserializedCastleHearts));
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, nameof (_runtimes));
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleHeartCurrentTeam_byref_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, 100666679);
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, 100666680);
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, 100666681);
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, 100666682);
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, 100666683);
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DeserializeTeamSystem_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, 100666684);
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, 100666685);
        DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, 100666686);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castleHeartCurrentTeam;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_team;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DeserializeTeamSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<CastleHeartCurrentTeam> forParameter_castleHeartCurrentTeam;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Team> forParameter_team;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1392856, RefRangeEnd = 1392857, XrefRangeStart = 1392849, XrefRangeEnd = 1392856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DeserializeTeamSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DeserializeTeamSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1392864, RefRangeEnd = 1392865, XrefRangeStart = 1392857, XrefRangeEnd = 1392864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castleHeartCurrentTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castleHeartCurrentTeam));
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_team));
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DeserializeTeamSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, 100666687);
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, 100666688);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castleHeartCurrentTeam;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_team;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<CastleHeartCurrentTeam>.Runtime runtime_castleHeartCurrentTeam;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Team>.Runtime runtime_team;

          static Runtimes()
          {
            Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castleHeartCurrentTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castleHeartCurrentTeam));
            DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_team));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.DeserializeTeamSystem/ProjectM.<>c__DisplayClass_DeserializeCastleHearts/ProjectM.RunWithoutJobSystem_00000807$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, "RunWithoutJobSystem_00000807$PostfixBurstDelegate");
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666689);
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666690);
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666691);
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666692);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.DeserializeTeamSystem/ProjectM.<>c__DisplayClass_DeserializeCastleHearts/ProjectM.RunWithoutJobSystem_00000807$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392865, XrefRangeEnd = 1392879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392879, XrefRangeEnd = 1392897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392897, XrefRangeEnd = 1392912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1392939, RefRangeEnd = 1392940, XrefRangeStart = 1392912, XrefRangeEnd = 1392939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, "RunWithoutJobSystem_00000807$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666693);
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666694);
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666695);
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666696);
          DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666698);
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
            IL2CPP.il2cpp_field_static_get_value(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DeserializeTeamSystem.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DeserializeTeamSystem/ProjectM.<>c__DisplayClass_UpdateTeamOnCastleParts")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateTeamOnCastleParts
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_deserializedCastleHeart;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Team_byref_CastleHeartConnection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DeserializeTeamSystem_byref___c__DisplayClass6_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public DeserializeTeamSystem.DeserializedCastleHeart deserializedCastleHeart;
      [FieldOffset(16)]
      public DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1393060, RefRangeEnd = 1393061, XrefRangeStart = 1393058, XrefRangeEnd = 1393060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref Team team,
        [In] ref CastleHeartConnection castleHeartConnection)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref team;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartConnection;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Team_byref_CastleHeartConnection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DeserializeTeamSystem.__c__DisplayClass6_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DeserializeTeamSystem.__c__DisplayClass6_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1393061, XrefRangeEnd = 1393063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1393071, RefRangeEnd = 1393072, XrefRangeStart = 1393063, XrefRangeEnd = 1393071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1393074, RefRangeEnd = 1393075, XrefRangeStart = 1393072, XrefRangeEnd = 1393074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DeserializeTeamSystem componentSystem,
        ref DeserializeTeamSystem.__c__DisplayClass6_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DeserializeTeamSystem_byref___c__DisplayClass6_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1393075, XrefRangeEnd = 1393079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1393079, XrefRangeEnd = 1393085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateTeamOnCastleParts()
      {
        Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializeTeamSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateTeamOnCastleParts");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts>.NativeClassPtr);
        DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeFieldInfoPtr_deserializedCastleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts>.NativeClassPtr, nameof (deserializedCastleHeart));
        DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts>.NativeClassPtr, nameof (_runtimes));
        DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Team_byref_CastleHeartConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts>.NativeClassPtr, 100666699);
        DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts>.NativeClassPtr, 100666700);
        DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts>.NativeClassPtr, 100666701);
        DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts>.NativeClassPtr, 100666702);
        DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts>.NativeClassPtr, 100666703);
        DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DeserializeTeamSystem_byref___c__DisplayClass6_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts>.NativeClassPtr, 100666704);
        DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts>.NativeClassPtr, 100666705);
        DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts>.NativeClassPtr, 100666706);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_team;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castleHeartConnection;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DeserializeTeamSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<Team> forParameter_team;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<CastleHeartConnection> forParameter_castleHeartConnection;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1392975, RefRangeEnd = 1392976, XrefRangeStart = 1392969, XrefRangeEnd = 1392975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DeserializeTeamSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DeserializeTeamSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1392982, RefRangeEnd = 1392983, XrefRangeStart = 1392976, XrefRangeEnd = 1392982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_team));
          DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castleHeartConnection));
          DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DeserializeTeamSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders>.NativeClassPtr, 100666707);
          DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders>.NativeClassPtr, 100666708);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_team;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castleHeartConnection;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<Team>.Runtime runtime_team;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<CastleHeartConnection>.Runtime runtime_castleHeartConnection;

          static Runtimes()
          {
            Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_team));
            DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castleHeartConnection));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.DeserializeTeamSystem/ProjectM.<>c__DisplayClass_UpdateTeamOnCastleParts/ProjectM.RunWithoutJobSystem_00000810$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts>.NativeClassPtr, "RunWithoutJobSystem_00000810$PostfixBurstDelegate");
          DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666709);
          DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666710);
          DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666711);
          DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666712);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.DeserializeTeamSystem/ProjectM.<>c__DisplayClass_UpdateTeamOnCastleParts/ProjectM.RunWithoutJobSystem_00000810$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392983, XrefRangeEnd = 1392997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392997, XrefRangeEnd = 1393015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1393015, XrefRangeEnd = 1393030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1393057, RefRangeEnd = 1393058, XrefRangeStart = 1393030, XrefRangeEnd = 1393057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts>.NativeClassPtr, "RunWithoutJobSystem_00000810$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666713);
          DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666714);
          DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666715);
          DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666716);
          DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666718);
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
            IL2CPP.il2cpp_field_static_get_value(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DeserializeTeamSystem.__c__DisplayClass_UpdateTeamOnCastleParts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
