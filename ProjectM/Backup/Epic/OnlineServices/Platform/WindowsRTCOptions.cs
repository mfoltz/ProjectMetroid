// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.WindowsRTCOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform
{
  public sealed class WindowsRTCOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PlatformSpecificOptions_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlatformSpecificOptions_Public_get_Nullable_1_WindowsRTCOptionsPlatformSpecificOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlatformSpecificOptions_Public_set_Void_Nullable_1_WindowsRTCOptionsPlatformSpecificOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_WindowsRTCOptionsInternal_0;

    public unsafe Il2CppSystem.Nullable<WindowsRTCOptionsPlatformSpecificOptions> PlatformSpecificOptions
    {
      [CallerCount(46), CachedScanResults(RefRangeStart = 257985, RefRangeEnd = 258031, XrefRangeStart = 257985, XrefRangeEnd = 258031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptions.NativeMethodInfoPtr_get_PlatformSpecificOptions_Public_get_Nullable_1_WindowsRTCOptionsPlatformSpecificOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new Il2CppSystem.Nullable<WindowsRTCOptionsPlatformSpecificOptions>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptions.NativeMethodInfoPtr_set_PlatformSpecificOptions_Public_set_Void_Nullable_1_WindowsRTCOptionsPlatformSpecificOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 972478, RefRangeEnd = 972479, XrefRangeStart = 972471, XrefRangeEnd = 972478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref WindowsRTCOptionsInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptions.NativeMethodInfoPtr_Set_Internal_Void_byref_WindowsRTCOptionsInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WindowsRTCOptions()
    {
      Il2CppClassPointerStore<WindowsRTCOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Platform", nameof (WindowsRTCOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsRTCOptions>.NativeClassPtr);
      WindowsRTCOptions.NativeFieldInfoPtr__PlatformSpecificOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsRTCOptions>.NativeClassPtr, "<PlatformSpecificOptions>k__BackingField");
      WindowsRTCOptions.NativeMethodInfoPtr_get_PlatformSpecificOptions_Public_get_Nullable_1_WindowsRTCOptionsPlatformSpecificOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptions>.NativeClassPtr, 100674814);
      WindowsRTCOptions.NativeMethodInfoPtr_set_PlatformSpecificOptions_Public_set_Void_Nullable_1_WindowsRTCOptionsPlatformSpecificOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptions>.NativeClassPtr, 100674815);
      WindowsRTCOptions.NativeMethodInfoPtr_Set_Internal_Void_byref_WindowsRTCOptionsInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptions>.NativeClassPtr, 100674816);
    }

    public WindowsRTCOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public WindowsRTCOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WindowsRTCOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WindowsRTCOptions>.NativeClassPtr, data));
    }

    public Il2CppSystem.Nullable<WindowsRTCOptionsPlatformSpecificOptions> _PlatformSpecificOptions_k__BackingField
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsRTCOptions.NativeFieldInfoPtr__PlatformSpecificOptions_k__BackingField);
        return new Il2CppSystem.Nullable<WindowsRTCOptionsPlatformSpecificOptions>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<WindowsRTCOptionsPlatformSpecificOptions>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsRTCOptions.NativeFieldInfoPtr__PlatformSpecificOptions_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<WindowsRTCOptionsPlatformSpecificOptions>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
