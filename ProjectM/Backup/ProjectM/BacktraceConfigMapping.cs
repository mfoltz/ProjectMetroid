// Decompiled with JetBrains decompiler
// Type: ProjectM.BacktraceConfigMapping
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Backtrace.Unity.Model;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class BacktraceConfigMapping : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Config;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BacktraceConfigMapping()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BacktraceConfigMapping>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BacktraceConfigMapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BacktraceConfigMapping()
    {
      Il2CppClassPointerStore<BacktraceConfigMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BacktraceConfigMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BacktraceConfigMapping>.NativeClassPtr);
      BacktraceConfigMapping.NativeFieldInfoPtr_Config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacktraceConfigMapping>.NativeClassPtr, nameof (Config));
      BacktraceConfigMapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacktraceConfigMapping>.NativeClassPtr, 100677357);
    }

    public BacktraceConfigMapping(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BacktraceConfiguration Config
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacktraceConfigMapping.NativeFieldInfoPtr_Config));
        return pointer == IntPtr.Zero ? (BacktraceConfiguration) null : new BacktraceConfiguration(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacktraceConfigMapping.NativeFieldInfoPtr_Config), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
