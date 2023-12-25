// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_EvenSpreadCluster
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.Scripting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_EvenSpreadCluster : GameplayScriptBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ClusterAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_IndividualRandom;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseAimDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlwaysMaxRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnSpawn;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDestroy;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177195, XrefRangeEnd = 1177201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_EvenSpreadCluster.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177201, XrefRangeEnd = 1177202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_EvenSpreadCluster()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_EvenSpreadCluster>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_EvenSpreadCluster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_EvenSpreadCluster()
    {
      Il2CppClassPointerStore<Script_EvenSpreadCluster>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_EvenSpreadCluster));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_EvenSpreadCluster>.NativeClassPtr);
      Script_EvenSpreadCluster.NativeFieldInfoPtr_ClusterAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster>.NativeClassPtr, nameof (ClusterAsset));
      Script_EvenSpreadCluster.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster>.NativeClassPtr, nameof (Count));
      Script_EvenSpreadCluster.NativeFieldInfoPtr_OffsetAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster>.NativeClassPtr, nameof (OffsetAngle));
      Script_EvenSpreadCluster.NativeFieldInfoPtr_RandomAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster>.NativeClassPtr, nameof (RandomAngle));
      Script_EvenSpreadCluster.NativeFieldInfoPtr_IndividualRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster>.NativeClassPtr, nameof (IndividualRandom));
      Script_EvenSpreadCluster.NativeFieldInfoPtr_UseAimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster>.NativeClassPtr, nameof (UseAimDirection));
      Script_EvenSpreadCluster.NativeFieldInfoPtr_AlwaysMaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster>.NativeClassPtr, nameof (AlwaysMaxRange));
      Script_EvenSpreadCluster.NativeFieldInfoPtr_OnSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster>.NativeClassPtr, nameof (OnSpawn));
      Script_EvenSpreadCluster.NativeFieldInfoPtr_OnDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster>.NativeClassPtr, nameof (OnDestroy));
      Script_EvenSpreadCluster.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster>.NativeClassPtr, nameof (SpellMods));
      Script_EvenSpreadCluster.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_EvenSpreadCluster>.NativeClassPtr, 100663608);
      Script_EvenSpreadCluster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_EvenSpreadCluster>.NativeClassPtr, 100663609);
    }

    public Script_EvenSpreadCluster(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> ClusterAsset
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.NativeFieldInfoPtr_ClusterAsset));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.NativeFieldInfoPtr_ClusterAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int Count
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.NativeFieldInfoPtr_Count));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.NativeFieldInfoPtr_Count)) = value;
      }
    }

    public unsafe float OffsetAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.NativeFieldInfoPtr_OffsetAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.NativeFieldInfoPtr_OffsetAngle)) = value;
      }
    }

    public unsafe float RandomAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.NativeFieldInfoPtr_RandomAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.NativeFieldInfoPtr_RandomAngle)) = value;
      }
    }

    public unsafe bool IndividualRandom
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.NativeFieldInfoPtr_IndividualRandom));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.NativeFieldInfoPtr_IndividualRandom)) = value;
      }
    }

    public unsafe bool UseAimDirection
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.NativeFieldInfoPtr_UseAimDirection));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.NativeFieldInfoPtr_UseAimDirection)) = value;
      }
    }

    public unsafe bool AlwaysMaxRange
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.NativeFieldInfoPtr_AlwaysMaxRange));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.NativeFieldInfoPtr_AlwaysMaxRange)) = value;
      }
    }

    public unsafe bool OnSpawn
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.NativeFieldInfoPtr_OnSpawn));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.NativeFieldInfoPtr_OnSpawn)) = value;
      }
    }

    public unsafe bool OnDestroy
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.NativeFieldInfoPtr_OnDestroy));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.NativeFieldInfoPtr_OnDestroy)) = value;
      }
    }

    public Script_EvenSpreadCluster.SpellModsAuthoring SpellMods
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.NativeFieldInfoPtr_SpellMods);
        return new Script_EvenSpreadCluster.SpellModsAuthoring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_EvenSpreadCluster.SpellModsAuthoring>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.NativeFieldInfoPtr_SpellMods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Script_EvenSpreadCluster.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [Serializable]
    public sealed class SpellModsAuthoring : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Count;

      static SpellModsAuthoring()
      {
        Il2CppClassPointerStore<Script_EvenSpreadCluster.SpellModsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_EvenSpreadCluster>.NativeClassPtr, nameof (SpellModsAuthoring));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_EvenSpreadCluster.SpellModsAuthoring>.NativeClassPtr);
        Script_EvenSpreadCluster.SpellModsAuthoring.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster.SpellModsAuthoring>.NativeClassPtr, nameof (Count));
      }

      public SpellModsAuthoring(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SpellModsAuthoring()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Script_EvenSpreadCluster.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_EvenSpreadCluster.SpellModsAuthoring>.NativeClassPtr, data));
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> Count
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.SpellModsAuthoring.NativeFieldInfoPtr_Count));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster.SpellModsAuthoring.NativeFieldInfoPtr_Count), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public class Server : ServerScript
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SpawnCluster_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_EvenSpreadCluster_DataServer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SpawnClusterThrow_Public_Static_Void_ServerGameManager_SelfServer_PrefabGUID_float3_float3_byref_Random_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177153, XrefRangeEnd = 1177157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_EvenSpreadCluster.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177157, XrefRangeEnd = 1177161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Destroy(ref ServerGameManager game, [In] ref SelfServer self)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_EvenSpreadCluster.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1177175, RefRangeEnd = 1177177, XrefRangeStart = 1177161, XrefRangeEnd = 1177175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void SpawnCluster(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        EvenSpreadCluster_DataServer dataServer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dataServer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_EvenSpreadCluster.Server.NativeMethodInfoPtr_SpawnCluster_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_EvenSpreadCluster_DataServer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1177193, RefRangeEnd = 1177195, XrefRangeStart = 1177177, XrefRangeEnd = 1177193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void SpawnClusterThrow(
        ServerGameManager game,
        SelfServer self,
        PrefabGUID throwPrefabGuid,
        float3 startPosition,
        float3 throwDirection,
        ref Unity.Mathematics.Random random,
        bool alwaysMaxRange = false,
        bool dontSpawnInCollision = true)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[8];
        numPtr[0] = (System.IntPtr) &game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &throwPrefabGuid;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &startPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &throwDirection;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &alwaysMaxRange;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &dontSpawnInCollision;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_EvenSpreadCluster.Server.NativeMethodInfoPtr_SpawnClusterThrow_Public_Static_Void_ServerGameManager_SelfServer_PrefabGUID_float3_float3_byref_Random_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_EvenSpreadCluster.Server>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_EvenSpreadCluster.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_EvenSpreadCluster.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_EvenSpreadCluster>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_EvenSpreadCluster.Server>.NativeClassPtr);
        Script_EvenSpreadCluster.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_EvenSpreadCluster.Server>.NativeClassPtr, 100663610);
        Script_EvenSpreadCluster.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_EvenSpreadCluster.Server>.NativeClassPtr, 100663611);
        Script_EvenSpreadCluster.Server.NativeMethodInfoPtr_SpawnCluster_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_EvenSpreadCluster_DataServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_EvenSpreadCluster.Server>.NativeClassPtr, 100663612);
        Script_EvenSpreadCluster.Server.NativeMethodInfoPtr_SpawnClusterThrow_Public_Static_Void_ServerGameManager_SelfServer_PrefabGUID_float3_float3_byref_Random_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_EvenSpreadCluster.Server>.NativeClassPtr, 100663613);
        Script_EvenSpreadCluster.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_EvenSpreadCluster.Server>.NativeClassPtr, 100663614);
      }

      public Server(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
