// Decompiled with JetBrains decompiler
// Type: ProjectM.ModificationSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Network;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ModificationSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__ModificationIDs_k__BackingField;
    private static readonly IntPtr NativeFieldInfoPtr__DetectModificationLeaksSystem;
    private static readonly IntPtr NativeMethodInfoPtr_get_ModificationIDs_Public_get_ModificationIDs_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_ModificationIDs_Private_set_Void_ModificationIDs_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetModificationStruct_Public_ModificationStructure_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ProjectM_IPersistentSystemSerializer_get_PersistentIdentifier_Private_Virtual_Final_New_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_0;
    private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe ModificationIDs ModificationIDs
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 73358, RefRangeEnd = 73412, XrefRangeStart = 73358, XrefRangeEnd = 73412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModificationSystem.NativeMethodInfoPtr_get_ModificationIDs_Public_get_ModificationIDs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ModificationIDs*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModificationSystem.NativeMethodInfoPtr_set_ModificationIDs_Private_set_Void_ModificationIDs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746886, XrefRangeEnd = 746895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModificationSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(35)]
    [CachedScanResults(RefRangeStart = 746895, RefRangeEnd = 746930, XrefRangeStart = 746895, XrefRangeEnd = 746895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ModificationStructure GetModificationStruct()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModificationSystem.NativeMethodInfoPtr_GetModificationStruct_Public_ModificationStructure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationStructure*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746930, XrefRangeEnd = 746933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModificationSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModificationSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe string ProjectM\u002EIPersistentSystemSerializer\u002EPersistentIdentifier
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746933, XrefRangeEnd = 746935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ModificationSystem.NativeMethodInfoPtr_ProjectM_IPersistentSystemSerializer_get_PersistentIdentifier_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746935, XrefRangeEnd = 746939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref netBuffer;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModificationSystem.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746939, XrefRangeEnd = 746943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref netBuffer;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModificationSystem.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ModificationSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModificationSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModificationSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModificationSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ModificationSystem()
    {
      Il2CppClassPointerStore<ModificationSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ModificationSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModificationSystem>.NativeClassPtr);
      ModificationSystem.NativeFieldInfoPtr__ModificationIDs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModificationSystem>.NativeClassPtr, "<ModificationIDs>k__BackingField");
      ModificationSystem.NativeFieldInfoPtr__DetectModificationLeaksSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModificationSystem>.NativeClassPtr, nameof (_DetectModificationLeaksSystem));
      ModificationSystem.NativeMethodInfoPtr_get_ModificationIDs_Public_get_ModificationIDs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationSystem>.NativeClassPtr, 100665746);
      ModificationSystem.NativeMethodInfoPtr_set_ModificationIDs_Private_set_Void_ModificationIDs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationSystem>.NativeClassPtr, 100665747);
      ModificationSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationSystem>.NativeClassPtr, 100665748);
      ModificationSystem.NativeMethodInfoPtr_GetModificationStruct_Public_ModificationStructure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationSystem>.NativeClassPtr, 100665749);
      ModificationSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationSystem>.NativeClassPtr, 100665750);
      ModificationSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationSystem>.NativeClassPtr, 100665751);
      ModificationSystem.NativeMethodInfoPtr_ProjectM_IPersistentSystemSerializer_get_PersistentIdentifier_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationSystem>.NativeClassPtr, 100665752);
      ModificationSystem.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationSystem>.NativeClassPtr, 100665753);
      ModificationSystem.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationSystem>.NativeClassPtr, 100665754);
      ModificationSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationSystem>.NativeClassPtr, 100665755);
      ModificationSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModificationSystem>.NativeClassPtr, 100665756);
    }

    public ModificationSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ModificationIDs _ModificationIDs_k__BackingField
    {
      get
      {
        return *(ModificationIDs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModificationSystem.NativeFieldInfoPtr__ModificationIDs_k__BackingField));
      }
      [param: In] set
      {
        *(ModificationIDs*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModificationSystem.NativeFieldInfoPtr__ModificationIDs_k__BackingField)) = value;
      }
    }

    public unsafe DetectModificationLeaksSystem _DetectModificationLeaksSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModificationSystem.NativeFieldInfoPtr__DetectModificationLeaksSystem));
        return pointer == IntPtr.Zero ? (DetectModificationLeaksSystem) null : new DetectModificationLeaksSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModificationSystem.NativeFieldInfoPtr__DetectModificationLeaksSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
