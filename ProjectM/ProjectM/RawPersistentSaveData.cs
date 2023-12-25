// Decompiled with JetBrains decompiler
// Type: ProjectM.RawPersistentSaveData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class RawPersistentSaveData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SaveFileFormatVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderData;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldData;
    private static readonly System.IntPtr NativeFieldInfoPtr_SystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArchetypeSerializationFiles;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadSaveDataAtPath_Public_Static_RawPersistentSaveData_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadVersion1_Private_Static_RawPersistentSaveData_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadVersion2_Private_Static_RawPersistentSaveData_String_BinaryReader_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidateRequiredFiles_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1058020, RefRangeEnd = 1058022, XrefRangeStart = 1057952, XrefRangeEnd = 1058020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RawPersistentSaveData LoadSaveDataAtPath(string saveInstancePath)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(saveInstancePath);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RawPersistentSaveData.NativeMethodInfoPtr_LoadSaveDataAtPath_Public_Static_RawPersistentSaveData_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (RawPersistentSaveData) null : new RawPersistentSaveData(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1058071, RefRangeEnd = 1058072, XrefRangeStart = 1058022, XrefRangeEnd = 1058071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RawPersistentSaveData ReadVersion1(string saveInstancePath)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(saveInstancePath);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RawPersistentSaveData.NativeMethodInfoPtr_ReadVersion1_Private_Static_RawPersistentSaveData_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (RawPersistentSaveData) null : new RawPersistentSaveData(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1058137, RefRangeEnd = 1058138, XrefRangeStart = 1058072, XrefRangeEnd = 1058137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RawPersistentSaveData ReadVersion2(
      string saveInstancePath,
      BinaryReader binaryReader)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(saveInstancePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) binaryReader);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RawPersistentSaveData.NativeMethodInfoPtr_ReadVersion2_Private_Static_RawPersistentSaveData_String_BinaryReader_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (RawPersistentSaveData) null : new RawPersistentSaveData(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1058141, RefRangeEnd = 1058142, XrefRangeStart = 1058138, XrefRangeEnd = 1058141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ValidateRequiredFiles()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RawPersistentSaveData.NativeMethodInfoPtr_ValidateRequiredFiles_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RawPersistentSaveData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RawPersistentSaveData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RawPersistentSaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RawPersistentSaveData()
    {
      Il2CppClassPointerStore<RawPersistentSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RawPersistentSaveData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RawPersistentSaveData>.NativeClassPtr);
      RawPersistentSaveData.NativeFieldInfoPtr_SaveFileFormatVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RawPersistentSaveData>.NativeClassPtr, nameof (SaveFileFormatVersion));
      RawPersistentSaveData.NativeFieldInfoPtr_HeaderData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RawPersistentSaveData>.NativeClassPtr, nameof (HeaderData));
      RawPersistentSaveData.NativeFieldInfoPtr_WorldData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RawPersistentSaveData>.NativeClassPtr, nameof (WorldData));
      RawPersistentSaveData.NativeFieldInfoPtr_SystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RawPersistentSaveData>.NativeClassPtr, nameof (SystemData));
      RawPersistentSaveData.NativeFieldInfoPtr_ArchetypeSerializationFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RawPersistentSaveData>.NativeClassPtr, nameof (ArchetypeSerializationFiles));
      RawPersistentSaveData.NativeMethodInfoPtr_LoadSaveDataAtPath_Public_Static_RawPersistentSaveData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawPersistentSaveData>.NativeClassPtr, 100683059);
      RawPersistentSaveData.NativeMethodInfoPtr_ReadVersion1_Private_Static_RawPersistentSaveData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawPersistentSaveData>.NativeClassPtr, 100683060);
      RawPersistentSaveData.NativeMethodInfoPtr_ReadVersion2_Private_Static_RawPersistentSaveData_String_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawPersistentSaveData>.NativeClassPtr, 100683061);
      RawPersistentSaveData.NativeMethodInfoPtr_ValidateRequiredFiles_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawPersistentSaveData>.NativeClassPtr, 100683062);
      RawPersistentSaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RawPersistentSaveData>.NativeClassPtr, 100683063);
    }

    public RawPersistentSaveData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int SaveFileFormatVersion
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RawPersistentSaveData.NativeFieldInfoPtr_SaveFileFormatVersion));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RawPersistentSaveData.NativeFieldInfoPtr_SaveFileFormatVersion)) = value;
      }
    }

    public unsafe Il2CppStructArray<byte> HeaderData
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RawPersistentSaveData.NativeFieldInfoPtr_HeaderData));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RawPersistentSaveData.NativeFieldInfoPtr_HeaderData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<byte> WorldData
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RawPersistentSaveData.NativeFieldInfoPtr_WorldData));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RawPersistentSaveData.NativeFieldInfoPtr_WorldData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<byte> SystemData
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RawPersistentSaveData.NativeFieldInfoPtr_SystemData));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RawPersistentSaveData.NativeFieldInfoPtr_SystemData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Il2CppStructArray<byte>> ArchetypeSerializationFiles
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RawPersistentSaveData.NativeFieldInfoPtr_ArchetypeSerializationFiles));
        return pointer == System.IntPtr.Zero ? (List<Il2CppStructArray<byte>>) null : new List<Il2CppStructArray<byte>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RawPersistentSaveData.NativeFieldInfoPtr_ArchetypeSerializationFiles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
