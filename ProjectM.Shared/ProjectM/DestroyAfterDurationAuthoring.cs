// Decompiled with JetBrains decompiler
// Type: ProjectM.DestroyAfterDurationAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class DestroyAfterDurationAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Duration;
    private static readonly IntPtr NativeFieldInfoPtr_Condition;
    private static readonly IntPtr NativeFieldInfoPtr_OnlyRemoveIfNoActiveUserInRange;
    private static readonly IntPtr NativeFieldInfoPtr_ActiveUserCheckRange;
    private static readonly IntPtr NativeFieldInfoPtr_ActiveUserDurationModifier;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724021, XrefRangeEnd = 724028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
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
      IL2CPP.il2cpp_runtime_invoke(DestroyAfterDurationAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724028, XrefRangeEnd = 724032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroyAfterDurationAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724032, XrefRangeEnd = 724033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DestroyAfterDurationAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyAfterDurationAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyAfterDurationAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DestroyAfterDurationAuthoring()
    {
      Il2CppClassPointerStore<DestroyAfterDurationAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DestroyAfterDurationAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyAfterDurationAuthoring>.NativeClassPtr);
      DestroyAfterDurationAuthoring.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyAfterDurationAuthoring>.NativeClassPtr, nameof (Duration));
      DestroyAfterDurationAuthoring.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyAfterDurationAuthoring>.NativeClassPtr, nameof (Condition));
      DestroyAfterDurationAuthoring.NativeFieldInfoPtr_OnlyRemoveIfNoActiveUserInRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyAfterDurationAuthoring>.NativeClassPtr, nameof (OnlyRemoveIfNoActiveUserInRange));
      DestroyAfterDurationAuthoring.NativeFieldInfoPtr_ActiveUserCheckRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyAfterDurationAuthoring>.NativeClassPtr, nameof (ActiveUserCheckRange));
      DestroyAfterDurationAuthoring.NativeFieldInfoPtr_ActiveUserDurationModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyAfterDurationAuthoring>.NativeClassPtr, nameof (ActiveUserDurationModifier));
      DestroyAfterDurationAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyAfterDurationAuthoring>.NativeClassPtr, 100664037);
      DestroyAfterDurationAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyAfterDurationAuthoring>.NativeClassPtr, 100664038);
      DestroyAfterDurationAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyAfterDurationAuthoring>.NativeClassPtr, 100664039);
    }

    public DestroyAfterDurationAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Duration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyAfterDurationAuthoring.NativeFieldInfoPtr_Duration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyAfterDurationAuthoring.NativeFieldInfoPtr_Duration)) = value;
      }
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Condition
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyAfterDurationAuthoring.NativeFieldInfoPtr_Condition));
        return pointer == IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DestroyAfterDurationAuthoring.NativeFieldInfoPtr_Condition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool OnlyRemoveIfNoActiveUserInRange
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyAfterDurationAuthoring.NativeFieldInfoPtr_OnlyRemoveIfNoActiveUserInRange));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyAfterDurationAuthoring.NativeFieldInfoPtr_OnlyRemoveIfNoActiveUserInRange)) = value;
      }
    }

    public unsafe float ActiveUserCheckRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyAfterDurationAuthoring.NativeFieldInfoPtr_ActiveUserCheckRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyAfterDurationAuthoring.NativeFieldInfoPtr_ActiveUserCheckRange)) = value;
      }
    }

    public unsafe float ActiveUserDurationModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyAfterDurationAuthoring.NativeFieldInfoPtr_ActiveUserDurationModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyAfterDurationAuthoring.NativeFieldInfoPtr_ActiveUserDurationModifier)) = value;
      }
    }
  }
}
