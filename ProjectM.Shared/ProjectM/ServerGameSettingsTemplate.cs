// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerGameSettingsTemplate
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
  public class ServerGameSettingsTemplate : SettingsBase
  {
    private static readonly IntPtr NativeFieldInfoPtr_Name;
    private static readonly IntPtr NativeFieldInfoPtr_Description;
    private static readonly IntPtr NativeFieldInfoPtr_Settings;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_ServerGameSettings_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 757541, RefRangeEnd = 757543, XrefRangeStart = 757540, XrefRangeEnd = 757541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerGameSettingsTemplate()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerGameSettingsTemplate>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameSettingsTemplate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 757544, RefRangeEnd = 757547, XrefRangeStart = 757543, XrefRangeEnd = 757544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerGameSettingsTemplate(string path)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerGameSettingsTemplate>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(path);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameSettingsTemplate.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 757551, RefRangeEnd = 757552, XrefRangeStart = 757547, XrefRangeEnd = 757551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerGameSettingsTemplate(
      string name,
      string description,
      ServerGameSettings settings)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerGameSettingsTemplate>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(description);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) settings);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameSettingsTemplate.NativeMethodInfoPtr__ctor_Public_Void_String_String_ServerGameSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerGameSettingsTemplate()
    {
      Il2CppClassPointerStore<ServerGameSettingsTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ServerGameSettingsTemplate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerGameSettingsTemplate>.NativeClassPtr);
      ServerGameSettingsTemplate.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettingsTemplate>.NativeClassPtr, nameof (Name));
      ServerGameSettingsTemplate.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettingsTemplate>.NativeClassPtr, nameof (Description));
      ServerGameSettingsTemplate.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettingsTemplate>.NativeClassPtr, nameof (Settings));
      ServerGameSettingsTemplate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettingsTemplate>.NativeClassPtr, 100666894);
      ServerGameSettingsTemplate.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettingsTemplate>.NativeClassPtr, 100666895);
      ServerGameSettingsTemplate.NativeMethodInfoPtr__ctor_Public_Void_String_String_ServerGameSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettingsTemplate>.NativeClassPtr, 100666896);
    }

    public ServerGameSettingsTemplate(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsTemplate.NativeFieldInfoPtr_Name)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsTemplate.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string Description
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsTemplate.NativeFieldInfoPtr_Description)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsTemplate.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe ServerGameSettings Settings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsTemplate.NativeFieldInfoPtr_Settings));
        return pointer == IntPtr.Zero ? (ServerGameSettings) null : new ServerGameSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsTemplate.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
