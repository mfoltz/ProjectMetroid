// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_BouncingProjectile
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_BouncingProjectile : GameplayScriptBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Settings;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177006, XrefRangeEnd = 1177020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_BouncingProjectile.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177020, XrefRangeEnd = 1177022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_BouncingProjectile()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_BouncingProjectile>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_BouncingProjectile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_BouncingProjectile()
    {
      Il2CppClassPointerStore<Script_BouncingProjectile>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_BouncingProjectile));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_BouncingProjectile>.NativeClassPtr);
      Script_BouncingProjectile.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BouncingProjectile>.NativeClassPtr, nameof (Settings));
      Script_BouncingProjectile.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BouncingProjectile>.NativeClassPtr, 100663575);
      Script_BouncingProjectile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BouncingProjectile>.NativeClassPtr, 100663576);
    }

    public Script_BouncingProjectile(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public BouncingProjectileData_Editor Settings
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BouncingProjectile.NativeFieldInfoPtr_Settings);
        return new BouncingProjectileData_Editor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BouncingProjectile.NativeFieldInfoPtr_Settings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct BounceTarget
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Priority;
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_Position;
      [FieldOffset(0)]
      public float Priority;
      [FieldOffset(4)]
      public Entity Entity;
      [FieldOffset(12)]
      public float3 Position;

      static BounceTarget()
      {
        Il2CppClassPointerStore<Script_BouncingProjectile.BounceTarget>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_BouncingProjectile>.NativeClassPtr, nameof (BounceTarget));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_BouncingProjectile.BounceTarget>.NativeClassPtr);
        Script_BouncingProjectile.BounceTarget.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BouncingProjectile.BounceTarget>.NativeClassPtr, nameof (Priority));
        Script_BouncingProjectile.BounceTarget.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BouncingProjectile.BounceTarget>.NativeClassPtr, nameof (Entity));
        Script_BouncingProjectile.BounceTarget.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BouncingProjectile.BounceTarget>.NativeClassPtr, nameof (Position));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_BouncingProjectile.BounceTarget>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct BounceTargetSorter
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_BreakerValue;
      private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_BounceTarget_BounceTarget_0;
      [FieldOffset(0)]
      public TieBreakerValue BreakerValue;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176680, XrefRangeEnd = 1176681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int Compare(
        Script_BouncingProjectile.BounceTarget x,
        Script_BouncingProjectile.BounceTarget y)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_BouncingProjectile.BounceTargetSorter.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_BounceTarget_BounceTarget_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static BounceTargetSorter()
      {
        Il2CppClassPointerStore<Script_BouncingProjectile.BounceTargetSorter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_BouncingProjectile>.NativeClassPtr, nameof (BounceTargetSorter));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_BouncingProjectile.BounceTargetSorter>.NativeClassPtr);
        Script_BouncingProjectile.BounceTargetSorter.NativeFieldInfoPtr_BreakerValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BouncingProjectile.BounceTargetSorter>.NativeClassPtr, nameof (BreakerValue));
        Script_BouncingProjectile.BounceTargetSorter.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_BounceTarget_BounceTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BouncingProjectile.BounceTargetSorter>.NativeClassPtr, 100663577);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_BouncingProjectile.BounceTargetSorter>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public class Server : ServerScript
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BouncingProjectileHit_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SpawnDelayBuff_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_Entity_BouncingProjectileData_BlobAssetReference_1_ConditionBlob_BlobAssetReference_1_ConditionBlob_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TrySpawnBouncingProjectileTowardsOwner_Public_Static_Void_byref_ServerGameManager_byref_SelfServer_Entity_BouncingProjectileData_BlobAssetReference_1_ConditionBlob_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TrySpawnBouncingProjectile_Public_Static_Boolean_byref_ServerGameManager_byref_SelfServer_Entity_BouncingProjectileData_BlobAssetReference_1_ConditionBlob_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176681, XrefRangeEnd = 1176690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BouncingProjectile.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176690, XrefRangeEnd = 1176697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void BouncingProjectileHit(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref GameplayEvent gameplayEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BouncingProjectile.Server.NativeMethodInfoPtr_BouncingProjectileHit_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1176736, RefRangeEnd = 1176737, XrefRangeStart = 1176697, XrefRangeEnd = 1176736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void SpawnDelayBuff(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Entity target,
        BouncingProjectileData settings,
        BlobAssetReference<ConditionBlob> condition,
        BlobAssetReference<ConditionBlob> bounceToOwnerCondition)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &settings;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &condition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &bounceToOwnerCondition;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BouncingProjectile.Server.NativeMethodInfoPtr_SpawnDelayBuff_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_Entity_BouncingProjectileData_BlobAssetReference_1_ConditionBlob_BlobAssetReference_1_ConditionBlob_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1176830, RefRangeEnd = 1176831, XrefRangeStart = 1176737, XrefRangeEnd = 1176830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void TrySpawnBouncingProjectileTowardsOwner(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Entity target,
        BouncingProjectileData settings,
        BlobAssetReference<ConditionBlob> condition)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &settings;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &condition;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BouncingProjectile.Server.NativeMethodInfoPtr_TrySpawnBouncingProjectileTowardsOwner_Public_Static_Void_byref_ServerGameManager_byref_SelfServer_Entity_BouncingProjectileData_BlobAssetReference_1_ConditionBlob_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1177004, RefRangeEnd = 1177006, XrefRangeStart = 1176831, XrefRangeEnd = 1177004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool TrySpawnBouncingProjectile(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Entity target,
        BouncingProjectileData settings,
        BlobAssetReference<ConditionBlob> condition)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &settings;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &condition;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_BouncingProjectile.Server.NativeMethodInfoPtr_TrySpawnBouncingProjectile_Public_Static_Boolean_byref_ServerGameManager_byref_SelfServer_Entity_BouncingProjectileData_BlobAssetReference_1_ConditionBlob_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_BouncingProjectile.Server>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BouncingProjectile.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_BouncingProjectile.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_BouncingProjectile>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_BouncingProjectile.Server>.NativeClassPtr);
        Script_BouncingProjectile.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BouncingProjectile.Server>.NativeClassPtr, 100663578);
        Script_BouncingProjectile.Server.NativeMethodInfoPtr_BouncingProjectileHit_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BouncingProjectile.Server>.NativeClassPtr, 100663579);
        Script_BouncingProjectile.Server.NativeMethodInfoPtr_SpawnDelayBuff_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_Entity_BouncingProjectileData_BlobAssetReference_1_ConditionBlob_BlobAssetReference_1_ConditionBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BouncingProjectile.Server>.NativeClassPtr, 100663580);
        Script_BouncingProjectile.Server.NativeMethodInfoPtr_TrySpawnBouncingProjectileTowardsOwner_Public_Static_Void_byref_ServerGameManager_byref_SelfServer_Entity_BouncingProjectileData_BlobAssetReference_1_ConditionBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BouncingProjectile.Server>.NativeClassPtr, 100663581);
        Script_BouncingProjectile.Server.NativeMethodInfoPtr_TrySpawnBouncingProjectile_Public_Static_Boolean_byref_ServerGameManager_byref_SelfServer_Entity_BouncingProjectileData_BlobAssetReference_1_ConditionBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BouncingProjectile.Server>.NativeClassPtr, 100663582);
        Script_BouncingProjectile.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BouncingProjectile.Server>.NativeClassPtr, 100663583);
      }

      public Server(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
