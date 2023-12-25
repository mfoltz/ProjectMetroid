// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnHitBuffPriority
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
using Unity.Transforms;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_CreateGameplayEventOnHitBuffPriority : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_TargetFilterCondition;
    private static readonly IntPtr NativeFieldInfoPtr_TargetHitFilter;
    private static readonly IntPtr NativeFieldInfoPtr_GameplayEventHitId;
    private static readonly IntPtr NativeFieldInfoPtr_InternalHitCooldown;
    private static readonly IntPtr NativeFieldInfoPtr_AddToPriorityListIfHasBuff;
    private static readonly IntPtr NativeFieldInfoPtr_TickTimer;
    private static readonly IntPtr NativeFieldInfoPtr_OverrideRadius;
    private static readonly IntPtr NativeFieldInfoPtr_Radius;
    private static readonly IntPtr NativeFieldInfoPtr_BuffEntity;
    private static readonly IntPtr NativeMethodInfoPtr_get_GameplayEventIds_Public_Virtual_Final_New_get_IEnumerable_1_GameplayEventIdSource_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe IEnumerable<GameplayEventIdSource> GameplayEventIds
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186926, XrefRangeEnd = 1186929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_CreateGameplayEventOnHitBuffPriority.NativeMethodInfoPtr_get_GameplayEventIds_Public_Virtual_Final_New_get_IEnumerable_1_GameplayEventIdSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IEnumerable<GameplayEventIdSource>) null : new IEnumerable<GameplayEventIdSource>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186929, XrefRangeEnd = 1186938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_CreateGameplayEventOnHitBuffPriority.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186938, XrefRangeEnd = 1186939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_CreateGameplayEventOnHitBuffPriority()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_CreateGameplayEventOnHitBuffPriority.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_CreateGameplayEventOnHitBuffPriority()
    {
      Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_CreateGameplayEventOnHitBuffPriority));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority>.NativeClassPtr);
      Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_TargetFilterCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority>.NativeClassPtr, nameof (TargetFilterCondition));
      Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_TargetHitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority>.NativeClassPtr, nameof (TargetHitFilter));
      Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_GameplayEventHitId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority>.NativeClassPtr, nameof (GameplayEventHitId));
      Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_InternalHitCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority>.NativeClassPtr, nameof (InternalHitCooldown));
      Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_AddToPriorityListIfHasBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority>.NativeClassPtr, nameof (AddToPriorityListIfHasBuff));
      Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_TickTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority>.NativeClassPtr, nameof (TickTimer));
      Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_OverrideRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority>.NativeClassPtr, nameof (OverrideRadius));
      Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority>.NativeClassPtr, nameof (Radius));
      Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_BuffEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority>.NativeClassPtr, nameof (BuffEntity));
      Script_CreateGameplayEventOnHitBuffPriority.NativeMethodInfoPtr_get_GameplayEventIds_Public_Virtual_Final_New_get_IEnumerable_1_GameplayEventIdSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority>.NativeClassPtr, 100664583);
      Script_CreateGameplayEventOnHitBuffPriority.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority>.NativeClassPtr, 100664584);
      Script_CreateGameplayEventOnHitBuffPriority.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority>.NativeClassPtr, 100664585);
    }

    public Script_CreateGameplayEventOnHitBuffPriority(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameplayConditionGroupData_Editor_Parent TargetFilterCondition
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_TargetFilterCondition));
        return pointer == IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_TargetFilterCondition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HitFilter TargetHitFilter
    {
      get
      {
        return *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_TargetHitFilter));
      }
      [param: In] set
      {
        *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_TargetHitFilter)) = value;
      }
    }

    public GameplayEventIdSource GameplayEventHitId
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_GameplayEventHitId);
        return new GameplayEventIdSource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_GameplayEventHitId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe float InternalHitCooldown
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_InternalHitCooldown));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_InternalHitCooldown)) = value;
      }
    }

    public unsafe bool AddToPriorityListIfHasBuff
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_AddToPriorityListIfHasBuff));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_AddToPriorityListIfHasBuff)) = value;
      }
    }

    public unsafe float TickTimer
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_TickTimer));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_TickTimer)) = value;
      }
    }

    public unsafe bool OverrideRadius
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_OverrideRadius));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_OverrideRadius)) = value;
      }
    }

    public unsafe float Radius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_Radius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_Radius)) = value;
      }
    }

    public unsafe PrefabGuidComponent BuffEntity
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_BuffEntity));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitBuffPriority.NativeFieldInfoPtr_BuffEntity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_CreateGameplayEventForRandomizedTarget_Private_Static_Void_ServerGameManager_SelfServer_Script_CreateGameplayEventOnHitBuffPriority_DataServer_EntityOwner_Translation_DynamicBuffer_1_BuffPriority_HitList_Previous_Entity_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186800, XrefRangeEnd = 1186911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_CreateGameplayEventOnHitBuffPriority.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1186925, RefRangeEnd = 1186926, XrefRangeStart = 1186911, XrefRangeEnd = 1186925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void CreateGameplayEventForRandomizedTarget(
        ServerGameManager game,
        SelfServer self,
        Script_CreateGameplayEventOnHitBuffPriority_DataServer dataShared,
        EntityOwner owner,
        Translation translation,
        DynamicBuffer<BuffPriority_HitList_Previous> previousHits,
        Entity target)
      {
        IntPtr* numPtr = stackalloc IntPtr[7];
        numPtr[0] = (IntPtr) &game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &dataShared;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &owner;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &translation;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &previousHits;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) &target;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_CreateGameplayEventOnHitBuffPriority.Server.NativeMethodInfoPtr_CreateGameplayEventForRandomizedTarget_Private_Static_Void_ServerGameManager_SelfServer_Script_CreateGameplayEventOnHitBuffPriority_DataServer_EntityOwner_Translation_DynamicBuffer_1_BuffPriority_HitList_Previous_Entity_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_CreateGameplayEventOnHitBuffPriority.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority.Server>.NativeClassPtr);
        Script_CreateGameplayEventOnHitBuffPriority.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority.Server>.NativeClassPtr, 100664586);
        Script_CreateGameplayEventOnHitBuffPriority.Server.NativeMethodInfoPtr_CreateGameplayEventForRandomizedTarget_Private_Static_Void_ServerGameManager_SelfServer_Script_CreateGameplayEventOnHitBuffPriority_DataServer_EntityOwner_Translation_DynamicBuffer_1_BuffPriority_HitList_Previous_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority.Server>.NativeClassPtr, 100664587);
        Script_CreateGameplayEventOnHitBuffPriority.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitBuffPriority.Server>.NativeClassPtr, 100664588);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
