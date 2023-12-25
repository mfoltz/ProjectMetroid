// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.StunlockIndoorAmbienceAsset
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
namespace ProjectM.Audio
{
  public class StunlockIndoorAmbienceAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Index;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunlockIndoorAmbienceAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunlockIndoorAmbienceAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunlockIndoorAmbienceAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StunlockIndoorAmbienceAsset()
    {
      Il2CppClassPointerStore<StunlockIndoorAmbienceAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (StunlockIndoorAmbienceAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunlockIndoorAmbienceAsset>.NativeClassPtr);
      StunlockIndoorAmbienceAsset.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunlockIndoorAmbienceAsset>.NativeClassPtr, nameof (Index));
      StunlockIndoorAmbienceAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunlockIndoorAmbienceAsset>.NativeClassPtr, 100690594);
    }

    public StunlockIndoorAmbienceAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int Index
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunlockIndoorAmbienceAsset.NativeFieldInfoPtr_Index));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunlockIndoorAmbienceAsset.NativeFieldInfoPtr_Index)) = value;
      }
    }
  }
}
