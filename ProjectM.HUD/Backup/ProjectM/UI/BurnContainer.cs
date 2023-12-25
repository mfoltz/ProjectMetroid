// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BurnContainer
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
  public class BurnContainer : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_BurnProgress;
    private static readonly IntPtr NativeFieldInfoPtr_ToggleButton_Active;
    private static readonly IntPtr NativeFieldInfoPtr_ToggleButton_Inactive;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BurnContainer()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurnContainer>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BurnContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BurnContainer()
    {
      Il2CppClassPointerStore<BurnContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BurnContainer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurnContainer>.NativeClassPtr);
      BurnContainer.NativeFieldInfoPtr_BurnProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurnContainer>.NativeClassPtr, nameof (BurnProgress));
      BurnContainer.NativeFieldInfoPtr_ToggleButton_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurnContainer>.NativeClassPtr, nameof (ToggleButton_Active));
      BurnContainer.NativeFieldInfoPtr_ToggleButton_Inactive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurnContainer>.NativeClassPtr, nameof (ToggleButton_Inactive));
      BurnContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurnContainer>.NativeClassPtr, 100665197);
    }

    public BurnContainer(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CraftingProgress BurnProgress
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BurnContainer.NativeFieldInfoPtr_BurnProgress));
        return pointer == IntPtr.Zero ? (CraftingProgress) null : new CraftingProgress(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BurnContainer.NativeFieldInfoPtr_BurnProgress), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Button ToggleButton_Active
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BurnContainer.NativeFieldInfoPtr_ToggleButton_Active));
        return pointer == IntPtr.Zero ? (Button) null : new Button(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BurnContainer.NativeFieldInfoPtr_ToggleButton_Active), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Button ToggleButton_Inactive
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BurnContainer.NativeFieldInfoPtr_ToggleButton_Inactive));
        return pointer == IntPtr.Zero ? (Button) null : new Button(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BurnContainer.NativeFieldInfoPtr_ToggleButton_Inactive), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
