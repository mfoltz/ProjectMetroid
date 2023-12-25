// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.FullscreenMenu_OuterTabEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class FullscreenMenu_OuterTabEntry : GridSelectionEntry
  {
    private static readonly IntPtr NativeFieldInfoPtr_State;
    private static readonly IntPtr NativeFieldInfoPtr_Button;
    private static readonly IntPtr NativeFieldInfoPtr_HighlightImage;
    private static readonly IntPtr NativeFieldInfoPtr_Requirement;
    private static readonly IntPtr NativeFieldInfoPtr_RequirementNotMetState;
    private static readonly IntPtr NativeFieldInfoPtr__RequirementsMet_k__BackingField;
    private static readonly IntPtr NativeMethodInfoPtr_get_RequirementsMet_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_RequirementsMet_Private_set_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_Boolean_Boolean_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe bool RequirementsMet
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(FullscreenMenu_OuterTabEntry.NativeMethodInfoPtr_get_RequirementsMet_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FullscreenMenu_OuterTabEntry.NativeMethodInfoPtr_set_RequirementsMet_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1262039, RefRangeEnd = 1262040, XrefRangeStart = 1262008, XrefRangeEnd = 1262039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Refresh(bool isSelected, bool requirementMet, bool highlight)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &isSelected;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &requirementMet;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &highlight;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FullscreenMenu_OuterTabEntry.NativeMethodInfoPtr_Refresh_Public_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FullscreenMenu_OuterTabEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FullscreenMenu_OuterTabEntry>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FullscreenMenu_OuterTabEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FullscreenMenu_OuterTabEntry()
    {
      Il2CppClassPointerStore<FullscreenMenu_OuterTabEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (FullscreenMenu_OuterTabEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullscreenMenu_OuterTabEntry>.NativeClassPtr);
      FullscreenMenu_OuterTabEntry.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu_OuterTabEntry>.NativeClassPtr, nameof (State));
      FullscreenMenu_OuterTabEntry.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu_OuterTabEntry>.NativeClassPtr, nameof (Button));
      FullscreenMenu_OuterTabEntry.NativeFieldInfoPtr_HighlightImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu_OuterTabEntry>.NativeClassPtr, nameof (HighlightImage));
      FullscreenMenu_OuterTabEntry.NativeFieldInfoPtr_Requirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu_OuterTabEntry>.NativeClassPtr, nameof (Requirement));
      FullscreenMenu_OuterTabEntry.NativeFieldInfoPtr_RequirementNotMetState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu_OuterTabEntry>.NativeClassPtr, nameof (RequirementNotMetState));
      FullscreenMenu_OuterTabEntry.NativeFieldInfoPtr__RequirementsMet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu_OuterTabEntry>.NativeClassPtr, "<RequirementsMet>k__BackingField");
      FullscreenMenu_OuterTabEntry.NativeMethodInfoPtr_get_RequirementsMet_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenMenu_OuterTabEntry>.NativeClassPtr, 100667346);
      FullscreenMenu_OuterTabEntry.NativeMethodInfoPtr_set_RequirementsMet_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenMenu_OuterTabEntry>.NativeClassPtr, 100667347);
      FullscreenMenu_OuterTabEntry.NativeMethodInfoPtr_Refresh_Public_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenMenu_OuterTabEntry>.NativeClassPtr, 100667348);
      FullscreenMenu_OuterTabEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenMenu_OuterTabEntry>.NativeClassPtr, 100667349);
    }

    public FullscreenMenu_OuterTabEntry(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe FullscreenMenuState State
    {
      get
      {
        return *(FullscreenMenuState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu_OuterTabEntry.NativeFieldInfoPtr_State));
      }
      [param: In] set
      {
        *(FullscreenMenuState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu_OuterTabEntry.NativeFieldInfoPtr_State)) = value;
      }
    }

    public unsafe SimpleStunButton Button
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu_OuterTabEntry.NativeFieldInfoPtr_Button));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu_OuterTabEntry.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image HighlightImage
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu_OuterTabEntry.NativeFieldInfoPtr_HighlightImage));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu_OuterTabEntry.NativeFieldInfoPtr_HighlightImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe OuterTabRequirement Requirement
    {
      get
      {
        return *(OuterTabRequirement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu_OuterTabEntry.NativeFieldInfoPtr_Requirement));
      }
      [param: In] set
      {
        *(OuterTabRequirement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu_OuterTabEntry.NativeFieldInfoPtr_Requirement)) = value;
      }
    }

    public unsafe OuterTabState RequirementNotMetState
    {
      get
      {
        return *(OuterTabState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu_OuterTabEntry.NativeFieldInfoPtr_RequirementNotMetState));
      }
      [param: In] set
      {
        *(OuterTabState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu_OuterTabEntry.NativeFieldInfoPtr_RequirementNotMetState)) = value;
      }
    }

    public unsafe bool _RequirementsMet_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu_OuterTabEntry.NativeFieldInfoPtr__RequirementsMet_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu_OuterTabEntry.NativeFieldInfoPtr__RequirementsMet_k__BackingField)) = value;
      }
    }
  }
}
