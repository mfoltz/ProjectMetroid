// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_AbilityChargeBuff
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_AbilityChargeBuff : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ChargeAbilityGroup;
    private static readonly IntPtr NativeFieldInfoPtr_AbilitySlot;
    private static readonly IntPtr NativeFieldInfoPtr_ConsumeWhenInterrupted;
    private static readonly IntPtr NativeFieldInfoPtr_ResetOnAnyAbilityUseForSlot;
    private static readonly IntPtr NativeFieldInfoPtr_WeaponChargeAbilityPriority;
    private static readonly IntPtr NativeFieldInfoPtr_ChargedSequence;
    private static readonly IntPtr NativeFieldInfoPtr_ActiveSequence;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176271, XrefRangeEnd = 1176283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_AbilityChargeBuff.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176283, XrefRangeEnd = 1176290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_AbilityChargeBuff.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176290, XrefRangeEnd = 1176291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_AbilityChargeBuff()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_AbilityChargeBuff>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_AbilityChargeBuff.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_AbilityChargeBuff()
    {
      Il2CppClassPointerStore<Script_AbilityChargeBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_AbilityChargeBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_AbilityChargeBuff>.NativeClassPtr);
      Script_AbilityChargeBuff.NativeFieldInfoPtr_ChargeAbilityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_AbilityChargeBuff>.NativeClassPtr, nameof (ChargeAbilityGroup));
      Script_AbilityChargeBuff.NativeFieldInfoPtr_AbilitySlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_AbilityChargeBuff>.NativeClassPtr, nameof (AbilitySlot));
      Script_AbilityChargeBuff.NativeFieldInfoPtr_ConsumeWhenInterrupted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_AbilityChargeBuff>.NativeClassPtr, nameof (ConsumeWhenInterrupted));
      Script_AbilityChargeBuff.NativeFieldInfoPtr_ResetOnAnyAbilityUseForSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_AbilityChargeBuff>.NativeClassPtr, nameof (ResetOnAnyAbilityUseForSlot));
      Script_AbilityChargeBuff.NativeFieldInfoPtr_WeaponChargeAbilityPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_AbilityChargeBuff>.NativeClassPtr, nameof (WeaponChargeAbilityPriority));
      Script_AbilityChargeBuff.NativeFieldInfoPtr_ChargedSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_AbilityChargeBuff>.NativeClassPtr, nameof (ChargedSequence));
      Script_AbilityChargeBuff.NativeFieldInfoPtr_ActiveSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_AbilityChargeBuff>.NativeClassPtr, nameof (ActiveSequence));
      Script_AbilityChargeBuff.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_AbilityChargeBuff>.NativeClassPtr, 100663523);
      Script_AbilityChargeBuff.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_AbilityChargeBuff>.NativeClassPtr, 100663524);
      Script_AbilityChargeBuff.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_AbilityChargeBuff>.NativeClassPtr, 100663525);
    }

    public Script_AbilityChargeBuff(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent ChargeAbilityGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityChargeBuff.NativeFieldInfoPtr_ChargeAbilityGroup));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityChargeBuff.NativeFieldInfoPtr_ChargeAbilityGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int AbilitySlot
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityChargeBuff.NativeFieldInfoPtr_AbilitySlot));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityChargeBuff.NativeFieldInfoPtr_AbilitySlot)) = value;
      }
    }

    public unsafe bool ConsumeWhenInterrupted
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityChargeBuff.NativeFieldInfoPtr_ConsumeWhenInterrupted));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityChargeBuff.NativeFieldInfoPtr_ConsumeWhenInterrupted)) = value;
      }
    }

    public unsafe bool ResetOnAnyAbilityUseForSlot
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityChargeBuff.NativeFieldInfoPtr_ResetOnAnyAbilityUseForSlot));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityChargeBuff.NativeFieldInfoPtr_ResetOnAnyAbilityUseForSlot)) = value;
      }
    }

    public unsafe int WeaponChargeAbilityPriority
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityChargeBuff.NativeFieldInfoPtr_WeaponChargeAbilityPriority));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityChargeBuff.NativeFieldInfoPtr_WeaponChargeAbilityPriority)) = value;
      }
    }

    public unsafe SequenceField ChargedSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityChargeBuff.NativeFieldInfoPtr_ChargedSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityChargeBuff.NativeFieldInfoPtr_ChargedSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField ActiveSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityChargeBuff.NativeFieldInfoPtr_ActiveSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_AbilityChargeBuff.NativeFieldInfoPtr_ActiveSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176202, XrefRangeEnd = 1176237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_AbilityChargeBuff.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176237, XrefRangeEnd = 1176244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Destroy(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_AbilityChargeBuff.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_AbilityChargeBuff.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_AbilityChargeBuff.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_AbilityChargeBuff.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_AbilityChargeBuff>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_AbilityChargeBuff.Server>.NativeClassPtr);
        Script_AbilityChargeBuff.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_AbilityChargeBuff.Server>.NativeClassPtr, 100663526);
        Script_AbilityChargeBuff.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_AbilityChargeBuff.Server>.NativeClassPtr, 100663527);
        Script_AbilityChargeBuff.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_AbilityChargeBuff.Server>.NativeClassPtr, 100663528);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Client : ClientScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0;
      private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176244, XrefRangeEnd = 1176266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ClientGameManager game, [In] ref SelfClient self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_AbilityChargeBuff.Client.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176266, XrefRangeEnd = 1176271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Destroy(ref ClientGameManager game, [In] ref SelfClient self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_AbilityChargeBuff.Client.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Client()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_AbilityChargeBuff.Client>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_AbilityChargeBuff.Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Client()
      {
        Il2CppClassPointerStore<Script_AbilityChargeBuff.Client>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_AbilityChargeBuff>.NativeClassPtr, nameof (Client));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_AbilityChargeBuff.Client>.NativeClassPtr);
        Script_AbilityChargeBuff.Client.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_AbilityChargeBuff.Client>.NativeClassPtr, 100663529);
        Script_AbilityChargeBuff.Client.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_AbilityChargeBuff.Client>.NativeClassPtr, 100663530);
        Script_AbilityChargeBuff.Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_AbilityChargeBuff.Client>.NativeClassPtr, 100663531);
      }

      public Client(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
