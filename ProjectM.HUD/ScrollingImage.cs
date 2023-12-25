// Decompiled with JetBrains decompiler
// Type: ScrollingImage
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ScrollingImage : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr__Image;
  private static readonly IntPtr NativeFieldInfoPtr__X;
  private static readonly IntPtr NativeFieldInfoPtr__Y;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206392, XrefRangeEnd = 1206397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrollingImage.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScrollingImage()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollingImage>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScrollingImage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScrollingImage()
  {
    Il2CppClassPointerStore<ScrollingImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (ScrollingImage));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollingImage>.NativeClassPtr);
    ScrollingImage.NativeFieldInfoPtr__Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingImage>.NativeClassPtr, nameof (_Image));
    ScrollingImage.NativeFieldInfoPtr__X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingImage>.NativeClassPtr, nameof (_X));
    ScrollingImage.NativeFieldInfoPtr__Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingImage>.NativeClassPtr, nameof (_Y));
    ScrollingImage.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingImage>.NativeClassPtr, 100663390);
    ScrollingImage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingImage>.NativeClassPtr, 100663391);
  }

  public ScrollingImage(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe RawImage _Image
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollingImage.NativeFieldInfoPtr__Image));
      return pointer == IntPtr.Zero ? (RawImage) null : new RawImage(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrollingImage.NativeFieldInfoPtr__Image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float _X
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollingImage.NativeFieldInfoPtr__X));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollingImage.NativeFieldInfoPtr__X)) = value;
    }
  }

  public unsafe float _Y
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollingImage.NativeFieldInfoPtr__Y));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollingImage.NativeFieldInfoPtr__Y)) = value;
    }
  }
}
