// Decompiled with JetBrains decompiler
// Type: ResearchEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM;
using ProjectM.UI;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ResearchEntry : GridSelectionEntry
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Selected;
  private static readonly System.IntPtr NativeFieldInfoPtr_StatusText;
  private static readonly System.IntPtr NativeFieldInfoPtr_ItemIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_ButtonComponent;
  private static readonly System.IntPtr NativeFieldInfoPtr_TreeNodes;
  private static readonly System.IntPtr NativeFieldInfoPtr_BiggerTreeIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_NewIndicatorNode;
  private static readonly System.IntPtr NativeFieldInfoPtr_EntryId;
  private static readonly System.IntPtr NativeFieldInfoPtr_Color_Normal;
  private static readonly System.IntPtr NativeFieldInfoPtr_Color_Selected;
  private static readonly System.IntPtr NativeFieldInfoPtr_Color_Unlocked;
  private static readonly System.IntPtr NativeFieldInfoPtr_Color_Restricted;
  private static readonly System.IntPtr NativeFieldInfoPtr_Color_OutOfStation;
  private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundSprite_Unlocked;
  private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundSprite_Teachable;
  private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundSprite_Insertable;
  private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundSprite_Normal;
  private static readonly System.IntPtr NativeFieldInfoPtr_Image_QuestionMark;
  private static readonly System.IntPtr NativeFieldInfoPtr_Highlighted;
  private static readonly System.IntPtr NativeFieldInfoPtr_UpdatedData;
  private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Researching;
  private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Queued;
  private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Available;
  private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Shareable;
  private static readonly System.IntPtr NativeFieldInfoPtr_TreeParent;
  private static readonly System.IntPtr NativeFieldInfoPtr_TreeLine;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Static_Void_ResearchEntry_Data_ControllerType_GridSelectionGroup_2_ResearchEntry_Data_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 1205731, RefRangeEnd = 1205739, XrefRangeStart = 1205680, XrefRangeEnd = 1205731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RefreshData(
    ResearchEntry entry,
    ResearchEntry.Data data,
    ControllerType controllerType,
    GridSelectionGroup<ResearchEntry, ResearchEntry.Data> parent,
    bool isBloodAltar)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isBloodAltar;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ResearchEntry.NativeMethodInfoPtr_RefreshData_Public_Static_Void_ResearchEntry_Data_ControllerType_GridSelectionGroup_2_ResearchEntry_Data_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ResearchEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ResearchEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ResearchEntry()
  {
    Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (ResearchEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr);
    ResearchEntry.NativeFieldInfoPtr_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (Selected));
    ResearchEntry.NativeFieldInfoPtr_StatusText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (StatusText));
    ResearchEntry.NativeFieldInfoPtr_ItemIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (ItemIcon));
    ResearchEntry.NativeFieldInfoPtr_ButtonComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (ButtonComponent));
    ResearchEntry.NativeFieldInfoPtr_TreeNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (TreeNodes));
    ResearchEntry.NativeFieldInfoPtr_BiggerTreeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (BiggerTreeIcon));
    ResearchEntry.NativeFieldInfoPtr_NewIndicatorNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (NewIndicatorNode));
    ResearchEntry.NativeFieldInfoPtr_EntryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (EntryId));
    ResearchEntry.NativeFieldInfoPtr_Color_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (Color_Normal));
    ResearchEntry.NativeFieldInfoPtr_Color_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (Color_Selected));
    ResearchEntry.NativeFieldInfoPtr_Color_Unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (Color_Unlocked));
    ResearchEntry.NativeFieldInfoPtr_Color_Restricted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (Color_Restricted));
    ResearchEntry.NativeFieldInfoPtr_Color_OutOfStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (Color_OutOfStation));
    ResearchEntry.NativeFieldInfoPtr_BackgroundSprite_Unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (BackgroundSprite_Unlocked));
    ResearchEntry.NativeFieldInfoPtr_BackgroundSprite_Teachable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (BackgroundSprite_Teachable));
    ResearchEntry.NativeFieldInfoPtr_BackgroundSprite_Insertable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (BackgroundSprite_Insertable));
    ResearchEntry.NativeFieldInfoPtr_BackgroundSprite_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (BackgroundSprite_Normal));
    ResearchEntry.NativeFieldInfoPtr_Image_QuestionMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (Image_QuestionMark));
    ResearchEntry.NativeFieldInfoPtr_Highlighted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (Highlighted));
    ResearchEntry.NativeFieldInfoPtr_UpdatedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (UpdatedData));
    ResearchEntry.NativeFieldInfoPtr_LKey_Researching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (LKey_Researching));
    ResearchEntry.NativeFieldInfoPtr_LKey_Queued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (LKey_Queued));
    ResearchEntry.NativeFieldInfoPtr_LKey_Available = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (LKey_Available));
    ResearchEntry.NativeFieldInfoPtr_LKey_Shareable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (LKey_Shareable));
    ResearchEntry.NativeFieldInfoPtr_TreeParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (TreeParent));
    ResearchEntry.NativeFieldInfoPtr_TreeLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (TreeLine));
    ResearchEntry.NativeMethodInfoPtr_RefreshData_Public_Static_Void_ResearchEntry_Data_ControllerType_GridSelectionGroup_2_ResearchEntry_Data_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, 100663343);
    ResearchEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, 100663344);
  }

  public ResearchEntry(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Image Selected
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_Selected));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_Selected), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText StatusText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_StatusText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_StatusText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image ItemIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_ItemIcon));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_ItemIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button ButtonComponent
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_ButtonComponent));
      return pointer == System.IntPtr.Zero ? (Button) null : new Button(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_ButtonComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform TreeNodes
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_TreeNodes));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_TreeNodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform BiggerTreeIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_BiggerTreeIcon));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_BiggerTreeIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform NewIndicatorNode
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_NewIndicatorNode));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_NewIndicatorNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PrefabGUID EntryId
  {
    get
    {
      return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_EntryId));
    }
    [param: In] set
    {
      *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_EntryId)) = value;
    }
  }

  public unsafe Color Color_Normal
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_Color_Normal));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_Color_Normal)) = value;
    }
  }

  public unsafe Color Color_Selected
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_Color_Selected));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_Color_Selected)) = value;
    }
  }

  public unsafe Color Color_Unlocked
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_Color_Unlocked));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_Color_Unlocked)) = value;
    }
  }

  public unsafe Color Color_Restricted
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_Color_Restricted));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_Color_Restricted)) = value;
    }
  }

  public unsafe Color Color_OutOfStation
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_Color_OutOfStation));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_Color_OutOfStation)) = value;
    }
  }

  public unsafe Sprite BackgroundSprite_Unlocked
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_BackgroundSprite_Unlocked));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_BackgroundSprite_Unlocked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite BackgroundSprite_Teachable
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_BackgroundSprite_Teachable));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_BackgroundSprite_Teachable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite BackgroundSprite_Insertable
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_BackgroundSprite_Insertable));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_BackgroundSprite_Insertable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite BackgroundSprite_Normal
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_BackgroundSprite_Normal));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_BackgroundSprite_Normal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image Image_QuestionMark
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_Image_QuestionMark));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_Image_QuestionMark), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image Highlighted
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_Highlighted));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_Highlighted), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public ResearchEntry.Data UpdatedData
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_UpdatedData);
      return new ResearchEntry.Data(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_UpdatedData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe LocalizationKey LKey_Researching
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_LKey_Researching));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_LKey_Researching)) = value;
    }
  }

  public unsafe LocalizationKey LKey_Queued
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_LKey_Queued));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_LKey_Queued)) = value;
    }
  }

  public unsafe LocalizationKey LKey_Available
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_LKey_Available));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_LKey_Available)) = value;
    }
  }

  public unsafe LocalizationKey LKey_Shareable
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_LKey_Shareable));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_LKey_Shareable)) = value;
    }
  }

  public unsafe RectTransform TreeParent
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_TreeParent));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_TreeParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image TreeLine
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_TreeLine));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.NativeFieldInfoPtr_TreeLine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum ResearchStatus
  {
    Teachable,
    Researching,
    Queued,
    Researchable,
    Unlocked,
    Insertable,
    Restricted,
  }

  public sealed class Data : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EntryId;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutSideStationResearch;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsSelected;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsHovered;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsTreeEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsNew;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Desc;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemSprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_PercentualProgress;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResearchDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Requirements;
    private static readonly System.IntPtr NativeFieldInfoPtr_Status;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sorting;
    private static readonly System.IntPtr NativeFieldInfoPtr_NeverShowQuestionmarkResearch;
    private static readonly System.IntPtr NativeFieldInfoPtr_TechCateogry;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueueSpot;
    private static readonly System.IntPtr NativeFieldInfoPtr_TechRequirements;

    static Data()
    {
      Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResearchEntry>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr);
      ResearchEntry.Data.NativeFieldInfoPtr_EntryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, nameof (EntryId));
      ResearchEntry.Data.NativeFieldInfoPtr_OutSideStationResearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, nameof (OutSideStationResearch));
      ResearchEntry.Data.NativeFieldInfoPtr_IsSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, nameof (IsSelected));
      ResearchEntry.Data.NativeFieldInfoPtr_IsHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, nameof (IsHovered));
      ResearchEntry.Data.NativeFieldInfoPtr_IsTreeEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, nameof (IsTreeEntry));
      ResearchEntry.Data.NativeFieldInfoPtr_IsNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, nameof (IsNew));
      ResearchEntry.Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, nameof (Name));
      ResearchEntry.Data.NativeFieldInfoPtr_Desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, nameof (Desc));
      ResearchEntry.Data.NativeFieldInfoPtr_ItemSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, nameof (ItemSprite));
      ResearchEntry.Data.NativeFieldInfoPtr_PercentualProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, nameof (PercentualProgress));
      ResearchEntry.Data.NativeFieldInfoPtr_ResearchDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, nameof (ResearchDuration));
      ResearchEntry.Data.NativeFieldInfoPtr_Requirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, nameof (Requirements));
      ResearchEntry.Data.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, nameof (Status));
      ResearchEntry.Data.NativeFieldInfoPtr_Sorting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, nameof (Sorting));
      ResearchEntry.Data.NativeFieldInfoPtr_NeverShowQuestionmarkResearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, nameof (NeverShowQuestionmarkResearch));
      ResearchEntry.Data.NativeFieldInfoPtr_TechCateogry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, nameof (TechCateogry));
      ResearchEntry.Data.NativeFieldInfoPtr_QueueSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, nameof (QueueSpot));
      ResearchEntry.Data.NativeFieldInfoPtr_TechRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, nameof (TechRequirements));
    }

    public Data(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Data()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ResearchEntry.Data>.NativeClassPtr, data));
    }

    public unsafe PrefabGUID EntryId
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_EntryId));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_EntryId)) = value;
      }
    }

    public unsafe bool OutSideStationResearch
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_OutSideStationResearch));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_OutSideStationResearch)) = value;
      }
    }

    public unsafe bool IsSelected
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_IsSelected));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_IsSelected)) = value;
      }
    }

    public unsafe bool IsHovered
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_IsHovered));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_IsHovered)) = value;
      }
    }

    public unsafe bool IsTreeEntry
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_IsTreeEntry));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_IsTreeEntry)) = value;
      }
    }

    public unsafe bool IsNew
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_IsNew));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_IsNew)) = value;
      }
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public LocalizedString Desc
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_Desc);
        return new LocalizedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_Desc), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Sprite ItemSprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_ItemSprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_ItemSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float PercentualProgress
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_PercentualProgress));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_PercentualProgress)) = value;
      }
    }

    public unsafe float ResearchDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_ResearchDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_ResearchDuration)) = value;
      }
    }

    public unsafe List<CostData> Requirements
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_Requirements));
        return pointer == System.IntPtr.Zero ? (List<CostData>) null : new List<CostData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_Requirements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ResearchEntry.ResearchStatus Status
    {
      get
      {
        return *(ResearchEntry.ResearchStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_Status));
      }
      [param: In] set
      {
        *(ResearchEntry.ResearchStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_Status)) = value;
      }
    }

    public unsafe int Sorting
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_Sorting));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_Sorting)) = value;
      }
    }

    public unsafe bool NeverShowQuestionmarkResearch
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_NeverShowQuestionmarkResearch));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_NeverShowQuestionmarkResearch)) = value;
      }
    }

    public unsafe TechCateogry TechCateogry
    {
      get
      {
        return *(TechCateogry*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_TechCateogry));
      }
      [param: In] set
      {
        *(TechCateogry*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_TechCateogry)) = value;
      }
    }

    public unsafe int QueueSpot
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_QueueSpot));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_QueueSpot)) = value;
      }
    }

    public unsafe Il2CppStructArray<PrefabGUID> TechRequirements
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_TechRequirements));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<PrefabGUID>) null : new Il2CppStructArray<PrefabGUID>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchEntry.Data.NativeFieldInfoPtr_TechRequirements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
