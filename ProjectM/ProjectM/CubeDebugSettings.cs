// Decompiled with JetBrains decompiler
// Type: ProjectM.CubeDebugSettings
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
namespace ProjectM
{
  public class CubeDebugSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_DebugShader;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CubeDebugSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubeDebugSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CubeDebugSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CubeDebugSettings()
    {
      Il2CppClassPointerStore<CubeDebugSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CubeDebugSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CubeDebugSettings>.NativeClassPtr);
      CubeDebugSettings.NativeFieldInfoPtr_DebugShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubeDebugSettings>.NativeClassPtr, nameof (DebugShader));
      CubeDebugSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubeDebugSettings>.NativeClassPtr, 100676720);
    }

    public CubeDebugSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Shader DebugShader
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CubeDebugSettings.NativeFieldInfoPtr_DebugShader));
        return pointer == IntPtr.Zero ? (Shader) null : new Shader(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CubeDebugSettings.NativeFieldInfoPtr_DebugShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
