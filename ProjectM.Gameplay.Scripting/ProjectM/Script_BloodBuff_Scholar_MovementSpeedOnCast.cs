// Decompiled with JetBrains decompiler
// Type: ProjectM.Script_BloodBuff_Scholar_MovementSpeedOnCast
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class Script_BloodBuff_Scholar_MovementSpeedOnCast : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_SCT;
    private static readonly IntPtr NativeFieldInfoPtr_MovementBuff;
    private static readonly IntPtr NativeFieldInfoPtr_ChanceToGainMovementOnCast_Min;
    private static readonly IntPtr NativeFieldInfoPtr_ChanceToGainMovementOnCast_Max;
    private static readonly IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174489, XrefRangeEnd = 1174493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174493, XrefRangeEnd = 1174497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_BloodBuff_Scholar_MovementSpeedOnCast()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_BloodBuff_Scholar_MovementSpeedOnCast>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_BloodBuff_Scholar_MovementSpeedOnCast()
    {
      Il2CppClassPointerStore<Script_BloodBuff_Scholar_MovementSpeedOnCast>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM", nameof (Script_BloodBuff_Scholar_MovementSpeedOnCast));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_BloodBuff_Scholar_MovementSpeedOnCast>.NativeClassPtr);
      Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeFieldInfoPtr_SCT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Scholar_MovementSpeedOnCast>.NativeClassPtr, nameof (SCT));
      Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeFieldInfoPtr_MovementBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Scholar_MovementSpeedOnCast>.NativeClassPtr, nameof (MovementBuff));
      Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeFieldInfoPtr_ChanceToGainMovementOnCast_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Scholar_MovementSpeedOnCast>.NativeClassPtr, nameof (ChanceToGainMovementOnCast_Min));
      Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeFieldInfoPtr_ChanceToGainMovementOnCast_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Scholar_MovementSpeedOnCast>.NativeClassPtr, nameof (ChanceToGainMovementOnCast_Max));
      Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Scholar_MovementSpeedOnCast>.NativeClassPtr, nameof (RequiredBloodPercentage));
      Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Scholar_MovementSpeedOnCast>.NativeClassPtr, 100663328);
      Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Scholar_MovementSpeedOnCast>.NativeClassPtr, 100663329);
      Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Scholar_MovementSpeedOnCast>.NativeClassPtr, 100663330);
    }

    public Script_BloodBuff_Scholar_MovementSpeedOnCast(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey SCT
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeFieldInfoPtr_SCT));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeFieldInfoPtr_SCT)) = value;
      }
    }

    public unsafe PrefabGuidComponent MovementBuff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeFieldInfoPtr_MovementBuff));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeFieldInfoPtr_MovementBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float ChanceToGainMovementOnCast_Min
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeFieldInfoPtr_ChanceToGainMovementOnCast_Min));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeFieldInfoPtr_ChanceToGainMovementOnCast_Min)) = value;
      }
    }

    public unsafe float ChanceToGainMovementOnCast_Max
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeFieldInfoPtr_ChanceToGainMovementOnCast_Max));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeFieldInfoPtr_ChanceToGainMovementOnCast_Max)) = value;
      }
    }

    public unsafe float RequiredBloodPercentage
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeFieldInfoPtr_RequiredBloodPercentage));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Scholar_MovementSpeedOnCast.NativeFieldInfoPtr_RequiredBloodPercentage)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_AbilityCastFinished_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174470, XrefRangeEnd = 1174489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void AbilityCastFinished(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastFinishedData data)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref data;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Scholar_MovementSpeedOnCast.Server.NativeMethodInfoPtr_AbilityCastFinished_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_BloodBuff_Scholar_MovementSpeedOnCast.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Scholar_MovementSpeedOnCast.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_BloodBuff_Scholar_MovementSpeedOnCast.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_BloodBuff_Scholar_MovementSpeedOnCast>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_BloodBuff_Scholar_MovementSpeedOnCast.Server>.NativeClassPtr);
        Script_BloodBuff_Scholar_MovementSpeedOnCast.Server.NativeMethodInfoPtr_AbilityCastFinished_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastFinishedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Scholar_MovementSpeedOnCast.Server>.NativeClassPtr, 100663331);
        Script_BloodBuff_Scholar_MovementSpeedOnCast.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Scholar_MovementSpeedOnCast.Server>.NativeClassPtr, 100663332);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
