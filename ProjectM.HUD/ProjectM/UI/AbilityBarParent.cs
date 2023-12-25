// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.AbilityBarParent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using TMPro;

#nullable disable
namespace ProjectM.UI
{
  public class AbilityBarParent : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ActionWheelReminderKeybindText;
    private static readonly IntPtr NativeFieldInfoPtr_Entries;
    private static readonly IntPtr NativeFieldInfoPtr_INPUTS;
    private static readonly IntPtr NativeMethodInfoPtr_TryGetGroupSlotIndexFromAbilityType_Public_Static_Boolean_AbilityTypeEnum_byref_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212265, XrefRangeEnd = 1212282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetGroupSlotIndexFromAbilityType(
      AbilityTypeEnum abilityType,
      out int groupSlotIndex)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &abilityType;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref groupSlotIndex;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityBarParent.NativeMethodInfoPtr_TryGetGroupSlotIndexFromAbilityType_Public_Static_Boolean_AbilityTypeEnum_byref_Int32_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityBarParent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityBarParent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityBarParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityBarParent()
    {
      Il2CppClassPointerStore<AbilityBarParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (AbilityBarParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityBarParent>.NativeClassPtr);
      AbilityBarParent.NativeFieldInfoPtr_ActionWheelReminderKeybindText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarParent>.NativeClassPtr, nameof (ActionWheelReminderKeybindText));
      AbilityBarParent.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarParent>.NativeClassPtr, nameof (Entries));
      AbilityBarParent.NativeFieldInfoPtr_INPUTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarParent>.NativeClassPtr, nameof (INPUTS));
      AbilityBarParent.NativeMethodInfoPtr_TryGetGroupSlotIndexFromAbilityType_Public_Static_Boolean_AbilityTypeEnum_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBarParent>.NativeClassPtr, 100663841);
      AbilityBarParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBarParent>.NativeClassPtr, 100663842);
    }

    public AbilityBarParent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TMP_Text ActionWheelReminderKeybindText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarParent.NativeFieldInfoPtr_ActionWheelReminderKeybindText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarParent.NativeFieldInfoPtr_ActionWheelReminderKeybindText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<AbilityBarEntry> Entries
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarParent.NativeFieldInfoPtr_Entries));
        return pointer == IntPtr.Zero ? (List<AbilityBarEntry>) null : new List<AbilityBarEntry>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarParent.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppStructArray<InputFlag> INPUTS
    {
      get
      {
        IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(AbilityBarParent.NativeFieldInfoPtr_INPUTS, (void*) &num);
        IntPtr nativeObject = num;
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<InputFlag>) null : new Il2CppStructArray<InputFlag>(nativeObject);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AbilityBarParent.NativeFieldInfoPtr_INPUTS, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
