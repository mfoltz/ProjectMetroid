// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Blood_CrimsonBeam
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.Scripting;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_Blood_CrimsonBeam : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_TickRateServer;
    private static readonly IntPtr NativeFieldInfoPtr_TickRateClient;
    private static readonly IntPtr NativeFieldInfoPtr_ServerTickEvent;
    private static readonly IntPtr NativeFieldInfoPtr_HitFilter;
    private static readonly IntPtr NativeFieldInfoPtr_TargetFilterCondition;
    private static readonly IntPtr NativeFieldInfoPtr_BoxSize;
    private static readonly IntPtr NativeFieldInfoPtr_BoxOffset;
    private static readonly IntPtr NativeFieldInfoPtr_DamageParameters;
    private static readonly IntPtr NativeFieldInfoPtr_HealParameters;
    private static readonly IntPtr NativeFieldInfoPtr_SelfHealParameters;
    private static readonly IntPtr NativeFieldInfoPtr_AllyHitSequences;
    private static readonly IntPtr NativeFieldInfoPtr_NonAllyHitSequences;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178770, XrefRangeEnd = 1178799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_Blood_CrimsonBeam.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_Blood_CrimsonBeam()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Blood_CrimsonBeam>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_Blood_CrimsonBeam.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_Blood_CrimsonBeam()
    {
      Il2CppClassPointerStore<Script_Blood_CrimsonBeam>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Blood_CrimsonBeam));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Blood_CrimsonBeam>.NativeClassPtr);
      Script_Blood_CrimsonBeam.NativeFieldInfoPtr_TickRateServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam>.NativeClassPtr, nameof (TickRateServer));
      Script_Blood_CrimsonBeam.NativeFieldInfoPtr_TickRateClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam>.NativeClassPtr, nameof (TickRateClient));
      Script_Blood_CrimsonBeam.NativeFieldInfoPtr_ServerTickEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam>.NativeClassPtr, nameof (ServerTickEvent));
      Script_Blood_CrimsonBeam.NativeFieldInfoPtr_HitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam>.NativeClassPtr, nameof (HitFilter));
      Script_Blood_CrimsonBeam.NativeFieldInfoPtr_TargetFilterCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam>.NativeClassPtr, nameof (TargetFilterCondition));
      Script_Blood_CrimsonBeam.NativeFieldInfoPtr_BoxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam>.NativeClassPtr, nameof (BoxSize));
      Script_Blood_CrimsonBeam.NativeFieldInfoPtr_BoxOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam>.NativeClassPtr, nameof (BoxOffset));
      Script_Blood_CrimsonBeam.NativeFieldInfoPtr_DamageParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam>.NativeClassPtr, nameof (DamageParameters));
      Script_Blood_CrimsonBeam.NativeFieldInfoPtr_HealParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam>.NativeClassPtr, nameof (HealParameters));
      Script_Blood_CrimsonBeam.NativeFieldInfoPtr_SelfHealParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam>.NativeClassPtr, nameof (SelfHealParameters));
      Script_Blood_CrimsonBeam.NativeFieldInfoPtr_AllyHitSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam>.NativeClassPtr, nameof (AllyHitSequences));
      Script_Blood_CrimsonBeam.NativeFieldInfoPtr_NonAllyHitSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam>.NativeClassPtr, nameof (NonAllyHitSequences));
      Script_Blood_CrimsonBeam.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Blood_CrimsonBeam>.NativeClassPtr, 100663730);
      Script_Blood_CrimsonBeam.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Blood_CrimsonBeam>.NativeClassPtr, 100663731);
    }

    public Script_Blood_CrimsonBeam(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float TickRateServer
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_TickRateServer));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_TickRateServer)) = value;
      }
    }

    public unsafe float TickRateClient
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_TickRateClient));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_TickRateClient)) = value;
      }
    }

    public GameplayEventIdSource ServerTickEvent
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_ServerTickEvent);
        return new GameplayEventIdSource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_ServerTickEvent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe HitFilter HitFilter
    {
      get
      {
        return *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_HitFilter));
      }
      [param: In] set
      {
        *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_HitFilter)) = value;
      }
    }

    public unsafe GameplayConditionGroupData_Editor_Parent TargetFilterCondition
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_TargetFilterCondition));
        return pointer == IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_TargetFilterCondition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float3 BoxSize
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_BoxSize));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_BoxSize)) = value;
      }
    }

    public unsafe float3 BoxOffset
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_BoxOffset));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_BoxOffset)) = value;
      }
    }

    public DealDamageParameters_Editor DamageParameters
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_DamageParameters);
        return new DealDamageParameters_Editor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_DamageParameters), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe HealUtility.DealHealingParameters_Editor HealParameters
    {
      get
      {
        return *(HealUtility.DealHealingParameters_Editor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_HealParameters));
      }
      [param: In] set
      {
        *(HealUtility.DealHealingParameters_Editor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_HealParameters)) = value;
      }
    }

    public unsafe HealUtility.DealHealingParameters_Editor SelfHealParameters
    {
      get
      {
        return *(HealUtility.DealHealingParameters_Editor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_SelfHealParameters));
      }
      [param: In] set
      {
        *(HealUtility.DealHealingParameters_Editor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_SelfHealParameters)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<SequenceField> AllyHitSequences
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_AllyHitSequences));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<SequenceField>) null : new Il2CppReferenceArray<SequenceField>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_AllyHitSequences), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<SequenceField> NonAllyHitSequences
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_NonAllyHitSequences));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<SequenceField>) null : new Il2CppReferenceArray<SequenceField>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Blood_CrimsonBeam.NativeFieldInfoPtr_NonAllyHitSequences), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Tick_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_TryFindHitElementIndex_Private_Static_Boolean_DynamicBuffer_1_Script_Blood_CrimsonBeam_HitElement_Entity_byref_Int32_0;
      private static readonly IntPtr NativeMethodInfoPtr_IsOragnicTarget_Private_Static_Boolean_byref_ServerGameManager_Entity_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178604, XrefRangeEnd = 1178614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Blood_CrimsonBeam.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178614, XrefRangeEnd = 1178658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Blood_CrimsonBeam.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178658, XrefRangeEnd = 1178703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Tick(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Blood_CrimsonBeam.Server.NativeMethodInfoPtr_Tick_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1178712, RefRangeEnd = 1178713, XrefRangeStart = 1178703, XrefRangeEnd = 1178712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool TryFindHitElementIndex(
        DynamicBuffer<Script_Blood_CrimsonBeam_HitElement> buffer,
        Entity entity,
        out int result)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) &buffer;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &entity;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref result;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_Blood_CrimsonBeam.Server.NativeMethodInfoPtr_TryFindHitElementIndex_Private_Static_Boolean_DynamicBuffer_1_Script_Blood_CrimsonBeam_HitElement_Entity_byref_Int32_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1178716, RefRangeEnd = 1178717, XrefRangeStart = 1178713, XrefRangeEnd = 1178716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool IsOragnicTarget(ref ServerGameManager game, Entity target)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &target;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_Blood_CrimsonBeam.Server.NativeMethodInfoPtr_IsOragnicTarget_Private_Static_Boolean_byref_ServerGameManager_Entity_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Blood_CrimsonBeam.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Blood_CrimsonBeam.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_Blood_CrimsonBeam.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_Blood_CrimsonBeam>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Blood_CrimsonBeam.Server>.NativeClassPtr);
        Script_Blood_CrimsonBeam.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Blood_CrimsonBeam.Server>.NativeClassPtr, 100663732);
        Script_Blood_CrimsonBeam.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Blood_CrimsonBeam.Server>.NativeClassPtr, 100663733);
        Script_Blood_CrimsonBeam.Server.NativeMethodInfoPtr_Tick_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Blood_CrimsonBeam.Server>.NativeClassPtr, 100663734);
        Script_Blood_CrimsonBeam.Server.NativeMethodInfoPtr_TryFindHitElementIndex_Private_Static_Boolean_DynamicBuffer_1_Script_Blood_CrimsonBeam_HitElement_Entity_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Blood_CrimsonBeam.Server>.NativeClassPtr, 100663735);
        Script_Blood_CrimsonBeam.Server.NativeMethodInfoPtr_IsOragnicTarget_Private_Static_Boolean_byref_ServerGameManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Blood_CrimsonBeam.Server>.NativeClassPtr, 100663736);
        Script_Blood_CrimsonBeam.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Blood_CrimsonBeam.Server>.NativeClassPtr, 100663737);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Client : ClientScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0;
      private static readonly IntPtr NativeMethodInfoPtr_PlaySequences_Private_Static_Void_byref_HitResult_Boolean_byref_ClientGameManager_byref_SelfClient_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178717, XrefRangeEnd = 1178755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ClientGameManager game, [In] ref SelfClient self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Blood_CrimsonBeam.Client.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1178769, RefRangeEnd = 1178770, XrefRangeStart = 1178755, XrefRangeEnd = 1178769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PlaySequences(
        [In] ref HitResult hit,
        bool isAlly,
        ref ClientGameManager game,
        [In] ref SelfClient self)
      {
        IntPtr* numPtr = stackalloc IntPtr[4];
        numPtr[0] = (IntPtr) ref hit;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &isAlly;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Blood_CrimsonBeam.Client.NativeMethodInfoPtr_PlaySequences_Private_Static_Void_byref_HitResult_Boolean_byref_ClientGameManager_byref_SelfClient_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Client()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Blood_CrimsonBeam.Client>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Blood_CrimsonBeam.Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Client()
      {
        Il2CppClassPointerStore<Script_Blood_CrimsonBeam.Client>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_Blood_CrimsonBeam>.NativeClassPtr, nameof (Client));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Blood_CrimsonBeam.Client>.NativeClassPtr);
        Script_Blood_CrimsonBeam.Client.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Blood_CrimsonBeam.Client>.NativeClassPtr, 100663738);
        Script_Blood_CrimsonBeam.Client.NativeMethodInfoPtr_PlaySequences_Private_Static_Void_byref_HitResult_Boolean_byref_ClientGameManager_byref_SelfClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Blood_CrimsonBeam.Client>.NativeClassPtr, 100663739);
        Script_Blood_CrimsonBeam.Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Blood_CrimsonBeam.Client>.NativeClassPtr, 100663740);
      }

      public Client(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
