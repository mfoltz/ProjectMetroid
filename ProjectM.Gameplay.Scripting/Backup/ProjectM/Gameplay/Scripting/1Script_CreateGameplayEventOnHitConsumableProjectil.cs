// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnHitConsumableProjectile
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

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_CreateGameplayEventOnHitConsumableProjectile : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_TargetFilterCondition;
    private static readonly IntPtr NativeFieldInfoPtr_TargetHitFilter;
    private static readonly IntPtr NativeFieldInfoPtr_GameplayEventHitId;
    private static readonly IntPtr NativeFieldInfoPtr_EntityCategory;
    private static readonly IntPtr NativeFieldInfoPtr_MustBeOwnerOfProjectile;
    private static readonly IntPtr NativeMethodInfoPtr_get_GameplayEventIds_Public_Virtual_Final_New_get_IEnumerable_1_GameplayEventIdSource_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe IEnumerable<GameplayEventIdSource> GameplayEventIds
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187007, XrefRangeEnd = 1187010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_CreateGameplayEventOnHitConsumableProjectile.NativeMethodInfoPtr_get_GameplayEventIds_Public_Virtual_Final_New_get_IEnumerable_1_GameplayEventIdSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IEnumerable<GameplayEventIdSource>) null : new IEnumerable<GameplayEventIdSource>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187010, XrefRangeEnd = 1187018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_CreateGameplayEventOnHitConsumableProjectile.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187018, XrefRangeEnd = 1187019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_CreateGameplayEventOnHitConsumableProjectile()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_CreateGameplayEventOnHitConsumableProjectile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_CreateGameplayEventOnHitConsumableProjectile()
    {
      Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_CreateGameplayEventOnHitConsumableProjectile));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile>.NativeClassPtr);
      Script_CreateGameplayEventOnHitConsumableProjectile.NativeFieldInfoPtr_TargetFilterCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile>.NativeClassPtr, nameof (TargetFilterCondition));
      Script_CreateGameplayEventOnHitConsumableProjectile.NativeFieldInfoPtr_TargetHitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile>.NativeClassPtr, nameof (TargetHitFilter));
      Script_CreateGameplayEventOnHitConsumableProjectile.NativeFieldInfoPtr_GameplayEventHitId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile>.NativeClassPtr, nameof (GameplayEventHitId));
      Script_CreateGameplayEventOnHitConsumableProjectile.NativeFieldInfoPtr_EntityCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile>.NativeClassPtr, nameof (EntityCategory));
      Script_CreateGameplayEventOnHitConsumableProjectile.NativeFieldInfoPtr_MustBeOwnerOfProjectile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile>.NativeClassPtr, nameof (MustBeOwnerOfProjectile));
      Script_CreateGameplayEventOnHitConsumableProjectile.NativeMethodInfoPtr_get_GameplayEventIds_Public_Virtual_Final_New_get_IEnumerable_1_GameplayEventIdSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile>.NativeClassPtr, 100664589);
      Script_CreateGameplayEventOnHitConsumableProjectile.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile>.NativeClassPtr, 100664590);
      Script_CreateGameplayEventOnHitConsumableProjectile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile>.NativeClassPtr, 100664591);
    }

    public Script_CreateGameplayEventOnHitConsumableProjectile(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameplayConditionGroupData_Editor_Parent TargetFilterCondition
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitConsumableProjectile.NativeFieldInfoPtr_TargetFilterCondition));
        return pointer == IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitConsumableProjectile.NativeFieldInfoPtr_TargetFilterCondition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HitFilter TargetHitFilter
    {
      get
      {
        return *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitConsumableProjectile.NativeFieldInfoPtr_TargetHitFilter));
      }
      [param: In] set
      {
        *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitConsumableProjectile.NativeFieldInfoPtr_TargetHitFilter)) = value;
      }
    }

    public GameplayEventIdSource GameplayEventHitId
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitConsumableProjectile.NativeFieldInfoPtr_GameplayEventHitId);
        return new GameplayEventIdSource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitConsumableProjectile.NativeFieldInfoPtr_GameplayEventHitId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe MainEntityCategory EntityCategory
    {
      get
      {
        return *(MainEntityCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitConsumableProjectile.NativeFieldInfoPtr_EntityCategory));
      }
      [param: In] set
      {
        *(MainEntityCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitConsumableProjectile.NativeFieldInfoPtr_EntityCategory)) = value;
      }
    }

    public unsafe bool MustBeOwnerOfProjectile
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitConsumableProjectile.NativeFieldInfoPtr_MustBeOwnerOfProjectile));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitConsumableProjectile.NativeFieldInfoPtr_MustBeOwnerOfProjectile)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186939, XrefRangeEnd = 1187007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_CreateGameplayEventOnHitConsumableProjectile.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_CreateGameplayEventOnHitConsumableProjectile.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile.Server>.NativeClassPtr);
        Script_CreateGameplayEventOnHitConsumableProjectile.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile.Server>.NativeClassPtr, 100664592);
        Script_CreateGameplayEventOnHitConsumableProjectile.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitConsumableProjectile.Server>.NativeClassPtr, 100664593);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
