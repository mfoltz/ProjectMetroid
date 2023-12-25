// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.SequencerPrefab.VFXControllerComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Stunlock.Sequencer.SequencerPrefab
{
  public class VFXControllerComponent : SequencerPrefabComponent
  {
    private static readonly IntPtr NativeFieldInfoPtr_Data;
    private static readonly IntPtr NativeMethodInfoPtr_GetSequenceData_Public_Virtual_List_1_SequencerEventBuilder_BlackboardBuilder_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_ConstructParticleEvent_Private_ParticleEventBuilder_BlackboardBuilder_VFXControllerData_byref_List_1_SequencerEventBuilder_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925502, XrefRangeEnd = 925573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe List<SequencerEventBuilder> GetSequenceData(
      BlackboardBuilder blackboardBuilder,
      int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &index;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VFXControllerComponent.NativeMethodInfoPtr_GetSequenceData_Public_Virtual_List_1_SequencerEventBuilder_BlackboardBuilder_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (List<SequencerEventBuilder>) null : new List<SequencerEventBuilder>(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 925760, RefRangeEnd = 925762, XrefRangeStart = 925573, XrefRangeEnd = 925760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ParticleEventBuilder ConstructParticleEvent(
      BlackboardBuilder blackboardBuilder,
      VFXControllerData entry,
      ref List<SequencerEventBuilder> children,
      int effectIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr1 = stackalloc IntPtr[4];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(2) * sizeof (IntPtr));
      IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) children);
      IntPtr* numPtr2 = &ptr;
      *(IntPtr*) num1 = (IntPtr) numPtr2;
      *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &effectIndex;
      IntPtr exc;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VFXControllerComponent.NativeMethodInfoPtr_ConstructParticleEvent_Private_ParticleEventBuilder_BlackboardBuilder_VFXControllerData_byref_List_1_SequencerEventBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<SequencerEventBuilder> local = ref children;
      IntPtr pointer1 = ptr;
      List<> list = pointer1 == IntPtr.Zero ? (List<>) null : new List<>(pointer1);
      local = (List<SequencerEventBuilder>) list;
      IntPtr pointer2 = num2;
      return pointer2 == IntPtr.Zero ? (ParticleEventBuilder) null : new ParticleEventBuilder(pointer2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925762, XrefRangeEnd = 925809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VFXControllerComponent.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925809, XrefRangeEnd = 925817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VFXControllerComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXControllerComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VFXControllerComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VFXControllerComponent()
    {
      Il2CppClassPointerStore<VFXControllerComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer.SequencerPrefab", nameof (VFXControllerComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXControllerComponent>.NativeClassPtr);
      VFXControllerComponent.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXControllerComponent>.NativeClassPtr, nameof (Data));
      VFXControllerComponent.NativeMethodInfoPtr_GetSequenceData_Public_Virtual_List_1_SequencerEventBuilder_BlackboardBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXControllerComponent>.NativeClassPtr, 100663968);
      VFXControllerComponent.NativeMethodInfoPtr_ConstructParticleEvent_Private_ParticleEventBuilder_BlackboardBuilder_VFXControllerData_byref_List_1_SequencerEventBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXControllerComponent>.NativeClassPtr, 100663969);
      VFXControllerComponent.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXControllerComponent>.NativeClassPtr, 100663970);
      VFXControllerComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXControllerComponent>.NativeClassPtr, 100663971);
    }

    public VFXControllerComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<VFXControllerData> Data
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerComponent.NativeFieldInfoPtr_Data));
        return pointer == IntPtr.Zero ? (List<VFXControllerData>) null : new List<VFXControllerData>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerComponent.NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
