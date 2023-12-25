// Decompiled with JetBrains decompiler
// Type: HeatMapBinaryUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using System.Runtime.InteropServices;

#nullable disable
public static class HeatMapBinaryUtility : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_FILE_EXTENSION;
  private static readonly System.IntPtr NativeFieldInfoPtr_CURRENT_VERSION;
  private static readonly System.IntPtr NativeMethodInfoPtr_WriteToFile_Public_Static_Void_String_TestSettings_List_1_ChunkData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryReadFromFile_Public_Static_Boolean_String_byref_TestSettings_byref_List_1_ChunkData_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 916342, RefRangeEnd = 916343, XrefRangeStart = 916312, XrefRangeEnd = 916342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void WriteToFile(
    string filePath,
    ChunkPerformanceTestBehaviour.TestSettings testSettings,
    List<ChunkPerformanceTestBehaviour.ChunkData> chunkData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(filePath);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) testSettings);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) chunkData);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HeatMapBinaryUtility.NativeMethodInfoPtr_WriteToFile_Public_Static_Void_String_TestSettings_List_1_ChunkData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916343, XrefRangeEnd = 916375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryReadFromFile(
    string filePath,
    out ChunkPerformanceTestBehaviour.TestSettings testSettings,
    out List<ChunkPerformanceTestBehaviour.ChunkData> chunkData)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(filePath);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero1 = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero1;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero2 = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero2;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
    System.IntPtr exc;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(HeatMapBinaryUtility.NativeMethodInfoPtr_TryReadFromFile_Public_Static_Boolean_String_byref_TestSettings_byref_List_1_ChunkData_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref ChunkPerformanceTestBehaviour.TestSettings local1 = ref testSettings;
    System.IntPtr pointer1 = zero1;
    ChunkPerformanceTestBehaviour.TestSettings testSettings1 = pointer1 == System.IntPtr.Zero ? (ChunkPerformanceTestBehaviour.TestSettings) null : new ChunkPerformanceTestBehaviour.TestSettings(pointer1);
    local1 = testSettings1;
    ref List<ChunkPerformanceTestBehaviour.ChunkData> local2 = ref chunkData;
    System.IntPtr pointer2 = zero2;
    List<> list = pointer2 == System.IntPtr.Zero ? (List<>) null : new List<>(pointer2);
    local2 = (List<ChunkPerformanceTestBehaviour.ChunkData>) list;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  static HeatMapBinaryUtility()
  {
    Il2CppClassPointerStore<HeatMapBinaryUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (HeatMapBinaryUtility));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeatMapBinaryUtility>.NativeClassPtr);
    HeatMapBinaryUtility.NativeFieldInfoPtr_FILE_EXTENSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatMapBinaryUtility>.NativeClassPtr, nameof (FILE_EXTENSION));
    HeatMapBinaryUtility.NativeFieldInfoPtr_CURRENT_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatMapBinaryUtility>.NativeClassPtr, nameof (CURRENT_VERSION));
    HeatMapBinaryUtility.NativeMethodInfoPtr_WriteToFile_Public_Static_Void_String_TestSettings_List_1_ChunkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatMapBinaryUtility>.NativeClassPtr, 100663636);
    HeatMapBinaryUtility.NativeMethodInfoPtr_TryReadFromFile_Public_Static_Boolean_String_byref_TestSettings_byref_List_1_ChunkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatMapBinaryUtility>.NativeClassPtr, 100663637);
  }

  public HeatMapBinaryUtility(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe string FILE_EXTENSION
  {
    get
    {
      System.IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(HeatMapBinaryUtility.NativeFieldInfoPtr_FILE_EXTENSION, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(HeatMapBinaryUtility.NativeFieldInfoPtr_FILE_EXTENSION, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe int CURRENT_VERSION
  {
    get
    {
      int currentVersion;
      IL2CPP.il2cpp_field_static_get_value(HeatMapBinaryUtility.NativeFieldInfoPtr_CURRENT_VERSION, (void*) &currentVersion);
      return currentVersion;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(HeatMapBinaryUtility.NativeFieldInfoPtr_CURRENT_VERSION, (void*) &value);
    }
  }

  public class HeatMapFileHeader : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_BinaryWriter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Boolean_BinaryReader_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    [CallerCount(0)]
    public virtual unsafe void Write(BinaryWriter bw)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bw);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HeatMapBinaryUtility.HeatMapFileHeader.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_BinaryWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe bool Read(BinaryReader br)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) br);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HeatMapBinaryUtility.HeatMapFileHeader.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Boolean_BinaryReader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HeatMapFileHeader()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeatMapBinaryUtility.HeatMapFileHeader>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HeatMapBinaryUtility.HeatMapFileHeader.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HeatMapFileHeader()
    {
      Il2CppClassPointerStore<HeatMapBinaryUtility.HeatMapFileHeader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HeatMapBinaryUtility>.NativeClassPtr, nameof (HeatMapFileHeader));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeatMapBinaryUtility.HeatMapFileHeader>.NativeClassPtr);
      HeatMapBinaryUtility.HeatMapFileHeader.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatMapBinaryUtility.HeatMapFileHeader>.NativeClassPtr, 100663638);
      HeatMapBinaryUtility.HeatMapFileHeader.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Boolean_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatMapBinaryUtility.HeatMapFileHeader>.NativeClassPtr, 100663639);
      HeatMapBinaryUtility.HeatMapFileHeader.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatMapBinaryUtility.HeatMapFileHeader>.NativeClassPtr, 100663640);
    }

    public HeatMapFileHeader(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }

  public class HeatMapMainHeader : HeatMapBinaryUtility.HeatMapFileHeader
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WriteVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_NumChunkData;
    private static readonly System.IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_BinaryWriter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Boolean_BinaryReader_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916309, XrefRangeEnd = 916310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Write(BinaryWriter bw)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bw);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HeatMapBinaryUtility.HeatMapMainHeader.NativeMethodInfoPtr_Write_Public_Virtual_Void_BinaryWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916310, XrefRangeEnd = 916312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Read(BinaryReader br)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) br);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HeatMapBinaryUtility.HeatMapMainHeader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_BinaryReader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HeatMapMainHeader()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeatMapBinaryUtility.HeatMapMainHeader>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HeatMapBinaryUtility.HeatMapMainHeader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HeatMapMainHeader()
    {
      Il2CppClassPointerStore<HeatMapBinaryUtility.HeatMapMainHeader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HeatMapBinaryUtility>.NativeClassPtr, nameof (HeatMapMainHeader));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeatMapBinaryUtility.HeatMapMainHeader>.NativeClassPtr);
      HeatMapBinaryUtility.HeatMapMainHeader.NativeFieldInfoPtr_WriteVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatMapBinaryUtility.HeatMapMainHeader>.NativeClassPtr, nameof (WriteVersion));
      HeatMapBinaryUtility.HeatMapMainHeader.NativeFieldInfoPtr_NumChunkData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatMapBinaryUtility.HeatMapMainHeader>.NativeClassPtr, nameof (NumChunkData));
      HeatMapBinaryUtility.HeatMapMainHeader.NativeMethodInfoPtr_Write_Public_Virtual_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatMapBinaryUtility.HeatMapMainHeader>.NativeClassPtr, 100663641);
      HeatMapBinaryUtility.HeatMapMainHeader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatMapBinaryUtility.HeatMapMainHeader>.NativeClassPtr, 100663642);
      HeatMapBinaryUtility.HeatMapMainHeader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatMapBinaryUtility.HeatMapMainHeader>.NativeClassPtr, 100663643);
    }

    public HeatMapMainHeader(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int WriteVersion
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeatMapBinaryUtility.HeatMapMainHeader.NativeFieldInfoPtr_WriteVersion));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeatMapBinaryUtility.HeatMapMainHeader.NativeFieldInfoPtr_WriteVersion)) = value;
      }
    }

    public unsafe int NumChunkData
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeatMapBinaryUtility.HeatMapMainHeader.NativeFieldInfoPtr_NumChunkData));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeatMapBinaryUtility.HeatMapMainHeader.NativeFieldInfoPtr_NumChunkData)) = value;
      }
    }
  }
}
