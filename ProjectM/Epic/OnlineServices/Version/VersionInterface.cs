// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Version.VersionInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Version
{
  public sealed class VersionInterface : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CompanyName;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyrightString;
    private static readonly System.IntPtr NativeFieldInfoPtr_MajorVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinorVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_PatchVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProductIdentifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProductName;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetVersion_Public_Static_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936420, XrefRangeEnd = 936425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Epic.OnlineServices.Utf8String GetVersion()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VersionInterface.NativeMethodInfoPtr_GetVersion_Public_Static_Utf8String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VersionInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VersionInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VersionInterface()
    {
      Il2CppClassPointerStore<VersionInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Version", nameof (VersionInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionInterface>.NativeClassPtr);
      VersionInterface.NativeFieldInfoPtr_CompanyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInterface>.NativeClassPtr, nameof (CompanyName));
      VersionInterface.NativeFieldInfoPtr_CopyrightString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInterface>.NativeClassPtr, nameof (CopyrightString));
      VersionInterface.NativeFieldInfoPtr_MajorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInterface>.NativeClassPtr, nameof (MajorVersion));
      VersionInterface.NativeFieldInfoPtr_MinorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInterface>.NativeClassPtr, nameof (MinorVersion));
      VersionInterface.NativeFieldInfoPtr_PatchVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInterface>.NativeClassPtr, nameof (PatchVersion));
      VersionInterface.NativeFieldInfoPtr_ProductIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInterface>.NativeClassPtr, nameof (ProductIdentifier));
      VersionInterface.NativeFieldInfoPtr_ProductName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInterface>.NativeClassPtr, nameof (ProductName));
      VersionInterface.NativeMethodInfoPtr_GetVersion_Public_Static_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInterface>.NativeClassPtr, 100664875);
      VersionInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInterface>.NativeClassPtr, 100664876);
    }

    public VersionInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Epic.OnlineServices.Utf8String CompanyName
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(VersionInterface.NativeFieldInfoPtr_CompanyName, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VersionInterface.NativeFieldInfoPtr_CompanyName, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Epic.OnlineServices.Utf8String CopyrightString
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(VersionInterface.NativeFieldInfoPtr_CopyrightString, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VersionInterface.NativeFieldInfoPtr_CopyrightString, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe int MajorVersion
    {
      get
      {
        int majorVersion;
        IL2CPP.il2cpp_field_static_get_value(VersionInterface.NativeFieldInfoPtr_MajorVersion, (void*) &majorVersion);
        return majorVersion;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VersionInterface.NativeFieldInfoPtr_MajorVersion, (void*) &value);
      }
    }

    public static unsafe int MinorVersion
    {
      get
      {
        int minorVersion;
        IL2CPP.il2cpp_field_static_get_value(VersionInterface.NativeFieldInfoPtr_MinorVersion, (void*) &minorVersion);
        return minorVersion;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VersionInterface.NativeFieldInfoPtr_MinorVersion, (void*) &value);
      }
    }

    public static unsafe int PatchVersion
    {
      get
      {
        int patchVersion;
        IL2CPP.il2cpp_field_static_get_value(VersionInterface.NativeFieldInfoPtr_PatchVersion, (void*) &patchVersion);
        return patchVersion;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VersionInterface.NativeFieldInfoPtr_PatchVersion, (void*) &value);
      }
    }

    public static unsafe Epic.OnlineServices.Utf8String ProductIdentifier
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(VersionInterface.NativeFieldInfoPtr_ProductIdentifier, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VersionInterface.NativeFieldInfoPtr_ProductIdentifier, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Epic.OnlineServices.Utf8String ProductName
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(VersionInterface.NativeFieldInfoPtr_ProductName, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VersionInterface.NativeFieldInfoPtr_ProductName, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
