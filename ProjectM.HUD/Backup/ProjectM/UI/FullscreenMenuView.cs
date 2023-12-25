// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.FullscreenMenuView
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class FullscreenMenuView : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TabDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnTabClicked;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1261959, RefRangeEnd = 1261962, XrefRangeStart = 1261951, XrefRangeEnd = 1261959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FullscreenMenuView()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FullscreenMenuView>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FullscreenMenuView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FullscreenMenuView()
    {
      Il2CppClassPointerStore<FullscreenMenuView>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (FullscreenMenuView));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullscreenMenuView>.NativeClassPtr);
      FullscreenMenuView.NativeFieldInfoPtr_TabDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenuView>.NativeClassPtr, nameof (TabDatas));
      FullscreenMenuView.NativeFieldInfoPtr_OnTabClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenuView>.NativeClassPtr, nameof (OnTabClicked));
      FullscreenMenuView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenMenuView>.NativeClassPtr, 100667332);
    }

    public FullscreenMenuView(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<FullscreenMenu_InnerTabEntry.Data> TabDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenuView.NativeFieldInfoPtr_TabDatas));
        return pointer == System.IntPtr.Zero ? (List<FullscreenMenu_InnerTabEntry.Data>) null : new List<FullscreenMenu_InnerTabEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenuView.NativeFieldInfoPtr_TabDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<int> OnTabClicked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenuView.NativeFieldInfoPtr_OnTabClicked));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : new Il2CppSystem.Action<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenuView.NativeFieldInfoPtr_OnTabClicked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
