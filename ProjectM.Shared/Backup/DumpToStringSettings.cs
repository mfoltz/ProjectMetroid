// Decompiled with JetBrains decompiler
// Type: DumpToStringSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
public class DumpToStringSettings : Il2CppSystem.Attribute
{
  private static readonly System.IntPtr NativeFieldInfoPtr_ExcludeByDefault;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1696)]
  [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DumpToStringSettings()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DumpToStringSettings>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DumpToStringSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DumpToStringSettings()
  {
    Il2CppClassPointerStore<DumpToStringSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (DumpToStringSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DumpToStringSettings>.NativeClassPtr);
    DumpToStringSettings.NativeFieldInfoPtr_ExcludeByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DumpToStringSettings>.NativeClassPtr, nameof (ExcludeByDefault));
    DumpToStringSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DumpToStringSettings>.NativeClassPtr, 100663304);
  }

  public DumpToStringSettings(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool ExcludeByDefault
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DumpToStringSettings.NativeFieldInfoPtr_ExcludeByDefault));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DumpToStringSettings.NativeFieldInfoPtr_ExcludeByDefault)) = value;
    }
  }
}
