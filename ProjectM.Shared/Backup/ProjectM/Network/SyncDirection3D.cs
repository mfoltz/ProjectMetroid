// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SyncDirection3D
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
  public class SyncDirection3D : SyncAttribute
  {
    private static readonly IntPtr NativeFieldInfoPtr__NumOfBits;
    private static readonly IntPtr NativeFieldInfoPtr__CanBeZero;
    private static readonly IntPtr NativeFieldInfoPtr__TwoD;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Boolean_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0;
    private static readonly IntPtr NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0;
    private static readonly IntPtr NativeMethodInfoPtr_GenerateServerEqualsCheck_Public_Virtual_String_FieldInfo_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Static_Boolean_byref_float3_byref_float3_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785979, XrefRangeEnd = 785985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SyncDirection3D(
      int numOfBits = 18,
      bool canBeZero = false,
      string fieldPostfix = null,
      string customSnapshotFieldName = null)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncDirection3D>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &numOfBits;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &canBeZero;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fieldPostfix);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(customSnapshotFieldName);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncDirection3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785992, RefRangeEnd = 785993, XrefRangeStart = 785985, XrefRangeEnd = 785992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SyncDirection3D(
      bool twoD = true,
      int numOfBits = 12,
      bool canBeZero = false,
      string fieldPostfix = null,
      string customSnapshotFieldName = null)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncDirection3D>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &twoD;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &numOfBits;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &canBeZero;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fieldPostfix);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(customSnapshotFieldName);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncDirection3D.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785993, XrefRangeEnd = 786009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GenerateSerializeCode(
      CodeSegment segment,
      [In] ref GenerateFieldContextData context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncDirection3D.NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786009, XrefRangeEnd = 786025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GenerateDeserializeCode(
      CodeSegment segment,
      [In] ref GenerateFieldContextData context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncDirection3D.NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786025, XrefRangeEnd = 786076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncDirection3D.NativeMethodInfoPtr_GenerateServerEqualsCheck_Public_Virtual_String_FieldInfo_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    public static unsafe bool Equals([In] ref float3 var1, [In] ref float3 var2)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) ref var1;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref var2;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncDirection3D.NativeMethodInfoPtr_Equals_Public_Static_Boolean_byref_float3_byref_float3_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SyncDirection3D()
    {
      Il2CppClassPointerStore<SyncDirection3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (SyncDirection3D));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncDirection3D>.NativeClassPtr);
      SyncDirection3D.NativeFieldInfoPtr__NumOfBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDirection3D>.NativeClassPtr, nameof (_NumOfBits));
      SyncDirection3D.NativeFieldInfoPtr__CanBeZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDirection3D>.NativeClassPtr, nameof (_CanBeZero));
      SyncDirection3D.NativeFieldInfoPtr__TwoD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDirection3D>.NativeClassPtr, nameof (_TwoD));
      SyncDirection3D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncDirection3D>.NativeClassPtr, 100669276);
      SyncDirection3D.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncDirection3D>.NativeClassPtr, 100669277);
      SyncDirection3D.NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncDirection3D>.NativeClassPtr, 100669278);
      SyncDirection3D.NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncDirection3D>.NativeClassPtr, 100669279);
      SyncDirection3D.NativeMethodInfoPtr_GenerateServerEqualsCheck_Public_Virtual_String_FieldInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncDirection3D>.NativeClassPtr, 100669280);
      SyncDirection3D.NativeMethodInfoPtr_Equals_Public_Static_Boolean_byref_float3_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncDirection3D>.NativeClassPtr, 100669281);
    }

    public SyncDirection3D(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int _NumOfBits
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncDirection3D.NativeFieldInfoPtr__NumOfBits));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncDirection3D.NativeFieldInfoPtr__NumOfBits)) = value;
      }
    }

    public unsafe bool _CanBeZero
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncDirection3D.NativeFieldInfoPtr__CanBeZero));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncDirection3D.NativeFieldInfoPtr__CanBeZero)) = value;
      }
    }

    public unsafe bool _TwoD
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncDirection3D.NativeFieldInfoPtr__TwoD));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncDirection3D.NativeFieldInfoPtr__TwoD)) = value;
      }
    }
  }
}
