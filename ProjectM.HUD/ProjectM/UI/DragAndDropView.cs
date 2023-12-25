// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.DragAndDropView
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class DragAndDropView : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DragAndDropImage;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DragAndDropView()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragAndDropView>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DragAndDropView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DragAndDropView()
    {
      Il2CppClassPointerStore<DragAndDropView>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (DragAndDropView));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragAndDropView>.NativeClassPtr);
      DragAndDropView.NativeFieldInfoPtr_DragAndDropImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragAndDropView>.NativeClassPtr, nameof (DragAndDropImage));
      DragAndDropView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragAndDropView>.NativeClassPtr, 100667648);
    }

    public DragAndDropView(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image DragAndDropImage
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DragAndDropView.NativeFieldInfoPtr_DragAndDropImage));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DragAndDropView.NativeFieldInfoPtr_DragAndDropImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
