// Decompiled with JetBrains decompiler
// Type: SpellBookMenu_BuffEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
public class SpellBookMenu_BuffEntry : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_Header;
  private static readonly IntPtr NativeFieldInfoPtr_Description;
  private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_ShowInSpellbookData_EntityManager_Entity_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1205930, RefRangeEnd = 1205931, XrefRangeStart = 1205925, XrefRangeEnd = 1205930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetData(
    ShowInSpellbookData buffData,
    EntityManager entityManager,
    Entity buffPrefab,
    Color buffsHeaderColor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffData);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &entityManager;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &buffPrefab;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &buffsHeaderColor;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpellBookMenu_BuffEntry.NativeMethodInfoPtr_SetData_Public_Void_ShowInSpellbookData_EntityManager_Entity_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpellBookMenu_BuffEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBookMenu_BuffEntry>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpellBookMenu_BuffEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SpellBookMenu_BuffEntry()
  {
    Il2CppClassPointerStore<SpellBookMenu_BuffEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (SpellBookMenu_BuffEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBookMenu_BuffEntry>.NativeClassPtr);
    SpellBookMenu_BuffEntry.NativeFieldInfoPtr_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBookMenu_BuffEntry>.NativeClassPtr, nameof (Header));
    SpellBookMenu_BuffEntry.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBookMenu_BuffEntry>.NativeClassPtr, nameof (Description));
    SpellBookMenu_BuffEntry.NativeMethodInfoPtr_SetData_Public_Void_ShowInSpellbookData_EntityManager_Entity_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBookMenu_BuffEntry>.NativeClassPtr, 100663362);
    SpellBookMenu_BuffEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBookMenu_BuffEntry>.NativeClassPtr, 100663363);
  }

  public SpellBookMenu_BuffEntry(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizedText Header
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellBookMenu_BuffEntry.NativeFieldInfoPtr_Header));
      return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellBookMenu_BuffEntry.NativeFieldInfoPtr_Header), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText Description
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellBookMenu_BuffEntry.NativeFieldInfoPtr_Description));
      return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellBookMenu_BuffEntry.NativeFieldInfoPtr_Description), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
