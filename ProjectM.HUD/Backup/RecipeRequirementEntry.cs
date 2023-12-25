// Decompiled with JetBrains decompiler
// Type: RecipeRequirementEntry
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
public class RecipeRequirementEntry : GridSelectionEntry
{
  private static readonly IntPtr NativeFieldInfoPtr_AmountText;
  private static readonly IntPtr NativeFieldInfoPtr_ItemNameText;
  private static readonly IntPtr NativeFieldInfoPtr_ItemIcon;
  private static readonly IntPtr NativeFieldInfoPtr_RequirementMetColor;
  private static readonly IntPtr NativeFieldInfoPtr_RequirementNotMetColor;
  private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_CostData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205544, XrefRangeEnd = 1205557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetData(CostData requirementData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) requirementData));
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RecipeRequirementEntry.NativeMethodInfoPtr_SetData_Public_Void_CostData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205557, XrefRangeEnd = 1205562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RecipeRequirementEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeRequirementEntry>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RecipeRequirementEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static RecipeRequirementEntry()
  {
    Il2CppClassPointerStore<RecipeRequirementEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (RecipeRequirementEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeRequirementEntry>.NativeClassPtr);
    RecipeRequirementEntry.NativeFieldInfoPtr_AmountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeRequirementEntry>.NativeClassPtr, nameof (AmountText));
    RecipeRequirementEntry.NativeFieldInfoPtr_ItemNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeRequirementEntry>.NativeClassPtr, nameof (ItemNameText));
    RecipeRequirementEntry.NativeFieldInfoPtr_ItemIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeRequirementEntry>.NativeClassPtr, nameof (ItemIcon));
    RecipeRequirementEntry.NativeFieldInfoPtr_RequirementMetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeRequirementEntry>.NativeClassPtr, nameof (RequirementMetColor));
    RecipeRequirementEntry.NativeFieldInfoPtr_RequirementNotMetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeRequirementEntry>.NativeClassPtr, nameof (RequirementNotMetColor));
    RecipeRequirementEntry.NativeMethodInfoPtr_SetData_Public_Void_CostData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeRequirementEntry>.NativeClassPtr, 100663332);
    RecipeRequirementEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeRequirementEntry>.NativeClassPtr, 100663333);
  }

  public RecipeRequirementEntry(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizedText AmountText
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeRequirementEntry.NativeFieldInfoPtr_AmountText));
      return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecipeRequirementEntry.NativeFieldInfoPtr_AmountText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText ItemNameText
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeRequirementEntry.NativeFieldInfoPtr_ItemNameText));
      return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecipeRequirementEntry.NativeFieldInfoPtr_ItemNameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image ItemIcon
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeRequirementEntry.NativeFieldInfoPtr_ItemIcon));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecipeRequirementEntry.NativeFieldInfoPtr_ItemIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color32 RequirementMetColor
  {
    get
    {
      return *(Color32*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeRequirementEntry.NativeFieldInfoPtr_RequirementMetColor));
    }
    [param: In] set
    {
      *(Color32*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeRequirementEntry.NativeFieldInfoPtr_RequirementMetColor)) = value;
    }
  }

  public unsafe Color32 RequirementNotMetColor
  {
    get
    {
      return *(Color32*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeRequirementEntry.NativeFieldInfoPtr_RequirementNotMetColor));
    }
    [param: In] set
    {
      *(Color32*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeRequirementEntry.NativeFieldInfoPtr_RequirementNotMetColor)) = value;
    }
  }
}
