// Decompiled with JetBrains decompiler
// Type: ProjectM.LightningStorm.LightningLightSource
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
namespace ProjectM.LightningStorm
{
  public class LightningLightSource : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;
    private static readonly IntPtr NativeFieldInfoPtr_LightFrustumViewport;
    private static readonly IntPtr NativeFieldInfoPtr_LightDepthOffset;
    private static readonly IntPtr NativeFieldInfoPtr_LightMinRange;
    private static readonly IntPtr NativeFieldInfoPtr_LightFrustumSizing;
    private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_LightningLightSource_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_LightningLightSource_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public static unsafe LightningLightSource Instance
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114710, XrefRangeEnd = 1114712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(LightningLightSource.NativeMethodInfoPtr_get_Instance_Public_Static_get_LightningLightSource_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (LightningLightSource) null : new LightningLightSource(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114712, XrefRangeEnd = 1114715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LightningLightSource.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_LightningLightSource_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114715, XrefRangeEnd = 1114724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningLightSource.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114724, XrefRangeEnd = 1114733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningLightSource.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114733, XrefRangeEnd = 1114734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LightningLightSource()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningLightSource>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningLightSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LightningLightSource()
    {
      Il2CppClassPointerStore<LightningLightSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.LightningStorm", nameof (LightningLightSource));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningLightSource>.NativeClassPtr);
      LightningLightSource.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLightSource>.NativeClassPtr, "<Instance>k__BackingField");
      LightningLightSource.NativeFieldInfoPtr_LightFrustumViewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLightSource>.NativeClassPtr, nameof (LightFrustumViewport));
      LightningLightSource.NativeFieldInfoPtr_LightDepthOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLightSource>.NativeClassPtr, nameof (LightDepthOffset));
      LightningLightSource.NativeFieldInfoPtr_LightMinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLightSource>.NativeClassPtr, nameof (LightMinRange));
      LightningLightSource.NativeFieldInfoPtr_LightFrustumSizing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLightSource>.NativeClassPtr, nameof (LightFrustumSizing));
      LightningLightSource.NativeMethodInfoPtr_get_Instance_Public_Static_get_LightningLightSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningLightSource>.NativeClassPtr, 100688253);
      LightningLightSource.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_LightningLightSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningLightSource>.NativeClassPtr, 100688254);
      LightningLightSource.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningLightSource>.NativeClassPtr, 100688255);
      LightningLightSource.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningLightSource>.NativeClassPtr, 100688256);
      LightningLightSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningLightSource>.NativeClassPtr, 100688257);
    }

    public LightningLightSource(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe LightningLightSource _Instance_k__BackingField
    {
      get
      {
        IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(LightningLightSource.NativeFieldInfoPtr__Instance_k__BackingField, (void*) &num);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (LightningLightSource) null : new LightningLightSource(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LightningLightSource.NativeFieldInfoPtr__Instance_k__BackingField, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 LightFrustumViewport
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningLightSource.NativeFieldInfoPtr_LightFrustumViewport));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningLightSource.NativeFieldInfoPtr_LightFrustumViewport)) = value;
      }
    }

    public unsafe float LightDepthOffset
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningLightSource.NativeFieldInfoPtr_LightDepthOffset));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningLightSource.NativeFieldInfoPtr_LightDepthOffset)) = value;
      }
    }

    public unsafe float LightMinRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningLightSource.NativeFieldInfoPtr_LightMinRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningLightSource.NativeFieldInfoPtr_LightMinRange)) = value;
      }
    }

    public unsafe LightningLightBoxFrustumSizing LightFrustumSizing
    {
      get
      {
        return *(LightningLightBoxFrustumSizing*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningLightSource.NativeFieldInfoPtr_LightFrustumSizing));
      }
      [param: In] set
      {
        *(LightningLightBoxFrustumSizing*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningLightSource.NativeFieldInfoPtr_LightFrustumSizing)) = value;
      }
    }
  }
}
