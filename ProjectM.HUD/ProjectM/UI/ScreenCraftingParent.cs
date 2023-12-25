// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ScreenCraftingParent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public class ScreenCraftingParent : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Crafting;
    private static readonly IntPtr NativeFieldInfoPtr_Keys;
    private static readonly IntPtr NativeFieldInfoPtr__LocalizedTime;
    private static readonly IntPtr NativeMethodInfoPtr_SetActive_Internal_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetData_Internal_Void_ManagedItemData_RecipeData_QueuedWorkstationCraftAction_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1275133, RefRangeEnd = 1275134, XrefRangeStart = 1275130, XrefRangeEnd = 1275133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetActive(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &state;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScreenCraftingParent.NativeMethodInfoPtr_SetActive_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1275151, RefRangeEnd = 1275152, XrefRangeStart = 1275134, XrefRangeEnd = 1275151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(
      ManagedItemData outputData,
      RecipeData recipeData,
      QueuedWorkstationCraftAction craftAction)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outputData);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &recipeData;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &craftAction;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScreenCraftingParent.NativeMethodInfoPtr_SetData_Internal_Void_ManagedItemData_RecipeData_QueuedWorkstationCraftAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ScreenCraftingParent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenCraftingParent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScreenCraftingParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ScreenCraftingParent()
    {
      Il2CppClassPointerStore<ScreenCraftingParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ScreenCraftingParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenCraftingParent>.NativeClassPtr);
      ScreenCraftingParent.NativeFieldInfoPtr_Crafting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenCraftingParent>.NativeClassPtr, nameof (Crafting));
      ScreenCraftingParent.NativeFieldInfoPtr_Keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenCraftingParent>.NativeClassPtr, nameof (Keys));
      ScreenCraftingParent.NativeFieldInfoPtr__LocalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenCraftingParent>.NativeClassPtr, nameof (_LocalizedTime));
      ScreenCraftingParent.NativeMethodInfoPtr_SetActive_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenCraftingParent>.NativeClassPtr, 100668423);
      ScreenCraftingParent.NativeMethodInfoPtr_SetData_Internal_Void_ManagedItemData_RecipeData_QueuedWorkstationCraftAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenCraftingParent>.NativeClassPtr, 100668424);
      ScreenCraftingParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenCraftingParent>.NativeClassPtr, 100668425);
    }

    public ScreenCraftingParent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CraftingProgress Crafting
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenCraftingParent.NativeFieldInfoPtr_Crafting));
        return pointer == IntPtr.Zero ? (CraftingProgress) null : new CraftingProgress(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScreenCraftingParent.NativeFieldInfoPtr_Crafting), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationTimeKeys Keys
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenCraftingParent.NativeFieldInfoPtr_Keys));
        return pointer == IntPtr.Zero ? (LocalizationTimeKeys) null : new LocalizationTimeKeys(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScreenCraftingParent.NativeFieldInfoPtr_Keys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public LocalizedTimeBuilder _LocalizedTime
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenCraftingParent.NativeFieldInfoPtr__LocalizedTime);
        return new LocalizedTimeBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenCraftingParent.NativeFieldInfoPtr__LocalizedTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }
  }
}
