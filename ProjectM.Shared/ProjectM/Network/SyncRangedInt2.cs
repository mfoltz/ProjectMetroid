// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SyncRangedInt2
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
  public class SyncRangedInt2 : SyncAttribute
  {
    private static readonly IntPtr NativeFieldInfoPtr__Min;
    private static readonly IntPtr NativeFieldInfoPtr__Max;
    private static readonly IntPtr NativeFieldInfoPtr__OverflowHandling;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_OverflowHandling_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_OverflowHandling_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0;
    private static readonly IntPtr NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0;
    private static readonly IntPtr NativeMethodInfoPtr_GenerateServerEqualsCheck_Public_Virtual_String_FieldInfo_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Static_Boolean_byref_int2_byref_int2_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787931, XrefRangeEnd = 787938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SyncRangedInt2(
      int min,
      int max,
      OverflowHandling overflowHandling = OverflowHandling.LogError,
      string fieldPostfix = null,
      string customSnapshotFieldName = null)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncRangedInt2>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &min;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &max;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &overflowHandling;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fieldPostfix);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(customSnapshotFieldName);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncRangedInt2.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_OverflowHandling_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787938, XrefRangeEnd = 787945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SyncRangedInt2(
      int minX,
      int minY,
      int maxX,
      int maxY,
      OverflowHandling overflowHandling = OverflowHandling.LogError,
      string fieldPostfix = null,
      string customSnapshotFieldName = null)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncRangedInt2>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[7];
      numPtr[0] = (IntPtr) &minX;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &minY;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &maxX;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &maxY;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &overflowHandling;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fieldPostfix);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(customSnapshotFieldName);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncRangedInt2.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_OverflowHandling_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787945, XrefRangeEnd = 787956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GenerateSerializeCode(
      CodeSegment segment,
      [In] ref GenerateFieldContextData context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncRangedInt2.NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787956, XrefRangeEnd = 787964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GenerateDeserializeCode(
      CodeSegment segment,
      [In] ref GenerateFieldContextData context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncRangedInt2.NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787964, XrefRangeEnd = 788015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncRangedInt2.NativeMethodInfoPtr_GenerateServerEqualsCheck_Public_Virtual_String_FieldInfo_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    public static unsafe bool Equals([In] ref int2 var1, [In] ref int2 var2)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) ref var1;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref var2;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncRangedInt2.NativeMethodInfoPtr_Equals_Public_Static_Boolean_byref_int2_byref_int2_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SyncRangedInt2()
    {
      Il2CppClassPointerStore<SyncRangedInt2>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (SyncRangedInt2));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncRangedInt2>.NativeClassPtr);
      SyncRangedInt2.NativeFieldInfoPtr__Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncRangedInt2>.NativeClassPtr, nameof (_Min));
      SyncRangedInt2.NativeFieldInfoPtr__Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncRangedInt2>.NativeClassPtr, nameof (_Max));
      SyncRangedInt2.NativeFieldInfoPtr__OverflowHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncRangedInt2>.NativeClassPtr, nameof (_OverflowHandling));
      SyncRangedInt2.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_OverflowHandling_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRangedInt2>.NativeClassPtr, 100669417);
      SyncRangedInt2.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_OverflowHandling_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRangedInt2>.NativeClassPtr, 100669418);
      SyncRangedInt2.NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRangedInt2>.NativeClassPtr, 100669419);
      SyncRangedInt2.NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRangedInt2>.NativeClassPtr, 100669420);
      SyncRangedInt2.NativeMethodInfoPtr_GenerateServerEqualsCheck_Public_Virtual_String_FieldInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRangedInt2>.NativeClassPtr, 100669421);
      SyncRangedInt2.NativeMethodInfoPtr_Equals_Public_Static_Boolean_byref_int2_byref_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRangedInt2>.NativeClassPtr, 100669422);
    }

    public SyncRangedInt2(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int2 _Min
    {
      get
      {
        return *(int2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncRangedInt2.NativeFieldInfoPtr__Min));
      }
      [param: In] set
      {
        *(int2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncRangedInt2.NativeFieldInfoPtr__Min)) = value;
      }
    }

    public unsafe int2 _Max
    {
      get
      {
        return *(int2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncRangedInt2.NativeFieldInfoPtr__Max));
      }
      [param: In] set
      {
        *(int2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncRangedInt2.NativeFieldInfoPtr__Max)) = value;
      }
    }

    public unsafe OverflowHandling _OverflowHandling
    {
      get
      {
        return *(OverflowHandling*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncRangedInt2.NativeFieldInfoPtr__OverflowHandling));
      }
      [param: In] set
      {
        *(OverflowHandling*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncRangedInt2.NativeFieldInfoPtr__OverflowHandling)) = value;
      }
    }
  }
}
