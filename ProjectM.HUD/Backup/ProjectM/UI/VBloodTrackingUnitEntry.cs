// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.VBloodTrackingUnitEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using StunShared.UI;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class VBloodTrackingUnitEntry : GridSelectionEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_Highlight;
    private static readonly System.IntPtr NativeFieldInfoPtr_Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameText;
    private static readonly System.IntPtr NativeFieldInfoPtr_DistanceText;
    private static readonly System.IntPtr NativeFieldInfoPtr_Title;
    private static readonly System.IntPtr NativeFieldInfoPtr_DistanceSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodIcon_Material_Standard;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodIcon_Material_Standard_Hovered;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodIcon_Material_Effect;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodIcon_Material_Effect_Hovered;
    private static readonly System.IntPtr NativeFieldInfoPtr_Highlight_Sprite_Unlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_Highlight_Sprite_Available;
    private static readonly System.IntPtr NativeFieldInfoPtr_PortraitColorUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_PortraitColorAvailable;
    private static readonly System.IntPtr NativeFieldInfoPtr_PortraitColorHidden;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnknownUnitSprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_TrackedImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewUnlockHighlightImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Distance;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_DirectionAndDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_DirectionKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr__UnitPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr__UnitState;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UnitPrefabGuid_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UnitState_Public_get_VBloodUnitTrackingState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Internal_Static_Void_VBloodTrackingUnitEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe PrefabGUID UnitPrefabGuid
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodTrackingUnitEntry.NativeMethodInfoPtr_get_UnitPrefabGuid_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe VBloodUnitTrackingState UnitState
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodTrackingUnitEntry.NativeMethodInfoPtr_get_UnitState_Public_get_VBloodUnitTrackingState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(VBloodUnitTrackingState*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1265079, RefRangeEnd = 1265081, XrefRangeStart = 1265020, XrefRangeEnd = 1265079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RefreshData(
      VBloodTrackingUnitEntry entry,
      VBloodTrackingUnitEntry.Data data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingUnitEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_VBloodTrackingUnitEntry_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VBloodTrackingUnitEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodTrackingUnitEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VBloodTrackingUnitEntry()
    {
      Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (VBloodTrackingUnitEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr);
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (Icon));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_Highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (Highlight));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (Button));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_NameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (NameText));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_DistanceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (DistanceText));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (Title));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_DistanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (DistanceSettings));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_VBloodIcon_Material_Standard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (VBloodIcon_Material_Standard));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_VBloodIcon_Material_Standard_Hovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (VBloodIcon_Material_Standard_Hovered));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_VBloodIcon_Material_Effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (VBloodIcon_Material_Effect));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_VBloodIcon_Material_Effect_Hovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (VBloodIcon_Material_Effect_Hovered));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_Highlight_Sprite_Unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (Highlight_Sprite_Unlocked));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_Highlight_Sprite_Available = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (Highlight_Sprite_Available));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_PortraitColorUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (PortraitColorUnlocked));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_PortraitColorAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (PortraitColorAvailable));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_PortraitColorHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (PortraitColorHidden));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_UnknownUnitSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (UnknownUnitSprite));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_TrackedImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (TrackedImage));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_NewUnlockHighlightImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (NewUnlockHighlightImage));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_LK_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (LK_Distance));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_LK_DirectionAndDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (LK_DirectionAndDistance));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr_DirectionKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (DirectionKeys));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr__UnitPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (_UnitPrefabGuid));
      VBloodTrackingUnitEntry.NativeFieldInfoPtr__UnitState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (_UnitState));
      VBloodTrackingUnitEntry.NativeMethodInfoPtr_get_UnitPrefabGuid_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, 100667538);
      VBloodTrackingUnitEntry.NativeMethodInfoPtr_get_UnitState_Public_get_VBloodUnitTrackingState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, 100667539);
      VBloodTrackingUnitEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_VBloodTrackingUnitEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, 100667540);
      VBloodTrackingUnitEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, 100667541);
    }

    public VBloodTrackingUnitEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ImageFadeIn Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (ImageFadeIn) null : new ImageFadeIn(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Highlight
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_Highlight));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_Highlight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton Button
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_Button));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText NameText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_NameText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_NameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText DistanceText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_DistanceText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_DistanceText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform Title
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_Title));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VBloodDistanceSettings DistanceSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_DistanceSettings));
        return pointer == System.IntPtr.Zero ? (VBloodDistanceSettings) null : new VBloodDistanceSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_DistanceSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Material VBloodIcon_Material_Standard
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_VBloodIcon_Material_Standard));
        return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_VBloodIcon_Material_Standard), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Material VBloodIcon_Material_Standard_Hovered
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_VBloodIcon_Material_Standard_Hovered));
        return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_VBloodIcon_Material_Standard_Hovered), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Material VBloodIcon_Material_Effect
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_VBloodIcon_Material_Effect));
        return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_VBloodIcon_Material_Effect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Material VBloodIcon_Material_Effect_Hovered
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_VBloodIcon_Material_Effect_Hovered));
        return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_VBloodIcon_Material_Effect_Hovered), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Highlight_Sprite_Unlocked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_Highlight_Sprite_Unlocked));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_Highlight_Sprite_Unlocked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Highlight_Sprite_Available
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_Highlight_Sprite_Available));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_Highlight_Sprite_Available), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color PortraitColorUnlocked
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_PortraitColorUnlocked));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_PortraitColorUnlocked)) = value;
      }
    }

    public unsafe Color PortraitColorAvailable
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_PortraitColorAvailable));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_PortraitColorAvailable)) = value;
      }
    }

    public unsafe Color PortraitColorHidden
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_PortraitColorHidden));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_PortraitColorHidden)) = value;
      }
    }

    public unsafe Sprite UnknownUnitSprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_UnknownUnitSprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_UnknownUnitSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image TrackedImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_TrackedImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_TrackedImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image NewUnlockHighlightImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_NewUnlockHighlightImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_NewUnlockHighlightImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LK_Distance
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_LK_Distance));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_LK_Distance)) = value;
      }
    }

    public unsafe LocalizationKey LK_DirectionAndDistance
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_LK_DirectionAndDistance));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_LK_DirectionAndDistance)) = value;
      }
    }

    public unsafe DirectionKeysAsset DirectionKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_DirectionKeys));
        return pointer == System.IntPtr.Zero ? (DirectionKeysAsset) null : new DirectionKeysAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr_DirectionKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGUID _UnitPrefabGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr__UnitPrefabGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr__UnitPrefabGuid)) = value;
      }
    }

    public unsafe VBloodUnitTrackingState _UnitState
    {
      get
      {
        return *(VBloodUnitTrackingState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr__UnitState));
      }
      [param: In] set
      {
        *(VBloodUnitTrackingState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.NativeFieldInfoPtr__UnitState)) = value;
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_UnitPrefabGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_UnitState;
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_GameDataSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_UIAssetSubSceneLoader;
      private static readonly System.IntPtr NativeFieldInfoPtr_Direction;
      private static readonly System.IntPtr NativeFieldInfoPtr_Distance;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsTracked;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsNewUnlockNotSeen;

      static Data()
      {
        Il2CppClassPointerStore<VBloodTrackingUnitEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VBloodTrackingUnitEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodTrackingUnitEntry.Data>.NativeClassPtr);
        VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_UnitPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry.Data>.NativeClassPtr, nameof (UnitPrefabGuid));
        VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_UnitState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry.Data>.NativeClassPtr, nameof (UnitState));
        VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry.Data>.NativeClassPtr, nameof (Name));
        VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry.Data>.NativeClassPtr, nameof (GameDataSystem));
        VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_UIAssetSubSceneLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry.Data>.NativeClassPtr, nameof (UIAssetSubSceneLoader));
        VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry.Data>.NativeClassPtr, nameof (Direction));
        VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry.Data>.NativeClassPtr, nameof (Distance));
        VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_IsTracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry.Data>.NativeClassPtr, nameof (IsTracked));
        VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_IsNewUnlockNotSeen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackingUnitEntry.Data>.NativeClassPtr, nameof (IsNewUnlockNotSeen));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VBloodTrackingUnitEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VBloodTrackingUnitEntry.Data>.NativeClassPtr, data));
      }

      public unsafe PrefabGUID UnitPrefabGuid
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_UnitPrefabGuid));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_UnitPrefabGuid)) = value;
        }
      }

      public unsafe VBloodUnitTrackingState UnitState
      {
        get
        {
          return *(VBloodUnitTrackingState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_UnitState));
        }
        [param: In] set
        {
          *(VBloodUnitTrackingState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_UnitState)) = value;
        }
      }

      public unsafe LocalizationKey Name
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_Name));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_Name)) = value;
        }
      }

      public unsafe GameDataSystem GameDataSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_GameDataSystem));
          return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe UIAssetSubSceneLoader_ClientWorld UIAssetSubSceneLoader
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_UIAssetSubSceneLoader));
          return pointer == System.IntPtr.Zero ? (UIAssetSubSceneLoader_ClientWorld) null : new UIAssetSubSceneLoader_ClientWorld(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_UIAssetSubSceneLoader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe CardinalDirection Direction
      {
        get
        {
          return *(CardinalDirection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_Direction));
        }
        [param: In] set
        {
          *(CardinalDirection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_Direction)) = value;
        }
      }

      public unsafe int Distance
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_Distance));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_Distance)) = value;
        }
      }

      public unsafe bool IsTracked
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_IsTracked));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_IsTracked)) = value;
        }
      }

      public unsafe bool IsNewUnlockNotSeen
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_IsNewUnlockNotSeen));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodTrackingUnitEntry.Data.NativeFieldInfoPtr_IsNewUnlockNotSeen)) = value;
        }
      }
    }
  }
}
