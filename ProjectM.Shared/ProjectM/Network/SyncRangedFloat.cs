// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SyncRangedFloat
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
  public class SyncRangedFloat : SyncAttribute
  {
    private static readonly IntPtr NativeFieldInfoPtr__Min;
    private static readonly IntPtr NativeFieldInfoPtr__Max;
    private static readonly IntPtr NativeFieldInfoPtr__Decimals;
    private static readonly IntPtr NativeFieldInfoPtr__OverflowHandling;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Int32_OverflowHandling_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0;
    private static readonly IntPtr NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787821, XrefRangeEnd = 787828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SyncRangedFloat(
      float min,
      float max,
      int decimals,
      OverflowHandling overflowHandling = OverflowHandling.LogError,
      string fieldPostfix = null,
      string customSnapshotFieldName = null)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncRangedFloat>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[6];
      numPtr[0] = (IntPtr) &min;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &max;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &decimals;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &overflowHandling;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fieldPostfix);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(customSnapshotFieldName);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncRangedFloat.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Int32_OverflowHandling_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787828, XrefRangeEnd = 787832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GenerateSerializeCode(
      CodeSegment segment,
      [In] ref GenerateFieldContextData context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncRangedFloat.NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 787832, XrefRangeEnd = 787835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GenerateDeserializeCode(
      CodeSegment segment,
      [In] ref GenerateFieldContextData context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncRangedFloat.NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SyncRangedFloat()
    {
      Il2CppClassPointerStore<SyncRangedFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (SyncRangedFloat));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncRangedFloat>.NativeClassPtr);
      SyncRangedFloat.NativeFieldInfoPtr__Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncRangedFloat>.NativeClassPtr, nameof (_Min));
      SyncRangedFloat.NativeFieldInfoPtr__Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncRangedFloat>.NativeClassPtr, nameof (_Max));
      SyncRangedFloat.NativeFieldInfoPtr__Decimals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncRangedFloat>.NativeClassPtr, nameof (_Decimals));
      SyncRangedFloat.NativeFieldInfoPtr__OverflowHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncRangedFloat>.NativeClassPtr, nameof (_OverflowHandling));
      SyncRangedFloat.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Int32_OverflowHandling_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRangedFloat>.NativeClassPtr, 100669405);
      SyncRangedFloat.NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRangedFloat>.NativeClassPtr, 100669406);
      SyncRangedFloat.NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncRangedFloat>.NativeClassPtr, 100669407);
    }

    public SyncRangedFloat(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float _Min
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncRangedFloat.NativeFieldInfoPtr__Min));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncRangedFloat.NativeFieldInfoPtr__Min)) = value;
      }
    }

    public unsafe float _Max
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncRangedFloat.NativeFieldInfoPtr__Max));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncRangedFloat.NativeFieldInfoPtr__Max)) = value;
      }
    }

    public unsafe int _Decimals
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncRangedFloat.NativeFieldInfoPtr__Decimals));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncRangedFloat.NativeFieldInfoPtr__Decimals)) = value;
      }
    }

    public unsafe OverflowHandling _OverflowHandling
    {
      get
      {
        return *(OverflowHandling*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncRangedFloat.NativeFieldInfoPtr__OverflowHandling));
      }
      [param: In] set
      {
        *(OverflowHandling*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncRangedFloat.NativeFieldInfoPtr__OverflowHandling)) = value;
      }
    }
  }
}
