// Decompiled with JetBrains decompiler
// Type: ProjectM.CloudCookieEditorSingleton
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class CloudCookieEditorSingleton : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr__Instance;
    private static readonly IntPtr NativeFieldInfoPtr_CloudLights;
    private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_CloudCookieEditorSingleton_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddCloudCookie_Public_Void_CloudCookieAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_RemoveCloudCookie_Public_Void_CloudCookieAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public static unsafe CloudCookieEditorSingleton Instance
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 987190, RefRangeEnd = 987193, XrefRangeStart = 987160, XrefRangeEnd = 987190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(CloudCookieEditorSingleton.NativeMethodInfoPtr_get_Instance_Public_Static_get_CloudCookieEditorSingleton_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (CloudCookieEditorSingleton) null : new CloudCookieEditorSingleton(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987193, XrefRangeEnd = 987197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddCloudCookie(CloudCookieAuthoring cloudCookie)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cloudCookie);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CloudCookieEditorSingleton.NativeMethodInfoPtr_AddCloudCookie_Public_Void_CloudCookieAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987197, XrefRangeEnd = 987201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveCloudCookie(CloudCookieAuthoring cloudCookie)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cloudCookie);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CloudCookieEditorSingleton.NativeMethodInfoPtr_RemoveCloudCookie_Public_Void_CloudCookieAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987201, XrefRangeEnd = 987209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CloudCookieEditorSingleton()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloudCookieEditorSingleton>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CloudCookieEditorSingleton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CloudCookieEditorSingleton()
    {
      Il2CppClassPointerStore<CloudCookieEditorSingleton>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CloudCookieEditorSingleton));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloudCookieEditorSingleton>.NativeClassPtr);
      CloudCookieEditorSingleton.NativeFieldInfoPtr__Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieEditorSingleton>.NativeClassPtr, nameof (_Instance));
      CloudCookieEditorSingleton.NativeFieldInfoPtr_CloudLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCookieEditorSingleton>.NativeClassPtr, nameof (CloudLights));
      CloudCookieEditorSingleton.NativeMethodInfoPtr_get_Instance_Public_Static_get_CloudCookieEditorSingleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieEditorSingleton>.NativeClassPtr, 100676145);
      CloudCookieEditorSingleton.NativeMethodInfoPtr_AddCloudCookie_Public_Void_CloudCookieAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieEditorSingleton>.NativeClassPtr, 100676146);
      CloudCookieEditorSingleton.NativeMethodInfoPtr_RemoveCloudCookie_Public_Void_CloudCookieAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieEditorSingleton>.NativeClassPtr, 100676147);
      CloudCookieEditorSingleton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCookieEditorSingleton>.NativeClassPtr, 100676148);
    }

    public CloudCookieEditorSingleton(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe CloudCookieEditorSingleton _Instance
    {
      get
      {
        IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CloudCookieEditorSingleton.NativeFieldInfoPtr__Instance, (void*) &num);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (CloudCookieEditorSingleton) null : new CloudCookieEditorSingleton(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CloudCookieEditorSingleton.NativeFieldInfoPtr__Instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<CloudCookieAuthoring> CloudLights
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieEditorSingleton.NativeFieldInfoPtr_CloudLights));
        return pointer == IntPtr.Zero ? (List<CloudCookieAuthoring>) null : new List<CloudCookieAuthoring>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CloudCookieEditorSingleton.NativeFieldInfoPtr_CloudLights), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
