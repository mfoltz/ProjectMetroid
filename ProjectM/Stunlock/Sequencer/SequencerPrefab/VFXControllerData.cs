// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.SequencerPrefab.VFXControllerData
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
using UnityEngine;

#nullable disable
namespace Stunlock.Sequencer.SequencerPrefab
{
  [Serializable]
  public class VFXControllerData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_VFXPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerAndTimingData;
    private static readonly System.IntPtr NativeFieldInfoPtr_TransformationData;
    private static readonly System.IntPtr NativeFieldInfoPtr_VFXGraphBlackboard;
    private static readonly System.IntPtr NativeFieldInfoPtr_VFXControllerType;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryTransformationData;
    private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryTransformationData;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartPosVFXParamIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndPosVFXParamIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_VFXGraphDefaultValues;
    private static readonly System.IntPtr NativeFieldInfoPtr_CommentColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_Comment;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925439, XrefRangeEnd = 925472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VFXControllerData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXControllerData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VFXControllerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VFXControllerData()
    {
      Il2CppClassPointerStore<VFXControllerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer.SequencerPrefab", nameof (VFXControllerData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXControllerData>.NativeClassPtr);
      VFXControllerData.NativeFieldInfoPtr_VFXPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXControllerData>.NativeClassPtr, nameof (VFXPrefab));
      VFXControllerData.NativeFieldInfoPtr_TriggerAndTimingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXControllerData>.NativeClassPtr, nameof (TriggerAndTimingData));
      VFXControllerData.NativeFieldInfoPtr_TransformationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXControllerData>.NativeClassPtr, nameof (TransformationData));
      VFXControllerData.NativeFieldInfoPtr_VFXGraphBlackboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXControllerData>.NativeClassPtr, nameof (VFXGraphBlackboard));
      VFXControllerData.NativeFieldInfoPtr_VFXControllerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXControllerData>.NativeClassPtr, nameof (VFXControllerType));
      VFXControllerData.NativeFieldInfoPtr_PrimaryTransformationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXControllerData>.NativeClassPtr, nameof (PrimaryTransformationData));
      VFXControllerData.NativeFieldInfoPtr_SecondaryTransformationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXControllerData>.NativeClassPtr, nameof (SecondaryTransformationData));
      VFXControllerData.NativeFieldInfoPtr_StartPosVFXParamIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXControllerData>.NativeClassPtr, nameof (StartPosVFXParamIndex));
      VFXControllerData.NativeFieldInfoPtr_EndPosVFXParamIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXControllerData>.NativeClassPtr, nameof (EndPosVFXParamIndex));
      VFXControllerData.NativeFieldInfoPtr_VFXGraphDefaultValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXControllerData>.NativeClassPtr, nameof (VFXGraphDefaultValues));
      VFXControllerData.NativeFieldInfoPtr_CommentColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXControllerData>.NativeClassPtr, nameof (CommentColor));
      VFXControllerData.NativeFieldInfoPtr_Comment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXControllerData>.NativeClassPtr, nameof (Comment));
      VFXControllerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXControllerData>.NativeClassPtr, 100663966);
    }

    public VFXControllerData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameObject VFXPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_VFXPrefab));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_VFXPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TriggerAndTimingData TriggerAndTimingData
    {
      get
      {
        return *(TriggerAndTimingData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_TriggerAndTimingData));
      }
      [param: In] set
      {
        *(TriggerAndTimingData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_TriggerAndTimingData)) = value;
      }
    }

    public unsafe TransformationData TransformationData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_TransformationData));
        return pointer == System.IntPtr.Zero ? (TransformationData) null : new TransformationData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_TransformationData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<VisualEffectPrefabConversionData> VFXGraphBlackboard
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_VFXGraphBlackboard));
        return pointer == System.IntPtr.Zero ? (List<VisualEffectPrefabConversionData>) null : new List<VisualEffectPrefabConversionData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_VFXGraphBlackboard), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VFXControllerType VFXControllerType
    {
      get
      {
        return *(VFXControllerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_VFXControllerType));
      }
      [param: In] set
      {
        *(VFXControllerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_VFXControllerType)) = value;
      }
    }

    public unsafe TransformationData PrimaryTransformationData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_PrimaryTransformationData));
        return pointer == System.IntPtr.Zero ? (TransformationData) null : new TransformationData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_PrimaryTransformationData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TransformationData SecondaryTransformationData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_SecondaryTransformationData));
        return pointer == System.IntPtr.Zero ? (TransformationData) null : new TransformationData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_SecondaryTransformationData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int StartPosVFXParamIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_StartPosVFXParamIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_StartPosVFXParamIndex)) = value;
      }
    }

    public unsafe int EndPosVFXParamIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_EndPosVFXParamIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_EndPosVFXParamIndex)) = value;
      }
    }

    public unsafe List<BlackboardParameterValue> VFXGraphDefaultValues
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_VFXGraphDefaultValues));
        return pointer == System.IntPtr.Zero ? (List<BlackboardParameterValue>) null : new List<BlackboardParameterValue>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_VFXGraphDefaultValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector4 CommentColor
    {
      get
      {
        return *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_CommentColor));
      }
      [param: In] set
      {
        *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_CommentColor)) = value;
      }
    }

    public unsafe string Comment
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_Comment)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXControllerData.NativeFieldInfoPtr_Comment), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
