// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BuildMenu_StructureEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class BuildMenu_StructureEntry : GridSelectionEntry
  {
    private static readonly IntPtr NativeFieldInfoPtr_NameText;
    private static readonly IntPtr NativeFieldInfoPtr_Icon;
    private static readonly IntPtr NativeFieldInfoPtr_Button;
    private static readonly IntPtr NativeFieldInfoPtr_Highlighted;
    private static readonly IntPtr NativeFieldInfoPtr_Amount;
    private static readonly IntPtr NativeFieldInfoPtr_DisabledAlpha;
    private static readonly IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly IntPtr NativeFieldInfoPtr_TooltipPrefabGuid;
    private static readonly IntPtr NativeFieldInfoPtr_Stacks;
    private static readonly IntPtr NativeFieldInfoPtr_Variations;
    private static readonly IntPtr NativeFieldInfoPtr__CanvasGroup;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_RefreshData_Internal_Void_byref_BuildMenu_SubStructureEntry_Data_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227710, XrefRangeEnd = 1227714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureEntry.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1227731, RefRangeEnd = 1227732, XrefRangeStart = 1227714, XrefRangeEnd = 1227731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshData(
      [In] ref BuildMenu_SubStructureEntry_Data data,
      PrefabGUID selectedStructure)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &selectedStructure;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureEntry.NativeMethodInfoPtr_RefreshData_Internal_Void_byref_BuildMenu_SubStructureEntry_Data_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BuildMenu_StructureEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenu_StructureEntry>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BuildMenu_StructureEntry()
    {
      Il2CppClassPointerStore<BuildMenu_StructureEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BuildMenu_StructureEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenu_StructureEntry>.NativeClassPtr);
      BuildMenu_StructureEntry.NativeFieldInfoPtr_NameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureEntry>.NativeClassPtr, nameof (NameText));
      BuildMenu_StructureEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureEntry>.NativeClassPtr, nameof (Icon));
      BuildMenu_StructureEntry.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureEntry>.NativeClassPtr, nameof (Button));
      BuildMenu_StructureEntry.NativeFieldInfoPtr_Highlighted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureEntry>.NativeClassPtr, nameof (Highlighted));
      BuildMenu_StructureEntry.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureEntry>.NativeClassPtr, nameof (Amount));
      BuildMenu_StructureEntry.NativeFieldInfoPtr_DisabledAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureEntry>.NativeClassPtr, nameof (DisabledAlpha));
      BuildMenu_StructureEntry.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureEntry>.NativeClassPtr, nameof (PrefabGuid));
      BuildMenu_StructureEntry.NativeFieldInfoPtr_TooltipPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureEntry>.NativeClassPtr, nameof (TooltipPrefabGuid));
      BuildMenu_StructureEntry.NativeFieldInfoPtr_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureEntry>.NativeClassPtr, nameof (Stacks));
      BuildMenu_StructureEntry.NativeFieldInfoPtr_Variations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureEntry>.NativeClassPtr, nameof (Variations));
      BuildMenu_StructureEntry.NativeFieldInfoPtr__CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureEntry>.NativeClassPtr, nameof (_CanvasGroup));
      BuildMenu_StructureEntry.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureEntry>.NativeClassPtr, 100665083);
      BuildMenu_StructureEntry.NativeMethodInfoPtr_RefreshData_Internal_Void_byref_BuildMenu_SubStructureEntry_Data_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureEntry>.NativeClassPtr, 100665084);
      BuildMenu_StructureEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureEntry>.NativeClassPtr, 100665085);
    }

    public BuildMenu_StructureEntry(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText NameText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr_NameText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr_NameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ImageFadeIn Icon
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr_Icon));
        return pointer == IntPtr.Zero ? (ImageFadeIn) null : new ImageFadeIn(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton Button
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr_Button));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Highlighted
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr_Highlighted));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr_Highlighted), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Amount
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr_Amount));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr_Amount), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float DisabledAlpha
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr_DisabledAlpha));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr_DisabledAlpha)) = value;
      }
    }

    public unsafe PrefabGUID PrefabGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr_PrefabGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr_PrefabGuid)) = value;
      }
    }

    public unsafe PrefabGUID TooltipPrefabGuid
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr_TooltipPrefabGuid));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr_TooltipPrefabGuid)) = value;
      }
    }

    public unsafe int Stacks
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr_Stacks));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr_Stacks)) = value;
      }
    }

    public unsafe IColorCollection Variations
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr_Variations));
        return pointer == IntPtr.Zero ? (IColorCollection) null : new IColorCollection(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr_Variations), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CanvasGroup _CanvasGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr__CanvasGroup));
        return pointer == IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureEntry.NativeFieldInfoPtr__CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
