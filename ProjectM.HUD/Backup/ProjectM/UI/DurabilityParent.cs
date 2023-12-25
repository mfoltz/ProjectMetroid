// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.DurabilityParent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class DurabilityParent : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DurabilitySelectionGroup;
    private static readonly IntPtr NativeFieldInfoPtr_DurabilityEntryPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_DurabilityLayout;
    private static readonly IntPtr NativeFieldInfoPtr_DurabilityThreshold_Damaged;
    private static readonly IntPtr NativeFieldInfoPtr_DurabilityThreshold_HeavyDamaged;
    private static readonly IntPtr NativeFieldInfoPtr_DurabilityColor_Damaged;
    private static readonly IntPtr NativeFieldInfoPtr_DurabilityColor_HeavyDamaged;
    private static readonly IntPtr NativeFieldInfoPtr_DurabilityColor_Broken;
    private static readonly IntPtr NativeFieldInfoPtr_DurabilitySprite_Weapon;
    private static readonly IntPtr NativeFieldInfoPtr_DurabilitySprite_Grimoire;
    private static readonly IntPtr NativeFieldInfoPtr_DurabilitySprite_Cloak;
    private static readonly IntPtr NativeFieldInfoPtr_DurabilitySprite_Head;
    private static readonly IntPtr NativeFieldInfoPtr_DurabilitySprite_Chest;
    private static readonly IntPtr NativeFieldInfoPtr_DurabilitySprite_Leg;
    private static readonly IntPtr NativeFieldInfoPtr_DurabilitySprite_Feet;
    private static readonly IntPtr NativeFieldInfoPtr_DurabilitySprite_Gloves;
    private static readonly IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__16_0_Private_Void_DurabilityGridSelectionEntry_Data_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260989, XrefRangeEnd = 1261004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DurabilityParent.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DurabilityParent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DurabilityParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261004, XrefRangeEnd = 1261006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__16_0(
      DurabilityGridSelectionEntry entry,
      DurabilityGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DurabilityParent.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__16_0_Private_Void_DurabilityGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DurabilityParent()
    {
      Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (DurabilityParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr);
      DurabilityParent.NativeFieldInfoPtr_DurabilitySelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr, nameof (DurabilitySelectionGroup));
      DurabilityParent.NativeFieldInfoPtr_DurabilityEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr, nameof (DurabilityEntryPrefab));
      DurabilityParent.NativeFieldInfoPtr_DurabilityLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr, nameof (DurabilityLayout));
      DurabilityParent.NativeFieldInfoPtr_DurabilityThreshold_Damaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr, nameof (DurabilityThreshold_Damaged));
      DurabilityParent.NativeFieldInfoPtr_DurabilityThreshold_HeavyDamaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr, nameof (DurabilityThreshold_HeavyDamaged));
      DurabilityParent.NativeFieldInfoPtr_DurabilityColor_Damaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr, nameof (DurabilityColor_Damaged));
      DurabilityParent.NativeFieldInfoPtr_DurabilityColor_HeavyDamaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr, nameof (DurabilityColor_HeavyDamaged));
      DurabilityParent.NativeFieldInfoPtr_DurabilityColor_Broken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr, nameof (DurabilityColor_Broken));
      DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Weapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr, nameof (DurabilitySprite_Weapon));
      DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Grimoire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr, nameof (DurabilitySprite_Grimoire));
      DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Cloak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr, nameof (DurabilitySprite_Cloak));
      DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr, nameof (DurabilitySprite_Head));
      DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Chest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr, nameof (DurabilitySprite_Chest));
      DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Leg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr, nameof (DurabilitySprite_Leg));
      DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Feet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr, nameof (DurabilitySprite_Feet));
      DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Gloves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr, nameof (DurabilitySprite_Gloves));
      DurabilityParent.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr, 100667244);
      DurabilityParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr, 100667245);
      DurabilityParent.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__16_0_Private_Void_DurabilityGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DurabilityParent>.NativeClassPtr, 100667246);
    }

    public DurabilityParent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GridSelectionGroup<DurabilityGridSelectionEntry, DurabilityGridSelectionEntry.Data> DurabilitySelectionGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilitySelectionGroup));
        return pointer == IntPtr.Zero ? (GridSelectionGroup<DurabilityGridSelectionEntry, DurabilityGridSelectionEntry.Data>) null : new GridSelectionGroup<DurabilityGridSelectionEntry, DurabilityGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilitySelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DurabilityGridSelectionEntry DurabilityEntryPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilityEntryPrefab));
        return pointer == IntPtr.Zero ? (DurabilityGridSelectionEntry) null : new DurabilityGridSelectionEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilityEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup DurabilityLayout
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilityLayout));
        return pointer == IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilityLayout), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float DurabilityThreshold_Damaged
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilityThreshold_Damaged));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilityThreshold_Damaged)) = value;
      }
    }

    public unsafe float DurabilityThreshold_HeavyDamaged
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilityThreshold_HeavyDamaged));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilityThreshold_HeavyDamaged)) = value;
      }
    }

    public unsafe Color DurabilityColor_Damaged
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilityColor_Damaged));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilityColor_Damaged)) = value;
      }
    }

    public unsafe Color DurabilityColor_HeavyDamaged
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilityColor_HeavyDamaged));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilityColor_HeavyDamaged)) = value;
      }
    }

    public unsafe Color DurabilityColor_Broken
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilityColor_Broken));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilityColor_Broken)) = value;
      }
    }

    public unsafe Sprite DurabilitySprite_Weapon
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Weapon));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Weapon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite DurabilitySprite_Grimoire
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Grimoire));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Grimoire), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite DurabilitySprite_Cloak
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Cloak));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Cloak), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite DurabilitySprite_Head
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Head));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Head), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite DurabilitySprite_Chest
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Chest));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Chest), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite DurabilitySprite_Leg
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Leg));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Leg), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite DurabilitySprite_Feet
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Feet));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Feet), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite DurabilitySprite_Gloves
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Gloves));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DurabilityParent.NativeFieldInfoPtr_DurabilitySprite_Gloves), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
