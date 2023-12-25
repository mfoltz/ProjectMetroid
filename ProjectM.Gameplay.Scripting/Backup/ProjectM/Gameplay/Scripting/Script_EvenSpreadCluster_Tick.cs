// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_EvenSpreadCluster_Tick
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Scripting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_EvenSpreadCluster_Tick : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_InitialEntries;
    private static readonly IntPtr NativeFieldInfoPtr_Count;
    private static readonly IntPtr NativeFieldInfoPtr_OffsetAngle;
    private static readonly IntPtr NativeFieldInfoPtr_RandomAngle;
    private static readonly IntPtr NativeFieldInfoPtr_RotationPerTick;
    private static readonly IntPtr NativeFieldInfoPtr_IndividualRandom;
    private static readonly IntPtr NativeFieldInfoPtr_UseAimDirection;
    private static readonly IntPtr NativeFieldInfoPtr_UseSelfRotation;
    private static readonly IntPtr NativeFieldInfoPtr_AlwaysMaxRange;
    private static readonly IntPtr NativeFieldInfoPtr_UseAIReturnPosAsOrigo;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnOffset;
    private static readonly IntPtr NativeFieldInfoPtr_IgnoreCollision;
    private static readonly IntPtr NativeFieldInfoPtr_FullCircleSpread;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177272, XrefRangeEnd = 1177286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_EvenSpreadCluster_Tick.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177286, XrefRangeEnd = 1177287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_EvenSpreadCluster_Tick()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_EvenSpreadCluster_Tick.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_EvenSpreadCluster_Tick()
    {
      Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_EvenSpreadCluster_Tick));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick>.NativeClassPtr);
      Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_InitialEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick>.NativeClassPtr, nameof (InitialEntries));
      Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick>.NativeClassPtr, nameof (Count));
      Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_OffsetAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick>.NativeClassPtr, nameof (OffsetAngle));
      Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_RandomAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick>.NativeClassPtr, nameof (RandomAngle));
      Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_RotationPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick>.NativeClassPtr, nameof (RotationPerTick));
      Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_IndividualRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick>.NativeClassPtr, nameof (IndividualRandom));
      Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_UseAimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick>.NativeClassPtr, nameof (UseAimDirection));
      Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_UseSelfRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick>.NativeClassPtr, nameof (UseSelfRotation));
      Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_AlwaysMaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick>.NativeClassPtr, nameof (AlwaysMaxRange));
      Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_UseAIReturnPosAsOrigo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick>.NativeClassPtr, nameof (UseAIReturnPosAsOrigo));
      Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_SpawnOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick>.NativeClassPtr, nameof (SpawnOffset));
      Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_IgnoreCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick>.NativeClassPtr, nameof (IgnoreCollision));
      Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_FullCircleSpread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick>.NativeClassPtr, nameof (FullCircleSpread));
      Script_EvenSpreadCluster_Tick.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick>.NativeClassPtr, 100663615);
      Script_EvenSpreadCluster_Tick.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick>.NativeClassPtr, 100663616);
    }

    public Script_EvenSpreadCluster_Tick(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<PrefabGuidComponent> InitialEntries
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_InitialEntries));
        return pointer == IntPtr.Zero ? (List<PrefabGuidComponent>) null : new List<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_InitialEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int Count
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_Count));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_Count)) = value;
      }
    }

    public unsafe float OffsetAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_OffsetAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_OffsetAngle)) = value;
      }
    }

    public unsafe float RandomAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_RandomAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_RandomAngle)) = value;
      }
    }

    public unsafe float RotationPerTick
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_RotationPerTick));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_RotationPerTick)) = value;
      }
    }

    public unsafe bool IndividualRandom
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_IndividualRandom));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_IndividualRandom)) = value;
      }
    }

    public unsafe bool UseAimDirection
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_UseAimDirection));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_UseAimDirection)) = value;
      }
    }

    public unsafe bool UseSelfRotation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_UseSelfRotation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_UseSelfRotation)) = value;
      }
    }

    public unsafe bool AlwaysMaxRange
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_AlwaysMaxRange));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_AlwaysMaxRange)) = value;
      }
    }

    public unsafe bool UseAIReturnPosAsOrigo
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_UseAIReturnPosAsOrigo));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_UseAIReturnPosAsOrigo)) = value;
      }
    }

    public unsafe float3 SpawnOffset
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_SpawnOffset));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_SpawnOffset)) = value;
      }
    }

    public unsafe bool IgnoreCollision
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_IgnoreCollision));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_IgnoreCollision)) = value;
      }
    }

    public unsafe bool FullCircleSpread
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_FullCircleSpread));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_EvenSpreadCluster_Tick.NativeFieldInfoPtr_FullCircleSpread)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_OnTick_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0;
      private static readonly IntPtr NativeMethodInfoPtr_SpawnCluster_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_EvenSpreadCluster_Tick_DataServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177202, XrefRangeEnd = 1177209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void OnTick(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref GameplayEvent gameplayEvent)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref gameplayEvent;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_EvenSpreadCluster_Tick.Server.NativeMethodInfoPtr_OnTick_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1177271, RefRangeEnd = 1177272, XrefRangeStart = 1177209, XrefRangeEnd = 1177271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void SpawnCluster(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        ref EvenSpreadCluster_Tick_DataServer dataServer)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref dataServer;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_EvenSpreadCluster_Tick.Server.NativeMethodInfoPtr_SpawnCluster_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_EvenSpreadCluster_Tick_DataServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_EvenSpreadCluster_Tick.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick.Server>.NativeClassPtr);
        Script_EvenSpreadCluster_Tick.Server.NativeMethodInfoPtr_OnTick_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick.Server>.NativeClassPtr, 100663617);
        Script_EvenSpreadCluster_Tick.Server.NativeMethodInfoPtr_SpawnCluster_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_EvenSpreadCluster_Tick_DataServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick.Server>.NativeClassPtr, 100663618);
        Script_EvenSpreadCluster_Tick.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_EvenSpreadCluster_Tick.Server>.NativeClassPtr, 100663619);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
