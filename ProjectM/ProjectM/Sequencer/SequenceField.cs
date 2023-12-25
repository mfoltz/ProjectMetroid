// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceField
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public class SequenceField : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Sequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideData;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_SequenceGUID_Object_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Void_Object_GameObjectConversionSystem_byref_SequenceGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGameObjectReferences_Internal_Il2CppReferenceArray_1_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(137)]
    [CachedScanResults(RefRangeStart = 1098731, RefRangeEnd = 1098868, XrefRangeStart = 1098720, XrefRangeEnd = 1098731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceGUID Convert(UnityEngine.Object creator, GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) creator);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceField.NativeMethodInfoPtr_Convert_Public_SequenceGUID_Object_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SequenceGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1098879, RefRangeEnd = 1098885, XrefRangeStart = 1098868, XrefRangeEnd = 1098879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Convert(
      UnityEngine.Object creator,
      GameObjectConversionSystem conversionSystem,
      out SequenceGUID sequenceGUID)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) creator);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceGUID;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceField.NativeMethodInfoPtr_Convert_Public_Void_Object_GameObjectConversionSystem_byref_SequenceGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098885, XrefRangeEnd = 1098887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppReferenceArray<GameObject> GetGameObjectReferences()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceField.NativeMethodInfoPtr_GetGameObjectReferences_Internal_Il2CppReferenceArray_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 1098893, RefRangeEnd = 1098908, XrefRangeStart = 1098887, XrefRangeEnd = 1098893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceField()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceField>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequenceField()
    {
      Il2CppClassPointerStore<SequenceField>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceField));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceField>.NativeClassPtr);
      SequenceField.NativeFieldInfoPtr_Sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceField>.NativeClassPtr, nameof (Sequence));
      SequenceField.NativeFieldInfoPtr_OverrideData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceField>.NativeClassPtr, nameof (OverrideData));
      SequenceField.NativeMethodInfoPtr_Convert_Public_SequenceGUID_Object_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceField>.NativeClassPtr, 100687242);
      SequenceField.NativeMethodInfoPtr_Convert_Public_Void_Object_GameObjectConversionSystem_byref_SequenceGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceField>.NativeClassPtr, 100687243);
      SequenceField.NativeMethodInfoPtr_GetGameObjectReferences_Internal_Il2CppReferenceArray_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceField>.NativeClassPtr, 100687244);
      SequenceField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceField>.NativeClassPtr, 100687245);
    }

    public SequenceField(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SequenceEditorObject Sequence
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceField.NativeFieldInfoPtr_Sequence));
        return pointer == System.IntPtr.Zero ? (SequenceEditorObject) null : new SequenceEditorObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceField.NativeFieldInfoPtr_Sequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceNodeOverrideData OverrideData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceField.NativeFieldInfoPtr_OverrideData));
        return pointer == System.IntPtr.Zero ? (SequenceNodeOverrideData) null : new SequenceNodeOverrideData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceField.NativeFieldInfoPtr_OverrideData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
