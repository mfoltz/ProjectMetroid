// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.SequencerPrefab.TransformationData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace Stunlock.Sequencer.SequencerPrefab
{
  [Serializable]
  public class TransformationData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionParameterName;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationParameterName;
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionOrigin;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationOrigin;
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionBone;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationBone;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Scale;
    private static readonly System.IntPtr NativeFieldInfoPtr_UsePositionOrigin;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseRotationOrigin;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseOffsetPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseOffsetRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseScale;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanPositionAndRotationGraphBeCombined_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 925426, RefRangeEnd = 925427, XrefRangeStart = 925426, XrefRangeEnd = 925426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanPositionAndRotationGraphBeCombined()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TransformationData.NativeMethodInfoPtr_CanPositionAndRotationGraphBeCombined_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 925433, RefRangeEnd = 925439, XrefRangeStart = 925427, XrefRangeEnd = 925433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TransformationData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformationData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TransformationData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TransformationData()
    {
      Il2CppClassPointerStore<TransformationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer.SequencerPrefab", nameof (TransformationData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformationData>.NativeClassPtr);
      TransformationData.NativeFieldInfoPtr_PositionParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformationData>.NativeClassPtr, nameof (PositionParameterName));
      TransformationData.NativeFieldInfoPtr_RotationParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformationData>.NativeClassPtr, nameof (RotationParameterName));
      TransformationData.NativeFieldInfoPtr_PositionOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformationData>.NativeClassPtr, nameof (PositionOrigin));
      TransformationData.NativeFieldInfoPtr_RotationOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformationData>.NativeClassPtr, nameof (RotationOrigin));
      TransformationData.NativeFieldInfoPtr_PositionBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformationData>.NativeClassPtr, nameof (PositionBone));
      TransformationData.NativeFieldInfoPtr_RotationBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformationData>.NativeClassPtr, nameof (RotationBone));
      TransformationData.NativeFieldInfoPtr_OffsetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformationData>.NativeClassPtr, nameof (OffsetPosition));
      TransformationData.NativeFieldInfoPtr_OffsetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformationData>.NativeClassPtr, nameof (OffsetRotation));
      TransformationData.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformationData>.NativeClassPtr, nameof (Scale));
      TransformationData.NativeFieldInfoPtr_UsePositionOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformationData>.NativeClassPtr, nameof (UsePositionOrigin));
      TransformationData.NativeFieldInfoPtr_UseRotationOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformationData>.NativeClassPtr, nameof (UseRotationOrigin));
      TransformationData.NativeFieldInfoPtr_UseOffsetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformationData>.NativeClassPtr, nameof (UseOffsetPosition));
      TransformationData.NativeFieldInfoPtr_UseOffsetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformationData>.NativeClassPtr, nameof (UseOffsetRotation));
      TransformationData.NativeFieldInfoPtr_UseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformationData>.NativeClassPtr, nameof (UseScale));
      TransformationData.NativeMethodInfoPtr_CanPositionAndRotationGraphBeCombined_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformationData>.NativeClassPtr, 100663963);
      TransformationData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformationData>.NativeClassPtr, 100663964);
    }

    public TransformationData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string PositionParameterName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_PositionParameterName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_PositionParameterName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string RotationParameterName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_RotationParameterName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_RotationParameterName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe OriginType PositionOrigin
    {
      get
      {
        return *(OriginType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_PositionOrigin));
      }
      [param: In] set
      {
        *(OriginType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_PositionOrigin)) = value;
      }
    }

    public unsafe OriginType RotationOrigin
    {
      get
      {
        return *(OriginType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_RotationOrigin));
      }
      [param: In] set
      {
        *(OriginType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_RotationOrigin)) = value;
      }
    }

    public unsafe HybridBoneEnum PositionBone
    {
      get
      {
        return *(HybridBoneEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_PositionBone));
      }
      [param: In] set
      {
        *(HybridBoneEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_PositionBone)) = value;
      }
    }

    public unsafe HybridBoneEnum RotationBone
    {
      get
      {
        return *(HybridBoneEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_RotationBone));
      }
      [param: In] set
      {
        *(HybridBoneEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_RotationBone)) = value;
      }
    }

    public unsafe float3 OffsetPosition
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_OffsetPosition));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_OffsetPosition)) = value;
      }
    }

    public unsafe float3 OffsetRotation
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_OffsetRotation));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_OffsetRotation)) = value;
      }
    }

    public unsafe float3 Scale
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_Scale));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_Scale)) = value;
      }
    }

    public unsafe bool UsePositionOrigin
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_UsePositionOrigin));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_UsePositionOrigin)) = value;
      }
    }

    public unsafe bool UseRotationOrigin
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_UseRotationOrigin));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_UseRotationOrigin)) = value;
      }
    }

    public unsafe bool UseOffsetPosition
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_UseOffsetPosition));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_UseOffsetPosition)) = value;
      }
    }

    public unsafe bool UseOffsetRotation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_UseOffsetRotation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_UseOffsetRotation)) = value;
      }
    }

    public unsafe bool UseScale
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_UseScale));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformationData.NativeFieldInfoPtr_UseScale)) = value;
      }
    }
  }
}
