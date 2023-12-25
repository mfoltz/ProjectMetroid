// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CastleHeartUI.CastleHeartUpgradeButton
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI.CastleHeartUI
{
  public class CastleHeartUpgradeButton : GridSelectionEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeRemainingText;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProgressBackground;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProgressImage;
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalizedTime;
    private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Public_Void_byref_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290383, XrefRangeEnd = 1290393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Refresh([In] ref CastleHeartUpgradeButton.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleHeartUpgradeButton.NativeMethodInfoPtr_Refresh_Public_Void_byref_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleHeartUpgradeButton()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleHeartUpgradeButton>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleHeartUpgradeButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleHeartUpgradeButton()
    {
      Il2CppClassPointerStore<CastleHeartUpgradeButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI.CastleHeartUI", nameof (CastleHeartUpgradeButton));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleHeartUpgradeButton>.NativeClassPtr);
      CastleHeartUpgradeButton.NativeFieldInfoPtr_TimeRemainingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpgradeButton>.NativeClassPtr, nameof (TimeRemainingText));
      CastleHeartUpgradeButton.NativeFieldInfoPtr_TimeKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpgradeButton>.NativeClassPtr, nameof (TimeKeys));
      CastleHeartUpgradeButton.NativeFieldInfoPtr_ItemIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpgradeButton>.NativeClassPtr, nameof (ItemIcon));
      CastleHeartUpgradeButton.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpgradeButton>.NativeClassPtr, nameof (Button));
      CastleHeartUpgradeButton.NativeFieldInfoPtr_ProgressBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpgradeButton>.NativeClassPtr, nameof (ProgressBackground));
      CastleHeartUpgradeButton.NativeFieldInfoPtr_ProgressImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpgradeButton>.NativeClassPtr, nameof (ProgressImage));
      CastleHeartUpgradeButton.NativeFieldInfoPtr__LocalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpgradeButton>.NativeClassPtr, nameof (_LocalizedTime));
      CastleHeartUpgradeButton.NativeMethodInfoPtr_Refresh_Public_Void_byref_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartUpgradeButton>.NativeClassPtr, 100669846);
      CastleHeartUpgradeButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartUpgradeButton>.NativeClassPtr, 100669847);
    }

    public CastleHeartUpgradeButton(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText TimeRemainingText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.NativeFieldInfoPtr_TimeRemainingText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.NativeFieldInfoPtr_TimeRemainingText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationTimeKeys TimeKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.NativeFieldInfoPtr_TimeKeys));
        return pointer == System.IntPtr.Zero ? (LocalizationTimeKeys) null : new LocalizationTimeKeys(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.NativeFieldInfoPtr_TimeKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ItemIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.NativeFieldInfoPtr_ItemIcon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.NativeFieldInfoPtr_ItemIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton Button
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.NativeFieldInfoPtr_Button));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ProgressBackground
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.NativeFieldInfoPtr_ProgressBackground));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.NativeFieldInfoPtr_ProgressBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ProgressImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.NativeFieldInfoPtr_ProgressImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.NativeFieldInfoPtr_ProgressImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public LocalizedTimeBuilder _LocalizedTime
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.NativeFieldInfoPtr__LocalizedTime);
        return new LocalizedTimeBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.NativeFieldInfoPtr__LocalizedTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
      private static readonly System.IntPtr NativeFieldInfoPtr_Progress;
      private static readonly System.IntPtr NativeFieldInfoPtr_UpgradeTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_TimeLeft;
      private static readonly System.IntPtr NativeFieldInfoPtr_CanAfford;

      static Data()
      {
        Il2CppClassPointerStore<CastleHeartUpgradeButton.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleHeartUpgradeButton>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleHeartUpgradeButton.Data>.NativeClassPtr);
        CastleHeartUpgradeButton.Data.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpgradeButton.Data>.NativeClassPtr, nameof (Icon));
        CastleHeartUpgradeButton.Data.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpgradeButton.Data>.NativeClassPtr, nameof (Progress));
        CastleHeartUpgradeButton.Data.NativeFieldInfoPtr_UpgradeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpgradeButton.Data>.NativeClassPtr, nameof (UpgradeTime));
        CastleHeartUpgradeButton.Data.NativeFieldInfoPtr_TimeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpgradeButton.Data>.NativeClassPtr, nameof (TimeLeft));
        CastleHeartUpgradeButton.Data.NativeFieldInfoPtr_CanAfford = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartUpgradeButton.Data>.NativeClassPtr, nameof (CanAfford));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CastleHeartUpgradeButton.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleHeartUpgradeButton.Data>.NativeClassPtr, data));
      }

      public unsafe Sprite Icon
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.Data.NativeFieldInfoPtr_Icon));
          return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.Data.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float Progress
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.Data.NativeFieldInfoPtr_Progress));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.Data.NativeFieldInfoPtr_Progress)) = value;
        }
      }

      public unsafe float UpgradeTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.Data.NativeFieldInfoPtr_UpgradeTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.Data.NativeFieldInfoPtr_UpgradeTime)) = value;
        }
      }

      public unsafe float TimeLeft
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.Data.NativeFieldInfoPtr_TimeLeft));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.Data.NativeFieldInfoPtr_TimeLeft)) = value;
        }
      }

      public unsafe bool CanAfford
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.Data.NativeFieldInfoPtr_CanAfford));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartUpgradeButton.Data.NativeFieldInfoPtr_CanAfford)) = value;
        }
      }
    }
  }
}
