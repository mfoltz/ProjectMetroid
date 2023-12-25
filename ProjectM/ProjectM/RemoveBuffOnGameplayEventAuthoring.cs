// Decompiled with JetBrains decompiler
// Type: ProjectM.RemoveBuffOnGameplayEventAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Malee;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class RemoveBuffOnGameplayEventAuthoring : OnGameplayEventAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_Conditional;
    private static readonly IntPtr NativeFieldInfoPtr_BuffTarget;
    private static readonly IntPtr NativeFieldInfoPtr_Buffs;
    private static readonly IntPtr NativeFieldInfoPtr_BuffCategories;
    private static readonly IntPtr NativeFieldInfoPtr_IncludeSelf;
    private static readonly IntPtr NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetHeaderName_Public_Virtual_String_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    public override unsafe GameplayEventTypeEnum GetGameplayEventType()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RemoveBuffOnGameplayEventAuthoring.NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayEventTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008285, XrefRangeEnd = 1008343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(RemoveBuffOnGameplayEventAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008343, XrefRangeEnd = 1008357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string GetHeaderName()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RemoveBuffOnGameplayEventAuthoring.NativeMethodInfoPtr_GetHeaderName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RemoveBuffOnGameplayEventAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RemoveBuffOnGameplayEventAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RemoveBuffOnGameplayEventAuthoring()
    {
      Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RemoveBuffOnGameplayEventAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring>.NativeClassPtr);
      RemoveBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (Conditional));
      RemoveBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_BuffTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (BuffTarget));
      RemoveBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_Buffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (Buffs));
      RemoveBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_BuffCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (BuffCategories));
      RemoveBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_IncludeSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (IncludeSelf));
      RemoveBuffOnGameplayEventAuthoring.NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring>.NativeClassPtr, 100678331);
      RemoveBuffOnGameplayEventAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring>.NativeClassPtr, 100678332);
      RemoveBuffOnGameplayEventAuthoring.NativeMethodInfoPtr_GetHeaderName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring>.NativeClassPtr, 100678333);
      RemoveBuffOnGameplayEventAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring>.NativeClassPtr, 100678334);
    }

    public RemoveBuffOnGameplayEventAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Conditional
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional));
        return pointer == IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RemoveBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RemoveBuffTarget BuffTarget
    {
      get
      {
        return *(RemoveBuffTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_BuffTarget));
      }
      [param: In] set
      {
        *(RemoveBuffTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_BuffTarget)) = value;
      }
    }

    public unsafe RemoveBuffOnGameplayEventAuthoring.BuffsArray Buffs
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_Buffs));
        return pointer == IntPtr.Zero ? (RemoveBuffOnGameplayEventAuthoring.BuffsArray) null : new RemoveBuffOnGameplayEventAuthoring.BuffsArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RemoveBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_Buffs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RemoveBuffOnGameplayEventAuthoring.BuffCategoriesArray BuffCategories
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_BuffCategories));
        return pointer == IntPtr.Zero ? (RemoveBuffOnGameplayEventAuthoring.BuffCategoriesArray) null : new RemoveBuffOnGameplayEventAuthoring.BuffCategoriesArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RemoveBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_BuffCategories), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool IncludeSelf
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_IncludeSelf));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveBuffOnGameplayEventAuthoring.NativeFieldInfoPtr_IncludeSelf)) = value;
      }
    }

    [Serializable]
    public class BuffsArray : ReorderableArray<RemoveBuffOnGameplayEventEntry_Editor>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008279, XrefRangeEnd = 1008282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BuffsArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring.BuffsArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveBuffOnGameplayEventAuthoring.BuffsArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static BuffsArray()
      {
        Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring.BuffsArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (BuffsArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring.BuffsArray>.NativeClassPtr);
        RemoveBuffOnGameplayEventAuthoring.BuffsArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring.BuffsArray>.NativeClassPtr, 100678335);
      }

      public BuffsArray(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [Serializable]
    public class BuffCategoriesArray : 
      ReorderableArray<RemoveBuffCategoryOnGameplayEventEntry_Editor>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008282, XrefRangeEnd = 1008285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BuffCategoriesArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring.BuffCategoriesArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveBuffOnGameplayEventAuthoring.BuffCategoriesArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static BuffCategoriesArray()
      {
        Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring.BuffCategoriesArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring>.NativeClassPtr, nameof (BuffCategoriesArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring.BuffCategoriesArray>.NativeClassPtr);
        RemoveBuffOnGameplayEventAuthoring.BuffCategoriesArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveBuffOnGameplayEventAuthoring.BuffCategoriesArray>.NativeClassPtr, 100678336);
      }

      public BuffCategoriesArray(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
