// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MenuCollection
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class MenuCollection : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MenuButtons;
    private static readonly IntPtr NativeFieldInfoPtr_MenuButtonPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_ButtonsParent;
    private static readonly IntPtr NativeFieldInfoPtr__InstancedButtons;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_RequirementMet_Private_Boolean_MenuEntryRequirement_0;
    private static readonly IntPtr NativeMethodInfoPtr_SelectFirst_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279186, XrefRangeEnd = 1279208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MenuCollection.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1279234, RefRangeEnd = 1279235, XrefRangeStart = 1279208, XrefRangeEnd = 1279234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool RequirementMet(MenuEntryRequirement requirement)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &requirement;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(MenuCollection.NativeMethodInfoPtr_RequirementMet_Private_Boolean_MenuEntryRequirement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SelectFirst()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MenuCollection.NativeMethodInfoPtr_SelectFirst_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279235, XrefRangeEnd = 1279250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MenuCollection()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MenuCollection>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MenuCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MenuCollection()
    {
      Il2CppClassPointerStore<MenuCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MenuCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MenuCollection>.NativeClassPtr);
      MenuCollection.NativeFieldInfoPtr_MenuButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuCollection>.NativeClassPtr, nameof (MenuButtons));
      MenuCollection.NativeFieldInfoPtr_MenuButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuCollection>.NativeClassPtr, nameof (MenuButtonPrefab));
      MenuCollection.NativeFieldInfoPtr_ButtonsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuCollection>.NativeClassPtr, nameof (ButtonsParent));
      MenuCollection.NativeFieldInfoPtr__InstancedButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuCollection>.NativeClassPtr, nameof (_InstancedButtons));
      MenuCollection.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuCollection>.NativeClassPtr, 100668886);
      MenuCollection.NativeMethodInfoPtr_RequirementMet_Private_Boolean_MenuEntryRequirement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuCollection>.NativeClassPtr, 100668887);
      MenuCollection.NativeMethodInfoPtr_SelectFirst_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuCollection>.NativeClassPtr, 100668888);
      MenuCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuCollection>.NativeClassPtr, 100668889);
    }

    public MenuCollection(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<MenuButtonData> MenuButtons
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuCollection.NativeFieldInfoPtr_MenuButtons));
        return pointer == IntPtr.Zero ? (List<MenuButtonData>) null : new List<MenuButtonData>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MenuCollection.NativeFieldInfoPtr_MenuButtons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MenuButton MenuButtonPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuCollection.NativeFieldInfoPtr_MenuButtonPrefab));
        return pointer == IntPtr.Zero ? (MenuButton) null : new MenuButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MenuCollection.NativeFieldInfoPtr_MenuButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ButtonsParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuCollection.NativeFieldInfoPtr_ButtonsParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MenuCollection.NativeFieldInfoPtr_ButtonsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<MenuButton> _InstancedButtons
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuCollection.NativeFieldInfoPtr__InstancedButtons));
        return pointer == IntPtr.Zero ? (List<MenuButton>) null : new List<MenuButton>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MenuCollection.NativeFieldInfoPtr__InstancedButtons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
