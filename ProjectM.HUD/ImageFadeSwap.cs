// Decompiled with JetBrains decompiler
// Type: ImageFadeSwap
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ImageFadeSwap : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_DefaultSprite;
  private static readonly IntPtr NativeFieldInfoPtr_DefaultColor;
  private static readonly IntPtr NativeFieldInfoPtr_CurrentImage;
  private static readonly IntPtr NativeFieldInfoPtr_PreviousImage;
  private static readonly IntPtr NativeFieldInfoPtr_Binding;
  private static readonly IntPtr NativeFieldInfoPtr_StartTime;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetSprite_Public_Void_Sprite_Material_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetSprite_Public_Void_Sprite_Color_Material_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208387, XrefRangeEnd = 1208389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ImageFadeSwap.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ImageFadeSwap.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 1208391, RefRangeEnd = 1208395, XrefRangeStart = 1208389, XrefRangeEnd = 1208391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSprite(Sprite newSprite, Material material = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newSprite);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ImageFadeSwap.NativeMethodInfoPtr_SetSprite_Public_Void_Sprite_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1208410, RefRangeEnd = 1208411, XrefRangeStart = 1208395, XrefRangeEnd = 1208410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSprite(Sprite newSprite, Color color, Material material = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newSprite);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &color;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ImageFadeSwap.NativeMethodInfoPtr_SetSprite_Public_Void_Sprite_Color_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208411, XrefRangeEnd = 1208413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ImageFadeSwap.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ImageFadeSwap()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageFadeSwap>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ImageFadeSwap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ImageFadeSwap()
  {
    Il2CppClassPointerStore<ImageFadeSwap>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (ImageFadeSwap));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageFadeSwap>.NativeClassPtr);
    ImageFadeSwap.NativeFieldInfoPtr_DefaultSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageFadeSwap>.NativeClassPtr, nameof (DefaultSprite));
    ImageFadeSwap.NativeFieldInfoPtr_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageFadeSwap>.NativeClassPtr, nameof (DefaultColor));
    ImageFadeSwap.NativeFieldInfoPtr_CurrentImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageFadeSwap>.NativeClassPtr, nameof (CurrentImage));
    ImageFadeSwap.NativeFieldInfoPtr_PreviousImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageFadeSwap>.NativeClassPtr, nameof (PreviousImage));
    ImageFadeSwap.NativeFieldInfoPtr_Binding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageFadeSwap>.NativeClassPtr, nameof (Binding));
    ImageFadeSwap.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageFadeSwap>.NativeClassPtr, nameof (StartTime));
    ImageFadeSwap.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageFadeSwap>.NativeClassPtr, 100663530);
    ImageFadeSwap.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageFadeSwap>.NativeClassPtr, 100663531);
    ImageFadeSwap.NativeMethodInfoPtr_SetSprite_Public_Void_Sprite_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageFadeSwap>.NativeClassPtr, 100663532);
    ImageFadeSwap.NativeMethodInfoPtr_SetSprite_Public_Void_Sprite_Color_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageFadeSwap>.NativeClassPtr, 100663533);
    ImageFadeSwap.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageFadeSwap>.NativeClassPtr, 100663534);
    ImageFadeSwap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageFadeSwap>.NativeClassPtr, 100663535);
  }

  public ImageFadeSwap(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Sprite DefaultSprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImageFadeSwap.NativeFieldInfoPtr_DefaultSprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImageFadeSwap.NativeFieldInfoPtr_DefaultSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color DefaultColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImageFadeSwap.NativeFieldInfoPtr_DefaultColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImageFadeSwap.NativeFieldInfoPtr_DefaultColor)) = value;
    }
  }

  public unsafe Image CurrentImage
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImageFadeSwap.NativeFieldInfoPtr_CurrentImage));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImageFadeSwap.NativeFieldInfoPtr_CurrentImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image PreviousImage
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImageFadeSwap.NativeFieldInfoPtr_PreviousImage));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImageFadeSwap.NativeFieldInfoPtr_PreviousImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Motion2DBinding Binding
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImageFadeSwap.NativeFieldInfoPtr_Binding));
      return pointer == IntPtr.Zero ? (Motion2DBinding) null : new Motion2DBinding(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImageFadeSwap.NativeFieldInfoPtr_Binding), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float StartTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImageFadeSwap.NativeFieldInfoPtr_StartTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImageFadeSwap.NativeFieldInfoPtr_StartTime)) = value;
    }
  }
}
