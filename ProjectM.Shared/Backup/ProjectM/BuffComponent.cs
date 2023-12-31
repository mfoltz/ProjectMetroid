// Decompiled with JetBrains decompiler
// Type: ProjectM.BuffComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class BuffComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_BuffType;
    private static readonly IntPtr NativeFieldInfoPtr_Stack_MaxPerTarget;
    private static readonly IntPtr NativeFieldInfoPtr_Stack_ResetAge;
    private static readonly IntPtr NativeFieldInfoPtr_Stack_KeepOldest;
    private static readonly IntPtr NativeFieldInfoPtr_Merge_KeepOldest;
    private static readonly IntPtr NativeFieldInfoPtr_Merge_ResetAge;
    private static readonly IntPtr NativeFieldInfoPtr_Persists_Through_Death;
    private static readonly IntPtr NativeFieldInfoPtr_Destroy_On_Owner_Death;
    private static readonly IntPtr NativeFieldInfoPtr_ForceSync;
    private static readonly IntPtr NativeFieldInfoPtr_AllowTranslationSync;
    private static readonly IntPtr NativeFieldInfoPtr_BuffEffectType;
    private static readonly IntPtr NativeFieldInfoPtr_BuffModifications;
    private static readonly IntPtr NativeFieldInfoPtr_ConditionalModifications;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726321, XrefRangeEnd = 726353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(BuffComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726353, XrefRangeEnd = 726372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuffComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726372, XrefRangeEnd = 726373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BuffComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BuffComponent()
    {
      Il2CppClassPointerStore<BuffComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BuffComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffComponent>.NativeClassPtr);
      BuffComponent.NativeFieldInfoPtr_BuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffComponent>.NativeClassPtr, nameof (BuffType));
      BuffComponent.NativeFieldInfoPtr_Stack_MaxPerTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffComponent>.NativeClassPtr, nameof (Stack_MaxPerTarget));
      BuffComponent.NativeFieldInfoPtr_Stack_ResetAge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffComponent>.NativeClassPtr, nameof (Stack_ResetAge));
      BuffComponent.NativeFieldInfoPtr_Stack_KeepOldest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffComponent>.NativeClassPtr, nameof (Stack_KeepOldest));
      BuffComponent.NativeFieldInfoPtr_Merge_KeepOldest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffComponent>.NativeClassPtr, nameof (Merge_KeepOldest));
      BuffComponent.NativeFieldInfoPtr_Merge_ResetAge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffComponent>.NativeClassPtr, nameof (Merge_ResetAge));
      BuffComponent.NativeFieldInfoPtr_Persists_Through_Death = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffComponent>.NativeClassPtr, nameof (Persists_Through_Death));
      BuffComponent.NativeFieldInfoPtr_Destroy_On_Owner_Death = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffComponent>.NativeClassPtr, nameof (Destroy_On_Owner_Death));
      BuffComponent.NativeFieldInfoPtr_ForceSync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffComponent>.NativeClassPtr, nameof (ForceSync));
      BuffComponent.NativeFieldInfoPtr_AllowTranslationSync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffComponent>.NativeClassPtr, nameof (AllowTranslationSync));
      BuffComponent.NativeFieldInfoPtr_BuffEffectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffComponent>.NativeClassPtr, nameof (BuffEffectType));
      BuffComponent.NativeFieldInfoPtr_BuffModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffComponent>.NativeClassPtr, nameof (BuffModifications));
      BuffComponent.NativeFieldInfoPtr_ConditionalModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffComponent>.NativeClassPtr, nameof (ConditionalModifications));
      BuffComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffComponent>.NativeClassPtr, 100664196);
      BuffComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffComponent>.NativeClassPtr, 100664197);
      BuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffComponent>.NativeClassPtr, 100664198);
    }

    public BuffComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BuffType_Editor BuffType
    {
      get
      {
        return *(BuffType_Editor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_BuffType));
      }
      [param: In] set
      {
        *(BuffType_Editor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_BuffType)) = value;
      }
    }

    public unsafe byte Stack_MaxPerTarget
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_Stack_MaxPerTarget));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_Stack_MaxPerTarget)) = value;
      }
    }

    public unsafe bool Stack_ResetAge
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_Stack_ResetAge));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_Stack_ResetAge)) = value;
      }
    }

    public unsafe bool Stack_KeepOldest
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_Stack_KeepOldest));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_Stack_KeepOldest)) = value;
      }
    }

    public unsafe bool Merge_KeepOldest
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_Merge_KeepOldest));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_Merge_KeepOldest)) = value;
      }
    }

    public unsafe bool Merge_ResetAge
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_Merge_ResetAge));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_Merge_ResetAge)) = value;
      }
    }

    public unsafe bool Persists_Through_Death
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_Persists_Through_Death));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_Persists_Through_Death)) = value;
      }
    }

    public unsafe bool Destroy_On_Owner_Death
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_Destroy_On_Owner_Death));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_Destroy_On_Owner_Death)) = value;
      }
    }

    public unsafe bool ForceSync
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_ForceSync));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_ForceSync)) = value;
      }
    }

    public unsafe bool AllowTranslationSync
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_AllowTranslationSync));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_AllowTranslationSync)) = value;
      }
    }

    public unsafe BuffEffectType BuffEffectType
    {
      get
      {
        return *(BuffEffectType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_BuffEffectType));
      }
      [param: In] set
      {
        *(BuffEffectType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_BuffEffectType)) = value;
      }
    }

    public unsafe long BuffModifications
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_BuffModifications));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_BuffModifications)) = value;
      }
    }

    public unsafe List<ConditionBuffModificationFlagData_Editor> ConditionalModifications
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_ConditionalModifications));
        return pointer == IntPtr.Zero ? (List<ConditionBuffModificationFlagData_Editor>) null : new List<ConditionBuffModificationFlagData_Editor>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffComponent.NativeFieldInfoPtr_ConditionalModifications), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
