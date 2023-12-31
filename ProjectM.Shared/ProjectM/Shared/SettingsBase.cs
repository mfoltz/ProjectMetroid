// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SettingsBase
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Reflection;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  public class SettingsBase : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Verbose_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReloadOnFileChanges_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__DefaultFilePath;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Verbose_Public_Virtual_New_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ReloadOnFileChanges_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ReloadOnFileChanges_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SettingsName_Private_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SettingsFullName_Private_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadDefaultFile_Public_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromFile_Public_Void_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadFilesFromDirectory_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromEnvironment_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromCommandLineParameters_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CommandLineProcessObject_Private_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromEnvironment_Public_Void_EnvironmentVariableTarget_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EnvironmentProcessObject_Private_Void_Object_EnvironmentVariableTarget_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAssignField_Private_Boolean_Object_FieldInfo_Type_String_Boolean_Boolean_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryLoadJsonFile_Private_Void_String_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PopulateFromJson_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OverwriteDefaultSettings_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveToPath_Public_Void_String_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveToPath_Public_Static_Void_String_String_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetJson_Private_Static_String_Object_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteChanges_Private_Static_Object_JsonWriter_Object_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteJsonFile_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToJsonString_Public_String_JsonStringMode_DefaultValueHandling_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FullJsonHash_Public_String_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ComputeSha256Hash_Private_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToJsonString_Public_String_Boolean_Boolean_0;

    public virtual unsafe bool Verbose
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SettingsBase.NativeMethodInfoPtr_get_Verbose_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool ReloadOnFileChanges
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_get_ReloadOnFileChanges_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_set_ReloadOnFileChanges_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe string SettingsName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_get_SettingsName_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe string SettingsFullName
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 802217, RefRangeEnd = 802218, XrefRangeStart = 802215, XrefRangeEnd = 802217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_get_SettingsFullName_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 802219, RefRangeEnd = 802222, XrefRangeStart = 802218, XrefRangeEnd = 802219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SettingsBase()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(19)]
    [CachedScanResults(RefRangeStart = 802242, RefRangeEnd = 802261, XrefRangeStart = 802222, XrefRangeEnd = 802242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SettingsBase(
      string defaultFilePath,
      bool loadDefault = false,
      bool applyEnvironmentVariables = false)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(defaultFilePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &loadDefault;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &applyEnvironmentVariables;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802261, XrefRangeEnd = 802262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LoadDefaultFile(bool logIfFileDoesntExist = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &logIfFileDoesntExist;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_LoadDefaultFile_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 802263, RefRangeEnd = 802273, XrefRangeStart = 802262, XrefRangeEnd = 802263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LoadFromFile(string filePath, bool logIfFileDoesntExist = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(filePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &logIfFileDoesntExist;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_LoadFromFile_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LoadFilesFromDirectory(string path)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(path);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_LoadFilesFromDirectory_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802273, XrefRangeEnd = 802276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LoadFromEnvironment()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_LoadFromEnvironment_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802276, XrefRangeEnd = 802277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LoadFromCommandLineParameters()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_LoadFromCommandLineParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 802459, RefRangeEnd = 802462, XrefRangeStart = 802277, XrefRangeEnd = 802459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CommandLineProcessObject(Il2CppSystem.Object obj)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_CommandLineProcessObject_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802462, XrefRangeEnd = 802463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LoadFromEnvironment(Il2CppSystem.EnvironmentVariableTarget target)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_LoadFromEnvironment_Public_Void_EnvironmentVariableTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 802544, RefRangeEnd = 802555, XrefRangeStart = 802463, XrefRangeEnd = 802544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EnvironmentProcessObject(Il2CppSystem.Object obj, Il2CppSystem.EnvironmentVariableTarget target)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_EnvironmentProcessObject_Private_Void_Object_EnvironmentVariableTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 802681, RefRangeEnd = 802683, XrefRangeStart = 802555, XrefRangeEnd = 802681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryAssignField(
      Il2CppSystem.Object obj,
      FieldInfo field,
      Il2CppSystem.Type type,
      string stringValue,
      bool parseNewLines,
      bool invert,
      out bool parseError)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) field);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(stringValue);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &parseNewLines;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &invert;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref parseError;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_TryAssignField_Private_Boolean_Object_FieldInfo_Type_String_Boolean_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 802739, RefRangeEnd = 802749, XrefRangeStart = 802683, XrefRangeEnd = 802739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TryLoadJsonFile(string path, bool logWarning = true, bool defaultSettings = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(path);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &logWarning;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultSettings;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_TryLoadJsonFile_Private_Void_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 802753, RefRangeEnd = 802754, XrefRangeStart = 802749, XrefRangeEnd = 802753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PopulateFromJson(string fileContent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fileContent);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_PopulateFromJson_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802754, XrefRangeEnd = 802755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OverwriteDefaultSettings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_OverwriteDefaultSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(31)]
    [CachedScanResults(RefRangeStart = 802759, RefRangeEnd = 802790, XrefRangeStart = 802755, XrefRangeEnd = 802759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SaveToPath(string path, bool removeDefaultValues = true, bool saveWholeFile = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(path);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &removeDefaultValues;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &saveWholeFile;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_SaveToPath_Public_Void_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 802828, RefRangeEnd = 802829, XrefRangeStart = 802790, XrefRangeEnd = 802828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SaveToPath(
      string path,
      string json,
      bool verbose = false,
      string settingsFullName = "")
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(path);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(json);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &verbose;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(settingsFullName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_SaveToPath_Public_Static_Void_String_String_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 802847, RefRangeEnd = 802853, XrefRangeStart = 802829, XrefRangeEnd = 802847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetJson(Il2CppSystem.Object thing, Il2CppSystem.Object defaultThing)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) thing);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) defaultThing);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_GetJson_Private_Static_String_Object_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 802905, RefRangeEnd = 802908, XrefRangeStart = 802853, XrefRangeEnd = 802905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Object WriteChanges(
      JsonWriter writer,
      Il2CppSystem.Object thing,
      Il2CppSystem.Object defaultThing)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) writer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) thing);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) defaultThing);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_WriteChanges_Private_Static_Object_JsonWriter_Object_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 802930, RefRangeEnd = 802931, XrefRangeStart = 802908, XrefRangeEnd = 802930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void WriteJsonFile(string path)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(path);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_WriteJsonFile_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802931, XrefRangeEnd = 802940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string ToJsonString(
      SettingsBase.JsonStringMode mode,
      DefaultValueHandling defaultValueHandling = DefaultValueHandling.Ignore)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &mode;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValueHandling;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_ToJsonString_Public_String_JsonStringMode_DefaultValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 802955, RefRangeEnd = 802963, XrefRangeStart = 802940, XrefRangeEnd = 802955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string FullJsonHash(out string jsonString)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_FullJsonHash_Public_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      jsonString = IL2CPP.Il2CppStringToManaged(zero);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 802979, RefRangeEnd = 802980, XrefRangeStart = 802963, XrefRangeEnd = 802979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string ComputeSha256Hash(string rawString)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(rawString);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_ComputeSha256Hash_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 802989, RefRangeEnd = 803001, XrefRangeStart = 802980, XrefRangeEnd = 802989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string ToJsonString(bool removeDefaultValues, bool saveWholeFile = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &removeDefaultValues;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &saveWholeFile;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SettingsBase.NativeMethodInfoPtr_ToJsonString_Public_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static SettingsBase()
    {
      Il2CppClassPointerStore<SettingsBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SettingsBase));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr);
      SettingsBase.NativeFieldInfoPtr__Verbose_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, "<Verbose>k__BackingField");
      SettingsBase.NativeFieldInfoPtr__ReloadOnFileChanges_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, "<ReloadOnFileChanges>k__BackingField");
      SettingsBase.NativeFieldInfoPtr__DefaultFilePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, nameof (_DefaultFilePath));
      SettingsBase.NativeMethodInfoPtr_get_Verbose_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670756);
      SettingsBase.NativeMethodInfoPtr_get_ReloadOnFileChanges_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670757);
      SettingsBase.NativeMethodInfoPtr_set_ReloadOnFileChanges_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670758);
      SettingsBase.NativeMethodInfoPtr_get_SettingsName_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670759);
      SettingsBase.NativeMethodInfoPtr_get_SettingsFullName_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670760);
      SettingsBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670761);
      SettingsBase.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670762);
      SettingsBase.NativeMethodInfoPtr_LoadDefaultFile_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670763);
      SettingsBase.NativeMethodInfoPtr_LoadFromFile_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670764);
      SettingsBase.NativeMethodInfoPtr_LoadFilesFromDirectory_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670765);
      SettingsBase.NativeMethodInfoPtr_LoadFromEnvironment_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670766);
      SettingsBase.NativeMethodInfoPtr_LoadFromCommandLineParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670767);
      SettingsBase.NativeMethodInfoPtr_CommandLineProcessObject_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670768);
      SettingsBase.NativeMethodInfoPtr_LoadFromEnvironment_Public_Void_EnvironmentVariableTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670769);
      SettingsBase.NativeMethodInfoPtr_EnvironmentProcessObject_Private_Void_Object_EnvironmentVariableTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670770);
      SettingsBase.NativeMethodInfoPtr_TryAssignField_Private_Boolean_Object_FieldInfo_Type_String_Boolean_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670771);
      SettingsBase.NativeMethodInfoPtr_TryLoadJsonFile_Private_Void_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670772);
      SettingsBase.NativeMethodInfoPtr_PopulateFromJson_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670773);
      SettingsBase.NativeMethodInfoPtr_OverwriteDefaultSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670774);
      SettingsBase.NativeMethodInfoPtr_SaveToPath_Public_Void_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670775);
      SettingsBase.NativeMethodInfoPtr_SaveToPath_Public_Static_Void_String_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670776);
      SettingsBase.NativeMethodInfoPtr_GetJson_Private_Static_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670777);
      SettingsBase.NativeMethodInfoPtr_WriteChanges_Private_Static_Object_JsonWriter_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670778);
      SettingsBase.NativeMethodInfoPtr_WriteJsonFile_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670779);
      SettingsBase.NativeMethodInfoPtr_ToJsonString_Public_String_JsonStringMode_DefaultValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670780);
      SettingsBase.NativeMethodInfoPtr_FullJsonHash_Public_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670781);
      SettingsBase.NativeMethodInfoPtr_ComputeSha256Hash_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670782);
      SettingsBase.NativeMethodInfoPtr_ToJsonString_Public_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBase>.NativeClassPtr, 100670783);
    }

    public SettingsBase(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool _Verbose_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingsBase.NativeFieldInfoPtr__Verbose_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingsBase.NativeFieldInfoPtr__Verbose_k__BackingField)) = value;
      }
    }

    public unsafe bool _ReloadOnFileChanges_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingsBase.NativeFieldInfoPtr__ReloadOnFileChanges_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingsBase.NativeFieldInfoPtr__ReloadOnFileChanges_k__BackingField)) = value;
      }
    }

    public unsafe string _DefaultFilePath
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingsBase.NativeFieldInfoPtr__DefaultFilePath)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SettingsBase.NativeFieldInfoPtr__DefaultFilePath), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public enum JsonStringMode
    {
      One,
      Two,
      Three,
    }
  }
}
