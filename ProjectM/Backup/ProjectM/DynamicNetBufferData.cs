// Decompiled with JetBrains decompiler
// Type: ProjectM.DynamicNetBufferData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DynamicNetBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Data;
    private static readonly System.IntPtr NativeFieldInfoPtr_LengthBits;
    private static readonly System.IntPtr NativeMethodInfoPtr_Allocate_Public_Static_DynamicNetBufferData_Int32_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
    [FieldOffset(0)]
    public NativeList<byte> Data;
    [FieldOffset(16)]
    public NativeReference<int> LengthBits;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1058466, RefRangeEnd = 1058470, XrefRangeStart = 1058457, XrefRangeEnd = 1058466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe DynamicNetBufferData Allocate(int lengthBytes, Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &lengthBytes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicNetBufferData.NativeMethodInfoPtr_Allocate_Public_Static_DynamicNetBufferData_Int32_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DynamicNetBufferData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1058482, RefRangeEnd = 1058486, XrefRangeStart = 1058470, XrefRangeEnd = 1058482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DynamicNetBufferData.NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DynamicNetBufferData()
    {
      Il2CppClassPointerStore<DynamicNetBufferData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DynamicNetBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicNetBufferData>.NativeClassPtr);
      DynamicNetBufferData.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicNetBufferData>.NativeClassPtr, nameof (Data));
      DynamicNetBufferData.NativeFieldInfoPtr_LengthBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicNetBufferData>.NativeClassPtr, nameof (LengthBits));
      DynamicNetBufferData.NativeMethodInfoPtr_Allocate_Public_Static_DynamicNetBufferData_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicNetBufferData>.NativeClassPtr, 100683105);
      DynamicNetBufferData.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicNetBufferData>.NativeClassPtr, 100683106);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DynamicNetBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
