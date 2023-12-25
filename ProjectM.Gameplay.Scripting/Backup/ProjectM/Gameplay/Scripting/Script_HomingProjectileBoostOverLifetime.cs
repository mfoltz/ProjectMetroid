// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_HomingProjectileBoostOverLifetime
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

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_HomingProjectileBoostOverLifetime : GameplayScriptBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetHitFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageParameters;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitEventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetFilterCondition;
    private static readonly System.IntPtr NativeFieldInfoPtr_InternalHitCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitFX_Y_Offset;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188137, XrefRangeEnd = 1188148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_HomingProjectileBoostOverLifetime.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_HomingProjectileBoostOverLifetime()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_HomingProjectileBoostOverLifetime.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_HomingProjectileBoostOverLifetime()
    {
      Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_HomingProjectileBoostOverLifetime));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime>.NativeClassPtr);
      Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_TargetHitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime>.NativeClassPtr, nameof (TargetHitFilter));
      Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_DamageParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime>.NativeClassPtr, nameof (DamageParameters));
      Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_HitEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime>.NativeClassPtr, nameof (HitEventId));
      Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_TargetFilterCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime>.NativeClassPtr, nameof (TargetFilterCondition));
      Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_InternalHitCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime>.NativeClassPtr, nameof (InternalHitCooldown));
      Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_MinTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime>.NativeClassPtr, nameof (MinTimer));
      Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_MaxTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime>.NativeClassPtr, nameof (MaxTimer));
      Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_HitFX_Y_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime>.NativeClassPtr, nameof (HitFX_Y_Offset));
      Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime>.NativeClassPtr, nameof (SpellMods));
      Script_HomingProjectileBoostOverLifetime.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime>.NativeClassPtr, 100664712);
      Script_HomingProjectileBoostOverLifetime.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime>.NativeClassPtr, 100664713);
    }

    public Script_HomingProjectileBoostOverLifetime(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe HitFilter TargetHitFilter
    {
      get
      {
        return *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_TargetHitFilter));
      }
      [param: In] set
      {
        *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_TargetHitFilter)) = value;
      }
    }

    public DealDamageParameters_Editor DamageParameters
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_DamageParameters);
        return new DealDamageParameters_Editor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_DamageParameters), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public GameplayEventIdSource HitEventId
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_HitEventId);
        return new GameplayEventIdSource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_HitEventId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe GameplayConditionGroupData_Editor_Parent TargetFilterCondition
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_TargetFilterCondition));
        return pointer == System.IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_TargetFilterCondition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float InternalHitCooldown
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_InternalHitCooldown));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_InternalHitCooldown)) = value;
      }
    }

    public unsafe float MinTimer
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_MinTimer));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_MinTimer)) = value;
      }
    }

    public unsafe float MaxTimer
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_MaxTimer));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_MaxTimer)) = value;
      }
    }

    public unsafe float HitFX_Y_Offset
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_HitFX_Y_Offset));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_HitFX_Y_Offset)) = value;
      }
    }

    public Script_HomingProjectileBoostOverLifetime.SpellModsAuthoring SpellMods
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_SpellMods);
        return new Script_HomingProjectileBoostOverLifetime.SpellModsAuthoring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime.SpellModsAuthoring>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingProjectileBoostOverLifetime.NativeFieldInfoPtr_SpellMods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [Serializable]
    public sealed class SpellModsAuthoring : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Damage;

      static SpellModsAuthoring()
      {
        Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime.SpellModsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime>.NativeClassPtr, nameof (SpellModsAuthoring));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime.SpellModsAuthoring>.NativeClassPtr);
        Script_HomingProjectileBoostOverLifetime.SpellModsAuthoring.NativeFieldInfoPtr_Damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime.SpellModsAuthoring>.NativeClassPtr, nameof (Damage));
      }

      public SpellModsAuthoring(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SpellModsAuthoring()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime.SpellModsAuthoring>.NativeClassPtr, data));
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> Damage
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingProjectileBoostOverLifetime.SpellModsAuthoring.NativeFieldInfoPtr_Damage));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_HomingProjectileBoostOverLifetime.SpellModsAuthoring.NativeFieldInfoPtr_Damage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public class Server : ServerScript
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188055, XrefRangeEnd = 1188137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ServerGameManager game, [In] ref SelfServer self)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_HomingProjectileBoostOverLifetime.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime.Server>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_HomingProjectileBoostOverLifetime.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime.Server>.NativeClassPtr);
        Script_HomingProjectileBoostOverLifetime.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime.Server>.NativeClassPtr, 100664714);
        Script_HomingProjectileBoostOverLifetime.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime.Server>.NativeClassPtr, 100664715);
      }

      public Server(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Client : ClientScript
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Client()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime.Client>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_HomingProjectileBoostOverLifetime.Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Client()
      {
        Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime.Client>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime>.NativeClassPtr, nameof (Client));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime.Client>.NativeClassPtr);
        Script_HomingProjectileBoostOverLifetime.Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_HomingProjectileBoostOverLifetime.Client>.NativeClassPtr, 100664716);
      }

      public Client(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
