// Decompiled with JetBrains decompiler
// Type: ProjectM.CloudCookieAuthoring
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
namespace ProjectM
{
  public class CloudCookieAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Alpha;
    private static readonly IntPtr NativeFieldInfoPtr_Scale;
    private static readonly IntPtr NativeFieldInfoPtr_TextureIndex;
    private static readonly IntPtr NativeFieldInfoPtr_WrapMode;
    private static readonly IntPtr NativeFieldInfoPtr_ThresholdMode;
    private static readonly IntPtr NativeFieldInfoPtr_MipLevel;
    private static readonly IntPtr NativeFieldInfoPtr_Speed;
    private static readonly IntPtr NativeFieldInfoPtr_Size;
    private static readonly IntPtr NativeFieldInfoPtr_CloudType;
    private static readonly IntPtr NativeFieldInfoPtr_InvertColors;
    private static readonly IntPtr NativeFieldInfoPtr_VolumetricMultiplier;
    private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987140, XrefRangeEnd = 987145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CloudCookieAuthoring.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987145, XrefRangeEnd = 987150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CloudCookieAuthoring.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987150, XrefRangeEnd = 987159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(CloudCookieAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987159, XrefRangeEnd = 987160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CloudCookieAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloudCookieAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CloudCookieAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CloudCookieAuthoring()
    {
      Il2CppClassPointerStore<CloudCookieAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CloudCookieAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloudCookieAuthoring>.NativeClassPtr);
      CloudCookieAuthoring.NativeFieldInfoPtr_Alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieAuthoring>.NativeClassPtr, nameof (Alpha));
      CloudCookieAuthoring.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieAuthoring>.NativeClassPtr, nameof (Scale));
      CloudCookieAuthoring.NativeFieldInfoPtr_TextureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieAuthoring>.NativeClassPtr, nameof (TextureIndex));
      CloudCookieAuthoring.NativeFieldInfoPtr_WrapMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieAuthoring>.NativeClassPtr, nameof (WrapMode));
      CloudCookieAuthoring.NativeFieldInfoPtr_ThresholdMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieAuthoring>.NativeClassPtr, nameof (ThresholdMode));
      CloudCookieAuthoring.NativeFieldInfoPtr_MipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieAuthoring>.NativeClassPtr, nameof (MipLevel));
      CloudCookieAuthoring.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieAuthoring>.NativeClassPtr, nameof (Speed));
      CloudCookieAuthoring.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieAuthoring>.NativeClassPtr, nameof (Size));
      CloudCookieAuthoring.NativeFieldInfoPtr_CloudType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieAuthoring>.NativeClassPtr, nameof (CloudType));
      CloudCookieAuthoring.NativeFieldInfoPtr_InvertColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieAuthoring>.NativeClassPtr, nameof (InvertColors));
      CloudCookieAuthoring.NativeFieldInfoPtr_VolumetricMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieAuthoring>.NativeClassPtr, nameof (VolumetricMultiplier));
      CloudCookieAuthoring.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieAuthoring>.NativeClassPtr, 100676141);
      CloudCookieAuthoring.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieAuthoring>.NativeClassPtr, 100676142);
      CloudCookieAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieAuthoring>.NativeClassPtr, 100676143);
      CloudCookieAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieAuthoring>.NativeClassPtr, 100676144);
    }

    public CloudCookieAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Alpha
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_Alpha));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_Alpha)) = value;
      }
    }

    public unsafe float Scale
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_Scale));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_Scale)) = value;
      }
    }

    public unsafe int TextureIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_TextureIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_TextureIndex)) = value;
      }
    }

    public unsafe CloudWrapModeEnum WrapMode
    {
      get
      {
        return *(CloudWrapModeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_WrapMode));
      }
      [param: In] set
      {
        *(CloudWrapModeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_WrapMode)) = value;
      }
    }

    public unsafe bool ThresholdMode
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_ThresholdMode));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_ThresholdMode)) = value;
      }
    }

    public unsafe int MipLevel
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_MipLevel));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_MipLevel)) = value;
      }
    }

    public unsafe Vector2 Speed
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_Speed));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_Speed)) = value;
      }
    }

    public unsafe float Size
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_Size));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_Size)) = value;
      }
    }

    public unsafe CloudTypeEnum CloudType
    {
      get
      {
        return *(CloudTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_CloudType));
      }
      [param: In] set
      {
        *(CloudTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_CloudType)) = value;
      }
    }

    public unsafe bool InvertColors
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_InvertColors));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_InvertColors)) = value;
      }
    }

    public unsafe float VolumetricMultiplier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_VolumetricMultiplier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieAuthoring.NativeFieldInfoPtr_VolumetricMultiplier)) = value;
      }
    }
  }
}
