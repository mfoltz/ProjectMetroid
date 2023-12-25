// Decompiled with JetBrains decompiler
// Type: ImageFillAnimation
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ImageFillAnimation : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_AnimationSpeed;
  private static readonly IntPtr NativeFieldInfoPtr__Image;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912001, XrefRangeEnd = 912008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ImageFillAnimation.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912008, XrefRangeEnd = 912014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ImageFillAnimation.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 724616, RefRangeEnd = 724620, XrefRangeStart = 724616, XrefRangeEnd = 724620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ImageFillAnimation()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageFillAnimation>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ImageFillAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ImageFillAnimation()
  {
    Il2CppClassPointerStore<ImageFillAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (ImageFillAnimation));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageFillAnimation>.NativeClassPtr);
    ImageFillAnimation.NativeFieldInfoPtr_AnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageFillAnimation>.NativeClassPtr, nameof (AnimationSpeed));
    ImageFillAnimation.NativeFieldInfoPtr__Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageFillAnimation>.NativeClassPtr, nameof (_Image));
    ImageFillAnimation.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageFillAnimation>.NativeClassPtr, 100663316);
    ImageFillAnimation.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageFillAnimation>.NativeClassPtr, 100663317);
    ImageFillAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageFillAnimation>.NativeClassPtr, 100663318);
  }

  public ImageFillAnimation(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float AnimationSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImageFillAnimation.NativeFieldInfoPtr_AnimationSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImageFillAnimation.NativeFieldInfoPtr_AnimationSpeed)) = value;
    }
  }

  public unsafe Image _Image
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImageFillAnimation.NativeFieldInfoPtr__Image));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImageFillAnimation.NativeFieldInfoPtr__Image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
