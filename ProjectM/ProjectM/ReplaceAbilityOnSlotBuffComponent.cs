// Decompiled with JetBrains decompiler
// Type: ProjectM.ReplaceAbilityOnSlotBuffComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ReplaceAbilityOnSlotBuffComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ReplaceEntries;
    private static readonly IntPtr NativeFieldInfoPtr_CopyCooldown;
    private static readonly IntPtr NativeFieldInfoPtr_CastBlockType;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001391, XrefRangeEnd = 1001405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotBuffComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001405, XrefRangeEnd = 1001415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReplaceAbilityOnSlotBuffComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ReplaceAbilityOnSlotBuffComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceAbilityOnSlotBuffComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotBuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ReplaceAbilityOnSlotBuffComponent()
    {
      Il2CppClassPointerStore<ReplaceAbilityOnSlotBuffComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ReplaceAbilityOnSlotBuffComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceAbilityOnSlotBuffComponent>.NativeClassPtr);
      ReplaceAbilityOnSlotBuffComponent.NativeFieldInfoPtr_ReplaceEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotBuffComponent>.NativeClassPtr, nameof (ReplaceEntries));
      ReplaceAbilityOnSlotBuffComponent.NativeFieldInfoPtr_CopyCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotBuffComponent>.NativeClassPtr, nameof (CopyCooldown));
      ReplaceAbilityOnSlotBuffComponent.NativeFieldInfoPtr_CastBlockType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotBuffComponent>.NativeClassPtr, nameof (CastBlockType));
      ReplaceAbilityOnSlotBuffComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotBuffComponent>.NativeClassPtr, 100677515);
      ReplaceAbilityOnSlotBuffComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotBuffComponent>.NativeClassPtr, 100677516);
      ReplaceAbilityOnSlotBuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotBuffComponent>.NativeClassPtr, 100677517);
    }

    public ReplaceAbilityOnSlotBuffComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<ReplaceAbilityOnSlotBuff_Editor> ReplaceEntries
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotBuffComponent.NativeFieldInfoPtr_ReplaceEntries));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<ReplaceAbilityOnSlotBuff_Editor>) null : new Il2CppReferenceArray<ReplaceAbilityOnSlotBuff_Editor>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotBuffComponent.NativeFieldInfoPtr_ReplaceEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool CopyCooldown
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotBuffComponent.NativeFieldInfoPtr_CopyCooldown));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotBuffComponent.NativeFieldInfoPtr_CopyCooldown)) = value;
      }
    }

    public unsafe GroupSlotModificationCastBlockType CastBlockType
    {
      get
      {
        return *(GroupSlotModificationCastBlockType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotBuffComponent.NativeFieldInfoPtr_CastBlockType));
      }
      [param: In] set
      {
        *(GroupSlotModificationCastBlockType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotBuffComponent.NativeFieldInfoPtr_CastBlockType)) = value;
      }
    }
  }
}
