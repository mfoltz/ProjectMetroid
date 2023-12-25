// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_HomingSpell
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM.Scripting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_HomingSpell : GameplayScriptBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PreHomingMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreHomingDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerHitBeforeReturning;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreHomingSpeedData;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreHomingRangeData;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
    private static readonly System.IntPtr NativeFieldInfoPtr_HomingType;
    private static readonly System.IntPtr NativeFieldInfoPtr_DistanceBasedData;
    private static readonly System.IntPtr NativeFieldInfoPtr_HomingData;
    private static readonly System.IntPtr NativeFieldInfoPtr_EventOnHomingStart;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyWhenOwnerReached;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GameplayEventIds_Public_Virtual_Final_New_get_IEnumerable_1_GameplayEventIdSource_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe IEnumerable<GameplayEventIdSource> GameplayEventIds
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177550, XrefRangeEnd = 1177553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_HomingSpell.NativeMethodInfoPtr_get_GameplayEventIds_Public_Virtual_Final_New_get_IEnumerable_1_GameplayEventIdSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerable<GameplayEventIdSource>) null : new IEnumerable<GameplayEventIdSource>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177553, XrefRangeEnd = 1177577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_HomingSpell.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177577, XrefRangeEnd = 1177590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_HomingSpell.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177590, XrefRangeEnd = 1177591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_HomingSpell()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_HomingSpell.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_HomingSpell()
    {
      Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_HomingSpell));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr);
      Script_HomingSpell.NativeFieldInfoPtr_PreHomingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr, nameof (PreHomingMode));
      Script_HomingSpell.NativeFieldInfoPtr_PreHomingDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr, nameof (PreHomingDuration));
      Script_HomingSpell.NativeFieldInfoPtr_TriggerHitBeforeReturning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr, nameof (TriggerHitBeforeReturning));
      Script_HomingSpell.NativeFieldInfoPtr_PreHomingSpeedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr, nameof (PreHomingSpeedData));
      Script_HomingSpell.NativeFieldInfoPtr_PreHomingRangeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr, nameof (PreHomingRangeData));
      Script_HomingSpell.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr, nameof (SpellMods));
      Script_HomingSpell.NativeFieldInfoPtr_HomingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr, nameof (HomingType));
      Script_HomingSpell.NativeFieldInfoPtr_DistanceBasedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr, nameof (DistanceBasedData));
      Script_HomingSpell.NativeFieldInfoPtr_HomingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr, nameof (HomingData));
      Script_HomingSpell.NativeFieldInfoPtr_EventOnHomingStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr, nameof (EventOnHomingStart));
      Script_HomingSpell.NativeFieldInfoPtr_DestroyWhenOwnerReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr, nameof (DestroyWhenOwnerReached));
      Script_HomingSpell.NativeMethodInfoPtr_get_GameplayEventIds_Public_Virtual_Final_New_get_IEnumerable_1_GameplayEventIdSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr, 100663631);
      Script_HomingSpell.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr, 100663632);
      Script_HomingSpell.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr, 100663633);
      Script_HomingSpell.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr, 100663634);
    }

    public Script_HomingSpell(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Script_HomingSpell_DataShared.PreHomingModeType PreHomingMode
    {
      get
      {
        return *(Script_HomingSpell_DataShared.PreHomingModeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_PreHomingMode));
      }
      [param: In] set
      {
        *(Script_HomingSpell_DataShared.PreHomingModeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_PreHomingMode)) = value;
      }
    }

    public unsafe float PreHomingDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_PreHomingDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_PreHomingDuration)) = value;
      }
    }

    public unsafe bool TriggerHitBeforeReturning
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_TriggerHitBeforeReturning));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_TriggerHitBeforeReturning)) = value;
      }
    }

    public unsafe Homing_SpeedLerpData PreHomingSpeedData
    {
      get
      {
        return *(Homing_SpeedLerpData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_PreHomingSpeedData));
      }
      [param: In] set
      {
        *(Homing_SpeedLerpData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_PreHomingSpeedData)) = value;
      }
    }

    public unsafe Homing_RangeLerpData PreHomingRangeData
    {
      get
      {
        return *(Homing_RangeLerpData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_PreHomingRangeData));
      }
      [param: In] set
      {
        *(Homing_RangeLerpData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_PreHomingRangeData)) = value;
      }
    }

    public Script_HomingSpell.SpellModsAuthoring SpellMods
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_SpellMods);
        return new Script_HomingSpell.SpellModsAuthoring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_HomingSpell.SpellModsAuthoring>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_SpellMods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Script_HomingSpell.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Script_HomingSpell_DataShared.HomingSpellType HomingType
    {
      get
      {
        return *(Script_HomingSpell_DataShared.HomingSpellType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_HomingType));
      }
      [param: In] set
      {
        *(Script_HomingSpell_DataShared.HomingSpellType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_HomingType)) = value;
      }
    }

    public unsafe Homing_DistanceBasedData DistanceBasedData
    {
      get
      {
        return *(Homing_DistanceBasedData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_DistanceBasedData));
      }
      [param: In] set
      {
        *(Homing_DistanceBasedData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_DistanceBasedData)) = value;
      }
    }

    public unsafe Homing_LerpData HomingData
    {
      get
      {
        return *(Homing_LerpData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_HomingData));
      }
      [param: In] set
      {
        *(Homing_LerpData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_HomingData)) = value;
      }
    }

    public GameplayEventIdSource EventOnHomingStart
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_EventOnHomingStart);
        return new GameplayEventIdSource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_EventOnHomingStart), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool DestroyWhenOwnerReached
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_DestroyWhenOwnerReached));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.NativeFieldInfoPtr_DestroyWhenOwnerReached)) = value;
      }
    }

    [Serializable]
    public sealed class SpellModsAuthoring : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Speed;
      private static readonly System.IntPtr NativeFieldInfoPtr_Range;

      static SpellModsAuthoring()
      {
        Il2CppClassPointerStore<Script_HomingSpell.SpellModsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr, nameof (SpellModsAuthoring));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_HomingSpell.SpellModsAuthoring>.NativeClassPtr);
        Script_HomingSpell.SpellModsAuthoring.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell.SpellModsAuthoring>.NativeClassPtr, nameof (Speed));
        Script_HomingSpell.SpellModsAuthoring.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingSpell.SpellModsAuthoring>.NativeClassPtr, nameof (Range));
      }

      public SpellModsAuthoring(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SpellModsAuthoring()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Script_HomingSpell.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_HomingSpell.SpellModsAuthoring>.NativeClassPtr, data));
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> Speed
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.SpellModsAuthoring.NativeFieldInfoPtr_Speed));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.SpellModsAuthoring.NativeFieldInfoPtr_Speed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> Range
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.SpellModsAuthoring.NativeFieldInfoPtr_Range));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingSpell.SpellModsAuthoring.NativeFieldInfoPtr_Range), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public class Server : ServerScript
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177335, XrefRangeEnd = 1177370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_HomingSpell.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177370, XrefRangeEnd = 1177478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ServerGameManager game, [In] ref SelfServer self)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_HomingSpell.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_HomingSpell.Server>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_HomingSpell.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_HomingSpell.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_HomingSpell.Server>.NativeClassPtr);
        Script_HomingSpell.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_HomingSpell.Server>.NativeClassPtr, 100663635);
        Script_HomingSpell.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_HomingSpell.Server>.NativeClassPtr, 100663636);
        Script_HomingSpell.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_HomingSpell.Server>.NativeClassPtr, 100663637);
      }

      public Server(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public static class Shared : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateRotation_Internal_Static_Void_byref_Translation_byref_Rotation_byref_Translation_byref_Height_byref_Script_HomingSpell_DataShared_byref_Homing_RotationLerpData_byref_CurveCollection_Single_Single_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetNormalizedTime_Internal_Static_Single_byref_Translation_byref_Age_byref_LifeTime_byref_Script_HomingSpell_DataShared_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMovement_Internal_Static_Void_byref_Translation_byref_LastTranslation_byref_quaternion_byref_Homing_SpeedLerpData_byref_CurveCollection_Single_Single_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1177504, RefRangeEnd = 1177505, XrefRangeStart = 1177478, XrefRangeEnd = 1177504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void UpdateRotation(
        [In] ref Translation selfTranslation,
        ref Rotation rotation,
        [In] ref Translation targetTranslation,
        [In] ref Height height,
        ref Script_HomingSpell_DataShared data,
        [In] ref Homing_RotationLerpData rotationData,
        [In] ref CurveCollection curveCollection,
        float deltaTime,
        float t,
        bool lockHeight = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[10];
        numPtr[0] = (System.IntPtr) ref selfTranslation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref targetTranslation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref height;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotationData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref curveCollection;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &lockHeight;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_HomingSpell.Shared.NativeMethodInfoPtr_UpdateRotation_Internal_Static_Void_byref_Translation_byref_Rotation_byref_Translation_byref_Height_byref_Script_HomingSpell_DataShared_byref_Homing_RotationLerpData_byref_CurveCollection_Single_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public static unsafe float GetNormalizedTime(
        [In] ref Translation translation,
        [In] ref Age age,
        [In] ref LifeTime lifeTime,
        ref Script_HomingSpell_DataShared data,
        [In] ref Translation targetTranslation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref age;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref lifeTime;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref targetTranslation;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_HomingSpell.Shared.NativeMethodInfoPtr_GetNormalizedTime_Internal_Static_Single_byref_Translation_byref_Age_byref_LifeTime_byref_Script_HomingSpell_DataShared_byref_Translation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1177506, RefRangeEnd = 1177508, XrefRangeStart = 1177505, XrefRangeEnd = 1177506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void UpdateMovement(
        ref Translation selfTranslation,
        ref LastTranslation lastTranslation,
        [In] ref quaternion rotation,
        [In] ref Homing_SpeedLerpData speedData,
        [In] ref CurveCollection curveCollection,
        float deltaTime,
        float t)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) ref selfTranslation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lastTranslation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref speedData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref curveCollection;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_HomingSpell.Shared.NativeMethodInfoPtr_UpdateMovement_Internal_Static_Void_byref_Translation_byref_LastTranslation_byref_quaternion_byref_Homing_SpeedLerpData_byref_CurveCollection_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Shared()
      {
        Il2CppClassPointerStore<Script_HomingSpell.Shared>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr, nameof (Shared));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_HomingSpell.Shared>.NativeClassPtr);
        Script_HomingSpell.Shared.NativeMethodInfoPtr_UpdateRotation_Internal_Static_Void_byref_Translation_byref_Rotation_byref_Translation_byref_Height_byref_Script_HomingSpell_DataShared_byref_Homing_RotationLerpData_byref_CurveCollection_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_HomingSpell.Shared>.NativeClassPtr, 100663638);
        Script_HomingSpell.Shared.NativeMethodInfoPtr_GetNormalizedTime_Internal_Static_Single_byref_Translation_byref_Age_byref_LifeTime_byref_Script_HomingSpell_DataShared_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_HomingSpell.Shared>.NativeClassPtr, 100663639);
        Script_HomingSpell.Shared.NativeMethodInfoPtr_UpdateMovement_Internal_Static_Void_byref_Translation_byref_LastTranslation_byref_quaternion_byref_Homing_SpeedLerpData_byref_CurveCollection_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_HomingSpell.Shared>.NativeClassPtr, 100663640);
      }

      public Shared(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Client : ClientScript
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177508, XrefRangeEnd = 1177530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ClientGameManager game, [In] ref SelfClient self)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_HomingSpell.Client.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177530, XrefRangeEnd = 1177550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ClientGameManager game, [In] ref SelfClient self)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_HomingSpell.Client.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Client()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_HomingSpell.Client>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_HomingSpell.Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Client()
      {
        Il2CppClassPointerStore<Script_HomingSpell.Client>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_HomingSpell>.NativeClassPtr, nameof (Client));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_HomingSpell.Client>.NativeClassPtr);
        Script_HomingSpell.Client.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_HomingSpell.Client>.NativeClassPtr, 100663641);
        Script_HomingSpell.Client.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_HomingSpell.Client>.NativeClassPtr, 100663642);
        Script_HomingSpell.Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_HomingSpell.Client>.NativeClassPtr, 100663643);
      }

      public Client(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
