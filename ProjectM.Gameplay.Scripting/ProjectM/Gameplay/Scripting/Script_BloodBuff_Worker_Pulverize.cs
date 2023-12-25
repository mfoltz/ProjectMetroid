// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_BloodBuff_Worker_Pulverize
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
  public class Script_BloodBuff_Worker_Pulverize : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_EmpowerBuff;
    private static readonly IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    private static readonly IntPtr NativeFieldInfoPtr_PulverizeChance;
    private static readonly IntPtr NativeFieldInfoPtr_PulverizeDamageParameters;
    private static readonly IntPtr NativeFieldInfoPtr_Sequence;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182296, XrefRangeEnd = 1182302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_BloodBuff_Worker_Pulverize.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182302, XrefRangeEnd = 1182308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_BloodBuff_Worker_Pulverize()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_BloodBuff_Worker_Pulverize>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Worker_Pulverize.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_BloodBuff_Worker_Pulverize()
    {
      Il2CppClassPointerStore<Script_BloodBuff_Worker_Pulverize>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_BloodBuff_Worker_Pulverize));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_BloodBuff_Worker_Pulverize>.NativeClassPtr);
      Script_BloodBuff_Worker_Pulverize.NativeFieldInfoPtr_EmpowerBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Worker_Pulverize>.NativeClassPtr, nameof (EmpowerBuff));
      Script_BloodBuff_Worker_Pulverize.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Worker_Pulverize>.NativeClassPtr, nameof (RequiredBloodPercentage));
      Script_BloodBuff_Worker_Pulverize.NativeFieldInfoPtr_PulverizeChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Worker_Pulverize>.NativeClassPtr, nameof (PulverizeChance));
      Script_BloodBuff_Worker_Pulverize.NativeFieldInfoPtr_PulverizeDamageParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Worker_Pulverize>.NativeClassPtr, nameof (PulverizeDamageParameters));
      Script_BloodBuff_Worker_Pulverize.NativeFieldInfoPtr_Sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_Worker_Pulverize>.NativeClassPtr, nameof (Sequence));
      Script_BloodBuff_Worker_Pulverize.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Worker_Pulverize>.NativeClassPtr, 100664118);
      Script_BloodBuff_Worker_Pulverize.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Worker_Pulverize>.NativeClassPtr, 100664119);
    }

    public Script_BloodBuff_Worker_Pulverize(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent EmpowerBuff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Worker_Pulverize.NativeFieldInfoPtr_EmpowerBuff));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Worker_Pulverize.NativeFieldInfoPtr_EmpowerBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float RequiredBloodPercentage
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Worker_Pulverize.NativeFieldInfoPtr_RequiredBloodPercentage));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Worker_Pulverize.NativeFieldInfoPtr_RequiredBloodPercentage)) = value;
      }
    }

    public unsafe float PulverizeChance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Worker_Pulverize.NativeFieldInfoPtr_PulverizeChance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Worker_Pulverize.NativeFieldInfoPtr_PulverizeChance)) = value;
      }
    }

    public DealDamageParameters_Editor PulverizeDamageParameters
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Worker_Pulverize.NativeFieldInfoPtr_PulverizeDamageParameters);
        return new DealDamageParameters_Editor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Worker_Pulverize.NativeFieldInfoPtr_PulverizeDamageParameters), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe SequenceField Sequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Worker_Pulverize.NativeFieldInfoPtr_Sequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_Worker_Pulverize.NativeFieldInfoPtr_Sequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_OnDamageDealt_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182240, XrefRangeEnd = 1182254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Worker_Pulverize.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182254, XrefRangeEnd = 1182296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void OnDamageDealt(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        ref StatChangeEvent statChangeEvent)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref statChangeEvent;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Worker_Pulverize.Server.NativeMethodInfoPtr_OnDamageDealt_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_BloodBuff_Worker_Pulverize.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_Worker_Pulverize.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_BloodBuff_Worker_Pulverize.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_BloodBuff_Worker_Pulverize>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_BloodBuff_Worker_Pulverize.Server>.NativeClassPtr);
        Script_BloodBuff_Worker_Pulverize.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Worker_Pulverize.Server>.NativeClassPtr, 100664120);
        Script_BloodBuff_Worker_Pulverize.Server.NativeMethodInfoPtr_OnDamageDealt_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Worker_Pulverize.Server>.NativeClassPtr, 100664121);
        Script_BloodBuff_Worker_Pulverize.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_Worker_Pulverize.Server>.NativeClassPtr, 100664122);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
