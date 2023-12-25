// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.FullscreenMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class FullscreenMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ViewParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_OuterTabGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_InnerTabPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_InnerTabGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_HudElementsToHide;
    private static readonly System.IntPtr NativeFieldInfoPtr_Views;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FullscreenMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FullscreenMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FullscreenMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FullscreenMenu()
    {
      Il2CppClassPointerStore<FullscreenMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (FullscreenMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullscreenMenu>.NativeClassPtr);
      FullscreenMenu.NativeFieldInfoPtr_ViewParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu>.NativeClassPtr, nameof (ViewParent));
      FullscreenMenu.NativeFieldInfoPtr_OuterTabGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu>.NativeClassPtr, nameof (OuterTabGroup));
      FullscreenMenu.NativeFieldInfoPtr_InnerTabPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu>.NativeClassPtr, nameof (InnerTabPrefab));
      FullscreenMenu.NativeFieldInfoPtr_InnerTabGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu>.NativeClassPtr, nameof (InnerTabGroup));
      FullscreenMenu.NativeFieldInfoPtr_HudElementsToHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu>.NativeClassPtr, nameof (HudElementsToHide));
      FullscreenMenu.NativeFieldInfoPtr_Views = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu>.NativeClassPtr, nameof (Views));
      FullscreenMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenMenu>.NativeClassPtr, 100667289);
    }

    public FullscreenMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RectTransform ViewParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu.NativeFieldInfoPtr_ViewParent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu.NativeFieldInfoPtr_ViewParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HorizontalLayoutGroup OuterTabGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu.NativeFieldInfoPtr_OuterTabGroup));
        return pointer == System.IntPtr.Zero ? (HorizontalLayoutGroup) null : new HorizontalLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu.NativeFieldInfoPtr_OuterTabGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FullscreenMenu_InnerTabEntry InnerTabPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu.NativeFieldInfoPtr_InnerTabPrefab));
        return pointer == System.IntPtr.Zero ? (FullscreenMenu_InnerTabEntry) null : new FullscreenMenu_InnerTabEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu.NativeFieldInfoPtr_InnerTabPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GenericSelectionGroup<FullscreenMenu_InnerTabEntry, FullscreenMenu_InnerTabEntry.Data> InnerTabGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu.NativeFieldInfoPtr_InnerTabGroup));
        return pointer == System.IntPtr.Zero ? (GenericSelectionGroup<FullscreenMenu_InnerTabEntry, FullscreenMenu_InnerTabEntry.Data>) null : new GenericSelectionGroup<FullscreenMenu_InnerTabEntry, FullscreenMenu_InnerTabEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu.NativeFieldInfoPtr_InnerTabGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HUDElementType HudElementsToHide
    {
      get
      {
        return *(HUDElementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu.NativeFieldInfoPtr_HudElementsToHide));
      }
      [param: In] set
      {
        *(HUDElementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu.NativeFieldInfoPtr_HudElementsToHide)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<FullscreenMenu.StateToView> Views
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu.NativeFieldInfoPtr_Views));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<FullscreenMenu.StateToView>) null : new Il2CppReferenceArray<FullscreenMenu.StateToView>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu.NativeFieldInfoPtr_Views), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InitData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MenuState;
      [FieldOffset(0)]
      public FullscreenMenuState MenuState;

      static InitData()
      {
        Il2CppClassPointerStore<FullscreenMenu.InitData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FullscreenMenu>.NativeClassPtr, nameof (InitData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullscreenMenu.InitData>.NativeClassPtr);
        FullscreenMenu.InitData.NativeFieldInfoPtr_MenuState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu.InitData>.NativeClassPtr, nameof (MenuState));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FullscreenMenu.InitData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [Serializable]
    public class StateToView : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_State;
      private static readonly System.IntPtr NativeFieldInfoPtr_View;
      private static readonly System.IntPtr NativeFieldInfoPtr_Instance;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe StateToView()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FullscreenMenu.StateToView>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FullscreenMenu.StateToView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static StateToView()
      {
        Il2CppClassPointerStore<FullscreenMenu.StateToView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FullscreenMenu>.NativeClassPtr, nameof (StateToView));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullscreenMenu.StateToView>.NativeClassPtr);
        FullscreenMenu.StateToView.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu.StateToView>.NativeClassPtr, nameof (State));
        FullscreenMenu.StateToView.NativeFieldInfoPtr_View = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu.StateToView>.NativeClassPtr, nameof (View));
        FullscreenMenu.StateToView.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu.StateToView>.NativeClassPtr, nameof (Instance));
        FullscreenMenu.StateToView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenMenu.StateToView>.NativeClassPtr, 100667290);
      }

      public StateToView(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe FullscreenMenuState State
      {
        get
        {
          return *(FullscreenMenuState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu.StateToView.NativeFieldInfoPtr_State));
        }
        [param: In] set
        {
          *(FullscreenMenuState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu.StateToView.NativeFieldInfoPtr_State)) = value;
        }
      }

      public unsafe FullscreenMenuView View
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu.StateToView.NativeFieldInfoPtr_View));
          return pointer == System.IntPtr.Zero ? (FullscreenMenuView) null : new FullscreenMenuView(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu.StateToView.NativeFieldInfoPtr_View), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe FullscreenMenuView Instance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu.StateToView.NativeFieldInfoPtr_Instance));
          return pointer == System.IntPtr.Zero ? (FullscreenMenuView) null : new FullscreenMenuView(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu.StateToView.NativeFieldInfoPtr_Instance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
