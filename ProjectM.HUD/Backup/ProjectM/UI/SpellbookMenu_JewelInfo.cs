// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SpellbookMenu_JewelInfo
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class SpellbookMenu_JewelInfo : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameText;
    private static readonly System.IntPtr NativeFieldInfoPtr_ButtonText;
    private static readonly System.IntPtr NativeFieldInfoPtr_JewelAbility;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellModTopParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellModEntryParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResultsMotions;
    private static readonly System.IntPtr NativeFieldInfoPtr__JewelAbilityPrefabGUID_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpellModCache;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_JewelAbilityPrefabGUID_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_JewelAbilityPrefabGUID_Private_set_Void_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Internal_Void_byref_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshEmpty_Internal_Void_byref_Data_Empty_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Internal_Void_byref_Data_Crafting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshShared_Private_Void_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe PrefabGUID JewelAbilityPrefabGUID
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 43842, RefRangeEnd = 43846, XrefRangeStart = 43842, XrefRangeEnd = 43846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellbookMenu_JewelInfo.NativeMethodInfoPtr_get_JewelAbilityPrefabGUID_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 86269, RefRangeEnd = 86272, XrefRangeStart = 86269, XrefRangeEnd = 86272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellbookMenu_JewelInfo.NativeMethodInfoPtr_set_JewelAbilityPrefabGUID_Private_set_Void_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1263297, RefRangeEnd = 1263298, XrefRangeStart = 1263267, XrefRangeEnd = 1263297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Refresh([In] ref SpellbookMenu_JewelInfo.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenu_JewelInfo.NativeMethodInfoPtr_Refresh_Internal_Void_byref_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263298, XrefRangeEnd = 1263308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshEmpty([In] ref SpellbookMenu_JewelInfo.Data_Empty data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenu_JewelInfo.NativeMethodInfoPtr_RefreshEmpty_Internal_Void_byref_Data_Empty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1263338, RefRangeEnd = 1263339, XrefRangeStart = 1263308, XrefRangeEnd = 1263338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Refresh([In] ref SpellbookMenu_JewelInfo.Data_Crafting data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenu_JewelInfo.NativeMethodInfoPtr_Refresh_Internal_Void_byref_Data_Crafting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263339, XrefRangeEnd = 1263340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshShared(bool empty, bool isBrowsingAbilities)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &empty;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isBrowsingAbilities;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenu_JewelInfo.NativeMethodInfoPtr_RefreshShared_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263340, XrefRangeEnd = 1263348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellbookMenu_JewelInfo()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenu_JewelInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpellbookMenu_JewelInfo()
    {
      Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (SpellbookMenu_JewelInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr);
      SpellbookMenu_JewelInfo.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr, nameof (Button));
      SpellbookMenu_JewelInfo.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr, nameof (Icon));
      SpellbookMenu_JewelInfo.NativeFieldInfoPtr_NameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr, nameof (NameText));
      SpellbookMenu_JewelInfo.NativeFieldInfoPtr_ButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr, nameof (ButtonText));
      SpellbookMenu_JewelInfo.NativeFieldInfoPtr_JewelAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr, nameof (JewelAbility));
      SpellbookMenu_JewelInfo.NativeFieldInfoPtr_SpellModTopParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr, nameof (SpellModTopParent));
      SpellbookMenu_JewelInfo.NativeFieldInfoPtr_SpellModEntryParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr, nameof (SpellModEntryParent));
      SpellbookMenu_JewelInfo.NativeFieldInfoPtr_ResultsMotions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr, nameof (ResultsMotions));
      SpellbookMenu_JewelInfo.NativeFieldInfoPtr__JewelAbilityPrefabGUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr, "<JewelAbilityPrefabGUID>k__BackingField");
      SpellbookMenu_JewelInfo.NativeFieldInfoPtr__SpellModCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr, nameof (_SpellModCache));
      SpellbookMenu_JewelInfo.NativeMethodInfoPtr_get_JewelAbilityPrefabGUID_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr, 100667442);
      SpellbookMenu_JewelInfo.NativeMethodInfoPtr_set_JewelAbilityPrefabGUID_Private_set_Void_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr, 100667443);
      SpellbookMenu_JewelInfo.NativeMethodInfoPtr_Refresh_Internal_Void_byref_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr, 100667444);
      SpellbookMenu_JewelInfo.NativeMethodInfoPtr_RefreshEmpty_Internal_Void_byref_Data_Empty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr, 100667445);
      SpellbookMenu_JewelInfo.NativeMethodInfoPtr_Refresh_Internal_Void_byref_Data_Crafting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr, 100667446);
      SpellbookMenu_JewelInfo.NativeMethodInfoPtr_RefreshShared_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr, 100667447);
      SpellbookMenu_JewelInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr, 100667448);
    }

    public SpellbookMenu_JewelInfo(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SimpleStunButton Button
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.NativeFieldInfoPtr_Button));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText NameText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.NativeFieldInfoPtr_NameText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.NativeFieldInfoPtr_NameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ButtonText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.NativeFieldInfoPtr_ButtonText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.NativeFieldInfoPtr_ButtonText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TooltipJewelAbility JewelAbility
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.NativeFieldInfoPtr_JewelAbility));
        return pointer == System.IntPtr.Zero ? (TooltipJewelAbility) null : new TooltipJewelAbility(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.NativeFieldInfoPtr_JewelAbility), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SpellModTopParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.NativeFieldInfoPtr_SpellModTopParent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.NativeFieldInfoPtr_SpellModTopParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellbookMenu_SpellModSelectionGroup SpellModEntryParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.NativeFieldInfoPtr_SpellModEntryParent));
        return pointer == System.IntPtr.Zero ? (SpellbookMenu_SpellModSelectionGroup) null : new SpellbookMenu_SpellModSelectionGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.NativeFieldInfoPtr_SpellModEntryParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject ResultsMotions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.NativeFieldInfoPtr_ResultsMotions));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.NativeFieldInfoPtr_ResultsMotions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGUID _JewelAbilityPrefabGUID_k__BackingField
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.NativeFieldInfoPtr__JewelAbilityPrefabGUID_k__BackingField));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.NativeFieldInfoPtr__JewelAbilityPrefabGUID_k__BackingField)) = value;
      }
    }

    public unsafe List<SpellbookMenu_SpellModEntry.Data> _SpellModCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.NativeFieldInfoPtr__SpellModCache));
        return pointer == System.IntPtr.Zero ? (List<SpellbookMenu_SpellModEntry.Data>) null : new List<SpellbookMenu_SpellModEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.NativeFieldInfoPtr__SpellModCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsBrowsingAbilities;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;

      static Data()
      {
        Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data>.NativeClassPtr);
        SpellbookMenu_JewelInfo.Data.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data>.NativeClassPtr, nameof (Icon));
        SpellbookMenu_JewelInfo.Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data>.NativeClassPtr, nameof (Name));
        SpellbookMenu_JewelInfo.Data.NativeFieldInfoPtr_IsBrowsingAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data>.NativeClassPtr, nameof (IsBrowsingAbilities));
        SpellbookMenu_JewelInfo.Data.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data>.NativeClassPtr, nameof (SpellMods));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data>.NativeClassPtr, data));
      }

      public unsafe Sprite Icon
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data.NativeFieldInfoPtr_Icon));
          return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe bool IsBrowsingAbilities
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data.NativeFieldInfoPtr_IsBrowsingAbilities));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data.NativeFieldInfoPtr_IsBrowsingAbilities)) = value;
        }
      }

      public unsafe List<string> SpellMods
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data.NativeFieldInfoPtr_SpellMods));
          return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data.NativeFieldInfoPtr_SpellMods), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public sealed class Data_Empty : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
      private static readonly System.IntPtr NativeFieldInfoPtr_OwnsJewel;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsBrowsingAbilities;

      static Data_Empty()
      {
        Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data_Empty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr, nameof (Data_Empty));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data_Empty>.NativeClassPtr);
        SpellbookMenu_JewelInfo.Data_Empty.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data_Empty>.NativeClassPtr, nameof (Icon));
        SpellbookMenu_JewelInfo.Data_Empty.NativeFieldInfoPtr_OwnsJewel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data_Empty>.NativeClassPtr, nameof (OwnsJewel));
        SpellbookMenu_JewelInfo.Data_Empty.NativeFieldInfoPtr_IsBrowsingAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data_Empty>.NativeClassPtr, nameof (IsBrowsingAbilities));
      }

      public Data_Empty(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data_Empty()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data_Empty>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data_Empty>.NativeClassPtr, data));
      }

      public unsafe Sprite Icon
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data_Empty.NativeFieldInfoPtr_Icon));
          return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data_Empty.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool OwnsJewel
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data_Empty.NativeFieldInfoPtr_OwnsJewel));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data_Empty.NativeFieldInfoPtr_OwnsJewel)) = value;
        }
      }

      public unsafe bool IsBrowsingAbilities
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data_Empty.NativeFieldInfoPtr_IsBrowsingAbilities));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data_Empty.NativeFieldInfoPtr_IsBrowsingAbilities)) = value;
        }
      }
    }

    public sealed class Data_Crafting : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpellModInfo;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilityPrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_ButtonTextKey;

      static Data_Crafting()
      {
        Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data_Crafting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellbookMenu_JewelInfo>.NativeClassPtr, nameof (Data_Crafting));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data_Crafting>.NativeClassPtr);
        SpellbookMenu_JewelInfo.Data_Crafting.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data_Crafting>.NativeClassPtr, nameof (Icon));
        SpellbookMenu_JewelInfo.Data_Crafting.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data_Crafting>.NativeClassPtr, nameof (Name));
        SpellbookMenu_JewelInfo.Data_Crafting.NativeFieldInfoPtr_SpellModInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data_Crafting>.NativeClassPtr, nameof (SpellModInfo));
        SpellbookMenu_JewelInfo.Data_Crafting.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data_Crafting>.NativeClassPtr, nameof (SpellMods));
        SpellbookMenu_JewelInfo.Data_Crafting.NativeFieldInfoPtr_AbilityPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data_Crafting>.NativeClassPtr, nameof (AbilityPrefabGUID));
        SpellbookMenu_JewelInfo.Data_Crafting.NativeFieldInfoPtr_ButtonTextKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data_Crafting>.NativeClassPtr, nameof (ButtonTextKey));
      }

      public Data_Crafting(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data_Crafting()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data_Crafting>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellbookMenu_JewelInfo.Data_Crafting>.NativeClassPtr, data));
      }

      public unsafe Sprite Icon
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data_Crafting.NativeFieldInfoPtr_Icon));
          return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data_Crafting.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data_Crafting.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data_Crafting.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public Il2CppSystem.Nullable<SpellModInfo> SpellModInfo
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data_Crafting.NativeFieldInfoPtr_SpellModInfo);
          return new Il2CppSystem.Nullable<SpellModInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<SpellModInfo>>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data_Crafting.NativeFieldInfoPtr_SpellModInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<SpellModInfo>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe List<string> SpellMods
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data_Crafting.NativeFieldInfoPtr_SpellMods));
          return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data_Crafting.NativeFieldInfoPtr_SpellMods), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabGUID AbilityPrefabGUID
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data_Crafting.NativeFieldInfoPtr_AbilityPrefabGUID));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data_Crafting.NativeFieldInfoPtr_AbilityPrefabGUID)) = value;
        }
      }

      public unsafe LocalizationKey ButtonTextKey
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data_Crafting.NativeFieldInfoPtr_ButtonTextKey));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelInfo.Data_Crafting.NativeFieldInfoPtr_ButtonTextKey)) = value;
        }
      }
    }
  }
}
