// Decompiled with JetBrains decompiler
// Type: ProjectM.ConditionalSharedAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ConditionalSharedAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeFieldInfoPtr_Condition;
    private static readonly IntPtr NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_PrintDebug_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe int GuidHash
    {
      [CallerCount(14), CachedScanResults(RefRangeStart = 466385, RefRangeEnd = 466399, XrefRangeStart = 466385, XrefRangeEnd = 466399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionalSharedAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748714, XrefRangeEnd = 748755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrintDebug()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConditionalSharedAsset.NativeMethodInfoPtr_PrintDebug_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConditionalSharedAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalSharedAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConditionalSharedAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ConditionalSharedAsset()
    {
      Il2CppClassPointerStore<ConditionalSharedAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ConditionalSharedAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalSharedAsset>.NativeClassPtr);
      ConditionalSharedAsset.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalSharedAsset>.NativeClassPtr, nameof (_Guid));
      ConditionalSharedAsset.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalSharedAsset>.NativeClassPtr, nameof (Condition));
      ConditionalSharedAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalSharedAsset>.NativeClassPtr, 100665923);
      ConditionalSharedAsset.NativeMethodInfoPtr_PrintDebug_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalSharedAsset>.NativeClassPtr, 100665924);
      ConditionalSharedAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalSharedAsset>.NativeClassPtr, 100665925);
    }

    public ConditionalSharedAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalSharedAsset.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConditionalSharedAsset.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Condition
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalSharedAsset.NativeFieldInfoPtr_Condition));
        return pointer == IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConditionalSharedAsset.NativeFieldInfoPtr_Condition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
