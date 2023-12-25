// Decompiled with JetBrains decompiler
// Type: ForgeSubMenu_RepairButton
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.UI;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ForgeSubMenu_RepairButton : GridSelectionEntry
{
  private static readonly System.IntPtr NativeFieldInfoPtr_ItemNameText;
  private static readonly System.IntPtr NativeFieldInfoPtr_StationStatusText;
  private static readonly System.IntPtr NativeFieldInfoPtr_TimeRemainingText;
  private static readonly System.IntPtr NativeFieldInfoPtr_TimeKeys;
  private static readonly System.IntPtr NativeFieldInfoPtr_ItemIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_Button;
  private static readonly System.IntPtr NativeFieldInfoPtr_ProgressBackground;
  private static readonly System.IntPtr NativeFieldInfoPtr_ProgressImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StationStatus_NoBloodSource;
  private static readonly System.IntPtr NativeFieldInfoPtr_LKey_StationStatus_Damaged;
  private static readonly System.IntPtr NativeFieldInfoPtr__LocalizedTime;
  private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Public_Void_byref_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1205391, RefRangeEnd = 1205392, XrefRangeStart = 1205375, XrefRangeEnd = 1205391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Refresh([In] ref ForgeSubMenu_RepairButton.Data data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ForgeSubMenu_RepairButton.NativeMethodInfoPtr_Refresh_Public_Void_byref_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ForgeSubMenu_RepairButton()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForgeSubMenu_RepairButton>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ForgeSubMenu_RepairButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ForgeSubMenu_RepairButton()
  {
    Il2CppClassPointerStore<ForgeSubMenu_RepairButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (ForgeSubMenu_RepairButton));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForgeSubMenu_RepairButton>.NativeClassPtr);
    ForgeSubMenu_RepairButton.NativeFieldInfoPtr_ItemNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_RepairButton>.NativeClassPtr, nameof (ItemNameText));
    ForgeSubMenu_RepairButton.NativeFieldInfoPtr_StationStatusText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_RepairButton>.NativeClassPtr, nameof (StationStatusText));
    ForgeSubMenu_RepairButton.NativeFieldInfoPtr_TimeRemainingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_RepairButton>.NativeClassPtr, nameof (TimeRemainingText));
    ForgeSubMenu_RepairButton.NativeFieldInfoPtr_TimeKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_RepairButton>.NativeClassPtr, nameof (TimeKeys));
    ForgeSubMenu_RepairButton.NativeFieldInfoPtr_ItemIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_RepairButton>.NativeClassPtr, nameof (ItemIcon));
    ForgeSubMenu_RepairButton.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_RepairButton>.NativeClassPtr, nameof (Button));
    ForgeSubMenu_RepairButton.NativeFieldInfoPtr_ProgressBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_RepairButton>.NativeClassPtr, nameof (ProgressBackground));
    ForgeSubMenu_RepairButton.NativeFieldInfoPtr_ProgressImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_RepairButton>.NativeClassPtr, nameof (ProgressImage));
    ForgeSubMenu_RepairButton.NativeFieldInfoPtr_LKey_StationStatus_NoBloodSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_RepairButton>.NativeClassPtr, nameof (LKey_StationStatus_NoBloodSource));
    ForgeSubMenu_RepairButton.NativeFieldInfoPtr_LKey_StationStatus_Damaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_RepairButton>.NativeClassPtr, nameof (LKey_StationStatus_Damaged));
    ForgeSubMenu_RepairButton.NativeFieldInfoPtr__LocalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_RepairButton>.NativeClassPtr, nameof (_LocalizedTime));
    ForgeSubMenu_RepairButton.NativeMethodInfoPtr_Refresh_Public_Void_byref_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeSubMenu_RepairButton>.NativeClassPtr, 100663310);
    ForgeSubMenu_RepairButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeSubMenu_RepairButton>.NativeClassPtr, 100663311);
  }

  public ForgeSubMenu_RepairButton(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizedText ItemNameText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr_ItemNameText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr_ItemNameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText StationStatusText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr_StationStatusText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr_StationStatusText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText TimeRemainingText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr_TimeRemainingText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr_TimeRemainingText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizationTimeKeys TimeKeys
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr_TimeKeys));
      return pointer == System.IntPtr.Zero ? (LocalizationTimeKeys) null : new LocalizationTimeKeys(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr_TimeKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image ItemIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr_ItemIcon));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr_ItemIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button Button
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr_Button));
      return pointer == System.IntPtr.Zero ? (Button) null : new Button(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image ProgressBackground
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr_ProgressBackground));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr_ProgressBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image ProgressImage
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr_ProgressImage));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr_ProgressImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizationKey LKey_StationStatus_NoBloodSource
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr_LKey_StationStatus_NoBloodSource));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr_LKey_StationStatus_NoBloodSource)) = value;
    }
  }

  public unsafe LocalizationKey LKey_StationStatus_Damaged
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr_LKey_StationStatus_Damaged));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr_LKey_StationStatus_Damaged)) = value;
    }
  }

  public LocalizedTimeBuilder _LocalizedTime
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr__LocalizedTime);
      return new LocalizedTimeBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.NativeFieldInfoPtr__LocalizedTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public enum StationStatusEnum
  {
    Functional,
    NoBloodSource,
    Damaged,
  }

  public sealed class Data : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_Progress;
    private static readonly System.IntPtr NativeFieldInfoPtr_RepairTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_StationStatus;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemColor;

    static Data()
    {
      Il2CppClassPointerStore<ForgeSubMenu_RepairButton.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForgeSubMenu_RepairButton>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForgeSubMenu_RepairButton.Data>.NativeClassPtr);
      ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_RepairButton.Data>.NativeClassPtr, nameof (Icon));
      ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_RepairButton.Data>.NativeClassPtr, nameof (Progress));
      ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_RepairTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_RepairButton.Data>.NativeClassPtr, nameof (RepairTime));
      ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_TimeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_RepairButton.Data>.NativeClassPtr, nameof (TimeLeft));
      ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_StationStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_RepairButton.Data>.NativeClassPtr, nameof (StationStatus));
      ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_RepairButton.Data>.NativeClassPtr, nameof (ItemName));
      ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_ItemColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_RepairButton.Data>.NativeClassPtr, nameof (ItemColor));
    }

    public Data(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Data()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ForgeSubMenu_RepairButton.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForgeSubMenu_RepairButton.Data>.NativeClassPtr, data));
    }

    public unsafe Sprite Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float Progress
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_Progress));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_Progress)) = value;
      }
    }

    public unsafe float RepairTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_RepairTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_RepairTime)) = value;
      }
    }

    public unsafe float TimeLeft
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_TimeLeft));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_TimeLeft)) = value;
      }
    }

    public unsafe ForgeSubMenu_RepairButton.StationStatusEnum StationStatus
    {
      get
      {
        return *(ForgeSubMenu_RepairButton.StationStatusEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_StationStatus));
      }
      [param: In] set
      {
        *(ForgeSubMenu_RepairButton.StationStatusEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_StationStatus)) = value;
      }
    }

    public unsafe string ItemName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_ItemName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_ItemName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Color ItemColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_ItemColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_RepairButton.Data.NativeFieldInfoPtr_ItemColor)) = value;
      }
    }
  }
}
