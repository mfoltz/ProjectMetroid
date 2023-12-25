// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_BloodBuff_Brute_RecoverOnKill
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_BloodBuff_Brute_RecoverOnKill : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MinHealingReceived;
    private static readonly IntPtr NativeFieldInfoPtr_MaxHealingReceived;
    private static readonly IntPtr NativeFieldInfoPtr_RecoverHealthOnKill;
    private static readonly IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    private static readonly IntPtr NativeFieldInfoPtr_AffectRecovery;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180437, XrefRangeEnd = 1180440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_BloodBuff_Brute_RecoverOnKill.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_BloodBuff_Brute_RecoverOnKill()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_BloodBuff_Brute_RecoverOnKill>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Brute_RecoverOnKill.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_BloodBuff_Brute_RecoverOnKill()
    {
      Il2CppClassPointerStore<Script_BloodBuff_Brute_RecoverOnKill>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_BloodBuff_Brute_RecoverOnKill));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_BloodBuff_Brute_RecoverOnKill>.NativeClassPtr);
      Script_BloodBuff_Brute_RecoverOnKill.NativeFieldInfoPtr_MinHealingReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Brute_RecoverOnKill>.NativeClassPtr, nameof (MinHealingReceived));
      Script_BloodBuff_Brute_RecoverOnKill.NativeFieldInfoPtr_MaxHealingReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Brute_RecoverOnKill>.NativeClassPtr, nameof (MaxHealingReceived));
      Script_BloodBuff_Brute_RecoverOnKill.NativeFieldInfoPtr_RecoverHealthOnKill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Brute_RecoverOnKill>.NativeClassPtr, nameof (RecoverHealthOnKill));
      Script_BloodBuff_Brute_RecoverOnKill.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Brute_RecoverOnKill>.NativeClassPtr, nameof (RequiredBloodPercentage));
      Script_BloodBuff_Brute_RecoverOnKill.NativeFieldInfoPtr_AffectRecovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Brute_RecoverOnKill>.NativeClassPtr, nameof (AffectRecovery));
      Script_BloodBuff_Brute_RecoverOnKill.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Brute_RecoverOnKill>.NativeClassPtr, 100663914);
      Script_BloodBuff_Brute_RecoverOnKill.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Brute_RecoverOnKill>.NativeClassPtr, 100663915);
    }

    public Script_BloodBuff_Brute_RecoverOnKill(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float MinHealingReceived
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Brute_RecoverOnKill.NativeFieldInfoPtr_MinHealingReceived));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Brute_RecoverOnKill.NativeFieldInfoPtr_MinHealingReceived)) = value;
      }
    }

    public unsafe float MaxHealingReceived
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Brute_RecoverOnKill.NativeFieldInfoPtr_MaxHealingReceived));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Brute_RecoverOnKill.NativeFieldInfoPtr_MaxHealingReceived)) = value;
      }
    }

    public unsafe float RecoverHealthOnKill
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Brute_RecoverOnKill.NativeFieldInfoPtr_RecoverHealthOnKill));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Brute_RecoverOnKill.NativeFieldInfoPtr_RecoverHealthOnKill)) = value;
      }
    }

    public unsafe float RequiredBloodPercentage
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Brute_RecoverOnKill.NativeFieldInfoPtr_RequiredBloodPercentage));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Brute_RecoverOnKill.NativeFieldInfoPtr_RequiredBloodPercentage)) = value;
      }
    }

    public unsafe bool AffectRecovery
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Brute_RecoverOnKill.NativeFieldInfoPtr_AffectRecovery));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Brute_RecoverOnKill.NativeFieldInfoPtr_AffectRecovery)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_OnHealingReceived_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0;
      private static readonly IntPtr NativeMethodInfoPtr_OnKill_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_Entity_Entity_Entity_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180385, XrefRangeEnd = 1180408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Brute_RecoverOnKill.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180408, XrefRangeEnd = 1180419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void OnHealingReceived(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        ref StatChangeEvent statChangeEvent)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref statChangeEvent;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Brute_RecoverOnKill.Server.NativeMethodInfoPtr_OnHealingReceived_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180419, XrefRangeEnd = 1180437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void OnKill(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        Entity killed,
        Entity killer,
        Entity source)
      {
        IntPtr* numPtr = stackalloc IntPtr[5];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &killed;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &killer;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &source;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Brute_RecoverOnKill.Server.NativeMethodInfoPtr_OnKill_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_Entity_Entity_Entity_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_BloodBuff_Brute_RecoverOnKill.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Brute_RecoverOnKill.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_BloodBuff_Brute_RecoverOnKill.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_BloodBuff_Brute_RecoverOnKill>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_BloodBuff_Brute_RecoverOnKill.Server>.NativeClassPtr);
        Script_BloodBuff_Brute_RecoverOnKill.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Brute_RecoverOnKill.Server>.NativeClassPtr, 100663916);
        Script_BloodBuff_Brute_RecoverOnKill.Server.NativeMethodInfoPtr_OnHealingReceived_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Brute_RecoverOnKill.Server>.NativeClassPtr, 100663917);
        Script_BloodBuff_Brute_RecoverOnKill.Server.NativeMethodInfoPtr_OnKill_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_Entity_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Brute_RecoverOnKill.Server>.NativeClassPtr, 100663918);
        Script_BloodBuff_Brute_RecoverOnKill.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Brute_RecoverOnKill.Server>.NativeClassPtr, 100663919);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
