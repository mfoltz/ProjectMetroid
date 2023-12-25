// Decompiled with JetBrains decompiler
// Type: ProjectM.PlaySequenceOnTargetOnDamageTakenComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class PlaySequenceOnTargetOnDamageTakenComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_NewSequence;
    private static readonly IntPtr NativeFieldInfoPtr_SequenceField;
    private static readonly IntPtr NativeFieldInfoPtr_DamageThreshold;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008257, XrefRangeEnd = 1008279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySequenceOnTargetOnDamageTakenComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlaySequenceOnTargetOnDamageTakenComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaySequenceOnTargetOnDamageTakenComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlaySequenceOnTargetOnDamageTakenComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlaySequenceOnTargetOnDamageTakenComponent()
    {
      Il2CppClassPointerStore<PlaySequenceOnTargetOnDamageTakenComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PlaySequenceOnTargetOnDamageTakenComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaySequenceOnTargetOnDamageTakenComponent>.NativeClassPtr);
      PlaySequenceOnTargetOnDamageTakenComponent.NativeFieldInfoPtr_NewSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySequenceOnTargetOnDamageTakenComponent>.NativeClassPtr, nameof (NewSequence));
      PlaySequenceOnTargetOnDamageTakenComponent.NativeFieldInfoPtr_SequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySequenceOnTargetOnDamageTakenComponent>.NativeClassPtr, nameof (SequenceField));
      PlaySequenceOnTargetOnDamageTakenComponent.NativeFieldInfoPtr_DamageThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySequenceOnTargetOnDamageTakenComponent>.NativeClassPtr, nameof (DamageThreshold));
      PlaySequenceOnTargetOnDamageTakenComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySequenceOnTargetOnDamageTakenComponent>.NativeClassPtr, 100678326);
      PlaySequenceOnTargetOnDamageTakenComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySequenceOnTargetOnDamageTakenComponent>.NativeClassPtr, 100678327);
    }

    public PlaySequenceOnTargetOnDamageTakenComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SequenceEditorObject NewSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySequenceOnTargetOnDamageTakenComponent.NativeFieldInfoPtr_NewSequence));
        return pointer == IntPtr.Zero ? (SequenceEditorObject) null : new SequenceEditorObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySequenceOnTargetOnDamageTakenComponent.NativeFieldInfoPtr_NewSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField SequenceField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySequenceOnTargetOnDamageTakenComponent.NativeFieldInfoPtr_SequenceField));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlaySequenceOnTargetOnDamageTakenComponent.NativeFieldInfoPtr_SequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float DamageThreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySequenceOnTargetOnDamageTakenComponent.NativeFieldInfoPtr_DamageThreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlaySequenceOnTargetOnDamageTakenComponent.NativeFieldInfoPtr_DamageThreshold)) = value;
      }
    }
  }
}
