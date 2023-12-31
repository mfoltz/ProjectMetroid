// Decompiled with JetBrains decompiler
// Type: ProjectM.PrisonCellAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class PrisonCellAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_LKey_RequiresPsychicForm;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_TargetIsImmune;
    private static readonly IntPtr NativeFieldInfoPtr_Buff_PsychicForm;
    private static readonly IntPtr NativeFieldInfoPtr_ImprisonedBuff;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723145, XrefRangeEnd = 723155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(PrisonCellAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723155, XrefRangeEnd = 723159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrisonCellAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrisonCellAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrisonCellAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrisonCellAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PrisonCellAuthoring()
    {
      Il2CppClassPointerStore<PrisonCellAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PrisonCellAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrisonCellAuthoring>.NativeClassPtr);
      PrisonCellAuthoring.NativeFieldInfoPtr_LKey_RequiresPsychicForm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonCellAuthoring>.NativeClassPtr, nameof (LKey_RequiresPsychicForm));
      PrisonCellAuthoring.NativeFieldInfoPtr_LKey_TargetIsImmune = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonCellAuthoring>.NativeClassPtr, nameof (LKey_TargetIsImmune));
      PrisonCellAuthoring.NativeFieldInfoPtr_Buff_PsychicForm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonCellAuthoring>.NativeClassPtr, nameof (Buff_PsychicForm));
      PrisonCellAuthoring.NativeFieldInfoPtr_ImprisonedBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonCellAuthoring>.NativeClassPtr, nameof (ImprisonedBuff));
      PrisonCellAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonCellAuthoring>.NativeClassPtr, 100663917);
      PrisonCellAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonCellAuthoring>.NativeClassPtr, 100663918);
      PrisonCellAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonCellAuthoring>.NativeClassPtr, 100663919);
    }

    public PrisonCellAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey LKey_RequiresPsychicForm
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonCellAuthoring.NativeFieldInfoPtr_LKey_RequiresPsychicForm));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonCellAuthoring.NativeFieldInfoPtr_LKey_RequiresPsychicForm)) = value;
      }
    }

    public unsafe LocalizationKey LKey_TargetIsImmune
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonCellAuthoring.NativeFieldInfoPtr_LKey_TargetIsImmune));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonCellAuthoring.NativeFieldInfoPtr_LKey_TargetIsImmune)) = value;
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> Buff_PsychicForm
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonCellAuthoring.NativeFieldInfoPtr_Buff_PsychicForm));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonCellAuthoring.NativeFieldInfoPtr_Buff_PsychicForm), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> ImprisonedBuff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonCellAuthoring.NativeFieldInfoPtr_ImprisonedBuff));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonCellAuthoring.NativeFieldInfoPtr_ImprisonedBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
