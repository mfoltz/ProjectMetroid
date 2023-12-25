// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_StormPolarityShift
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
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_StormPolarityShift : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_GeneralFilterCondition;
    private static readonly IntPtr NativeFieldInfoPtr_TargetFilterCondition;
    private static readonly IntPtr NativeFieldInfoPtr_AllyFilterCondition;
    private static readonly IntPtr NativeFieldInfoPtr_SelfTravelSpell;
    private static readonly IntPtr NativeFieldInfoPtr_EnemyTravelSpell;
    private static readonly IntPtr NativeFieldInfoPtr_AllyTravelSpell;
    private static readonly IntPtr NativeFieldInfoPtr_TargetHitFilter;
    private static readonly IntPtr NativeFieldInfoPtr_AllyHitFilter;
    private static readonly IntPtr NativeFieldInfoPtr_MinDuration;
    private static readonly IntPtr NativeFieldInfoPtr_MaxDuration;
    private static readonly IntPtr NativeFieldInfoPtr_MaxRange;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178487, XrefRangeEnd = 1178496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_StormPolarityShift.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_StormPolarityShift()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_StormPolarityShift>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_StormPolarityShift.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_StormPolarityShift()
    {
      Il2CppClassPointerStore<Script_StormPolarityShift>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_StormPolarityShift));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_StormPolarityShift>.NativeClassPtr);
      Script_StormPolarityShift.NativeFieldInfoPtr_GeneralFilterCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift>.NativeClassPtr, nameof (GeneralFilterCondition));
      Script_StormPolarityShift.NativeFieldInfoPtr_TargetFilterCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift>.NativeClassPtr, nameof (TargetFilterCondition));
      Script_StormPolarityShift.NativeFieldInfoPtr_AllyFilterCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift>.NativeClassPtr, nameof (AllyFilterCondition));
      Script_StormPolarityShift.NativeFieldInfoPtr_SelfTravelSpell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift>.NativeClassPtr, nameof (SelfTravelSpell));
      Script_StormPolarityShift.NativeFieldInfoPtr_EnemyTravelSpell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift>.NativeClassPtr, nameof (EnemyTravelSpell));
      Script_StormPolarityShift.NativeFieldInfoPtr_AllyTravelSpell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift>.NativeClassPtr, nameof (AllyTravelSpell));
      Script_StormPolarityShift.NativeFieldInfoPtr_TargetHitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift>.NativeClassPtr, nameof (TargetHitFilter));
      Script_StormPolarityShift.NativeFieldInfoPtr_AllyHitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift>.NativeClassPtr, nameof (AllyHitFilter));
      Script_StormPolarityShift.NativeFieldInfoPtr_MinDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift>.NativeClassPtr, nameof (MinDuration));
      Script_StormPolarityShift.NativeFieldInfoPtr_MaxDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift>.NativeClassPtr, nameof (MaxDuration));
      Script_StormPolarityShift.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StormPolarityShift>.NativeClassPtr, nameof (MaxRange));
      Script_StormPolarityShift.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_StormPolarityShift>.NativeClassPtr, 100663716);
      Script_StormPolarityShift.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_StormPolarityShift>.NativeClassPtr, 100663717);
    }

    public Script_StormPolarityShift(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameplayConditionGroupData_Editor_Parent GeneralFilterCondition
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_GeneralFilterCondition));
        return pointer == IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_GeneralFilterCondition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameplayConditionGroupData_Editor_Parent TargetFilterCondition
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_TargetFilterCondition));
        return pointer == IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_TargetFilterCondition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameplayConditionGroupData_Editor_Parent AllyFilterCondition
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_AllyFilterCondition));
        return pointer == IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_AllyFilterCondition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent SelfTravelSpell
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_SelfTravelSpell));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_SelfTravelSpell), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent EnemyTravelSpell
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_EnemyTravelSpell));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_EnemyTravelSpell), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent AllyTravelSpell
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_AllyTravelSpell));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_AllyTravelSpell), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HitFilter TargetHitFilter
    {
      get
      {
        return *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_TargetHitFilter));
      }
      [param: In] set
      {
        *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_TargetHitFilter)) = value;
      }
    }

    public unsafe HitFilter AllyHitFilter
    {
      get
      {
        return *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_AllyHitFilter));
      }
      [param: In] set
      {
        *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_AllyHitFilter)) = value;
      }
    }

    public unsafe float MinDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_MinDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_MinDuration)) = value;
      }
    }

    public unsafe float MaxDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_MaxDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_MaxDuration)) = value;
      }
    }

    public unsafe float MaxRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_MaxRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_StormPolarityShift.NativeFieldInfoPtr_MaxRange)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_EventHit_Protected_Static_Boolean_byref_ServerGameManager_SelfServer_Entity_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr_CanApplyBuff_Private_Static_Boolean_ServerGameManager_Entity_0;
      private static readonly IntPtr NativeMethodInfoPtr_SpawnBuff_Private_Static_Void_ServerGameManager_SelfServer_Entity_PrefabGUID_Script_StormPolarityShift_DataServer_float3_float3_Single_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178352, XrefRangeEnd = 1178415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_StormPolarityShift.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1178447, RefRangeEnd = 1178449, XrefRangeStart = 1178415, XrefRangeEnd = 1178447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool EventHit(
        ref ServerGameManager game,
        SelfServer self,
        Entity targetHit,
        bool isEnemy)
      {
        IntPtr* numPtr = stackalloc IntPtr[4];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &targetHit;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &isEnemy;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_StormPolarityShift.Server.NativeMethodInfoPtr_EventHit_Protected_Static_Boolean_byref_ServerGameManager_SelfServer_Entity_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1178463, RefRangeEnd = 1178465, XrefRangeStart = 1178449, XrefRangeEnd = 1178463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool CanApplyBuff(ServerGameManager game, Entity target)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) &game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &target;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_StormPolarityShift.Server.NativeMethodInfoPtr_CanApplyBuff_Private_Static_Boolean_ServerGameManager_Entity_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1178485, RefRangeEnd = 1178487, XrefRangeStart = 1178465, XrefRangeEnd = 1178485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void SpawnBuff(
        ServerGameManager game,
        SelfServer creator,
        Entity target,
        PrefabGUID travelBuff,
        Script_StormPolarityShift_DataServer data,
        float3 startPosition,
        float3 targetPosition,
        float distanceFactor)
      {
        IntPtr* numPtr = stackalloc IntPtr[8];
        numPtr[0] = (IntPtr) &game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &creator;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &target;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &travelBuff;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &data;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &startPosition;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) &targetPosition;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(7) * sizeof (IntPtr))) = (IntPtr) &distanceFactor;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_StormPolarityShift.Server.NativeMethodInfoPtr_SpawnBuff_Private_Static_Void_ServerGameManager_SelfServer_Entity_PrefabGUID_Script_StormPolarityShift_DataServer_float3_float3_Single_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_StormPolarityShift.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_StormPolarityShift.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_StormPolarityShift.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_StormPolarityShift>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_StormPolarityShift.Server>.NativeClassPtr);
        Script_StormPolarityShift.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_StormPolarityShift.Server>.NativeClassPtr, 100663718);
        Script_StormPolarityShift.Server.NativeMethodInfoPtr_EventHit_Protected_Static_Boolean_byref_ServerGameManager_SelfServer_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_StormPolarityShift.Server>.NativeClassPtr, 100663719);
        Script_StormPolarityShift.Server.NativeMethodInfoPtr_CanApplyBuff_Private_Static_Boolean_ServerGameManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_StormPolarityShift.Server>.NativeClassPtr, 100663720);
        Script_StormPolarityShift.Server.NativeMethodInfoPtr_SpawnBuff_Private_Static_Void_ServerGameManager_SelfServer_Entity_PrefabGUID_Script_StormPolarityShift_DataServer_float3_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_StormPolarityShift.Server>.NativeClassPtr, 100663721);
        Script_StormPolarityShift.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_StormPolarityShift.Server>.NativeClassPtr, 100663722);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
