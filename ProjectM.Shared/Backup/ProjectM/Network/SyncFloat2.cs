// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SyncFloat2
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Reflection;
using ProjectM.CodeGeneration;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  public class SyncFloat2 : SyncAttribute
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0;
    private static readonly IntPtr NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0;
    private static readonly IntPtr NativeMethodInfoPtr_GenerateServerEqualsCheck_Public_Virtual_String_FieldInfo_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Static_Boolean_byref_float2_byref_float2_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786659, XrefRangeEnd = 786666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SyncFloat2(string fieldPostfix = null, string customSnapshotFieldName = null)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncFloat2>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fieldPostfix);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(customSnapshotFieldName);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncFloat2.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786666, XrefRangeEnd = 786678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GenerateSerializeCode(
      CodeSegment segment,
      [In] ref GenerateFieldContextData context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncFloat2.NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786678, XrefRangeEnd = 786687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GenerateDeserializeCode(
      CodeSegment segment,
      [In] ref GenerateFieldContextData context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncFloat2.NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786687, XrefRangeEnd = 786738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string GenerateServerEqualsCheck(
      FieldInfo targetField,
      string variable1,
      string variable2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetField);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(variable1);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(variable2);
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncFloat2.NativeMethodInfoPtr_GenerateServerEqualsCheck_Public_Virtual_String_FieldInfo_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    public static unsafe bool Equals([In] ref float2 var1, [In] ref float2 var2)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) ref var1;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref var2;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncFloat2.NativeMethodInfoPtr_Equals_Public_Static_Boolean_byref_float2_byref_float2_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SyncFloat2()
    {
      Il2CppClassPointerStore<SyncFloat2>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (SyncFloat2));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncFloat2>.NativeClassPtr);
      SyncFloat2.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncFloat2>.NativeClassPtr, 100669317);
      SyncFloat2.NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncFloat2>.NativeClassPtr, 100669318);
      SyncFloat2.NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncFloat2>.NativeClassPtr, 100669319);
      SyncFloat2.NativeMethodInfoPtr_GenerateServerEqualsCheck_Public_Virtual_String_FieldInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncFloat2>.NativeClassPtr, 100669320);
      SyncFloat2.NativeMethodInfoPtr_Equals_Public_Static_Boolean_byref_float2_byref_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncFloat2>.NativeClassPtr, 100669321);
    }

    public SyncFloat2(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
