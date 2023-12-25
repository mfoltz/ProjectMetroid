// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SpellbookMenu_SpellModSelectionGroup
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
  public class SpellbookMenu_SpellModSelectionGroup : 
    SelectionGroupBase<SpellbookMenu_SpellModEntry, SpellbookMenu_SpellModEntry.Data>
  {
    private static readonly IntPtr NativeFieldInfoPtr_DividerPrefab;
    private static readonly IntPtr NativeFieldInfoPtr__Dividers;
    private static readonly IntPtr NativeMethodInfoPtr_OnEntryCreated_Protected_Virtual_Void_SpellbookMenu_SpellModEntry_0;
    private static readonly IntPtr NativeMethodInfoPtr_RefreshInternal_Protected_Virtual_Void_List_1_Data_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263356, XrefRangeEnd = 1263369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEntryCreated(SpellbookMenu_SpellModEntry entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpellbookMenu_SpellModSelectionGroup.NativeMethodInfoPtr_OnEntryCreated_Protected_Virtual_Void_SpellbookMenu_SpellModEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263369, XrefRangeEnd = 1263380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void RefreshInternal(List<SpellbookMenu_SpellModEntry.Data> data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpellbookMenu_SpellModSelectionGroup.NativeMethodInfoPtr_RefreshInternal_Protected_Virtual_Void_List_1_Data_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263380, XrefRangeEnd = 1263390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellbookMenu_SpellModSelectionGroup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellbookMenu_SpellModSelectionGroup>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenu_SpellModSelectionGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpellbookMenu_SpellModSelectionGroup()
    {
      Il2CppClassPointerStore<SpellbookMenu_SpellModSelectionGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (SpellbookMenu_SpellModSelectionGroup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellbookMenu_SpellModSelectionGroup>.NativeClassPtr);
      SpellbookMenu_SpellModSelectionGroup.NativeFieldInfoPtr_DividerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_SpellModSelectionGroup>.NativeClassPtr, nameof (DividerPrefab));
      SpellbookMenu_SpellModSelectionGroup.NativeFieldInfoPtr__Dividers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_SpellModSelectionGroup>.NativeClassPtr, nameof (_Dividers));
      SpellbookMenu_SpellModSelectionGroup.NativeMethodInfoPtr_OnEntryCreated_Protected_Virtual_Void_SpellbookMenu_SpellModEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenu_SpellModSelectionGroup>.NativeClassPtr, 100667452);
      SpellbookMenu_SpellModSelectionGroup.NativeMethodInfoPtr_RefreshInternal_Protected_Virtual_Void_List_1_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenu_SpellModSelectionGroup>.NativeClassPtr, 100667453);
      SpellbookMenu_SpellModSelectionGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenu_SpellModSelectionGroup>.NativeClassPtr, 100667454);
    }

    public SpellbookMenu_SpellModSelectionGroup(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameObject DividerPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_SpellModSelectionGroup.NativeFieldInfoPtr_DividerPrefab));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_SpellModSelectionGroup.NativeFieldInfoPtr_DividerPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<GameObject> _Dividers
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_SpellModSelectionGroup.NativeFieldInfoPtr__Dividers));
        return pointer == IntPtr.Zero ? (List<GameObject>) null : new List<GameObject>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_SpellModSelectionGroup.NativeFieldInfoPtr__Dividers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
