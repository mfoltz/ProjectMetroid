// Decompiled with JetBrains decompiler
// Type: CameraControl
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CameraControl : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_lookSpeedH;
  private static readonly IntPtr NativeFieldInfoPtr_lookSpeedV;
  private static readonly IntPtr NativeFieldInfoPtr_zoomSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_dragSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_yaw;
  private static readonly IntPtr NativeFieldInfoPtr_pitch;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921614, XrefRangeEnd = 921618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraControl.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921618, XrefRangeEnd = 921654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraControl.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921654, XrefRangeEnd = 921655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CameraControl()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraControl>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CameraControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CameraControl()
  {
    Il2CppClassPointerStore<CameraControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (CameraControl));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraControl>.NativeClassPtr);
    CameraControl.NativeFieldInfoPtr_lookSpeedH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControl>.NativeClassPtr, nameof (lookSpeedH));
    CameraControl.NativeFieldInfoPtr_lookSpeedV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControl>.NativeClassPtr, nameof (lookSpeedV));
    CameraControl.NativeFieldInfoPtr_zoomSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControl>.NativeClassPtr, nameof (zoomSpeed));
    CameraControl.NativeFieldInfoPtr_dragSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControl>.NativeClassPtr, nameof (dragSpeed));
    CameraControl.NativeFieldInfoPtr_yaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControl>.NativeClassPtr, nameof (yaw));
    CameraControl.NativeFieldInfoPtr_pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraControl>.NativeClassPtr, nameof (pitch));
    CameraControl.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControl>.NativeClassPtr, 100663694);
    CameraControl.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControl>.NativeClassPtr, 100663695);
    CameraControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraControl>.NativeClassPtr, 100663696);
  }

  public CameraControl(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float lookSpeedH
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraControl.NativeFieldInfoPtr_lookSpeedH));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraControl.NativeFieldInfoPtr_lookSpeedH)) = value;
    }
  }

  public unsafe float lookSpeedV
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraControl.NativeFieldInfoPtr_lookSpeedV));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraControl.NativeFieldInfoPtr_lookSpeedV)) = value;
    }
  }

  public unsafe float zoomSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraControl.NativeFieldInfoPtr_zoomSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraControl.NativeFieldInfoPtr_zoomSpeed)) = value;
    }
  }

  public unsafe float dragSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraControl.NativeFieldInfoPtr_dragSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraControl.NativeFieldInfoPtr_dragSpeed)) = value;
    }
  }

  public unsafe float yaw
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraControl.NativeFieldInfoPtr_yaw));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraControl.NativeFieldInfoPtr_yaw)) = value;
    }
  }

  public unsafe float pitch
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraControl.NativeFieldInfoPtr_pitch));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraControl.NativeFieldInfoPtr_pitch)) = value;
    }
  }
}
