// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_ModifyAbilityCooldownOnGameplayEvent
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
  public class Script_ModifyAbilityCooldownOnGameplayEvent : GameplayScriptBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModifyCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModifyCooldownFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityIndexOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResetCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187293, XrefRangeEnd = 1187307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_ModifyAbilityCooldownOnGameplayEvent.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_ModifyAbilityCooldownOnGameplayEvent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_ModifyAbilityCooldownOnGameplayEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_ModifyAbilityCooldownOnGameplayEvent()
    {
      Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_ModifyAbilityCooldownOnGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent>.NativeClassPtr);
      Script_ModifyAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_AbilityGroupType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent>.NativeClassPtr, nameof (AbilityGroupType));
      Script_ModifyAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_ModifyCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent>.NativeClassPtr, nameof (ModifyCooldown));
      Script_ModifyAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_ModifyCooldownFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent>.NativeClassPtr, nameof (ModifyCooldownFactor));
      Script_ModifyAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_AbilityIndexOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent>.NativeClassPtr, nameof (AbilityIndexOverride));
      Script_ModifyAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_ResetCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent>.NativeClassPtr, nameof (ResetCooldown));
      Script_ModifyAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent>.NativeClassPtr, nameof (SpellMods));
      Script_ModifyAbilityCooldownOnGameplayEvent.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent>.NativeClassPtr, 100664618);
      Script_ModifyAbilityCooldownOnGameplayEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent>.NativeClassPtr, 100664619);
    }

    public Script_ModifyAbilityCooldownOnGameplayEvent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent AbilityGroupType
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ModifyAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_AbilityGroupType));
        return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_ModifyAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_AbilityGroupType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float ModifyCooldown
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ModifyAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_ModifyCooldown));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ModifyAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_ModifyCooldown)) = value;
      }
    }

    public unsafe float ModifyCooldownFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ModifyAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_ModifyCooldownFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ModifyAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_ModifyCooldownFactor)) = value;
      }
    }

    public unsafe int AbilityIndexOverride
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ModifyAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_AbilityIndexOverride));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ModifyAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_AbilityIndexOverride)) = value;
      }
    }

    public unsafe bool ResetCooldown
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ModifyAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_ResetCooldown));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ModifyAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_ResetCooldown)) = value;
      }
    }

    public Script_ModifyAbilityCooldownOnGameplayEvent.SpellModsAuthoring SpellMods
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ModifyAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_SpellMods);
        return new Script_ModifyAbilityCooldownOnGameplayEvent.SpellModsAuthoring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent.SpellModsAuthoring>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ModifyAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_SpellMods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [Serializable]
    public sealed class SpellModsAuthoring : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ModifyCooldown;
      private static readonly System.IntPtr NativeFieldInfoPtr_ModifyCooldownFactor;

      static SpellModsAuthoring()
      {
        Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent.SpellModsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent>.NativeClassPtr, nameof (SpellModsAuthoring));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent.SpellModsAuthoring>.NativeClassPtr);
        Script_ModifyAbilityCooldownOnGameplayEvent.SpellModsAuthoring.NativeFieldInfoPtr_ModifyCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent.SpellModsAuthoring>.NativeClassPtr, nameof (ModifyCooldown));
        Script_ModifyAbilityCooldownOnGameplayEvent.SpellModsAuthoring.NativeFieldInfoPtr_ModifyCooldownFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent.SpellModsAuthoring>.NativeClassPtr, nameof (ModifyCooldownFactor));
      }

      public SpellModsAuthoring(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SpellModsAuthoring()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent.SpellModsAuthoring>.NativeClassPtr, data));
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> ModifyCooldown
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ModifyAbilityCooldownOnGameplayEvent.SpellModsAuthoring.NativeFieldInfoPtr_ModifyCooldown));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_ModifyAbilityCooldownOnGameplayEvent.SpellModsAuthoring.NativeFieldInfoPtr_ModifyCooldown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> ModifyCooldownFactor
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ModifyAbilityCooldownOnGameplayEvent.SpellModsAuthoring.NativeFieldInfoPtr_ModifyCooldownFactor));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_ModifyAbilityCooldownOnGameplayEvent.SpellModsAuthoring.NativeFieldInfoPtr_ModifyCooldownFactor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public class Server : ServerScript
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_ModifyAbilityCooldownOnGameplayEvent_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ModifyCooldown_Private_Static_Void_ServerGameManager_Script_ModifyAbilityCooldownOnGameplayEvent_DataServer_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAbilityGroupSlots_Private_Static_Boolean_byref_ServerGameManager_byref_SelfServer_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187222, XrefRangeEnd = 1187262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void ModifyAbilityCooldownOnGameplayEvent(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref GameplayEvent gameplayEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_ModifyAbilityCooldownOnGameplayEvent.Server.NativeMethodInfoPtr_ModifyAbilityCooldownOnGameplayEvent_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1187284, RefRangeEnd = 1187285, XrefRangeStart = 1187262, XrefRangeEnd = 1187284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void ModifyCooldown(
        ServerGameManager game,
        Script_ModifyAbilityCooldownOnGameplayEvent_DataServer serverData,
        Entity abilityGroupStateEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &serverData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGroupStateEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_ModifyAbilityCooldownOnGameplayEvent.Server.NativeMethodInfoPtr_ModifyCooldown_Private_Static_Void_ServerGameManager_Script_ModifyAbilityCooldownOnGameplayEvent_DataServer_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187285, XrefRangeEnd = 1187293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool TryGetAbilityGroupSlots(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        out DynamicBuffer<AbilityGroupSlotBuffer> result)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_ModifyAbilityCooldownOnGameplayEvent.Server.NativeMethodInfoPtr_TryGetAbilityGroupSlots_Private_Static_Boolean_byref_ServerGameManager_byref_SelfServer_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent.Server>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_ModifyAbilityCooldownOnGameplayEvent.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent.Server>.NativeClassPtr);
        Script_ModifyAbilityCooldownOnGameplayEvent.Server.NativeMethodInfoPtr_ModifyAbilityCooldownOnGameplayEvent_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent.Server>.NativeClassPtr, 100664620);
        Script_ModifyAbilityCooldownOnGameplayEvent.Server.NativeMethodInfoPtr_ModifyCooldown_Private_Static_Void_ServerGameManager_Script_ModifyAbilityCooldownOnGameplayEvent_DataServer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent.Server>.NativeClassPtr, 100664621);
        Script_ModifyAbilityCooldownOnGameplayEvent.Server.NativeMethodInfoPtr_TryGetAbilityGroupSlots_Private_Static_Boolean_byref_ServerGameManager_byref_SelfServer_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent.Server>.NativeClassPtr, 100664622);
        Script_ModifyAbilityCooldownOnGameplayEvent.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ModifyAbilityCooldownOnGameplayEvent.Server>.NativeClassPtr, 100664623);
      }

      public Server(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
