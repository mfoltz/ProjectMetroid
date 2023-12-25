// Decompiled with JetBrains decompiler
// Type: ProjectM.InteractValidator
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct InteractValidator
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SKIP_LOS_DISTANCE;
    private static readonly System.IntPtr NativeFieldInfoPtr_SKIP_LOS_HEIGHT;
    private static readonly System.IntPtr NativeFieldInfoPtr_CHEST_HEIGHT;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConditionChecker;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionFilter;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_InteractValidator_SystemBase_byref_TileWorld_byref_CollisionWorld_byref_ConditionChecker_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestInteractable_Public_Entity_Entity_byref_EntityAimData_byref_Interactor_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNearbyInteractables_Private_Void_Entity_byref_float3_byref_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidateCanInteractWith_Public_Boolean_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidateCanInteractWith_Public_Boolean_Entity_Entity_byref_float3_byref_float3_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanUseInteractAbility_Public_Boolean_Entity_Entity_InteractAbilityBuffer_0;
    [FieldOffset(0)]
    public EntityManager EntityManager;
    [FieldOffset(8)]
    public TileWorld TileWorld;
    [FieldOffset(32)]
    public ConditionChecker ConditionChecker;
    [FieldOffset(2232)]
    public CollisionWorld CollisionWorld;
    [FieldOffset(2576)]
    public CollisionFilter CollisionFilter;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1000829, RefRangeEnd = 1000832, XrefRangeStart = 1000826, XrefRangeEnd = 1000829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe InteractValidator Create(
      SystemBase systemBase,
      [In] ref TileWorld tileWorld,
      [In] ref CollisionWorld collisionWorld,
      [In] ref ConditionChecker conditionChecker)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref conditionChecker;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractValidator.NativeMethodInfoPtr_Create_Public_Static_InteractValidator_SystemBase_byref_TileWorld_byref_CollisionWorld_byref_ConditionChecker_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(InteractValidator*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1000882, RefRangeEnd = 1000883, XrefRangeStart = 1000832, XrefRangeEnd = 1000882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetClosestInteractable(
      Entity interactorEntity,
      [In] ref EntityAimData aimData,
      [In] ref Interactor interactor)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &interactorEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aimData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref interactor;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractValidator.NativeMethodInfoPtr_GetClosestInteractable_Public_Entity_Entity_byref_EntityAimData_byref_Interactor_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1000907, RefRangeEnd = 1000908, XrefRangeStart = 1000883, XrefRangeEnd = 1000907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetNearbyInteractables(
      Entity interactor,
      [In] ref float3 interactorPosition,
      ref NativeList<Entity> interactables)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &interactor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref interactorPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref interactables;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InteractValidator.NativeMethodInfoPtr_GetNearbyInteractables_Private_Void_Entity_byref_float3_byref_NativeList_1_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1000912, RefRangeEnd = 1000914, XrefRangeStart = 1000908, XrefRangeEnd = 1000912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ValidateCanInteractWith(Entity owner, Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractValidator.NativeMethodInfoPtr_ValidateCanInteractWith_Public_Boolean_Entity_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1000959, RefRangeEnd = 1000961, XrefRangeStart = 1000914, XrefRangeEnd = 1000959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ValidateCanInteractWith(
      Entity owner,
      Entity target,
      [In] ref float3 interactorPosition,
      out float3 targetPosition,
      bool skipCollisionCheck = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref interactorPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref targetPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &skipCollisionCheck;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractValidator.NativeMethodInfoPtr_ValidateCanInteractWith_Public_Boolean_Entity_Entity_byref_float3_byref_float3_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1000963, RefRangeEnd = 1000966, XrefRangeStart = 1000961, XrefRangeEnd = 1000963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanUseInteractAbility(
      Entity owner,
      Entity target,
      InteractAbilityBuffer ability)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &ability;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractValidator.NativeMethodInfoPtr_CanUseInteractAbility_Public_Boolean_Entity_Entity_InteractAbilityBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static InteractValidator()
    {
      Il2CppClassPointerStore<InteractValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (InteractValidator));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractValidator>.NativeClassPtr);
      InteractValidator.NativeFieldInfoPtr_SKIP_LOS_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidator>.NativeClassPtr, nameof (SKIP_LOS_DISTANCE));
      InteractValidator.NativeFieldInfoPtr_SKIP_LOS_HEIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidator>.NativeClassPtr, nameof (SKIP_LOS_HEIGHT));
      InteractValidator.NativeFieldInfoPtr_CHEST_HEIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidator>.NativeClassPtr, nameof (CHEST_HEIGHT));
      InteractValidator.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidator>.NativeClassPtr, nameof (EntityManager));
      InteractValidator.NativeFieldInfoPtr_TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidator>.NativeClassPtr, nameof (TileWorld));
      InteractValidator.NativeFieldInfoPtr_ConditionChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidator>.NativeClassPtr, nameof (ConditionChecker));
      InteractValidator.NativeFieldInfoPtr_CollisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidator>.NativeClassPtr, nameof (CollisionWorld));
      InteractValidator.NativeFieldInfoPtr_CollisionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidator>.NativeClassPtr, nameof (CollisionFilter));
      InteractValidator.NativeMethodInfoPtr_Create_Public_Static_InteractValidator_SystemBase_byref_TileWorld_byref_CollisionWorld_byref_ConditionChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidator>.NativeClassPtr, 100677472);
      InteractValidator.NativeMethodInfoPtr_GetClosestInteractable_Public_Entity_Entity_byref_EntityAimData_byref_Interactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidator>.NativeClassPtr, 100677473);
      InteractValidator.NativeMethodInfoPtr_GetNearbyInteractables_Private_Void_Entity_byref_float3_byref_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidator>.NativeClassPtr, 100677474);
      InteractValidator.NativeMethodInfoPtr_ValidateCanInteractWith_Public_Boolean_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidator>.NativeClassPtr, 100677475);
      InteractValidator.NativeMethodInfoPtr_ValidateCanInteractWith_Public_Boolean_Entity_Entity_byref_float3_byref_float3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidator>.NativeClassPtr, 100677476);
      InteractValidator.NativeMethodInfoPtr_CanUseInteractAbility_Public_Boolean_Entity_Entity_InteractAbilityBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidator>.NativeClassPtr, 100677477);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractValidator>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe float SKIP_LOS_DISTANCE
    {
      get
      {
        float skipLosDistance;
        IL2CPP.il2cpp_field_static_get_value(InteractValidator.NativeFieldInfoPtr_SKIP_LOS_DISTANCE, (void*) &skipLosDistance);
        return skipLosDistance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(InteractValidator.NativeFieldInfoPtr_SKIP_LOS_DISTANCE, (void*) &value);
      }
    }

    public static unsafe float SKIP_LOS_HEIGHT
    {
      get
      {
        float skipLosHeight;
        IL2CPP.il2cpp_field_static_get_value(InteractValidator.NativeFieldInfoPtr_SKIP_LOS_HEIGHT, (void*) &skipLosHeight);
        return skipLosHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(InteractValidator.NativeFieldInfoPtr_SKIP_LOS_HEIGHT, (void*) &value);
      }
    }

    public static unsafe float CHEST_HEIGHT
    {
      get
      {
        float chestHeight;
        IL2CPP.il2cpp_field_static_get_value(InteractValidator.NativeFieldInfoPtr_CHEST_HEIGHT, (void*) &chestHeight);
        return chestHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(InteractValidator.NativeFieldInfoPtr_CHEST_HEIGHT, (void*) &value);
      }
    }
  }
}
