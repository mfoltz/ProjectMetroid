// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.RuntimeSequenceConversionAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  public class RuntimeSequenceConversionAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Sequences;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088179, XrefRangeEnd = 1088187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RuntimeSequenceConversionAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088187, XrefRangeEnd = 1088196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RuntimeSequenceConversionAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeSequenceConversionAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RuntimeSequenceConversionAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RuntimeSequenceConversionAsset()
    {
      Il2CppClassPointerStore<RuntimeSequenceConversionAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (RuntimeSequenceConversionAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeSequenceConversionAsset>.NativeClassPtr);
      RuntimeSequenceConversionAsset.NativeFieldInfoPtr_Sequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeSequenceConversionAsset>.NativeClassPtr, nameof (Sequences));
      RuntimeSequenceConversionAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeSequenceConversionAsset>.NativeClassPtr, 100685653);
      RuntimeSequenceConversionAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeSequenceConversionAsset>.NativeClassPtr, 100685654);
    }

    public RuntimeSequenceConversionAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<SequenceConversionSystem.CreateData> Sequences
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RuntimeSequenceConversionAsset.NativeFieldInfoPtr_Sequences));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<SequenceConversionSystem.CreateData>) null : new Il2CppReferenceArray<SequenceConversionSystem.CreateData>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RuntimeSequenceConversionAsset.NativeFieldInfoPtr_Sequences), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
