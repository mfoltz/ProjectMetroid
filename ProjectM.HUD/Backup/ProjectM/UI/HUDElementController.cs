// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.HUDElementController
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public static class HUDElementController : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__HiddenElementTypes;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HiddenElementTypes_Public_Static_get_HUDElementType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HideElement_Public_Static_Void_HUDElementType_0;

    public static unsafe HUDElementType HiddenElementTypes
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266498, XrefRangeEnd = 1266500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HUDElementController.NativeMethodInfoPtr_get_HiddenElementTypes_Public_Static_get_HUDElementType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(HUDElementType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1266502, RefRangeEnd = 1266503, XrefRangeStart = 1266500, XrefRangeEnd = 1266502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Clear()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDElementController.NativeMethodInfoPtr_Clear_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(19)]
    [CachedScanResults(RefRangeStart = 1266505, RefRangeEnd = 1266524, XrefRangeStart = 1266503, XrefRangeEnd = 1266505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void HideElement(HUDElementType elementType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &elementType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDElementController.NativeMethodInfoPtr_HideElement_Public_Static_Void_HUDElementType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HUDElementController()
    {
      Il2CppClassPointerStore<HUDElementController>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (HUDElementController));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUDElementController>.NativeClassPtr);
      HUDElementController.NativeFieldInfoPtr__HiddenElementTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDElementController>.NativeClassPtr, nameof (_HiddenElementTypes));
      HUDElementController.NativeMethodInfoPtr_get_HiddenElementTypes_Public_Static_get_HUDElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDElementController>.NativeClassPtr, 100667620);
      HUDElementController.NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDElementController>.NativeClassPtr, 100667621);
      HUDElementController.NativeMethodInfoPtr_HideElement_Public_Static_Void_HUDElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDElementController>.NativeClassPtr, 100667622);
    }

    public HUDElementController(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe HUDElementType _HiddenElementTypes
    {
      get
      {
        HUDElementType hiddenElementTypes;
        IL2CPP.il2cpp_field_static_get_value(HUDElementController.NativeFieldInfoPtr__HiddenElementTypes, (void*) &hiddenElementTypes);
        return hiddenElementTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HUDElementController.NativeFieldInfoPtr__HiddenElementTypes, (void*) &value);
      }
    }
  }
}
