// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SyncEntity
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Reflection;
using ProjectM.CodeGeneration;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  public class SyncEntity : SyncAttribute
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSnapshotFieldType_Public_Virtual_Type_FieldInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateCopyFromSnapshotCode_Public_Virtual_Void_CodeSegment_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateCopyToSnapshotCode_Public_Virtual_Void_CodeSegment_String_String_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786095, XrefRangeEnd = 786102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SyncEntity(string fieldPostfix = null, string customSnapshotFieldName = null)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncEntity>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fieldPostfix);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(customSnapshotFieldName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncEntity.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786102, XrefRangeEnd = 786108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppSystem.Type GetSnapshotFieldType(FieldInfo targetField)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetField);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncEntity.NativeMethodInfoPtr_GetSnapshotFieldType_Public_Virtual_Type_FieldInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786108, XrefRangeEnd = 786121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GenerateSerializeCode(
      CodeSegment segment,
      [In] ref GenerateFieldContextData context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncEntity.NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786121, XrefRangeEnd = 786126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GenerateDeserializeCode(
      CodeSegment segment,
      [In] ref GenerateFieldContextData context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncEntity.NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786126, XrefRangeEnd = 786171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GenerateCopyFromSnapshotCode(
      CodeSegment segment,
      string snapshotFieldName,
      string fullRealFieldName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(snapshotFieldName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fullRealFieldName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncEntity.NativeMethodInfoPtr_GenerateCopyFromSnapshotCode_Public_Virtual_Void_CodeSegment_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786171, XrefRangeEnd = 786188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GenerateCopyToSnapshotCode(
      CodeSegment segment,
      string snapshotFieldName,
      string fullRealFieldName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) segment);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(snapshotFieldName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fullRealFieldName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncEntity.NativeMethodInfoPtr_GenerateCopyToSnapshotCode_Public_Virtual_Void_CodeSegment_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SyncEntity()
    {
      Il2CppClassPointerStore<SyncEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (SyncEntity));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncEntity>.NativeClassPtr);
      SyncEntity.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEntity>.NativeClassPtr, 100669285);
      SyncEntity.NativeMethodInfoPtr_GetSnapshotFieldType_Public_Virtual_Type_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEntity>.NativeClassPtr, 100669286);
      SyncEntity.NativeMethodInfoPtr_GenerateSerializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEntity>.NativeClassPtr, 100669287);
      SyncEntity.NativeMethodInfoPtr_GenerateDeserializeCode_Public_Virtual_Void_CodeSegment_byref_GenerateFieldContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEntity>.NativeClassPtr, 100669288);
      SyncEntity.NativeMethodInfoPtr_GenerateCopyFromSnapshotCode_Public_Virtual_Void_CodeSegment_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEntity>.NativeClassPtr, 100669289);
      SyncEntity.NativeMethodInfoPtr_GenerateCopyToSnapshotCode_Public_Virtual_Void_CodeSegment_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncEntity>.NativeClassPtr, 100669290);
    }

    public SyncEntity(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
