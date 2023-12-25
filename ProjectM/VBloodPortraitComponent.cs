// Decompiled with JetBrains decompiler
// Type: VBloodPortraitComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
public class VBloodPortraitComponent : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_HeadPortrait;
  private static readonly IntPtr NativeFieldInfoPtr_FullBodyPortrait;
  private static readonly IntPtr NativeFieldInfoPtr_HeadCamTranslation;
  private static readonly IntPtr NativeFieldInfoPtr_HeadCamRotationEuler;
  private static readonly IntPtr NativeFieldInfoPtr_HeadUnitTranslation;
  private static readonly IntPtr NativeFieldInfoPtr_HeadUnitRotationEuler;
  private static readonly IntPtr NativeFieldInfoPtr_HeadUnitScale;
  private static readonly IntPtr NativeFieldInfoPtr_CurrentAnimationTimeHead;
  private static readonly IntPtr NativeFieldInfoPtr_CurrentClipIndexHead;
  private static readonly IntPtr NativeFieldInfoPtr_BodyCamTranslation;
  private static readonly IntPtr NativeFieldInfoPtr_BodyCamRotationEuler;
  private static readonly IntPtr NativeFieldInfoPtr_BodyUnitTranslation;
  private static readonly IntPtr NativeFieldInfoPtr_BodyUnitRotationEuler;
  private static readonly IntPtr NativeFieldInfoPtr_BodyUnitScale;
  private static readonly IntPtr NativeFieldInfoPtr_CurrentAnimationTimeBody;
  private static readonly IntPtr NativeFieldInfoPtr_CurrentClipIndexBody;
  private static readonly IntPtr NativeFieldInfoPtr_MaskColor;
  private static readonly IntPtr NativeFieldInfoPtr_AbilityLayerIndex;
  private static readonly IntPtr NativeFieldInfoPtr_HybModelIndex;
  private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(VBloodPortraitComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915608, XrefRangeEnd = 915614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VBloodPortraitComponent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VBloodPortraitComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static VBloodPortraitComponent()
  {
    Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (VBloodPortraitComponent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr);
    VBloodPortraitComponent.NativeFieldInfoPtr_HeadPortrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, nameof (HeadPortrait));
    VBloodPortraitComponent.NativeFieldInfoPtr_FullBodyPortrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, nameof (FullBodyPortrait));
    VBloodPortraitComponent.NativeFieldInfoPtr_HeadCamTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, nameof (HeadCamTranslation));
    VBloodPortraitComponent.NativeFieldInfoPtr_HeadCamRotationEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, nameof (HeadCamRotationEuler));
    VBloodPortraitComponent.NativeFieldInfoPtr_HeadUnitTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, nameof (HeadUnitTranslation));
    VBloodPortraitComponent.NativeFieldInfoPtr_HeadUnitRotationEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, nameof (HeadUnitRotationEuler));
    VBloodPortraitComponent.NativeFieldInfoPtr_HeadUnitScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, nameof (HeadUnitScale));
    VBloodPortraitComponent.NativeFieldInfoPtr_CurrentAnimationTimeHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, nameof (CurrentAnimationTimeHead));
    VBloodPortraitComponent.NativeFieldInfoPtr_CurrentClipIndexHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, nameof (CurrentClipIndexHead));
    VBloodPortraitComponent.NativeFieldInfoPtr_BodyCamTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, nameof (BodyCamTranslation));
    VBloodPortraitComponent.NativeFieldInfoPtr_BodyCamRotationEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, nameof (BodyCamRotationEuler));
    VBloodPortraitComponent.NativeFieldInfoPtr_BodyUnitTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, nameof (BodyUnitTranslation));
    VBloodPortraitComponent.NativeFieldInfoPtr_BodyUnitRotationEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, nameof (BodyUnitRotationEuler));
    VBloodPortraitComponent.NativeFieldInfoPtr_BodyUnitScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, nameof (BodyUnitScale));
    VBloodPortraitComponent.NativeFieldInfoPtr_CurrentAnimationTimeBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, nameof (CurrentAnimationTimeBody));
    VBloodPortraitComponent.NativeFieldInfoPtr_CurrentClipIndexBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, nameof (CurrentClipIndexBody));
    VBloodPortraitComponent.NativeFieldInfoPtr_MaskColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, nameof (MaskColor));
    VBloodPortraitComponent.NativeFieldInfoPtr_AbilityLayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, nameof (AbilityLayerIndex));
    VBloodPortraitComponent.NativeFieldInfoPtr_HybModelIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, nameof (HybModelIndex));
    VBloodPortraitComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, 100663596);
    VBloodPortraitComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitComponent>.NativeClassPtr, 100663597);
  }

  public VBloodPortraitComponent(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Sprite HeadPortrait
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_HeadPortrait));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_HeadPortrait), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite FullBodyPortrait
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_FullBodyPortrait));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_FullBodyPortrait), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 HeadCamTranslation
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_HeadCamTranslation));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_HeadCamTranslation)) = value;
    }
  }

  public unsafe Vector3 HeadCamRotationEuler
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_HeadCamRotationEuler));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_HeadCamRotationEuler)) = value;
    }
  }

  public unsafe Vector3 HeadUnitTranslation
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_HeadUnitTranslation));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_HeadUnitTranslation)) = value;
    }
  }

  public unsafe Vector3 HeadUnitRotationEuler
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_HeadUnitRotationEuler));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_HeadUnitRotationEuler)) = value;
    }
  }

  public unsafe Vector3 HeadUnitScale
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_HeadUnitScale));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_HeadUnitScale)) = value;
    }
  }

  public unsafe float CurrentAnimationTimeHead
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_CurrentAnimationTimeHead));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_CurrentAnimationTimeHead)) = value;
    }
  }

  public unsafe int CurrentClipIndexHead
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_CurrentClipIndexHead));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_CurrentClipIndexHead)) = value;
    }
  }

  public unsafe Vector3 BodyCamTranslation
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_BodyCamTranslation));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_BodyCamTranslation)) = value;
    }
  }

  public unsafe Vector3 BodyCamRotationEuler
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_BodyCamRotationEuler));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_BodyCamRotationEuler)) = value;
    }
  }

  public unsafe Vector3 BodyUnitTranslation
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_BodyUnitTranslation));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_BodyUnitTranslation)) = value;
    }
  }

  public unsafe Vector3 BodyUnitRotationEuler
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_BodyUnitRotationEuler));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_BodyUnitRotationEuler)) = value;
    }
  }

  public unsafe Vector3 BodyUnitScale
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_BodyUnitScale));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_BodyUnitScale)) = value;
    }
  }

  public unsafe float CurrentAnimationTimeBody
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_CurrentAnimationTimeBody));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_CurrentAnimationTimeBody)) = value;
    }
  }

  public unsafe int CurrentClipIndexBody
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_CurrentClipIndexBody));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_CurrentClipIndexBody)) = value;
    }
  }

  public unsafe Color MaskColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_MaskColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_MaskColor)) = value;
    }
  }

  public unsafe int AbilityLayerIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_AbilityLayerIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_AbilityLayerIndex)) = value;
    }
  }

  public unsafe int HybModelIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_HybModelIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitComponent.NativeFieldInfoPtr_HybModelIndex)) = value;
    }
  }
}
