// Decompiled with JetBrains decompiler
// Type: ProjectM.VersionDataSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class VersionDataSettings : SettingsBase
  {
    private static readonly IntPtr NativeFieldInfoPtr_DefaultPath;
    private static readonly IntPtr NativeFieldInfoPtr_NetworkVersion;
    private static readonly IntPtr NativeFieldInfoPtr_PersistenceVersion;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 749534, RefRangeEnd = 749535, XrefRangeStart = 749529, XrefRangeEnd = 749534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VersionDataSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionDataSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VersionDataSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VersionDataSettings()
    {
      Il2CppClassPointerStore<VersionDataSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (VersionDataSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionDataSettings>.NativeClassPtr);
      VersionDataSettings.NativeFieldInfoPtr_DefaultPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionDataSettings>.NativeClassPtr, nameof (DefaultPath));
      VersionDataSettings.NativeFieldInfoPtr_NetworkVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionDataSettings>.NativeClassPtr, nameof (NetworkVersion));
      VersionDataSettings.NativeFieldInfoPtr_PersistenceVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionDataSettings>.NativeClassPtr, nameof (PersistenceVersion));
      VersionDataSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionDataSettings>.NativeClassPtr, 100666023);
    }

    public VersionDataSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string DefaultPath
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(VersionDataSettings.NativeFieldInfoPtr_DefaultPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VersionDataSettings.NativeFieldInfoPtr_DefaultPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int NetworkVersion
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VersionDataSettings.NativeFieldInfoPtr_NetworkVersion));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VersionDataSettings.NativeFieldInfoPtr_NetworkVersion)) = value;
      }
    }

    public unsafe int PersistenceVersion
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VersionDataSettings.NativeFieldInfoPtr_PersistenceVersion));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VersionDataSettings.NativeFieldInfoPtr_PersistenceVersion)) = value;
      }
    }
  }
}
