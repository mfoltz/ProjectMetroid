// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetCodeGenHelper
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CodeGeneration;

#nullable disable
namespace ProjectM.Network
{
  public static class NetCodeGenHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_InsertWriteRangedIntegerCode_Public_Static_Void_CodeSegment_Int32_Int32_String_OverflowHandling_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InsertReadRangedIntegerCode_Public_Static_Void_CodeSegment_Int32_Int32_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InsertWriteRangedIntegerCode_Public_Static_Void_CodeSegment_String_String_String_OverflowHandling_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InsertReadRangedIntegerCode_Public_Static_Void_CodeSegment_String_String_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InsertWriteRangedFloatCode_Public_Static_Void_CodeSegment_Single_Single_Int32_String_OverflowHandling_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InsertReadRangedFloatCode_Public_Static_Void_CodeSegment_Single_Single_Int32_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InsertWriteRangedFloatCode_Public_Static_Void_CodeSegment_String_String_String_String_OverflowHandling_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InsertReadRangedFloatCode_Public_Static_Void_CodeSegment_String_String_String_String_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 635629, RefRangeEnd = 635633, XrefRangeStart = 635626, XrefRangeEnd = 635629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void InsertWriteRangedIntegerCode(
      CodeSegment segment,
      int min,
      int max,
      string valuePath,
      OverflowHandling overflowHandling)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &min;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(valuePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &overflowHandling;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetCodeGenHelper.NativeMethodInfoPtr_InsertWriteRangedIntegerCode_Public_Static_Void_CodeSegment_Int32_Int32_String_OverflowHandling_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 635636, RefRangeEnd = 635640, XrefRangeStart = 635633, XrefRangeEnd = 635636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void InsertReadRangedIntegerCode(
      CodeSegment segment,
      int min,
      int max,
      string valuePath,
      string castToType = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &min;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(valuePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(castToType);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetCodeGenHelper.NativeMethodInfoPtr_InsertReadRangedIntegerCode_Public_Static_Void_CodeSegment_Int32_Int32_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 635874, RefRangeEnd = 635881, XrefRangeStart = 635640, XrefRangeEnd = 635874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void InsertWriteRangedIntegerCode(
      CodeSegment segment,
      string min,
      string max,
      string valuePath,
      OverflowHandling overflowHandling)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(min);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(max);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(valuePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &overflowHandling;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetCodeGenHelper.NativeMethodInfoPtr_InsertWriteRangedIntegerCode_Public_Static_Void_CodeSegment_String_String_String_OverflowHandling_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 635992, RefRangeEnd = 635999, XrefRangeStart = 635881, XrefRangeEnd = 635992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void InsertReadRangedIntegerCode(
      CodeSegment segment,
      string min,
      string max,
      string valuePath,
      string castToType = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(min);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(max);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(valuePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(castToType);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetCodeGenHelper.NativeMethodInfoPtr_InsertReadRangedIntegerCode_Public_Static_Void_CodeSegment_String_String_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 636011, RefRangeEnd = 636014, XrefRangeStart = 635999, XrefRangeEnd = 636011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void InsertWriteRangedFloatCode(
      CodeSegment segment,
      float min,
      float max,
      int decimals,
      string valuePath,
      OverflowHandling overflowHandling)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &min;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &decimals;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(valuePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &overflowHandling;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetCodeGenHelper.NativeMethodInfoPtr_InsertWriteRangedFloatCode_Public_Static_Void_CodeSegment_Single_Single_Int32_String_OverflowHandling_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 636026, RefRangeEnd = 636029, XrefRangeStart = 636014, XrefRangeEnd = 636026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void InsertReadRangedFloatCode(
      CodeSegment segment,
      float min,
      float max,
      int decimals,
      string valuePath)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &min;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &decimals;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(valuePath);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetCodeGenHelper.NativeMethodInfoPtr_InsertReadRangedFloatCode_Public_Static_Void_CodeSegment_Single_Single_Int32_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 636277, RefRangeEnd = 636278, XrefRangeStart = 636029, XrefRangeEnd = 636277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void InsertWriteRangedFloatCode(
      CodeSegment segment,
      string min,
      string max,
      string decimals,
      string valuePath,
      OverflowHandling overflowHandling)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(min);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(max);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(decimals);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(valuePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &overflowHandling;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetCodeGenHelper.NativeMethodInfoPtr_InsertWriteRangedFloatCode_Public_Static_Void_CodeSegment_String_String_String_String_OverflowHandling_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 636343, RefRangeEnd = 636344, XrefRangeStart = 636278, XrefRangeEnd = 636343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void InsertReadRangedFloatCode(
      CodeSegment segment,
      string min,
      string max,
      string decimals,
      string valuePath)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(min);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(max);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(decimals);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(valuePath);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetCodeGenHelper.NativeMethodInfoPtr_InsertReadRangedFloatCode_Public_Static_Void_CodeSegment_String_String_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NetCodeGenHelper()
    {
      Il2CppClassPointerStore<NetCodeGenHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.Network", nameof (NetCodeGenHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetCodeGenHelper>.NativeClassPtr);
      NetCodeGenHelper.NativeMethodInfoPtr_InsertWriteRangedIntegerCode_Public_Static_Void_CodeSegment_Int32_Int32_String_OverflowHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetCodeGenHelper>.NativeClassPtr, 100663498);
      NetCodeGenHelper.NativeMethodInfoPtr_InsertReadRangedIntegerCode_Public_Static_Void_CodeSegment_Int32_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetCodeGenHelper>.NativeClassPtr, 100663499);
      NetCodeGenHelper.NativeMethodInfoPtr_InsertWriteRangedIntegerCode_Public_Static_Void_CodeSegment_String_String_String_OverflowHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetCodeGenHelper>.NativeClassPtr, 100663500);
      NetCodeGenHelper.NativeMethodInfoPtr_InsertReadRangedIntegerCode_Public_Static_Void_CodeSegment_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetCodeGenHelper>.NativeClassPtr, 100663501);
      NetCodeGenHelper.NativeMethodInfoPtr_InsertWriteRangedFloatCode_Public_Static_Void_CodeSegment_Single_Single_Int32_String_OverflowHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetCodeGenHelper>.NativeClassPtr, 100663502);
      NetCodeGenHelper.NativeMethodInfoPtr_InsertReadRangedFloatCode_Public_Static_Void_CodeSegment_Single_Single_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetCodeGenHelper>.NativeClassPtr, 100663503);
      NetCodeGenHelper.NativeMethodInfoPtr_InsertWriteRangedFloatCode_Public_Static_Void_CodeSegment_String_String_String_String_OverflowHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetCodeGenHelper>.NativeClassPtr, 100663504);
      NetCodeGenHelper.NativeMethodInfoPtr_InsertReadRangedFloatCode_Public_Static_Void_CodeSegment_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetCodeGenHelper>.NativeClassPtr, 100663505);
    }

    public NetCodeGenHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
