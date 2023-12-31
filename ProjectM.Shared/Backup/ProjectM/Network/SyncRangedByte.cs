// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SyncRangedByte
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CodeGeneration;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  public class SyncRangedByte : SyncAttribute
  {
    private static readonly IntPtr NativeFieldInfoPtr__Min;
    private static readonly IntPtr NativeFieldInfoPtr__Max;
    private static readonly IntPtr NativeFieldInfoPtr__OverflowHandling;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_OverflowHandling_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0;
    private static readonly IntPtr NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787807, XrefRangeEnd = 787814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SyncRangedByte(
      byte min,
      byte max,
      OverflowHandling overflowHandling = OverflowHandling.LogError,
      string fieldPostfix = null,
      string customSnapshotFieldName = null)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncRangedByte>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &min;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &max;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &overflowHandling;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fieldPostfix);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(customSnapshotFieldName);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncRangedByte.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_OverflowHandling_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787814, XrefRangeEnd = 787818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GenerateSerializeCode(
      CodeSegment segment,
      [In] ref GenerateFieldContextData context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncRangedByte.NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787818, XrefRangeEnd = 787821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GenerateDeserializeCode(
      CodeSegment segment,
      [In] ref GenerateFieldContextData context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncRangedByte.NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SyncRangedByte()
    {
      Il2CppClassPointerStore<SyncRangedByte>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (SyncRangedByte));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncRangedByte>.NativeClassPtr);
      SyncRangedByte.NativeFieldInfoPtr__Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncRangedByte>.NativeClassPtr, nameof (_Min));
      SyncRangedByte.NativeFieldInfoPtr__Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncRangedByte>.NativeClassPtr, nameof (_Max));
      SyncRangedByte.NativeFieldInfoPtr__OverflowHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncRangedByte>.NativeClassPtr, nameof (_OverflowHandling));
      SyncRangedByte.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_OverflowHandling_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRangedByte>.NativeClassPtr, 100669402);
      SyncRangedByte.NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRangedByte>.NativeClassPtr, 100669403);
      SyncRangedByte.NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRangedByte>.NativeClassPtr, 100669404);
    }

    public SyncRangedByte(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe byte _Min
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncRangedByte.NativeFieldInfoPtr__Min));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncRangedByte.NativeFieldInfoPtr__Min)) = value;
      }
    }

    public unsafe byte _Max
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncRangedByte.NativeFieldInfoPtr__Max));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncRangedByte.NativeFieldInfoPtr__Max)) = value;
      }
    }

    public unsafe OverflowHandling _OverflowHandling
    {
      get
      {
        return *(OverflowHandling*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncRangedByte.NativeFieldInfoPtr__OverflowHandling));
      }
      [param: In] set
      {
        *(OverflowHandling*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncRangedByte.NativeFieldInfoPtr__OverflowHandling)) = value;
      }
    }
  }
}
