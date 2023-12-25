// Decompiled with JetBrains decompiler
// Type: ProjectM.EnableRandomAtAwake
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class EnableRandomAtAwake : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Objects;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976400, XrefRangeEnd = 976410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EnableRandomAtAwake.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976410, XrefRangeEnd = 976415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EnableRandomAtAwake()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnableRandomAtAwake>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EnableRandomAtAwake.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EnableRandomAtAwake()
    {
      Il2CppClassPointerStore<EnableRandomAtAwake>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (EnableRandomAtAwake));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnableRandomAtAwake>.NativeClassPtr);
      EnableRandomAtAwake.NativeFieldInfoPtr_Objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableRandomAtAwake>.NativeClassPtr, nameof (Objects));
      EnableRandomAtAwake.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableRandomAtAwake>.NativeClassPtr, 100675458);
      EnableRandomAtAwake.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableRandomAtAwake>.NativeClassPtr, 100675459);
    }

    public EnableRandomAtAwake(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<GameObject> Objects
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnableRandomAtAwake.NativeFieldInfoPtr_Objects));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnableRandomAtAwake.NativeFieldInfoPtr_Objects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
