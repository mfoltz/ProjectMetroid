// Decompiled with JetBrains decompiler
// Type: ProjectM.SequenceOverrideTestComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class SequenceOverrideTestComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MyPosition;
    private static readonly IntPtr NativeFieldInfoPtr_Sequence;
    private static readonly IntPtr NativeFieldInfoPtr_AnotherSequence;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceOverrideTestComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceOverrideTestComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceOverrideTestComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequenceOverrideTestComponent()
    {
      Il2CppClassPointerStore<SequenceOverrideTestComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SequenceOverrideTestComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceOverrideTestComponent>.NativeClassPtr);
      SequenceOverrideTestComponent.NativeFieldInfoPtr_MyPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceOverrideTestComponent>.NativeClassPtr, nameof (MyPosition));
      SequenceOverrideTestComponent.NativeFieldInfoPtr_Sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceOverrideTestComponent>.NativeClassPtr, nameof (Sequence));
      SequenceOverrideTestComponent.NativeFieldInfoPtr_AnotherSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceOverrideTestComponent>.NativeClassPtr, nameof (AnotherSequence));
      SequenceOverrideTestComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceOverrideTestComponent>.NativeClassPtr, 100683908);
    }

    public SequenceOverrideTestComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Vector3 MyPosition
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceOverrideTestComponent.NativeFieldInfoPtr_MyPosition));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceOverrideTestComponent.NativeFieldInfoPtr_MyPosition)) = value;
      }
    }

    public unsafe SequenceField Sequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceOverrideTestComponent.NativeFieldInfoPtr_Sequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceOverrideTestComponent.NativeFieldInfoPtr_Sequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField AnotherSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceOverrideTestComponent.NativeFieldInfoPtr_AnotherSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceOverrideTestComponent.NativeFieldInfoPtr_AnotherSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
