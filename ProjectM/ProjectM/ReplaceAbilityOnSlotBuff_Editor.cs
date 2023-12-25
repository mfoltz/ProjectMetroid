// Decompiled with JetBrains decompiler
// Type: ProjectM.ReplaceAbilityOnSlotBuff_Editor
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public sealed class ReplaceAbilityOnSlotBuff_Editor : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_Slot;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReplaceGroupId;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewGroupId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Priority;
    private static readonly System.IntPtr NativeFieldInfoPtr_Conditional;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastBlockType;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_ReplaceAbilityOnSlotBuff_MonoBehaviour_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1001390, RefRangeEnd = 1001391, XrefRangeStart = 1001380, XrefRangeEnd = 1001390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ReplaceAbilityOnSlotBuff Convert(MonoBehaviour builder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) builder);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotBuff_Editor.NativeMethodInfoPtr_Convert_Public_ReplaceAbilityOnSlotBuff_MonoBehaviour_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ReplaceAbilityOnSlotBuff*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ReplaceAbilityOnSlotBuff_Editor()
    {
      Il2CppClassPointerStore<ReplaceAbilityOnSlotBuff_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ReplaceAbilityOnSlotBuff_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceAbilityOnSlotBuff_Editor>.NativeClassPtr);
      ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotBuff_Editor>.NativeClassPtr, nameof (Target));
      ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_Slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotBuff_Editor>.NativeClassPtr, nameof (Slot));
      ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_ReplaceGroupId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotBuff_Editor>.NativeClassPtr, nameof (ReplaceGroupId));
      ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_NewGroupId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotBuff_Editor>.NativeClassPtr, nameof (NewGroupId));
      ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotBuff_Editor>.NativeClassPtr, nameof (Priority));
      ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_Conditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotBuff_Editor>.NativeClassPtr, nameof (Conditional));
      ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_CastBlockType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotBuff_Editor>.NativeClassPtr, nameof (CastBlockType));
      ReplaceAbilityOnSlotBuff_Editor.NativeMethodInfoPtr_Convert_Public_ReplaceAbilityOnSlotBuff_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotBuff_Editor>.NativeClassPtr, 100677514);
    }

    public ReplaceAbilityOnSlotBuff_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ReplaceAbilityOnSlotBuff_Editor()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReplaceAbilityOnSlotBuff_Editor>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceAbilityOnSlotBuff_Editor>.NativeClassPtr, data));
    }

    public unsafe ReplaceAbilityTarget Target
    {
      get
      {
        return *(ReplaceAbilityTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_Target));
      }
      [param: In] set
      {
        *(ReplaceAbilityTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_Target)) = value;
      }
    }

    public unsafe int Slot
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_Slot));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_Slot)) = value;
      }
    }

    public unsafe PrefabGuidComponent ReplaceGroupId
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_ReplaceGroupId));
        return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_ReplaceGroupId), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent NewGroupId
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_NewGroupId));
        return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_NewGroupId), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int Priority
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_Priority));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_Priority)) = value;
      }
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Conditional
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_Conditional));
        return pointer == System.IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_Conditional), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GroupSlotModificationCastBlockType CastBlockType
    {
      get
      {
        return *(GroupSlotModificationCastBlockType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_CastBlockType));
      }
      [param: In] set
      {
        *(GroupSlotModificationCastBlockType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotBuff_Editor.NativeFieldInfoPtr_CastBlockType)) = value;
      }
    }
  }
}
