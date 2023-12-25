// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BuffBarParent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class BuffBarParent : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_BuffsSelectionGroup;
    private static readonly IntPtr NativeFieldInfoPtr_DebuffsSelectionGroup;
    private static readonly IntPtr NativeFieldInfoPtr_BuffPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_BuffParent;
    private static readonly IntPtr NativeFieldInfoPtr_DebuffParent;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Buff;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Debuff;
    private static readonly IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateBuffBar_Internal_Void_List_1_Data_List_1_Data_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__7_0_Private_Void_BuffBarEntry_Data_0;
    private static readonly IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__7_1_Private_Void_BuffBarEntry_Data_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217234, XrefRangeEnd = 1217260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffBarParent.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217260, XrefRangeEnd = 1217266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateBuffBar(List<BuffBarEntry.Data> buffs, List<BuffBarEntry.Data> debuffs)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffs);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) debuffs);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffBarParent.NativeMethodInfoPtr_UpdateBuffBar_Internal_Void_List_1_Data_List_1_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BuffBarParent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffBarParent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffBarParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217266, XrefRangeEnd = 1217267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__7_0(
      BuffBarEntry entry,
      BuffBarEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffBarParent.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__7_0_Private_Void_BuffBarEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217267, XrefRangeEnd = 1217268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__7_1(
      BuffBarEntry entry,
      BuffBarEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffBarParent.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__7_1_Private_Void_BuffBarEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BuffBarParent()
    {
      Il2CppClassPointerStore<BuffBarParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BuffBarParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffBarParent>.NativeClassPtr);
      BuffBarParent.NativeFieldInfoPtr_BuffsSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarParent>.NativeClassPtr, nameof (BuffsSelectionGroup));
      BuffBarParent.NativeFieldInfoPtr_DebuffsSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarParent>.NativeClassPtr, nameof (DebuffsSelectionGroup));
      BuffBarParent.NativeFieldInfoPtr_BuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarParent>.NativeClassPtr, nameof (BuffPrefab));
      BuffBarParent.NativeFieldInfoPtr_BuffParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarParent>.NativeClassPtr, nameof (BuffParent));
      BuffBarParent.NativeFieldInfoPtr_DebuffParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarParent>.NativeClassPtr, nameof (DebuffParent));
      BuffBarParent.NativeFieldInfoPtr_LKey_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarParent>.NativeClassPtr, nameof (LKey_Buff));
      BuffBarParent.NativeFieldInfoPtr_LKey_Debuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffBarParent>.NativeClassPtr, nameof (LKey_Debuff));
      BuffBarParent.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffBarParent>.NativeClassPtr, 100664278);
      BuffBarParent.NativeMethodInfoPtr_UpdateBuffBar_Internal_Void_List_1_Data_List_1_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffBarParent>.NativeClassPtr, 100664279);
      BuffBarParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffBarParent>.NativeClassPtr, 100664280);
      BuffBarParent.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__7_0_Private_Void_BuffBarEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffBarParent>.NativeClassPtr, 100664281);
      BuffBarParent.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__7_1_Private_Void_BuffBarEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffBarParent>.NativeClassPtr, 100664282);
    }

    public BuffBarParent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GridSelectionGroup<BuffBarEntry, BuffBarEntry.Data> BuffsSelectionGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarParent.NativeFieldInfoPtr_BuffsSelectionGroup));
        return pointer == IntPtr.Zero ? (GridSelectionGroup<BuffBarEntry, BuffBarEntry.Data>) null : new GridSelectionGroup<BuffBarEntry, BuffBarEntry.Data>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffBarParent.NativeFieldInfoPtr_BuffsSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<BuffBarEntry, BuffBarEntry.Data> DebuffsSelectionGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarParent.NativeFieldInfoPtr_DebuffsSelectionGroup));
        return pointer == IntPtr.Zero ? (GridSelectionGroup<BuffBarEntry, BuffBarEntry.Data>) null : new GridSelectionGroup<BuffBarEntry, BuffBarEntry.Data>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffBarParent.NativeFieldInfoPtr_DebuffsSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BuffBarEntry BuffPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarParent.NativeFieldInfoPtr_BuffPrefab));
        return pointer == IntPtr.Zero ? (BuffBarEntry) null : new BuffBarEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffBarParent.NativeFieldInfoPtr_BuffPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup BuffParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarParent.NativeFieldInfoPtr_BuffParent));
        return pointer == IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffBarParent.NativeFieldInfoPtr_BuffParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup DebuffParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarParent.NativeFieldInfoPtr_DebuffParent));
        return pointer == IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffBarParent.NativeFieldInfoPtr_DebuffParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_Buff
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarParent.NativeFieldInfoPtr_LKey_Buff));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarParent.NativeFieldInfoPtr_LKey_Buff)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Debuff
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarParent.NativeFieldInfoPtr_LKey_Debuff));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffBarParent.NativeFieldInfoPtr_LKey_Debuff)) = value;
      }
    }
  }
}
